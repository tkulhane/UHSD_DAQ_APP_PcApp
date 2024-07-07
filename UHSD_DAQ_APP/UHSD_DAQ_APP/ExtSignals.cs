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

        const int NumOfPorts = 10;
        const int NumOfInputsSignals = 32;


        List<ExtSignals_Data> List_ExtSignals_Inputs = new List<ExtSignals_Data>
            {
                new ExtSignals_Data() {NUM = 0, SIG = "Res"},
                new ExtSignals_Data() {NUM = 1, SIG = "Res"},
                new ExtSignals_Data() {NUM = 2, SIG = "ClockInput_EXT1"},
                new ExtSignals_Data() {NUM = 3, SIG = "ClockInput_EXT2"},
                
                new ExtSignals_Data() {NUM = 10, SIG = "ACQ_EXT_TriggerInput"},
                
                new ExtSignals_Data() {NUM = 27, SIG = "Analyz_Trigger_7"},
                new ExtSignals_Data() {NUM = 28, SIG = "GPI_0"},
                new ExtSignals_Data() {NUM = 29, SIG = "GPI_1"},
                new ExtSignals_Data() {NUM = 30, SIG = "GPI_2"},
                new ExtSignals_Data() {NUM = 31, SIG = "GPI_3"}


            };

        List<ExtSignals_Data> List_ExtSignals_Outputs = new List<ExtSignals_Data>
            {
                new ExtSignals_Data() {NUM = 0, SIG = "Logic_Low"},
                new ExtSignals_Data() {NUM = 1, SIG = "Logic_High"},
                new ExtSignals_Data() {NUM = 2, SIG = "CLK_SRC_40MHz"},
                new ExtSignals_Data() {NUM = 3, SIG = "CLK_SRC_Logic"},
                new ExtSignals_Data() {NUM = 4, SIG = "CLK_SRC_Ref"},
                new ExtSignals_Data() {NUM = 5, SIG = "CLK_HMC"},

                new ExtSignals_Data() {NUM = 6, SIG = "FTDI_nTXE"},
                new ExtSignals_Data() {NUM = 7, SIG = "FTDI_nWR"},

                new ExtSignals_Data() {NUM = 8, SIG = "Diag_0"},
                new ExtSignals_Data() {NUM = 9, SIG = "Diag_1"},

                new ExtSignals_Data() {NUM = 10, SIG = "ACQ_Enable_Out"},
                new ExtSignals_Data() {NUM = 11, SIG = "ACQ_Trigger_Out"},
                new ExtSignals_Data() {NUM = 12, SIG = "ACQ_Run_Out"},
                new ExtSignals_Data() {NUM = 13, SIG = "ACQ_Busy_Out"},
                new ExtSignals_Data() {NUM = 14, SIG = "ACQ_SelfTrigger_Out"},
                new ExtSignals_Data() {NUM = 15, SIG = "ACQ_Fifo_NotFree"},
                new ExtSignals_Data() {NUM = 16, SIG = "ACQ_Abort_Out"},

                new ExtSignals_Data() {NUM = 20, SIG = "SYNCIB_Out"},
                new ExtSignals_Data() {NUM = 21, SIG = "SYSREF"},
                new ExtSignals_Data() {NUM = 22, SIG = "LMX_SYNC"},
                new ExtSignals_Data() {NUM = 23, SIG = "LMX_SYNC_Sychronized"},
                new ExtSignals_Data() {NUM = 24, SIG = "ADC_FD"},

                new ExtSignals_Data() {NUM = 28, SIG = "GPO-0"},
                new ExtSignals_Data() {NUM = 29, SIG = "GPO-1"},
                new ExtSignals_Data() {NUM = 30, SIG = "GPO-2"},
                new ExtSignals_Data() {NUM = 31, SIG = "GPO-3"}


            };


        public enum eCommandCode_ExtSignals: byte
        {
             CMD_EXT_SIGNALS_ADDR_BASE_INPUTS_SEL = 10,
             CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_SEL = 110,
             CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_ENABLE = 0xD2,
             CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_ENABLE_SET = 0xDC,
             CMD_EXT_SIGNALS_ADDR_BASE_OUTPUTS_ENABLE_CLEAR = 0xE6
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
            int index_comboBox = DataGrid_Inputs.Columns["comboBox_ExtSignalsPort"].Index;

            int row = e.RowIndex;

            if (e.ColumnIndex == index_comboBox)
            {
                int selectedNum;
                int.TryParse(DataGrid_Inputs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(),out selectedNum);

                for(int i = 0;i< List_ExtSignals_Inputs.Count; i++) 
                {
                    if (i.Equals(row))
                    {
                        SendSetting_Input(List_ExtSignals_Inputs[i].NUM, selectedNum);
                    }
                }

            }
        }

        private void DataGrid_Outputs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int index_comboBox = DataGrid_Outputs.Columns["comboBox_ExtSignalsOutputs"].Index;
            int index_checkBox = DataGrid_Outputs.Columns["checkBox_ExtSignalsOutputEnable"].Index;

            int row = e.RowIndex;

            if (e.ColumnIndex == index_comboBox) 
            {
                string selectedString = DataGrid_Outputs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
  
                foreach(ExtSignals_Data data in List_ExtSignals_Outputs) 
                {
                    if (data.SIG.Equals(selectedString)) 
                    {
                        SendSetting_Output(row, data.NUM);
                    }
                }

            }
            else if(e.ColumnIndex == index_checkBox) 
            {

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
        }

        public void WriteSetting() 
        {

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

            foreach (ExtSignals_Data x in List_ExtSignals_Outputs) 
            {
                if (x.NUM.Equals(signal)) 
                {
                    DataGrid_Outputs.Rows[port].Cells[index_comboBox].Value = x.SIG;
                    DataGrid_Inputs.UpdateCellValue(index_comboBox, port);

                    //MessageBox.Show(port.ToString() + "   " + x.SIG);
                }
            }

        }

        public void UpdateFromCommunication(byte data_0, byte data_1, byte data_2)
        {
            
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

                }
            }




        }

    }
}
