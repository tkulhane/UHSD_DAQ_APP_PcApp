using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class ExtSignals
    {

        const int NumOfPorts = 22;
        const int NumOfInputsSignals = 32;


        List<ExtSignals_Data> List_ExtSignals_Inputs = new List<ExtSignals_Data>
            {
                new ExtSignals_Data() {NUM = 0, SIG = "Res"},
                new ExtSignals_Data() {NUM = 1, SIG = "Res"}



            };

        List<ExtSignals_Data> List_ExtSignals_Outputs = new List<ExtSignals_Data>
            {
                new ExtSignals_Data() {NUM = 255, SIG = "Default_LogicLow"},
                new ExtSignals_Data() {NUM = 254, SIG = "LogicHigh"},

                new ExtSignals_Data() {NUM = 0, SIG = "CLK_IN"},
                new ExtSignals_Data() {NUM = 1, SIG = "SYSREF_IN"},
                new ExtSignals_Data() {NUM = 2, SIG = "Logic_Clk"},
                new ExtSignals_Data() {NUM = 3, SIG = "Ref_Clk"},
                new ExtSignals_Data() {NUM = 4, SIG = "CTRL_Clk"},
                new ExtSignals_Data() {NUM = 5, SIG = "Clk_40M"},

                new ExtSignals_Data() {NUM = 26, SIG = "GPO_0"},
                new ExtSignals_Data() {NUM = 27, SIG = "GPO_1"},

                new ExtSignals_Data() {NUM = 28, SIG = "Second_0"},
                new ExtSignals_Data() {NUM = 29, SIG = "Second_1"},
                new ExtSignals_Data() {NUM = 30, SIG = "Second_2"},
                new ExtSignals_Data() {NUM = 31, SIG = "Second_3"}



            };


        public enum eCommandCode_ExtSignals: byte
        {
             CMD_EXT_SIGNALS_ADDR_BASE_INPUTS_SEL = 0,
             CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_SEL = 100,
             CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_ENABLE = 0xC8,
             CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_ENABLE_SET = 0xCA,
             CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_ENABLE_CLEAR = 0xCC
        }


        public delegate void efunction(Communication.eCommandCode CMD, byte d1, byte d2, byte d3);
        public efunction SendCommand;

        public DataGridView DataGrid_Inputs;
        public DataGridView DataGrid_Outputs;


        public void DataGridsLoad() 
        {
            
            //ports definition
            List<ExtSignals_Ports> ListPorts = new List<ExtSignals_Ports>();
            for (int i = 0; i < NumOfPorts; i++)
            {
                ListPorts.Add(new ExtSignals_Ports() { Port = i });
            }


            //inputs
            DataGrid_Inputs.DataSource = List_ExtSignals_Inputs;

            DataGridViewComboBoxColumn comboBox_Ports = new DataGridViewComboBoxColumn();
            comboBox_Ports.HeaderText = "Port";
            comboBox_Ports.Name = "comboBox_ExtSignalsPort";
            foreach (ExtSignals_Ports data in ListPorts)
            {
                comboBox_Ports.Items.Add(data.p_Port.ToString());
            }

            DataGrid_Inputs.Columns.Add(comboBox_Ports);

            DataGrid_Inputs.CellValueChanged += new DataGridViewCellEventHandler(DataGrid_Inputs_CellValueChanged);


            //outputs
            DataGrid_Outputs.DataSource = ListPorts;

            DataGridViewComboBoxColumn comboBox_Outputs = new DataGridViewComboBoxColumn();
            comboBox_Outputs.HeaderText = "Signal";
            comboBox_Outputs.Name = "comboBox_ExtSignalsOutputs";
            foreach (ExtSignals_Data data in List_ExtSignals_Outputs)
            {
                comboBox_Outputs.Items.Add(data.SIG);
            }

            DataGridViewCheckBoxColumn checkBox_Enable = new DataGridViewCheckBoxColumn();
            checkBox_Enable.HeaderText = "Output Enable";
            checkBox_Enable.Name = "checkBox_ExtSignalsOutputEnable";

            DataGrid_Outputs.Columns.Add(comboBox_Outputs);
            DataGrid_Outputs.Columns.Add(checkBox_Enable);

            DataGrid_Outputs.CellValueChanged += new DataGridViewCellEventHandler(DataGrid_Outputs_CellValueChanged);

        }

        private void DataGrid_Inputs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            WriteInputsSetting(e.RowIndex, e.ColumnIndex);
        }

        private void DataGrid_Outputs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            WriteOutputsSetting(e.RowIndex, e.ColumnIndex);
        }

        public void WriteInputsSetting(int row, int cIndex) 
        {
            int index_comboBox = DataGrid_Inputs.Columns["comboBox_ExtSignalsPort"].Index;

            //int row = e.RowIndex;

            if (cIndex == index_comboBox)
            {
                int selectedNum;
                int.TryParse(DataGrid_Inputs.Rows[row].Cells[cIndex].Value.ToString(), out selectedNum);

                for (int i = 0; i < List_ExtSignals_Inputs.Count; i++)
                {
                    if (i.Equals(row))
                    {
                        SendSetting_Input(List_ExtSignals_Inputs[i].NUM, selectedNum);
                    }
                }

            }
        }

        public void WriteOutputsSetting(int row, int cIndex) 
        {
            int index_comboBox = DataGrid_Outputs.Columns["comboBox_ExtSignalsOutputs"].Index;
            int index_checkBox = DataGrid_Outputs.Columns["checkBox_ExtSignalsOutputEnable"].Index;

            //int row = e.RowIndex;

            if (cIndex == index_comboBox)
            {
                string selectedString = DataGrid_Outputs.Rows[row].Cells[cIndex].Value.ToString();

                foreach (ExtSignals_Data data in List_ExtSignals_Outputs)
                {
                    if (data.SIG.Equals(selectedString))
                    {
                        SendSetting_Output(row, data.NUM);
                    }
                }

            }
            else if (cIndex == index_checkBox)
            {
                //int num = List_ExtSignals_Outputs[row].NUM;

                //foreach (ExtSignals_Data data in List_ExtSignals_Outputs)
                //{
                    //if (data.NUM.Equals(num))
                    //{
                        bool b = Convert.ToBoolean(DataGrid_Outputs.Rows[row].Cells[cIndex].Value);

                        byte x = 0; 

                        if(row >= 16) 
                        {
                            row = row - 16;
                            x = 1;
                        }

                //MessageBox.Show(row.ToString());

                        UInt16 mask = (UInt16)(1 << row);
                        byte b0 = (byte)((mask >> 0) & 0xFF);
                        byte b1 = (byte)((mask >> 8) & 0xFF);

                        //MessageBox.Show(b.ToString() + "    " + mask.ToString());

                        if (b)
                        {
                            SendCommand(Communication.eCommandCode.CMD_CONST_SET_ExtSignals, (byte)((byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_ENABLE_SET + x), b1, b0);
                        }
                        else
                        {
                            SendCommand(Communication.eCommandCode.CMD_CONST_SET_ExtSignals, (byte)((byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_ENABLE_CLEAR + x), b1, b0);
                        }
                    //}
                //}
            }
        }

        public void SendSetting_Input(int signal, int port) 
        {
            //MessageBox.Show("Port " + port.ToString() + "routed to signal " + signal.ToString());

            UInt16 val = (UInt16)port;

            SendCommand(Communication.eCommandCode.CMD_CONST_SET_ExtSignals, (byte)((byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_INPUTS_SEL + signal), (byte)((val >> 8) & 0xFF), (byte)((val >> 0) & 0xFF));
        }

        public void SendSetting_Output(int port, int signal) 
        {
            //MessageBox.Show("Signal " + signal.ToString() + "routed to port" + port.ToString());

            UInt16 val = (UInt16)signal;

            SendCommand(Communication.eCommandCode.CMD_CONST_SET_ExtSignals, (byte)((byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_SEL + port), (byte)((val >> 8) & 0xFF), (byte)((val >> 0) & 0xFF));
        }

        public void ReadSetting() 
        {
            for(int i = 0; i < NumOfInputsSignals; i++) 
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_GET_ExtSignals, (byte)((byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_INPUTS_SEL + i), 0, 0);
            }
            for (int i = 0; i < NumOfPorts; i++)
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_GET_ExtSignals, (byte)((byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_SEL + i), 0, 0);
            }

            SendCommand(Communication.eCommandCode.CMD_CONST_GET_ExtSignals, (byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_ENABLE, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_ExtSignals, (byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_ENABLE + 1, 0, 0);
        }


        public void UpdateInputComboBox(int signal, int port) 
        {
            if (port > NumOfPorts - 1 || port < 0) return;

            int index_comboBox = DataGrid_Inputs.Columns["comboBox_ExtSignalsPort"].Index;

            for(int i = 0;i< List_ExtSignals_Inputs.Count; i++) 
            {
                if (List_ExtSignals_Inputs[i].NUM.Equals(signal)) 
                {
                    DataGrid_Inputs.Rows[i].Cells[index_comboBox].Value = port.ToString();
                    DataGrid_Inputs.UpdateCellValue(index_comboBox, i);
                }
            }
           
        }

        public void UpdateOutputComboBox(int port, int signal)
        {
            int index_comboBox = DataGrid_Outputs.Columns["comboBox_ExtSignalsOutputs"].Index;
            //MessageBox.Show(port.ToString() + "   " + signal.ToString());
            //MessageBox.Show(index_comboBox.ToString());
            foreach (ExtSignals_Data x in List_ExtSignals_Outputs) 
            {
                if (x.NUM.Equals(signal)) 
                {
                    DataGrid_Outputs.Rows[port].Cells[index_comboBox].Value = x.SIG;
                    //DataGrid_Inputs.UpdateCellValue(index_comboBox, port);
                    DataGrid_Outputs.UpdateCellValue(index_comboBox, port);

                    //MessageBox.Show(port.ToString() + "   " + x.SIG);
                }
            }

        }

        public void UpdateOutputEnableCheckBox(int value, byte b) 
        {
            
            int index_checkBox = DataGrid_Outputs.Columns["checkBox_ExtSignalsOutputEnable"].Index;

            //MessageBox.Show(index_checkBox.ToString() + "    " + value.ToString());
            for (int i = 0; i < NumOfPorts; i++)
            {
                int value_new;

                if (b == 0) 
                {
                    if (i > 15) continue;
                    value_new = value;
                }
                else 
                {
                    if (i <= 15) continue;
                    value_new = value << 16;
                }

                DataGrid_Outputs.Rows[i].Cells[index_checkBox].Value =(value_new >> i) & 0x1;


            }
        }

        public void UpdateFromCommunication(byte data_0, byte data_1, byte data_2)
        {
            //MessageBox.Show(data_0.ToString("2X") + " " + data_1.ToString("2X") + " " + data_2.ToString("2X"));
            if ((data_0 >= (byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_INPUTS_SEL) && (data_0 <= (byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_INPUTS_SEL + NumOfInputsSignals)) 
            {
                byte signal = (byte)(data_0 - (byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_INPUTS_SEL);
                UpdateInputComboBox(signal, ((data_1 << 8) | data_2));
            }

            else if ((data_0 >= (byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_SEL) && (data_0 <= (byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_SEL + NumOfInputsSignals))
            {
                byte port = (byte)(data_0 - (byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_SEL);
                UpdateOutputComboBox(port, ((data_1 << 8) | data_2));
            }

            else 
            {
                if(data_0 == (byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_ENABLE) 
                {
                    UpdateOutputEnableCheckBox((data_1 << 8) | data_2,0);
                }
                else if (data_0 == (byte)eCommandCode_ExtSignals.CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_ENABLE+1)
                {
                    UpdateOutputEnableCheckBox(((data_1 << 8) | data_2),1);
                }
            }

        }



        public void WriteAllSetting() 
        {
            int index_comboBox_Inputs = DataGrid_Inputs.Columns["comboBox_ExtSignalsPort"].Index;
            int index_comboBox_Outputs = DataGrid_Outputs.Columns["comboBox_ExtSignalsOutputs"].Index;
            int index_checkBox_Enable = DataGrid_Outputs.Columns["checkBox_ExtSignalsOutputEnable"].Index;


            for(int i = 0; i< List_ExtSignals_Inputs.Count;i++)
            {
                WriteInputsSetting(i, index_comboBox_Inputs);
            }

            for (int i = 0; i < NumOfPorts; i++)
            {
                WriteOutputsSetting(i, index_comboBox_Outputs);
                WriteOutputsSetting(i, index_checkBox_Enable);
            }

        }

    }
}
