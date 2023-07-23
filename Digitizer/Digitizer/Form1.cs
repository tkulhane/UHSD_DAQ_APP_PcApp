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



            Registers_ADC.DataGrid_RegistersSetting = dataGridView_ADCregisters;
            Registers_ADC.SendFunction = Send_Command_int;

            Registers_FpgaTest.DataGrid_RegistersSetting = dataGridView_FPGAregisters;
            Registers_FpgaTest.SendFunction = Send_Command_int;
        }

        UART_Communication uart = new UART_Communication();

        Registers_Setting Registers_ADC = new Registers_Setting(Registers_Setting.eAddressValueSize.Address16_Value8, (int)eCommandCode.CMD_CONST_GET_AdcRegisters, (int)eCommandCode.CMD_CONST_SET_AdcRegisters);
        Registers_Setting Registers_FpgaTest = new Registers_Setting(Registers_Setting.eAddressValueSize.Address16_Value8, (int)eCommandCode.CMD_CONST_GET_MainRegisters, (int)eCommandCode.CMD_CONST_SET_MainRegisters);
        

        BindingList<EventData> list_data = new BindingList<EventData>();
        BindingList<EventInfo> list_events = new BindingList<EventInfo>();

        //int EventNow = 0;

        EventInfo EventNow = new EventInfo(-1, -1);


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

        private void comm_log(byte[] data)
        {
            //using (StreamWriter writer = new StreamWriter("comm_log.txt"))
            using (StreamWriter writer =  File.AppendText("comm_log.txt"))
            {
                string s = String.Empty; 

                for(int i = 0; i < 4; i++) 
                {
                    s += data[i].ToString("X2") + " ";
                }



                writer.WriteLine(s);
            }
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

        private void Send_Command_int(int CMD, int address, int value)
        {
            byte id = (byte)(0x80 | (byte)CMD);

            uart.SendCommand(id, (byte)((address >> 8) & 0x00FF), (byte)(address & 0x00FF), (byte)value);
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

            //communication log
            //comm_log(data);

            StoreData(data);


            eCommandCode ID = (eCommandCode)(data[0] & 0x7F);

            label_Test.Text = data[0].ToString("X2") + " " + data[1].ToString("X2") + " " + data[2].ToString("X2") + " " + data[3].ToString("X2");

            switch (ID) 
            {
                case eCommandCode.CMD_CONST_GET_MainRegisters:
                    //Update_MainRegisters_Table(data[1], data[2], data[3]);
                    Registers_FpgaTest.UpdateRegisters(data[1], data[2], data[3]);
                    break;

                case eCommandCode.CMD_CONST_GET_AdcRegisters:
                    //Update_ADCRegisters_Table(data[1], data[2], data[3]);
                    Registers_ADC.UpdateRegisters(data[1], data[2], data[3]);
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
                //EventNow = new EventInfo(E_Inc, list_data.Count);
                label_E.Text = label_E.Text + "A";
            }

            else if(data[0] == 0xFB) //Event tail - store event
            {
                //E_Inc++;
                list_events.Add(EventNow);
                label_E.Text = label_E.Text + "B";
                //dataGridView_events.Rows[dataGridView_events.Rows.Count - 1].Selected = true;
            }

            else if (data[0] == 0xFC)
            {
                label_E.Text = label_E.Text + "C";
            }

            else if (data[0] == 0xFD)
            {
                label_E.Text = label_E.Text + "D";
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
                label_E.Text = label_E.Text + "F";
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
        }

        private void button_LoadFromFile_Click(object sender, EventArgs e)
        {
            
            int selected = tabControl_MAIN.SelectedIndex;

            switch (selected)
            {
                case 1:
                    Registers_ADC.OpenRegistersFile();
                    break;

                case 2:
                    Registers_FpgaTest.OpenRegistersFile();        
                    break;

                default:
                    return;
                    //break;
            }

   
        }
        

        private void button_SaveToFile_Click(object sender, EventArgs e)
        {

            int selected = tabControl_MAIN.SelectedIndex;


            switch (selected)
            {
                case 1:
                    Registers_ADC.SaveRegistersFile();
                    break;

                case 2:
                    Registers_FpgaTest.SaveRegistersFile();
                    break;

                default:
                    return;
                    //break;
            }

        }

        private void dataGridView_ADCregisters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int selected = tabControl_MAIN.SelectedIndex;

            switch (selected)
            {
                case 1:
                    Registers_ADC.DataGridView_CellContentClick(sender, e);
                    break;

                case 2:
                    Registers_FpgaTest.DataGridView_CellContentClick(sender, e);
                    break;

                default:
                    return;
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

            //chart_data.Series["Data"].Points.Clear();
            chart_data.Series.Clear();

            for (int r = 0; r < selectedRows; r++)
            {

                int selectedIndex = dataGridView_events.SelectedRows[r].Index;
                EventInfo SelectedEvent = list_events[selectedIndex];

                int EventStartIndex = SelectedEvent.p_eventStart;
                int EventEndIndex = EventStartIndex + SelectedEvent.p_eventSize - 1;

                chart_data.Series.Add(r.ToString());
                chart_data.Series[r.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_data.Series[r.ToString()].LegendText = SelectedEvent.p_eventNum.ToString();
                chart_data.Series[r.ToString()].BorderWidth = 3;


                for (int i = EventStartIndex; i < EventEndIndex; i++)
                {
                    chart_data.Series[r.ToString()].Points.AddY(list_data[i].p_sample);

                }

            }
            
            chart_data.DataBind();
        }


    }
}
