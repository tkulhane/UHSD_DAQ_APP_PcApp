using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class Reset_Control
    {
        public enum eCommandCode_RESET : byte
        {

            CMD_RST_Main_Reset = 0x55,
            CMD_RST_Clear_ALL = 0x01,

            CMD_RST_EXT_State = 0x11,
            CMD_RST_EXT_SET = 0x12,
            CMD_RST_EXT_CLR = 0x13,
            CMD_RST_EXT_PULSE = 0x14,

            CMD_RST_INT_State = 0x21,
            CMD_RST_INT_SET = 0x22,
            CMD_RST_INT_CLR = 0x23,
            CMD_RST_INT_PULSE = 0x24,
                 
            CMD_RST_PULSE_LENGTH = 0x05,

        }

        public BindingList<ResetControl_Data> List_Reset = new BindingList<ResetControl_Data>();

        public delegate void efunction(Communication.eCommandCode CMD, byte d1, byte d2, byte d3);
        public efunction SendCommand;

        public DataGridView DataGrid_Reset;



        public void LoadRst()
        {
            //Resets External
            ResetExtAdd(0, "ADC");
            ResetExtAdd(1, "HMC");
            ResetExtAdd(2, "LMX1");
            ResetExtAdd(3, "LMX2");

            //Reset Internal
            ResetIntAdd(0, "DataFifo");
            ResetIntAdd(1, "FTDI");




            //datagrid
            DataGridsLoad();
        }

        private void DataGridsLoad()
        {
            DataGrid_Reset.DataSource = List_Reset;
            DataGrid_Reset.Update();

            DataGridViewButtonColumn btn_pulse = new DataGridViewButtonColumn();
            btn_pulse.HeaderText = "PULSE";
            btn_pulse.Text = "PULSE";
            btn_pulse.Name = "button_RstPulse";
            btn_pulse.UseColumnTextForButtonValue = true;
            DataGrid_Reset.Columns.Add(btn_pulse);

            DataGridViewButtonColumn btn_set = new DataGridViewButtonColumn();
            btn_set.HeaderText = "SET";
            btn_set.Text = "SET";
            btn_set.Name = "button_RstSet";
            btn_set.UseColumnTextForButtonValue = true;
            DataGrid_Reset.Columns.Add(btn_set);

            DataGridViewButtonColumn btn_clear = new DataGridViewButtonColumn();
            btn_clear.HeaderText = "CLEAR";
            btn_clear.Text = "CLEAR";
            btn_clear.Name = "button_RstClear";
            btn_clear.UseColumnTextForButtonValue = true;
            DataGrid_Reset.Columns.Add(btn_clear);

            //DataGrid_Reset.Columns.
            
            for(int i = 0;i < DataGrid_Reset.Columns.Count; i++) 
            {
                DataGrid_Reset.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            

        }

        private void ResetExtAdd(int Number, string Name)
        {
            ResetControl_Data data = new ResetControl_Data(ResetControl_Data.eExtIntRes.External_Reset,Number, Name);
            List_Reset.Add(data);
        }
        private void ResetIntAdd(int Number, string Name)
        {
            ResetControl_Data data = new ResetControl_Data(ResetControl_Data.eExtIntRes.Internal_Reset, Number, Name);
            List_Reset.Add(data);
        }


        public void UpdateFromCommunication(byte data_0, byte data_1, byte data_2)
        {

            switch ((eCommandCode_RESET)data_0)
            {
                case eCommandCode_RESET.CMD_RST_EXT_State:
                    UpdateExtValue(data_1, data_2);
                    break;

                case eCommandCode_RESET.CMD_RST_INT_State:
                    UpdateIntValue(data_1, data_2);
                    break;


            }
        }


        private void UpdateExtValue(byte data_1, byte data_2)
        {
            UInt16 data = (UInt16)((data_1 << 8) + data_2);

            int value_cell = DataGrid_Reset.Columns["p_value"].Index;

            for (int i = 0; i < List_Reset.Count; i++)
            {
                if(List_Reset[i]._Res_ExtInt == ResetControl_Data.eExtIntRes.External_Reset) 
                {
                    List_Reset[i].p_value = (data >> List_Reset[i].p_number) & 0x0001;
                    DataGrid_Reset.UpdateCellValue(value_cell, i);
                }
                
            }
        }

        private void UpdateIntValue(byte data_1, byte data_2)
        {
            UInt16 data = (UInt16)((data_1 << 8) + data_2);

            int value_cell = DataGrid_Reset.Columns["p_value"].Index;

            for (int i = 0; i < List_Reset.Count; i++)
            {
                if (List_Reset[i]._Res_ExtInt == ResetControl_Data.eExtIntRes.Internal_Reset)
                {
                    List_Reset[i].p_value = (data >> List_Reset[i].p_number) & 0x0001;
                    DataGrid_Reset.UpdateCellValue(value_cell, i);
                }

            }
        }

        public void SetByName(string Name, int value) 
        {
            for (int i = 0; i < List_Reset.Count; i++)
            {
                if (Name.Equals(List_Reset[i].p_name))
                {
                    SetByIndex(i, value);
                }
            }
        }

        public void SetByIndex(int index, int value) 
        {
            ResetControl_Data data = List_Reset[index];
            int Number = data.p_number;
            if (Number < 0) return;
            int reg = 0 | 1 << Number;

            if (value == 1)
            {
                if (data._Res_ExtInt == ResetControl_Data.eExtIntRes.External_Reset)
                {
                    SendCommand(Communication.eCommandCode.CMD_CONST_SET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_EXT_SET, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
                }
                else if (data._Res_ExtInt == ResetControl_Data.eExtIntRes.Internal_Reset)
                {
                    SendCommand(Communication.eCommandCode.CMD_CONST_SET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_INT_SET, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
                }
                //MessageBox.Show("Reset set");
            }
            else if (value == 0)
            {
                if (data._Res_ExtInt == ResetControl_Data.eExtIntRes.External_Reset)
                {
                    SendCommand(Communication.eCommandCode.CMD_CONST_SET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_EXT_CLR, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
                }
                else if (data._Res_ExtInt == ResetControl_Data.eExtIntRes.Internal_Reset)
                {
                    SendCommand(Communication.eCommandCode.CMD_CONST_SET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_INT_CLR, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
                }
                //MessageBox.Show("Reset clr");
            }
            else
            {
                return;
            }
        }

        public void DataGridView_Reset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetControl_Data data = List_Reset[e.RowIndex];

            int Number = data.p_number;
            

            if (Number < 0) return;

            
            int index_set = DataGrid_Reset.Columns["button_RstSet"].Index;
            int index_clear = DataGrid_Reset.Columns["button_RstClear"].Index;
            int index_pulse = DataGrid_Reset.Columns["button_RstPulse"].Index;

            int reg = 0 | 1 << Number;

            //MessageBox.Show(reg.ToString("x"));

            if (e.ColumnIndex == index_set)
            {
                if(data._Res_ExtInt == ResetControl_Data.eExtIntRes.External_Reset) 
                {
                    SendCommand(Communication.eCommandCode.CMD_CONST_SET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_EXT_SET, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
                }
                else if (data._Res_ExtInt == ResetControl_Data.eExtIntRes.Internal_Reset)
                {
                    SendCommand(Communication.eCommandCode.CMD_CONST_SET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_INT_SET, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
                }
                //MessageBox.Show("Reset set");
            }
            else if (e.ColumnIndex == index_clear)
            {
                if (data._Res_ExtInt == ResetControl_Data.eExtIntRes.External_Reset)
                {
                    SendCommand(Communication.eCommandCode.CMD_CONST_SET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_EXT_CLR, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
                }
                else if (data._Res_ExtInt == ResetControl_Data.eExtIntRes.Internal_Reset)
                {
                    SendCommand(Communication.eCommandCode.CMD_CONST_SET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_INT_CLR, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
                }
                //MessageBox.Show("Reset clr");
            }
            else if (e.ColumnIndex == index_pulse)
            {
                if (data._Res_ExtInt == ResetControl_Data.eExtIntRes.External_Reset)
                {
                    SendCommand(Communication.eCommandCode.CMD_CONST_SET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_EXT_PULSE, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
                }
                else if (data._Res_ExtInt == ResetControl_Data.eExtIntRes.Internal_Reset)
                {
                    SendCommand(Communication.eCommandCode.CMD_CONST_SET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_INT_PULSE, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
                }

            }

            
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_EXT_State, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_INT_State, 0, 0);
        }

        public void ClearAll() 
        {
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_Clear_ALL, 0, 0);
        }

        public void SystemReset()
        {
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_Main_Reset, 0xAB, 0xCD);
        }

        public void ReadStateCommands()
        {
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_EXT_State, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_Reset_Controler, (byte)eCommandCode_RESET.CMD_RST_INT_State, 0, 0);
        }



    }
}
