using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class AnalyzInCirc
    {

        public enum eCommandCode_AnylyzInCirc : byte
        {

            CMD_ANALYZINCIRC_ENABLE = 0x01,
            CMD_ANALYZINCIRC_CLEAR = 0x02,
            CMD_ANALYZINCIRC_NUMBER_OF_SAMPLES = 0x03,
            CMD_ANALYZINCIRC_TRIGGERS_MASK_RISING = 0x04,
            CMD_ANALYZINCIRC_TRIGGERS_MASK_FALLING = 0x05,
            CMD_ANALYZINCIRC_TRG_START = 0x06,

            CMD_ANALYZINCIRC_STATE = 0x11,
            CMD_ANALYZINCIRC_EMPTY = 0x12,

            CMD_ANALYZINCIRC_FIFO_DATA_BASE = 100

        }


        public delegate void efunction(Communication.eCommandCode CMD, byte d1, byte d2, byte d3);
        public efunction SendCommand;

        public Label label_Enable;
        public NumericUpDown numericUpDown_NumOfSamples;
        public Label label_Empty;
        public Label label_DataReadState;

        public CheckBox[] checkBox_Triggers_Rising;
        public CheckBox[] checkBox_Triggers_Falling;

        public DataGridView _dataGridView_AnalyzData;


        System.Timers.Timer TimerDataRead = new System.Timers.Timer();

        public BindingList<AnalyzInCirc_Data> List_Data = new BindingList<AnalyzInCirc_Data>();

        public bool[] IsDataRead = new bool[2];
        public bool[] IsFifoEmpty = new bool[2];
        public bool DataReadGo = false;

        public void AnalyzInit() 
        {
            _dataGridView_AnalyzData.DataSource = List_Data;

            /*
            for(int i = 0; i < IsDataRead.Length; i++) 
            {
                IsDataRead[i] = true;
            }
            */

        }


        public void ReadData_Start()
        {
            TimerDataRead.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            TimerDataRead.Interval = 50;
            TimerDataRead.Enabled = true;
            DataReadGo = true;

            //nastavym IsDataRead na true abych odelal prvni comandy na data 
            for (int i = 0; i < IsDataRead.Length; i++)
            {
                IsDataRead[i] = true;
            }

            //vynuluju fifo empty
            for (int i = 0; i < IsFifoEmpty.Length; i++)
            {
                IsFifoEmpty[i] = false;
            }

            label_DataReadState.Text = "GO";
        }

        public void ReadData_Stop() 
        {
            TimerDataRead.Enabled = false;
            DataReadGo = false;

            label_DataReadState.Text = "STOP";
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            //vsechny fifa jsou prazdne
            bool AllIsEmpty = false;
            for (int i = 0; i < IsFifoEmpty.Length; i++)
            {
                if (IsFifoEmpty[i]) 
                {
                    AllIsEmpty = true;
                }
            }

            //vsechny fifa jsou prazdan - ukoncuju cteni
            if (AllIsEmpty) 
            {
                ReadData_Stop();
                return;
            } 

            ReadData();
        }

        public void ReadData() 
        {
            //pokud uz nebezi cteni dat tak napokracuj
            if (DataReadGo == false)
            {
                ReadData_Stop();
                return;
            }

            //pokud nejsou vsechny data prijata tak nepokracuju
            foreach(bool b in IsDataRead) 
            {
                if (b == false) return;
            }
            
            
            int count = List_Data.Count;

            AnalyzInCirc_Data data = new AnalyzInCirc_Data(count);
            List_Data.Add(data);

            SendCommand(Communication.eCommandCode.CMD_CONST_GET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_FIFO_DATA_BASE + 0, 0x00, 0x00);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_FIFO_DATA_BASE + 1, 0x00, 0x00);

            IsDataRead[0] = false;
            IsDataRead[1] = false;
        }



        public void UpdateData(int index, UInt16 data) 
        {
            int count = List_Data.Count;

            uint part_empty = (uint)((data >> 15) & 0x0001);
            uint part_valid = (uint)((data >> 14) & 0x0001);
           
            uint part_data = (uint)(data & 0x00FF);
            uint part_K = (uint)((data >> 8) & 0x0001);


            
            if (part_empty == 1) 
            {
                //fifo he prazdne - neukladam data
                IsFifoEmpty[index] = true;
                return;
            }
            else 
            {
                IsFifoEmpty[index] = false;
            }

            //data nejsou validni
            if(part_valid == 0) 
            {
                return;
            }

            string sK;

            if(part_K == 1) 
            {
                sK = "K";
            }
            else 
            {
                sK = "D";
            }

            string s =  sK + "." + part_data.ToString("X") + "  (" + part_K.ToString() + "."+ part_data.ToString() + ")";

            List_Data[count - 1].AddData(index, s);


            IsDataRead[index] = true;

            for (int j = 0; j < _dataGridView_AnalyzData.ColumnCount; j++) 
            {
                _dataGridView_AnalyzData.UpdateCellValue(j, count - 1);
            }
 
        }




        public void EnableDisable(bool state) 
        {
            if (state) 
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_ENABLE, 0x00, 0x01);
            }
            else 
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_ENABLE, 0x00, 0x00);
            }
        }

        public void SetNumberOfSamples()
        {
            UInt32 val = (UInt32)numericUpDown_NumOfSamples.Value;
            byte b0 = (byte)((val >> 0) & 0xFF);
            byte b1 = (byte)((val >> 8) & 0xFF);

            SendCommand(Communication.eCommandCode.CMD_CONST_SET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_NUMBER_OF_SAMPLES, b1, b0);

        }

        public void SwStart() 
        {
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_TRG_START, 0x00, 0x01);
        }

        public void TriggerSetting_CheckBox() 
        {
            int size;
            UInt16 val;
            byte b0;
            byte b1;

            //rising edge trigger setting
            size = checkBox_Triggers_Rising.Length;
            if (size > 8) size = 8;

            val = 0;

            for (int i = 0; i < size; i++) 
            {
                if (checkBox_Triggers_Rising[i].Checked) 
                {
                    val = (UInt16)(1 << i);
                }
            }

            b0 = (byte)((val >> 0) & 0xFF);
            b1 = (byte)((val >> 8) & 0xFF);
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_TRIGGERS_MASK_RISING, b1, b0);

            //falling edge trigger setting
            size = checkBox_Triggers_Falling.Length;
            if (size > 8) size = 8;

            val = 0;

            for (int i = 0; i < size; i++)
            {
                if (checkBox_Triggers_Falling[i].Checked)
                {
                    val = (UInt16)(1 << i);
                }
            }

            b0 = (byte)((val >> 0) & 0xFF);
            b1 = (byte)((val >> 8) & 0xFF);
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_TRIGGERS_MASK_FALLING, b1, b0);
        }

        public void Clear() 
        {
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_CLEAR, 0x00, 0x01);
        }

        public void ClearList() 
        {
            List_Data.Clear();
        }

        void UpdateTriggerCheckBox_Rising(UInt16 val) 
        {
            int size = checkBox_Triggers_Rising.Length;
            if (size > 8) size = 8;


            for (int i = 0; i < size; i++)
            {
                if(((val >> i) & 0x01) == 0x01) 
                {
                    checkBox_Triggers_Rising[i].Checked = true;
                }
                else
                {
                    checkBox_Triggers_Rising[i].Checked = false;
                }

            }
        }

        void UpdateTriggerCheckBox_Falling(UInt16 val)
        {
            int size = checkBox_Triggers_Falling.Length;
            if (size > 8) size = 8;


            for (int i = 0; i < size; i++)
            {
                if (((val >> i) & 0x01) == 0x01)
                {
                    checkBox_Triggers_Falling[i].Checked = true;
                }
                else
                {
                    checkBox_Triggers_Falling[i].Checked = false;
                }

            }
        }
 

        public void GetSetting() 
        {
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_ENABLE, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_NUMBER_OF_SAMPLES, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_TRIGGERS_MASK_RISING, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_TRIGGERS_MASK_FALLING, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_AnalyzInCirc, (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_EMPTY, 0, 0);
        }

        public void UpdateFromCommunication(byte data_0, byte data_1, byte data_2)
        {

            //UInt32 temp = 0;
            UInt16 val = 0;

            switch (data_0)
            {
                //enable
                case (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_ENABLE:
                    if ((data_2 & 0x01) == 0x01)
                    {
                        label_Enable.Text = "Enable";
                    }
                    else
                    {
                        label_Enable.Text = "Disable";
                    }
                    break;


                case (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_NUMBER_OF_SAMPLES:
                    numericUpDown_NumOfSamples.Value = (data_1 << 8) | data_2;
                    break;

                case (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_TRIGGERS_MASK_RISING:
                    val = (UInt16)((data_1 << 8) | data_2);
                    UpdateTriggerCheckBox_Rising(val);
                    break;

                case (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_TRIGGERS_MASK_FALLING:
                    val = (UInt16)((data_1 << 8) | data_2);
                    UpdateTriggerCheckBox_Falling(val);
                    break;

                case (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_EMPTY:
                    if ((data_2 & 0x01) == 0x01)
                    {
                        label_Empty.Text = "EMPTY";
                    }
                    else
                    {
                        label_Empty.Text = "NOT EMPTY";
                    }
                    break;

                case (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_FIFO_DATA_BASE + 0:
                    UpdateData(0, (UInt16)((data_1 << 8) | data_2));
                    break;

                case (byte)eCommandCode_AnylyzInCirc.CMD_ANALYZINCIRC_FIFO_DATA_BASE + 1:
                    UpdateData(1, (UInt16)((data_1 << 8) | data_2));
                    break;



            }

        }



    }
}
