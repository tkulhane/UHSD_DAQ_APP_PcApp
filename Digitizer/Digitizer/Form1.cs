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

            //setting form elements for communication class
            communication.comboBox_Ports = comboBox_Communication;
            communication.radioButton_UART = radioButton_UART;
            communication.radioButton_USB = radioButton_USB;
            communication.radioButton_PCIe = radioButton_PCIe;
            communication.button_Scan = button_ScanCommunication;
            communication.button_OpenClose = button_OpenCloseCommunication;
            communication.ExecuteCommand = ExecuteCommand;
            communication.ExecuteData = ExecuteData;

            //Acquisition_Control
            
            AcqControl.SendCommand = communication.SendCommand;

            AcqControl.radioButton_AcqInfinite = radioButton_AcqInfinite;
            AcqControl.radioButton_AcqNumEvents = radioButton_AcqNumEvents;
            AcqControl.radioButton_AcqTime = radioButton_AcqTime;

            AcqControl.numericUpDown_NumOfEvents = numericUpDown_NumOfEvents;
            AcqControl.numericUpDown_Time = numericUpDown_Time;
            AcqControl.numericUpDown_NumOfSamples = numericUpDown_NumOfSamples;
            AcqControl.numericUpDown_AcqThreshold = numericUpDown_AcqThreshold;
            AcqControl.numericUpDown_AcqRepeats = numericUpDown_AcqRepeats;

            AcqControl.label_CounterIncomingEvents = label_CounterIncomingEvents;
            AcqControl.label_CounterProcessedEvents = label_CounterProcessedEvents;
            AcqControl.label_CounterInRunEvents = label_CounterInRunEvents;

            AcqControl.label_AcqState = label_AcqState;
            AcqControl.checkBox_TestGeneratorEnable = checkBox_TestGeneratorEnable;
            AcqControl.button_AcqStartStop = button_AcqStartStop;

            AcqControl.UpdateAcqState(false);


            //data grids setting for registers class
            Registers_ADC.DataGrid_RegistersSetting = dataGridView_ADCReg;
            Registers_HMC.DataGrid_RegistersSetting = dataGridView_HMCReg;
            Registers_LMX1.DataGrid_RegistersSetting = dataGridView_LMX1Reg;
            Registers_LMX2.DataGrid_RegistersSetting = dataGridView_LMX2Reg;
            Registers_FpgaTest.DataGrid_RegistersSetting = dataGridView_TestReg;

            //command send for registers class
            Registers_ADC.SendFunction = communication.SendCommand;
            Registers_HMC.SendFunction = communication.SendCommand;
            Registers_LMX1.SendFunction = communication.SendCommand;
            Registers_LMX2.SendFunction = communication.SendCommand;
            Registers_FpgaTest.SendFunction = communication.SendCommand;

            //System Setting
            sysSetting.communication = communication;


            sysSetting.SettingLoad();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sysSetting.SettingSave();
        }



        Communication communication = new Communication();
        Acquisition_Control AcqControl = new Acquisition_Control();
        SystemSetting sysSetting = new SystemSetting();

        Registers_Setting Registers_ADC = new Registers_Setting(Registers_Setting.eAddressValueSize.Address16_Value8, Communication.eCommandCode.CMD_CONST_GET_AdcRegisters, Communication.eCommandCode.CMD_CONST_SET_AdcRegisters);
        Registers_Setting Registers_HMC = new Registers_Setting(Registers_Setting.eAddressValueSize.Address16_Value8, Communication.eCommandCode.CMD_CONST_GET_HmcRegisters, Communication.eCommandCode.CMD_CONST_SET_HmcRegisters);
        Registers_Setting Registers_LMX1 = new Registers_Setting(Registers_Setting.eAddressValueSize.Address8_Value16, Communication.eCommandCode.CMD_CONST_GET_Lmx1Registers, Communication.eCommandCode.CMD_CONST_SET_Lmx1Registers);
        Registers_Setting Registers_LMX2 = new Registers_Setting(Registers_Setting.eAddressValueSize.Address8_Value16, Communication.eCommandCode.CMD_CONST_GET_Lmx2Registers, Communication.eCommandCode.CMD_CONST_SET_Lmx2Registers);
        Registers_Setting Registers_FpgaTest = new Registers_Setting(Registers_Setting.eAddressValueSize.Address8_Value8, Communication.eCommandCode.CMD_CONST_GET_TestRegisters, Communication.eCommandCode.CMD_CONST_SET_TestRegisters);

        BindingList<EventData> list_data = new BindingList<EventData>();
        BindingList<EventInfo> list_events = new BindingList<EventInfo>();

        //int EventNow = 0;

        EventInfo EventNow = new EventInfo(-1, -1);


        

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


        
        private void timer_info_Tick(object sender, EventArgs e)
        {
            AcqControl.ReadSetting();
        }

        private void ExecuteCommand() 
        {
            Communication.eCommandCode ID = communication.CommandID;
            byte[] data = communication.CommandData;

            int int_ID = (int)ID;

            label_Test.Text = int_ID.ToString("X2") + " " + data[0].ToString("X2") + " " + data[1].ToString("X2") + " " + data[2].ToString("X2");

            switch (ID) 
            {
                
                case Communication.eCommandCode.CMD_CONST_GET_AdcRegisters:
                    Registers_ADC.UpdateRegisters(data[0], data[1], data[2]);
                    break;

                case Communication.eCommandCode.CMD_CONST_GET_HmcRegisters:
                    Registers_HMC.UpdateRegisters(data[0], data[1], data[2]);
                    break;

                case Communication.eCommandCode.CMD_CONST_GET_Lmx1Registers:
                    Registers_LMX1.UpdateRegisters(data[0], data[1], data[2]);
                    break;

                case Communication.eCommandCode.CMD_CONST_GET_Lmx2Registers:
                    Registers_LMX2.UpdateRegisters(data[0], data[1], data[2]);
                    break;

                case Communication.eCommandCode.CMD_CONST_GET_TestRegisters:
                    Registers_FpgaTest.UpdateRegisters(data[0], data[1], data[2]);
                    break;

                case Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters:
                    AcqControl.UpdateFromCommunication(data[0], data[1], data[2]);
                    break;

            }
        }

        private void ExecuteData() 
        {
            byte[] data = communication.ReceivedData;

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



        private void button_Test_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.CMD_CONST_Loopback, 0xA1, 0xB2, 0xC3);
        }

        private void button_LoadFromFile_Click(object sender, EventArgs e)
        {
            
            int selected = tabControl_RegistersSetting.SelectedIndex;

            switch (selected)
            {
                case 0:
                    Registers_ADC.OpenRegistersFile();
                    break;

                case 1:
                    Registers_HMC.OpenRegistersFile();        
                    break;

                case 2:
                    Registers_LMX1.OpenRegistersFile();
                    break;

                case 3:
                    Registers_LMX2.OpenRegistersFile();
                    break;

                case 4:
                    Registers_FpgaTest.OpenRegistersFile();
                    break;

                default:
                    return;
                    //break;
            }

   
        }
        

        private void button_SaveToFile_Click(object sender, EventArgs e)
        {

            int selected = tabControl_RegistersSetting.SelectedIndex;

            switch (selected)
            {
                case 0:
                    Registers_ADC.SaveRegistersFile();
                    break;

                case 1:
                    Registers_HMC.SaveRegistersFile();
                    break;

                case 2:
                    Registers_LMX1.SaveRegistersFile();
                    break;

                case 3:
                    Registers_LMX2.SaveRegistersFile();
                    break;

                case 4:
                    Registers_FpgaTest.SaveRegistersFile();
                    break;

                default:
                    return;
                    //break;
            }

        }

        private void dataGridView_AllRegistersGrids_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int selected = tabControl_RegistersSetting.SelectedIndex;

            switch (selected)
            {


                case 0:
                    Registers_ADC.DataGridView_CellContentClick(sender,e);
                    break;

                case 1:
                    Registers_HMC.DataGridView_CellContentClick(sender, e);
                    break;

                case 2:
                    Registers_LMX1.DataGridView_CellContentClick(sender, e);
                    break;

                case 3:
                    Registers_LMX2.DataGridView_CellContentClick(sender, e);
                    break;

                case 4:
                    Registers_FpgaTest.DataGridView_CellContentClick(sender, e);
                    break;

                default:
                    return;
            }


        }

       


        

        private void button_Reset_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.CMD_CONST_SET_System_Controler, 0x55, 0xAB, 0xCD);
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


        //-------------------------------------------------------------------------------------------------------------------
        //Communication Form Control
        //-------------------------------------------------------------------------------------------------------------------
        private void radioButton_Communication_CheckedChanged(object sender, EventArgs e)
        {
            communication.Scan();
        }

        private void button_ScanCommunication_Click(object sender, EventArgs e)
        {
            communication.Scan();
        }

        private void button_OpenCloseCommunication_Click(object sender, EventArgs e)
        {
            communication.OpenClose();
        }


        //-------------------------------------------------------------------------------------------------------------------
        //Acquisition Form Control
        //-------------------------------------------------------------------------------------------------------------------
        private void button_AcqStartStop_Click(object sender, EventArgs e)
        {
            AcqControl.StartStop();
            
        }

        private void numericUpDown_NumOfEvents_ValueChanged(object sender, EventArgs e)
        {
            AcqControl.SetNumberOfEvents();
        }

        private void numericUpDown_Time_ValueChanged(object sender, EventArgs e)
        {
            AcqControl.SetRunTime();
        }

        private void numericUpDown_NumOfSamples_ValueChanged(object sender, EventArgs e)
        {
            AcqControl.SetNumberOfSamples();
        }

        private void numericUpDown_AcqThreshold_ValueChanged(object sender, EventArgs e)
        {
            AcqControl.SetThreshold();
        }

        private void radioButton_Acq_CheckedChanged(object sender, EventArgs e)
        {
            AcqControl.AcqRunSetting();
        }

        private void button_ReadAcqState_Click(object sender, EventArgs e)
        {
            AcqControl.ReadSetting();
        }

        private void checkBox_TestGeneratorEnable_CheckedChanged(object sender, EventArgs e)
        {
            AcqControl.TestGeneratorEnable();
        }


    }
}
