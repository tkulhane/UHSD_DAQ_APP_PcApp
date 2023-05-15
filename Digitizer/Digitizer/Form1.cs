using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView_data.DataSource = list_data;
            dataGridView_events.DataSource = list_events;

            dataGridView_data.Columns[0].Width = 80;
            dataGridView_data.Columns[1].Width = 80;

            dataGridView_events.Columns[0].Width = 50;
            dataGridView_events.Columns[1].Width = 50;
            dataGridView_events.Columns[2].Width = 50;

            chart_data.DataSource = list_data;
        }

        UART_Communication uart = new UART_Communication();

        BindingList<Data_Registers> list_ADC_registers = new BindingList<Data_Registers>();
        BindingList<Data_Registers> list_FPGA_registers = new BindingList<Data_Registers>();

        BindingList<EventData> list_data = new BindingList<EventData>();
        BindingList<EventInfo> list_events = new BindingList<EventInfo>();

        //int EventNow = 0;

        EventInfo EventNow = new EventInfo(-1,-1);

        public enum eCommandCode : byte
        {

             CMD_CONST_Loopback = 0x01,
             CMD_CONST_SET_System_Controler = 0x03,
             CMD_CONST_GET_System_Controler = 0x04,
             CMD_CONST_SET_MainRegisters = 0x11,
             CMD_CONST_GET_MainRegisters = 0x12,
             CMD_CONST_SET_InfoRegisters = 0x23,
             CMD_CONST_GET_InfoRegisters = 0x24,
             CMD_CONST_SET_AdcRegisters = 0x25,
             CMD_CONST_GET_AdcRegisters = 0x26,
             CMD_CONST_SET_TriggerRegisters = 0x31,
             CMD_CONST_GET_TriggerRegisters = 0x32

        }

        public enum eCommandCode_Trigger : byte
        {

            CMD_TRG_ENABLE = 0x00,
            CMD_TRG_THRESHOLD = 0x01,
            CMD_TRG_SAMPLE_PER_EVENT_L = 0x02,
            CMD_TRG_SAMPLE_PER_EVENT_M = 0x03,
            CMD_TRG_COUNTER_EVENT_INCOMING_L = 0x04,
            CMD_TRG_COUNTER_EVENT_INCOMING_M = 0x05,
            CMD_TRG_COUNTER_EVENT_PROCESSED_L = 0x06,
            CMD_TRG_COUNTER_EVENT_PROCESSED_M = 0x07,
            CMD_TRG_SET_NUMBERS_OF_EVENTS_L = 0x08,
            CMD_TRG_SET_NUMBERS_OF_EVENTS_M = 0x09,
            CMD_TRG_TEST_GENERATOR_ENABLE = 0x10,
            CMD_TRG_COUNTERS_RESET = 0x20

        }

        private void Send_Command(eCommandCode CMD, byte[] data) 
        {
            byte id = (byte)(0x80 | (byte)CMD);

            uart.SendCommand(id, data[0], data[1], data[2]);
        }

        private void Send_Command(eCommandCode CMD, byte data_0, byte data_1, byte data_2)
        {
            byte id = (byte)(0x80 | (byte)CMD);

            uart.SendCommand(id, data_0, data_1, data_2);
        }

        private void Send_Command(eCommandCode CMD, string address, string value)
        {
            byte id = (byte)(0x80 | (byte)CMD);

            int i_address = 0;
            if( !int.TryParse(address,System.Globalization.NumberStyles.HexNumber ,null,out i_address)) 
            {
                return;
            }

            byte i_value = 0;
            if (!byte.TryParse(value, System.Globalization.NumberStyles.HexNumber, null, out i_value))
            {
                return;
            }

            uart.SendCommand(id, (byte)((i_address>>8) & 0x00FF), (byte)(i_address & 0x00FF) , i_value);
        }

        private void timer_info_Tick(object sender, EventArgs e)
        {
            if (uart.IsOpen())
            {
                button_OpenClose.BackColor = Color.Green;
                comboBox_Ports.Enabled = false;
            }
            else
            {
                button_OpenClose.BackColor = SystemColors.Control;
                comboBox_Ports.Enabled = true;
            }
        }

        private void ExecuteCommand() 
        {
            byte[] data = uart.dataBuffer;
            //byte[] data = uart.AllData;

            

            if ((data[0] & 0x80) >> 7 == 0) 
            {
                StoreData(data);
                return;
            }
            
            eCommandCode ID = (eCommandCode)(data[0] & 0x7F);

            label_Test.Text = data[0].ToString("X2") + " " + data[1].ToString("X2") + " " + data[2].ToString("X2") + " " + data[3].ToString("X2");

            switch (ID) 
            {
                case eCommandCode.CMD_CONST_GET_MainRegisters:
                    Update_MainRegisters_Table(data[1], data[2], data[3]);
                    break;

                case eCommandCode.CMD_CONST_GET_AdcRegisters:
                    Update_ADCRegisters_Table(data[1], data[2], data[3]);
                    break;

                case eCommandCode.CMD_CONST_GET_TriggerRegisters:
                    Update_TriggerSetting_Table(data[1], data[2], data[3]);
                    break;

            }
        }

        private void StoreData(byte[] data) 
        {

            if (data[0] == 0xFA) //Event head - actualing Number Of Event
            {
                EventNow = new EventInfo(data[3], list_data.Count);
                
            }

            else if(data[0] == 0xFB) //Event tail - store event
            {

                list_events.Add(EventNow);
            }

            else if ((data[0] & 0x80) >> 7 == 0) // data frame
            {

                int sample1 = data[3] + ((data[2] & 0x0F) << 8);
                int sample2 = ((data[2] & 0xF0) >> 4) + (data[1] << 4);


                EventData s1 = new EventData(EventNow.p_eventNum, sample1);
                EventData s2 = new EventData(EventNow.p_eventNum, sample2);

                list_data.Add(s1);
                list_data.Add(s2);

                EventNow.IncreaseSize(2);
            }


        }

        private void Update_MainRegisters_Table(byte data_0, byte data_1, byte data_2) 
        {
            int s_address = (data_0 << 8) + data_1;

            string address = s_address.ToString("X");


            for(int i = 0; i < list_FPGA_registers.Count; i++) 
            {
                if (address.Equals(list_FPGA_registers[i].p_address)) 
                {
                    list_FPGA_registers[i].p_value = data_2.ToString("X");
                    dataGridView_FPGAregisters.UpdateCellValue(2, i);
                }
            }            

        }

        private void Update_ADCRegisters_Table(byte data_0, byte data_1, byte data_2)
        {
            int s_address = (data_0 << 8) + data_1;

            string address = s_address.ToString("X");


            for (int i = 0; i < list_ADC_registers.Count; i++)
            {
                if (address.Equals(list_ADC_registers[i].p_address))
                {
                    list_ADC_registers[i].p_value = data_2.ToString("X");
                    dataGridView_ADCregisters.UpdateCellValue(2, i);
                }
            }


        }

        private void label_Test_Click(object sender, EventArgs e)
        {
            label_Test.Text = " ";
        }

        private void button_Scan_Click(object sender, EventArgs e)
        {
            
            comboBox_Ports.Items.Clear();

            foreach (String s in uart.PortScan())
            {
                comboBox_Ports.Items.Add(s);
            }

            if (comboBox_Ports.Items.Count > 0)
            {
                comboBox_Ports.SelectedIndex = 0;
            }

        }

        private void button_OpenClose_Click(object sender, EventArgs e)
        {
            if (uart.IsOpen())
            {
                uart.StopRead();
                uart.ClosePort();
            }
            else
            {
                if (comboBox_Ports.SelectedIndex < 0)
                {
                    MessageBox.Show("Nevybran port", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string port = comboBox_Ports.SelectedItem as String;

                    try
                    {
                        uart.OpenPort(port);
                        uart.BeginRead(ExecuteCommand);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void button_Test_Click(object sender, EventArgs e)
        {

            Send_Command(eCommandCode.CMD_CONST_Loopback, 0xA1, 0xB2, 0xC3);

            //Send_Command(eCommandCode.CMD_CONST_GET_System_Controler, 0x01, 0, 0);
        }

        private void button_LoadFromFile_Click(object sender, EventArgs e)
        {
            
            int selected = tabControl_MAIN.SelectedIndex;

            var list_temp = list_ADC_registers;
            var dataGridView_temp = dataGridView_ADCregisters;

            switch (selected)
            {
                case 1:
                    list_temp = list_ADC_registers;
                    dataGridView_temp = dataGridView_ADCregisters;
                    break;

                case 2:
                    list_temp = list_FPGA_registers;
                    dataGridView_temp = dataGridView_FPGAregisters;
                    break;

                default:
                    return;
                    //break;
            }


            String fname = String.Empty;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Soubory dat (*.csv)|*.csv|Vsechny|*.*";

                if (DialogResult.OK == ofd.ShowDialog())
                {
                    
                    fname = ofd.FileName;
                }
                else
                {
                    return;
                }

                if (String.IsNullOrEmpty(fname)) 
                {
                    return;
                }

                list_temp.Clear();

                String[] lines = File.ReadAllLines(fname, Encoding.GetEncoding("Windows-1250"));

                foreach(String s in lines) 
                {
                    Data_Registers data = new Data_Registers(s);
                    list_temp.Add(data);
                }



                dataGridView_temp.DataSource = list_temp;

                if (dataGridView_temp.Columns.Count >= 5)
                {
                    return;
                }


                DataGridViewButtonColumn btn_read = new DataGridViewButtonColumn();
                DataGridViewButtonColumn btn_write = new DataGridViewButtonColumn();

                btn_read.HeaderText = "Write";
                btn_read.Text = "Write";
                btn_read.Name = "button_ADCregisterWrite";
                btn_read.UseColumnTextForButtonValue = true;

                btn_write.HeaderText = "Read";
                btn_write.Text = "Read";
                btn_write.Name = "button_ADCregisterRead";
                btn_write.UseColumnTextForButtonValue = true;

                dataGridView_temp.Columns.Add(btn_write);
                dataGridView_temp.Columns.Add(btn_read);

                //dataGridView_temp.Columns[0].DefaultCellStyle.Format = "X";

                //list_ADC_registers = list_temp;
                //dataGridView_ADCregisters = dataGridView_temp;

            }
        }

        private void button_SaveToFile_Click(object sender, EventArgs e)
        {

            int selected = tabControl_MAIN.SelectedIndex;

            var list_temp = list_ADC_registers;

            switch (selected)
            {
                case 1:
                    list_temp = list_ADC_registers;
                    break;

                case 2:
                    list_temp = list_FPGA_registers;
                    break;

                default:
                    return;
                    //break;
            }



            String fname = String.Empty;

            using (SaveFileDialog ofd = new SaveFileDialog())
            {
                ofd.Filter = "Soubory dat (*.csv)|*.csv|Vsechny|*.*";

                if (DialogResult.OK == ofd.ShowDialog())
                {

                    fname = ofd.FileName;
                }
                else
                {
                    return;
                }

                if (String.IsNullOrEmpty(fname))
                {
                    return;
                }
            }

            if (String.IsNullOrEmpty(fname))
            {
                return;
            }

            FileStream fs = File.OpenWrite(fname);

            foreach (Data_Registers data in list_temp) 
            {
                byte[] line = Encoding.ASCII.GetBytes(data.FormatToCSV());

                fs.Write(line, 0, line.Length);
            }

            fs.Close();

        }

        private void dataGridView_ADCregisters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int selected = tabControl_MAIN.SelectedIndex;
            var list_temp = list_ADC_registers;
            
            eCommandCode ID_SET = 0;
            eCommandCode ID_GET = 0;

            switch (selected)
            {
                case 1:
                    list_temp = list_ADC_registers;
                    ID_SET = eCommandCode.CMD_CONST_SET_AdcRegisters;
                    ID_GET = eCommandCode.CMD_CONST_GET_AdcRegisters;
                    break;

                case 2:
                    list_temp = list_FPGA_registers;
                    ID_SET = eCommandCode.CMD_CONST_SET_MainRegisters;
                    ID_GET = eCommandCode.CMD_CONST_GET_MainRegisters;
                    break;

                default:
                    return;
            }



            if (e.ColumnIndex == 3) 
            {

                string address = list_temp[e.RowIndex].p_address;
                string value = list_temp[e.RowIndex].p_value;

                //MessageBox.Show("Read:  " + address);
                Send_Command(ID_GET, address, "1");
            }
            else if (e.ColumnIndex == 4)
            {

                string address = list_temp[e.RowIndex].p_address;
                string value = list_temp[e.RowIndex].p_value;

                //MessageBox.Show("Write:  " + address + " " + value);
                Send_Command(ID_SET, address, value);
            }
        }

        private void button_AutoTest_Click(object sender, EventArgs e)
        {
           

            if (timer_AutoTest.Enabled) 
            {
                button_AutoTest.BackColor = Color.Red;
                timer_AutoTest.Enabled = false;
            }
                
            else 
            {
                button_AutoTest.BackColor = Color.Green;
                Test_OneRun();
                timer_AutoTest.Enabled = true;
            }
                
        }

        private void button_ValidateTest_Click(object sender, EventArgs e)
        {
            if(data_for_valid == null) 
            {
                return;
            }
            Test_Validate();
        }

        private void timer_AutoTest_Tick(object sender, EventArgs e)
        {
            Test_Validate();
            Test_OneRun();


        }


        byte[] data_for_valid;


        private void Test_OneRun() 
        {

            string address;

            BindingList<Data_Registers> temp_reg = new BindingList<Data_Registers>();
            eCommandCode ID_SET = eCommandCode.CMD_CONST_SET_MainRegisters;
            eCommandCode ID_GET = eCommandCode.CMD_CONST_GET_MainRegisters;

            Random rnd = new Random();

            byte[] temp_data = new byte[list_FPGA_registers.Count];
            data_for_valid = temp_data;

            for (int i = 0; i < list_FPGA_registers.Count; i++)
            {
                address = list_FPGA_registers[i].p_address;
                byte data = (byte)rnd.Next(255);

                temp_data[i] = data;
                Send_Command(ID_SET, address, data.ToString("X"));

            }

            for (int i = 0; i < list_FPGA_registers.Count; i++)
            {
                address = list_FPGA_registers[i].p_address;

                Send_Command(ID_GET, address, "00");

            }



        }


        int tests_fail = 0;
        int tests_ok = 0;

        private void Test_Validate() 
        {
            string value;
            bool fault = false;

            for (int i = 0; i < list_FPGA_registers.Count; i++)
            {
                value = list_FPGA_registers[i].p_value;

                if (value.Equals(data_for_valid[i].ToString("X")))
                {

                }
                else
                {
                    fault = true;
                }

            }

            if (fault)
            {
                tests_fail++;
            }
            else
            {
                tests_ok++;
            }

            label_TestResult.Text = "OK=" + tests_ok.ToString() + "   FAULT=" + tests_fail.ToString();
        }

        private void numericUpDown_testPeriod_ValueChanged(object sender, EventArgs e)
        {
            timer_AutoTest.Interval = (int)numericUpDown_testPeriod.Value;
        }



        private void button_datatest_Click(object sender, EventArgs e)
        {
            //int sample1 = 3978;
            //int sample2 = 2256;

            //byte data1 = (byte)(sample1 & 0xFF);
            //byte data2 = (byte)((sample1 >> 8) + ((sample2 & 0x0F) << 4)) ;
            //byte data3 = (byte)(sample2 >> 4); 

            //byte[] data = { 0x00, data3, data2, data1 };



            String fname = String.Empty;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Soubory dat (*.txt)|*.txt|Vsechny|*.*";

                if (DialogResult.OK == ofd.ShowDialog())
                {

                    fname = ofd.FileName;
                }
                else
                {
                    return;
                }

                if (String.IsNullOrEmpty(fname))
                {
                    return;
                }


                String[] lines = File.ReadAllLines(fname, Encoding.GetEncoding("Windows-1250"));

                foreach (String s in lines)
                {

                    int val = Convert.ToInt32(s, 2);

                    byte[] data = new byte[4];// = { 0x00, 0x00, 0x00,  };
                    data[3] = (byte)((val >> 0) & 0xFF);
                    data[2] = (byte)((val >> 8) & 0xFF);
                    data[1] = (byte)((val >> 16) & 0xFF);
                    data[0] = (byte)((val >> 24) & 0xFF);


                    StoreData(data);


                }

            }


        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            Send_Command(eCommandCode.CMD_CONST_SET_System_Controler, 0x55, 0xAB, 0xCD);
        }

        //Trigger

        private void Update_TriggerSetting_Table(byte data_0, byte data_1, byte data_2) 
        {

            UInt32 temp = 0;
            UInt16 val = 0;

            switch (data_0)
            {
                //enable
                case (byte)eCommandCode_Trigger.CMD_TRG_ENABLE:
                    if((data_2 & 0x01) == 0x01)
                    {
                        checkBox_TRG_Enable.Checked = true;
                    }
                    else 
                    {
                        checkBox_TRG_Enable.Checked = false;
                    }
                    break;

                //threshold
                case (byte)eCommandCode_Trigger.CMD_TRG_THRESHOLD:
                    numericUpDown_Threshold.Value = (data_1 << 8) | data_2;
                    break;

                //Sample per event L
                case (byte)eCommandCode_Trigger.CMD_TRG_SAMPLE_PER_EVENT_L:
                    temp = (UInt32)numericUpDown_Num_Of_Samples.Value;
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0xFFFF0000) | ((UInt32)val << 0);
                    numericUpDown_Num_Of_Samples.Value = temp;
                    break;

                //Sample per event M
                case (byte)eCommandCode_Trigger.CMD_TRG_SAMPLE_PER_EVENT_M:
                    temp = (UInt32)numericUpDown_Num_Of_Samples.Value;
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0x0000FFFF) | ((UInt32)val << 16);
                    numericUpDown_Num_Of_Samples.Value = temp;
                    break;

                //Counter incoming L
                case (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_INCOMING_L:
                    temp = UInt32.Parse(label_Incoming_Events.Text);
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0xFFFF0000) | ((UInt32)val << 0);
                    label_Incoming_Events.Text = temp.ToString();
                    break;

                //Counter incoming M
                case (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_INCOMING_M:
                    temp = UInt32.Parse(label_Incoming_Events.Text);
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0x0000FFFF) | ((UInt32)val << 16);
                    label_Incoming_Events.Text = temp.ToString();
                    break;

                //Counter processed L
                case (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_PROCESSED_L:
                    temp = UInt32.Parse(label_Processed_Events.Text);
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0xFFFF0000) | ((UInt32)val << 0);
                    label_Processed_Events.Text = temp.ToString();
                    break;

                //Counter processed M
                case (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_PROCESSED_M:
                    temp = UInt32.Parse(label_Processed_Events.Text);
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0x0000FFFF) | ((UInt32)val << 16);
                    label_Processed_Events.Text = temp.ToString();
                    break;

                //set num of events L
                case (byte)eCommandCode_Trigger.CMD_TRG_SET_NUMBERS_OF_EVENTS_L:
                    temp = (UInt32)numericUpDown_set_num_of_events.Value;
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0xFFFF0000) | ((UInt32)val << 0);
                    numericUpDown_set_num_of_events.Value = temp;
                    break;

                //set num of events M
                case (byte)eCommandCode_Trigger.CMD_TRG_SET_NUMBERS_OF_EVENTS_M:
                    temp = (UInt32)numericUpDown_set_num_of_events.Value;
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0x0000FFFF) | ((UInt32)val << 16);
                    numericUpDown_set_num_of_events.Value = temp;
                    break;



                //test generator enable
                case (byte)eCommandCode_Trigger.CMD_TRG_TEST_GENERATOR_ENABLE:
                    if ((data_2 & 0x01) == 0x01)
                    {
                        checkBox_TRG_TestGen_Enable.Checked = true;
                    }
                    else
                    {
                        checkBox_TRG_TestGen_Enable.Checked = false;
                    }
                    break;


            }
        }

        private void checkBox_TRG_Enable_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_TRG_Enable.Checked)
            {
                Send_Command(eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_ENABLE, 0x00, 0x01);
            }
            else
            {
                Send_Command(eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_ENABLE, 0x00, 0x00);
            }

        }

        private void checkBox_TRG_TestGen_Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_TRG_TestGen_Enable.Checked)
            {
                Send_Command(eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TEST_GENERATOR_ENABLE, 0x00, 0x01);
            }
            else
            {
                Send_Command(eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TEST_GENERATOR_ENABLE, 0x00, 0x00);
            }
        }

        private void numericUpDown_Threshold_ValueChanged(object sender, EventArgs e)
        {
            UInt16 val = (UInt16)numericUpDown_Threshold.Value;
            byte b0 = (byte)((val >> 0) & 0xFF); 
            byte b1 = (byte)((val >> 8) & 0xFF);

            Send_Command(eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_THRESHOLD, b1, b0);
        }

        private void numericUpDown_Num_Of_Samples_ValueChanged(object sender, EventArgs e)
        {
            UInt32 val = (UInt32)numericUpDown_Num_Of_Samples.Value;
            byte b0 = (byte)((val >> 0) & 0xFF);
            byte b1 = (byte)((val >> 8) & 0xFF);
            byte b2 = (byte)((val >> 16) & 0xFF);
            byte b3 = (byte)((val >> 24) & 0xFF);

            Send_Command(eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SAMPLE_PER_EVENT_L, b1, b0);
            Send_Command(eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SAMPLE_PER_EVENT_M, b3, b2);
        }

        private void numericUpDown_set_num_of_events_ValueChanged(object sender, EventArgs e)
        {
            UInt32 val = (UInt32)numericUpDown_set_num_of_events.Value;
            byte b0 = (byte)((val >> 0) & 0xFF);
            byte b1 = (byte)((val >> 8) & 0xFF);
            byte b2 = (byte)((val >> 16) & 0xFF);
            byte b3 = (byte)((val >> 24) & 0xFF);

            Send_Command(eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SET_NUMBERS_OF_EVENTS_L, b1, b0);
            Send_Command(eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SET_NUMBERS_OF_EVENTS_M, b3, b2);
        }

        private void button_TRG_Read_Conters_Click(object sender, EventArgs e)
        {
            Send_Command(eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_INCOMING_L, 0, 0);
            Send_Command(eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_INCOMING_M, 0, 0);
            Send_Command(eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_PROCESSED_L, 0, 0);
            Send_Command(eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_PROCESSED_M, 0, 0);
        }

        private void button_Clear_Counters_Click(object sender, EventArgs e)
        {
            Send_Command(eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTERS_RESET, 0, 0);
        }

        private void button_Read_Setting_Click(object sender, EventArgs e)
        {
            Send_Command(eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_ENABLE, 0, 0);
            Send_Command(eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TEST_GENERATOR_ENABLE, 0, 0);
            Send_Command(eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_THRESHOLD, 0, 0);
            Send_Command(eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SAMPLE_PER_EVENT_L, 0, 0);
            Send_Command(eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SAMPLE_PER_EVENT_M, 0, 0);
            Send_Command(eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SET_NUMBERS_OF_EVENTS_L, 0, 0);
            Send_Command(eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SET_NUMBERS_OF_EVENTS_M, 0, 0);
        }

        private void chart_data_Click(object sender, EventArgs e)
        {

            int selectedRows = dataGridView_events.SelectedRows.Count;
            
            if(selectedRows == 0) 
            {
                return;
            }

            chart_data.Series["Data"].Points.Clear();

            for (int r = 0; r < selectedRows; r++)
            {

                int selectedIndex = dataGridView_events.SelectedRows[r].Index;
                EventInfo SelectedEvent = list_events[selectedIndex];

                int EventStartIndex = SelectedEvent.p_eventStart;
                int EventEndIndex = EventStartIndex + SelectedEvent.p_eventSize - 1;



                for (int i = EventStartIndex; i < EventEndIndex; i++)
                {
                    chart_data.Series["Data"].Points.AddY(list_data[i].p_sample);

                }

            }
            
            chart_data.DataBind();
        }
    }
}
