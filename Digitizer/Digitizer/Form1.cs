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

            //gpio
            gpio.SendCommand = communication.SendCommand;
            gpio.DataGrid_GpioInput = dataGridView_GpioInputs;
            gpio.DataGrid_GpioOutput = dataGridView_GpioOutputs;
            gpio.LoadGpio();

            //reset
            rst.SendCommand = communication.SendCommand;
            rst.DataGrid_Reset = dataGridView_Resets;
            rst.LoadRst();


            //System Setting
            sysSetting.communication = communication;
            sysSetting.dataGridView_RegistersFiles = dataGridView_RegistersFiles;
            sysSetting.CreateRegistersInList(Registers_ADC);
            sysSetting.CreateRegistersInList(Registers_HMC);
            sysSetting.CreateRegistersInList(Registers_LMX1);
            sysSetting.CreateRegistersInList(Registers_LMX2);
            sysSetting.CreateRegistersInList(Registers_FpgaTest);

            //system setting load
            sysSetting.SettingLoad();

            //configuration file sequence
            ConfigSequence.dataGridView_ConfigFile = dataGridView_ConfigFile;
            ConfigSequence.List_ReigistersFile = sysSetting.List_ReigistersFile;

            


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sysSetting.SettingSave();
        }


        private void button_LoadSetting_Click(object sender, EventArgs e)
        {

        }




        Communication communication = new Communication();
        Acquisition_Control AcqControl = new Acquisition_Control();
        SystemSetting sysSetting = new SystemSetting();
        GPIO_Control gpio = new GPIO_Control();
        Reset_Control rst = new Reset_Control();

        Registers_Setting Registers_ADC = new Registers_Setting("ADC", Registers_Setting.eAddressValueSize.Address16_Value8, Communication.eCommandCode.CMD_CONST_GET_AdcRegisters, Communication.eCommandCode.CMD_CONST_SET_AdcRegisters);
        Registers_Setting Registers_HMC = new Registers_Setting("HMC", Registers_Setting.eAddressValueSize.Address16_Value8, Communication.eCommandCode.CMD_CONST_GET_HmcRegisters, Communication.eCommandCode.CMD_CONST_SET_HmcRegisters);
        Registers_Setting Registers_LMX1 = new Registers_Setting("LMX1", Registers_Setting.eAddressValueSize.Address8_Value16, Communication.eCommandCode.CMD_CONST_GET_Lmx1Registers, Communication.eCommandCode.CMD_CONST_SET_Lmx1Registers);
        Registers_Setting Registers_LMX2 = new Registers_Setting("LMX2", Registers_Setting.eAddressValueSize.Address8_Value16, Communication.eCommandCode.CMD_CONST_GET_Lmx2Registers, Communication.eCommandCode.CMD_CONST_SET_Lmx2Registers);
        Registers_Setting Registers_FpgaTest = new Registers_Setting("FpgaTest", Registers_Setting.eAddressValueSize.Address8_Value8, Communication.eCommandCode.CMD_CONST_GET_TestRegisters, Communication.eCommandCode.CMD_CONST_SET_TestRegisters);

        ConfigurationFileSequencer ConfigSequence = new ConfigurationFileSequencer();


        BindingList<EventData> list_data = new BindingList<EventData>();
        BindingList<EventInfo> list_events = new BindingList<EventInfo>();

        //int EventNow = 0;

        EventInfo EventNow = new EventInfo(-1, -1);




        private void timer_info_Tick(object sender, EventArgs e)
        {
            AcqControl.ReadSetting();
            gpio.ReadStateCommands();
            rst.ReadStateCommands();
        }

        private void ExecuteCommand()
        {
            Communication.eCommandCode ID = communication.CommandID;
            byte[] data = communication.CommandData;

            int int_ID = (int)ID;

            label_Test.Text = int_ID.ToString("X2") + " " + data[0].ToString("X2") + " " + data[1].ToString("X2") + " " + data[2].ToString("X2");

            Updade_label_xRead((byte)ID, data[0], data[1], data[2]);

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

                case Communication.eCommandCode.CMD_CONST_GET_GPIO:
                    gpio.UpdateFromCommunication(data[0], data[1], data[2]);
                    break;

                case Communication.eCommandCode.CMD_CONST_GET_Reset_Controler:
                    rst.UpdateFromCommunication(data[0], data[1], data[2]);
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

            else if (data[0] == 0xFB) //Event tail - store event
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

        private void button_Reset_Click(object sender, EventArgs e)
        {
            //communication.SendCommand(Communication.eCommandCode.CMD_CONST_SET_System_Controler, 0x55, 0xAB, 0xCD);
        }


        private void label_Test_Click(object sender, EventArgs e)
        {
            label_Test.Text = " ";
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.CMD_CONST_Loopback, 0xA1, 0xB2, 0xC3);
        }



        //-------------------------------------------------------------------------------------------------------------------
        //Registers Tables
        //-------------------------------------------------------------------------------------------------------------------
        private void button_LoadFromFile_Click(object sender, EventArgs e)
        {

            int selected = tabControl_RegistersSetting.SelectedIndex;
            string FileName;

            switch (selected)
            {
                case 0:
                    FileName = Registers_ADC.OpenRegistersFile();
                    sysSetting.AddFileRegistersInList(Registers_ADC, FileName);
                    break;

                case 1:
                    FileName = Registers_HMC.OpenRegistersFile();
                    sysSetting.AddFileRegistersInList(Registers_HMC, FileName);
                    break;

                case 2:
                    FileName = Registers_LMX1.OpenRegistersFile();
                    sysSetting.AddFileRegistersInList(Registers_LMX1, FileName);
                    break;

                case 3:
                    FileName = Registers_LMX2.OpenRegistersFile();
                    sysSetting.AddFileRegistersInList(Registers_LMX2, FileName);
                    break;

                case 4:
                    FileName = Registers_FpgaTest.OpenRegistersFile();
                    sysSetting.AddFileRegistersInList(Registers_FpgaTest, FileName);
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
                    Registers_ADC.SaveRegistersFileAsString(sysSetting.GetFileStringForRegisters(Registers_ADC));
                    break;

                case 1:
                    Registers_HMC.SaveRegistersFileAsString(sysSetting.GetFileStringForRegisters(Registers_HMC));
                    break;

                case 2:
                    Registers_LMX1.SaveRegistersFileAsString(sysSetting.GetFileStringForRegisters(Registers_LMX1));
                    break;

                case 3:
                    Registers_LMX2.SaveRegistersFileAsString(sysSetting.GetFileStringForRegisters(Registers_LMX2));
                    break;

                case 4:
                    Registers_FpgaTest.SaveRegistersFileAsString(sysSetting.GetFileStringForRegisters(Registers_FpgaTest));
                    break;

                default:
                    return;
                    //break;
            }

        }

        private void button_SaveAs_Click(object sender, EventArgs e)
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
                    Registers_ADC.DataGridView_CellContentClick(sender, e);
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

        private void button_RegReadAll_Click(object sender, EventArgs e)
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;

            switch (selected)
            {

                case 0:
                    Registers_ADC.ReadAll();
                    break;

                case 1:
                    Registers_HMC.ReadAll();
                    break;

                case 2:
                    Registers_LMX1.ReadAll();
                    break;

                case 3:
                    Registers_LMX2.ReadAll();
                    break;

                case 4:
                    Registers_FpgaTest.ReadAll();
                    break;

                default:
                    return;
            }
        }

        private void button_RegWriteAll_Click(object sender, EventArgs e)
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;

            switch (selected)
            {

                case 0:
                    Registers_ADC.WriteAll();
                    break;

                case 1:
                    Registers_HMC.WriteAll();
                    break;

                case 2:
                    Registers_LMX1.WriteAll();
                    break;

                case 3:
                    Registers_LMX2.WriteAll();
                    break;

                case 4:
                    Registers_FpgaTest.WriteAll();
                    break;

                default:
                    return;
            }
        }


        //-------------------------------------------------------------------------------------------------------------------
        //Data Chart
        //-------------------------------------------------------------------------------------------------------------------
        private void chart_data_Click(object sender, EventArgs e)
        {

            int selectedRows = dataGridView_events.SelectedRows.Count;

            if (selectedRows == 0)
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


        //-------------------------------------------------------------------------------------------------------------------
        //Configutation Sequence File
        //-------------------------------------------------------------------------------------------------------------------
        private void button_ConfigFileLoadFromFile_Click(object sender, EventArgs e)
        {
            ConfigSequence.OpenRegistersFile();
        }

        private void button_ConfigFileSaveToFile_Click(object sender, EventArgs e)
        {

        }

        private void button_ConfigFileSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void button_ConfigRun_Click(object sender, EventArgs e)
        {
            ConfigSequence.ConfigSequenceStart();
        }

        private void button_ConfigStop_Click(object sender, EventArgs e)
        {
            ConfigSequence.ConfigSequenceStop();
        }



        //-------------------------------------------------------------------------------------------------------------------
        //xSend
        //-------------------------------------------------------------------------------------------------------------------
        byte xSendedCMD;
        private void button_xSend_Click(object sender, EventArgs e)
        {
            byte b3 = 0;
            byte b2 = 0;
            byte b1 = 0;
            byte b0 = 0;

            if (!byte.TryParse(textBox_xSendByte3.Text, NumberStyles.HexNumber, null, out b3)) return;
            if (!byte.TryParse(textBox_xSendByte2.Text, NumberStyles.HexNumber, null, out b2)) return;
            if (!byte.TryParse(textBox_xSendByte1.Text, NumberStyles.HexNumber, null, out b1)) return;
            if (!byte.TryParse(textBox_xSendByte0.Text, NumberStyles.HexNumber, null, out b0)) return;

            xSendedCMD = b3;

            communication.SendCommand((Communication.eCommandCode)b3, b2, b1, b0);
        }

        private void Updade_label_xRead(byte ID, byte b2, byte b1, byte b0) 
        {
            if (ID != xSendedCMD) return;
            
            label_xRead.Text = ID.ToString("X2") + " " + b2.ToString("X2") + " " + b1.ToString("X2") + " " + b0.ToString("X2");
        }

        private void label_xRead_Click(object sender, EventArgs e)
        {
            label_xRead.Text = String.Empty;
        }

        //-------------------------------------------------------------------------------------------------------------------
        //gpio reset
        //-------------------------------------------------------------------------------------------------------------------
        private void dataGridView_GpioOutputs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gpio.DataGridView_Output_CellContentClick(sender, e);
        }

        private void button_ClearRisingFalling_Click(object sender, EventArgs e)
        {
            gpio.ClearRisingFalling();
        }

        private void dataGridView_Resets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rst.DataGridView_Reset_CellContentClick(sender, e);
        }
    }
}
