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

            //dataGridView_data.DataSource = list_data;
            //dataGridView_events.DataSource = list_events;


            //dataGridView_data.Columns[0].Width = 80;
            //dataGridView_data.Columns[1].Width = 80;

            //dataGridView_events.Columns[0].Width = 50;
            //dataGridView_events.Columns[1].Width = 50;
            //dataGridView_events.Columns[2].Width = 50;

            //chart_data.DataSource = list_data;

            //acq data
            AcqData.dataGridView_Events = dataGridView_events;
            AcqData.chart_data = chart_data;
            AcqData.checkBox_SaveToRam = checkBox_SaveToRam;
            AcqData.checkBox_SaveToFile = checkBox_SaveToFile;
            AcqData.SetAcquisitionDataProcess();

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



            //configuration file sequence
            //ConfigSequence.dataGridView_ConfigFile = dataGridView_ConfigFile;
            //ConfigSequence.List_ReigistersFile = sysSetting.List_ReigistersFile;
            //ConfigSequence.rst = rst;
            //ConfigSequence.gpio = gpio;
            MultiConfigSequence.dataGridView_ConfigFile = dataGridView_ConfigFile;
            //MultiConfigSequence.comboBox_ConfigFiles = comboBox_ConfigFiles;
            MultiConfigSequence.MultipleConfigFiles = dataGridView_MultipleConfigFiles;
            MultiConfigSequence.List_ReigistersFile = sysSetting.List_ReigistersFile;
            MultiConfigSequence.rst = rst;
            MultiConfigSequence.gpio = gpio;
            MultiConfigSequence.Init();


            //Analyz In Circ
            AnalyzInCirc.label_Enable = label_AnalyzEnable;
            AnalyzInCirc.numericUpDown_NumOfSamples = numericUpDown_AnalyzNumOfSamples;
            AnalyzInCirc.label_Empty = label_AnalyzEmpty;
            AnalyzInCirc.label_DataReadState = label_DataReadState;
            AnalyzInCirc._dataGridView_AnalyzData = dataGridView_AnalyzData;
            CheckBox[] checkBoxes_Rising =  { checkBox_AnalyzTrg_R_1, checkBox_AnalyzTrg_R_2, checkBox_AnalyzTrg_R_3, checkBox_AnalyzTrg_R_4, checkBox_AnalyzTrg_R_5, checkBox_AnalyzTrg_R_6, checkBox_AnalyzTrg_R_7, checkBox_AnalyzTrg_R_8 };
            CheckBox[] checkBoxes_Falling = { checkBox_AnalyzTrg_F_1, checkBox_AnalyzTrg_F_2, checkBox_AnalyzTrg_F_3, checkBox_AnalyzTrg_F_4, checkBox_AnalyzTrg_F_5, checkBox_AnalyzTrg_F_6, checkBox_AnalyzTrg_F_7, checkBox_AnalyzTrg_F_8 };
            AnalyzInCirc.checkBox_Triggers_Rising = checkBoxes_Rising;
            AnalyzInCirc.checkBox_Triggers_Falling = checkBoxes_Falling;
            AnalyzInCirc.SendCommand = communication.SendCommand;
            AnalyzInCirc.AnalyzInit();


            //System Setting
            sysSetting.communication = communication;
            sysSetting.dataGridView_RegistersFiles = dataGridView_RegistersFiles;
            sysSetting.configurationFiles = MultiConfigSequence;
            sysSetting.CreateRegistersInList(Registers_ADC);
            sysSetting.CreateRegistersInList(Registers_HMC);
            sysSetting.CreateRegistersInList(Registers_LMX1);
            sysSetting.CreateRegistersInList(Registers_LMX2);
            sysSetting.CreateRegistersInList(Registers_FpgaTest);


            //system setting load
            sysSetting.SettingLoad();


            AcqControl.ReadSettingAndValues();






            reg_test = new Registers_Setting_X("TestTest", tabControl_RegistersSetting, Registers_Setting_X.eAddressValueSize.Address8_Value16, Communication.eCommandCode.CMD_CONST_GET_AdcRegisters, Communication.eCommandCode.CMD_CONST_SET_AdcRegisters);
            reg_test.SendFunction = communication.SendCommand;

            //tabControl_RegistersSetting.Controls.Add(dgv);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sysSetting.SettingSave();
            communication.CloseAll();
        }


        private void button_LoadSetting_Click(object sender, EventArgs e)
        {

        }




        Communication communication = new Communication();
        AcquisitionDataProcess AcqData = new AcquisitionDataProcess();
        Acquisition_Control AcqControl = new Acquisition_Control();
        SystemSetting sysSetting = new SystemSetting();
        GPIO_Control gpio = new GPIO_Control();
        Reset_Control rst = new Reset_Control();
        AnalyzInCirc AnalyzInCirc = new AnalyzInCirc();


        Registers_Setting Registers_ADC = new Registers_Setting("ADC", Registers_Setting.eAddressValueSize.Address16_Value8, Communication.eCommandCode.CMD_CONST_GET_AdcRegisters, Communication.eCommandCode.CMD_CONST_SET_AdcRegisters);
        Registers_Setting Registers_HMC = new Registers_Setting("HMC", Registers_Setting.eAddressValueSize.Address16_Value8, Communication.eCommandCode.CMD_CONST_GET_HmcRegisters, Communication.eCommandCode.CMD_CONST_SET_HmcRegisters);
        Registers_Setting Registers_LMX1 = new Registers_Setting("LMX1", Registers_Setting.eAddressValueSize.Address8_Value16, Communication.eCommandCode.CMD_CONST_GET_Lmx1Registers, Communication.eCommandCode.CMD_CONST_SET_Lmx1Registers);
        Registers_Setting Registers_LMX2 = new Registers_Setting("LMX2", Registers_Setting.eAddressValueSize.Address8_Value16, Communication.eCommandCode.CMD_CONST_GET_Lmx2Registers, Communication.eCommandCode.CMD_CONST_SET_Lmx2Registers);
        //Registers_Setting Registers_FpgaTest = new Registers_Setting("FpgaTest", Registers_Setting.eAddressValueSize.Address8_Value8, Communication.eCommandCode.CMD_CONST_GET_TestRegisters, Communication.eCommandCode.CMD_CONST_SET_TestRegisters);

        Registers_Setting Registers_FpgaTest = new Registers_Setting("FpgaTest", Registers_Setting.eAddressValueSize.Address8_Value16, Communication.eCommandCode.CMD_CONST_GET_TransceiversControl, Communication.eCommandCode.CMD_CONST_SET_TransceiversControl);


        Registers_Setting_X reg_test;

        //ConfigurationFileSequencer ConfigSequence = new ConfigurationFileSequencer();
        MultipleConfigurationFileSequencer MultiConfigSequence = new MultipleConfigurationFileSequencer();


        BindingList<EventData> list_data = new BindingList<EventData>();
        BindingList<EventInfo> list_events = new BindingList<EventInfo>();

        //int EventNow = 0;

        EventInfo EventNow = new EventInfo(-1, -1);

        UInt32 EventCount;


        private void timerForm_Tick(object sender, EventArgs e)
        {

            //if (communication.communicationControl.ActivityError == true)
            //    labelXXX.Text += "nOK";
            //else
            //    labelXXX.Text += "OK";


            label_RecvBytes.Text = communication.USB_RecvBytes().ToString();
            label_InQ.Text = communication.USB_InQ().ToString();

            label_dataErrors.Text = AcqData.ErrorCounter.ToString();
        }

        private void timerRequest_Tick(object sender, EventArgs e)
        {
            if (checkBox_cmdQuestions.Checked)
            {
                AcqControl.ReadValues();
                gpio.ReadStateCommands();
                rst.ReadStateCommands();
                AnalyzInCirc.GetSetting();
            }

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

                //case Communication.eCommandCode.CMD_CONST_GET_TestRegisters:       //ToDo:
                case Communication.eCommandCode.CMD_CONST_GET_TransceiversControl:
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

                case Communication.eCommandCode.CMD_CONST_GET_CommunicationControl:
                    communication.communicationControl.ActivityWatchUpdate(data[0], data[1], data[2]);
                    break;

                case Communication.eCommandCode.CMD_CONST_GET_AnalyzInCirc:
                    AnalyzInCirc.UpdateFromCommunication(data[0], data[1], data[2]);
                    break;


            }
        }

        private void ExecuteData()
        {
            byte[] data = communication.ReceivedData;

            AcqData.ExecuteData(data);
        }

        //-------------------------------------------------------------------------------------------------------------------
        //TabControl
        //-------------------------------------------------------------------------------------------------------------------
        private void tabControl_MAIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcqControl.ReadSettingAndValues();

            Update_label_QS_Phase1();
            Update_label_QS_Phase2();
            Update_QS_FcalEn_checkBox();

            AnalyzInCirc.GetSetting();
        }


        private void button_Reset_Click(object sender, EventArgs e)
        {
            //communication.SendCommand(Communication.eCommandCode.CMD_CONST_SET_System_Controler, 0x55, 0xAB, 0xCD);
            rst.SystemReset();
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

        private void dataGridView_AllRegistersGrids_SelectedChanged(object sender, EventArgs e)
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;
            Registers_Setting SelectedRegisters = null;

            switch (selected)
            {


                case 0:
                    SelectedRegisters = Registers_ADC;
                    break;

                case 1:
                    SelectedRegisters = Registers_HMC;
                    break;

                case 2:
                    SelectedRegisters = Registers_LMX1;
                    break;

                case 3:
                    SelectedRegisters = Registers_LMX2;
                    break;

                case 4:
                    SelectedRegisters = Registers_FpgaTest;
                    break;

                default:
                    break;
            }

            if (SelectedRegisters == null) //nebyl vybran zadny registers
            {
                SetRegistersInfoElements(false, null, 0);
                return;
            }

            Registers_SettingData data = null;
            if (SelectedRegisters.Grid_GetSelectData(out data))
            {
                // radek je vybran
                int valSize = SelectedRegisters.GetValueSize();
                SetRegistersInfoElements(true, data, valSize);
            }
            else
            {
                //radek neni vybran
                SetRegistersInfoElements(false, null, 0);
            }


        }

        private void SetRegistersInfoElements(bool set, Registers_SettingData data, int ValueSize) 
        {
            if (set == false || data == null) 
            {
                textBox_RegAddress.Text = String.Empty;
                textBox_RegValue.Text = String.Empty;
                label_RegRW.Text = String.Empty;
                label_RegDescription.Text = String.Empty;

                foreach (CheckBox ch in groupBox_RegBits.Controls)
                {
                    ch.Checked = false;
                    ch.Enabled = false;
                }
                return;
            }

            //zobrazeni adresy
            if (radioButton_RegAddrHEX.Checked)
            {
                textBox_RegAddress.Text = data.p_address.ToString("X"); //zobrazit jako hex
            }
            else if (radioButton_RegAddrDEC.Checked)
            {
                textBox_RegAddress.Text = data.p_address.ToString(); //zobrazit jako dec
            }

            //zobrazeni hodnoty
            if (radioButton_RegValHEX.Checked)
            {
                textBox_RegValue.Text = data.p_value; //zobrazit jako hex
            }
            else if (radioButton_RegValDEC.Checked)
            {
                textBox_RegValue.Text = data.ParseValue().ToString(); //zobrazit jako dec
            }

            
            
            label_RegRW.Text = data.p__StrReadWrite;
            label_RegDescription.Text = data.p_description;

            if (data._ReadWrite == Registers_SettingData.eReadWrite.read_write || data._ReadWrite == Registers_SettingData.eReadWrite.write)
            {
                textBox_RegValue.Enabled = true;
            }
            else
            {
                textBox_RegValue.Enabled = false;
            }

            int value = data.ParseValue();

            foreach (CheckBox ch in groupBox_RegBits.Controls) 
            {
                int chTag = int.Parse((string)ch.Tag);

                if (chTag < ValueSize) 
                {
                    if(data._ReadWrite == Registers_SettingData.eReadWrite.read_write || data._ReadWrite == Registers_SettingData.eReadWrite.write) 
                    {
                        ch.Enabled = true;
                    }
                    else 
                    {
                        ch.Enabled = false;
                    }

                    if(((value & (1 << chTag)) >> chTag) == 1 ) 
                    {
                        ch.Checked = true;
                    }
                    else 
                    {
                        ch.Checked = false;
                    }

                }
                else 
                {
                    ch.Checked = false;
                    ch.Enabled = false;
                }
                
                
            }
        }

        private void checkBox_RegBitSet_CheckedChanged(object sender, EventArgs e)
        {
            int value = 0;

            foreach(CheckBox ch in groupBox_RegBits.Controls) 
            {
                int chTag = int.Parse((string)ch.Tag);

                if (ch.Checked && ch.Enabled)
                {
                    value |= 1 << chTag;
                }
            }

            textBox_RegValue.Text = value.ToString("X"); 
        }

        private void textBox_RegAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_RegValue_TextChanged(object sender, EventArgs e)
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;
            Registers_Setting SelectedRegisters = null;


            switch (selected)
            {
                case 0:
                    SelectedRegisters = Registers_ADC;
                    break;

                case 1:
                    SelectedRegisters = Registers_HMC;
                    break;

                case 2:
                    SelectedRegisters = Registers_LMX1;
                    break;

                case 3:
                    SelectedRegisters = Registers_LMX2;
                    break;

                case 4:
                    SelectedRegisters = Registers_FpgaTest;
                    break;

                default:
                    break;
            }

            if (SelectedRegisters == null) //nebyl vybran zadny registers
            {
                SetRegistersInfoElements(false, null,0);
                return;
            }

            int address;
            int value = 0;

            Registers_SettingData data = null;
            if (SelectedRegisters.Grid_GetSelectData(out data))
            {
                // radek je vybran
                address = data.p_address;
            }
            else
            {
                //radek neni vybran
                return;
            }


            //zobrazeni hodnoty
            if (radioButton_RegValHEX.Checked) //parsovat jako hex
            {
                if (!int.TryParse(textBox_RegValue.Text, NumberStyles.HexNumber, null, out value)) return;
            }
            else if (radioButton_RegValDEC.Checked) //parsovat jako dec
            {
                if (!int.TryParse(textBox_RegValue.Text, out value)) return;
            }

           

            SelectedRegisters.UpdateRegistersNoRequest(address, value);

        }

        private void button_RegAddrFind_Click(object sender, EventArgs e)
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;
            Registers_Setting SelectedRegisters = null;


            switch (selected)
            {
                case 0:
                    SelectedRegisters = Registers_ADC;
                    break;

                case 1:
                    SelectedRegisters = Registers_HMC;
                    break;

                case 2:
                    SelectedRegisters = Registers_LMX1;
                    break;

                case 3:
                    SelectedRegisters = Registers_LMX2;
                    break;

                case 4:
                    SelectedRegisters = Registers_FpgaTest;
                    break;

                default:
                    break;
            }

            if (SelectedRegisters == null) //nebyl vybran zadny registers
            {
                return;
            }

            int address = 0;
            bool parseResult = false;

            //parsovani
            if (radioButton_RegAddrHEX.Checked)
            {
                parseResult = int.TryParse(textBox_RegAddress.Text, NumberStyles.HexNumber, null, out address);
            }
            else if (radioButton_RegAddrDEC.Checked)
            {
                parseResult = int.TryParse(textBox_RegAddress.Text, out address);
            }

            if (!parseResult)
            {
                MessageBox.Show("Wrong value when parsing text. \nText: " + textBox_RegAddress.Text, "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!SelectedRegisters.FindAddressSelect(address)) 
            {
                MessageBox.Show("Address not found. \nAddress: " + address.ToString("X"), "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void radioButton_RegAddr_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView_AllRegistersGrids_SelectedChanged(null, null);
        }

        private void radioButton_RegVal_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView_AllRegistersGrids_SelectedChanged(null, null);
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
                    //Registers_LMX1.WriteAll();
                    Registers_LMX1.WriteAllReverse();
                    break;

                case 3:
                    //Registers_LMX2.WriteAll();
                    Registers_LMX2.WriteAllReverse();
                    break;

                case 4:
                    Registers_FpgaTest.WriteAll();
                    break;

                default:
                    return;
            }
        }

        private void button_RegUpdateFromExtFile_Click(object sender, EventArgs e)
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;
 

            switch (selected)
            {
                case 0:
                    //FileName = Registers_ADC.OpenRegistersFile();
                    //sysSetting.AddFileRegistersInList(Registers_ADC, FileName);
                    break;

                case 1:
                    Registers_HMC.UpdateFromPyFile();
                    break;

                case 2:
                    Registers_LMX1.UpdateFromTxtFile();
                    break;

                case 3:
                    Registers_LMX2.UpdateFromTxtFile();
                    break;

                case 4:
                    //FileName = Registers_FpgaTest.OpenRegistersFile();
                    //sysSetting.AddFileRegistersInList(Registers_FpgaTest, FileName);
                    break;

                default:
                    return;
                    //break;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------
        //Measurement Data
        //-------------------------------------------------------------------------------------------------------------------
        private void chart_data_Click(object sender, EventArgs e)
        {
            AcqData.chart_data_Click(sender, e);
        }

        private void button_EventsListClear_Click(object sender, EventArgs e)
        {
            AcqData.ClearEventsList();
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
            if (AcqControl.AcqState) AcqData.UpdateSaving();
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

        private void checkBox_TestGeneratorEnable_CheckedChanged(object sender, EventArgs e)
        {
            AcqControl.TestGeneratorEnable();
        }


        //-------------------------------------------------------------------------------------------------------------------
        //Configutation Sequence File
        //-------------------------------------------------------------------------------------------------------------------
        private void button_AddNewConfig_Click(object sender, EventArgs e)
        {
            MultiConfigSequence.AddConfig();
        }

        private void button_ConfigFileLoadFromFile_Click(object sender, EventArgs e)
        {
            MultiConfigSequence.AssignFile();
        }

        private void button_RemoveConfig_Click(object sender, EventArgs e)
        {
            MultiConfigSequence.RemoveFile();
        }

        private void button_ConfigFileSaveToFile_Click(object sender, EventArgs e)
        {

        }

        private void button_ConfigFileSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void button_ConfigRun_Click(object sender, EventArgs e)
        {
            MultiConfigSequence.ConfigSequenceStart();
        }

        private void button_ConfigStop_Click(object sender, EventArgs e)
        {
            MultiConfigSequence.ConfigSequenceStop();
        }



        private void dataGridView_MultipleConfigFiles_SelectionChanged(object sender, EventArgs e)
        {
            MultiConfigSequence.SelectedChanged();
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

        private void button_ResetClearAll_Click(object sender, EventArgs e)
        {
            rst.ClearAll();
        }


        //-------------------------------------------------------------------------------------------------------------------
        //quick setup
        //-------------------------------------------------------------------------------------------------------------------

        private void numericUpDown_QS_Seed1_ValueChanged(object sender, EventArgs e)
        {
            UInt32 value = (UInt32)numericUpDown_QS_Seed1.Value;


            Registers_LMX1.UpdateRegistersNoRequest(0x29, (int)(value & 0x0000FFFF));
            Registers_LMX1.UpdateRegistersNoRequest(0x28, (int)((value >> 16) & 0x0000FFFF));

            Update_label_QS_Phase1();


            Registers_LMX1.SendRegister(0x29);
            Registers_LMX1.SendRegister(0x28);
        }

        private void numericUpDown_QS_Seed2_ValueChanged(object sender, EventArgs e)
        {
            UInt32 value = (UInt32)numericUpDown_QS_Seed2.Value;


            Registers_LMX2.UpdateRegistersNoRequest(0x29, (int)(value & 0x0000FFFF));
            Registers_LMX2.UpdateRegistersNoRequest(0x28, (int)((value >> 16) & 0x0000FFFF));

            Update_label_QS_Phase2();

            Registers_LMX2.SendRegister(0x29);
            Registers_LMX2.SendRegister(0x28);
        }

        private void Update_label_QS_Phase1() 
        {

            label_QS_PLL_DEN1.Text = String.Empty;
            label_QS_INC_DIV1.Text = String.Empty;
            label_QS_CHDIV1.Text = String.Empty;
            label_QS_Phase1.Text = String.Empty;

            UInt32 SEED_value = (UInt32)((Registers_LMX1.GetRegisterValue(0x28) << 16) | Registers_LMX1.GetRegisterValue(0x29));
            numericUpDown_QS_Seed1.Value = SEED_value;

            UInt32 PLL_DEN = (UInt32)((Registers_LMX1.GetRegisterValue(0x26) << 16) | Registers_LMX1.GetRegisterValue(0x27));
            UInt16 reg0 = (UInt16)Registers_LMX1.GetRegisterValue(0x00);
            UInt16 IncludedDivide;
            if (((reg0 >> 14) & 0x0001) == 1) //VCO_PHASE_SYNC enable
            {
                IncludedDivide = 4;
            }
            else
            {
                IncludedDivide = 1;
            }

            UInt16 CHDIV;
            UInt16 CHDIV_reg = (UInt16)((Registers_LMX1.GetRegisterValue(0x4B) & 0x07C0) >> 6);

            UInt16[] chdiv_val = { 2, 4, 6, 8, 12, 16, 24, 32, 48, 64, 72, 96, 128, 192, 256, 384, 512, 768 };

            if(CHDIV_reg <= 18) 
            {
                CHDIV = chdiv_val[CHDIV_reg];
            }
            else 
            {
                label_QS_CHDIV1.Text = "----";
                return;
            }

            label_QS_PLL_DEN1.Text = PLL_DEN.ToString();
            label_QS_INC_DIV1.Text = IncludedDivide.ToString();
            label_QS_CHDIV1.Text = CHDIV.ToString();

            float phase = (float)360 * ((float)SEED_value / (float)PLL_DEN) * ((float)IncludedDivide / (float)CHDIV);

            label_QS_Phase1.Text = phase.ToString();
        }

        private void Update_label_QS_Phase2()
        {

            label_QS_PLL_DEN2.Text = String.Empty;
            label_QS_INC_DIV2.Text = String.Empty;
            label_QS_CHDIV2.Text = String.Empty;
            label_QS_Phase2.Text = String.Empty;

            UInt32 SEED_value = (UInt32)((Registers_LMX2.GetRegisterValue(0x28) << 16) | Registers_LMX2.GetRegisterValue(0x29));
            numericUpDown_QS_Seed2.Value = SEED_value;

            UInt32 PLL_DEN = (UInt32)((Registers_LMX2.GetRegisterValue(0x26) << 16) | Registers_LMX2.GetRegisterValue(0x27));
            UInt16 reg0 = (UInt16)Registers_LMX2.GetRegisterValue(0x00);
            UInt16 IncludedDivide;
            if (((reg0 >> 14) & 0x0001) == 1) //VCO_PHASE_SYNC enable
            {
                IncludedDivide = 4;
            }
            else
            {
                IncludedDivide = 1;
            }

            UInt16 CHDIV;
            UInt16 CHDIV_reg = (UInt16)((Registers_LMX2.GetRegisterValue(0x4B) & 0x07C0) >> 6);

            UInt16[] chdiv_val = { 2, 4, 6, 8, 12, 16, 24, 32, 48, 64, 72, 96, 128, 192, 256, 384, 512, 768 };

            if (CHDIV_reg <= 18)
            {
                CHDIV = chdiv_val[CHDIV_reg];
            }
            else
            {
                label_QS_CHDIV2.Text = "----";
                return;
            }

            label_QS_PLL_DEN2.Text = PLL_DEN.ToString();
            label_QS_INC_DIV2.Text = IncludedDivide.ToString();
            label_QS_CHDIV2.Text = CHDIV.ToString();

            float phase = (float)360 * ((float)SEED_value / (float)PLL_DEN) * ((float)IncludedDivide / (float)CHDIV);

            label_QS_Phase2.Text = phase.ToString();
        }

        private void button_QS_Sync_Click(object sender, EventArgs e)
        {
            gpio.PulseByIndex(2);
        }

        private void Update_QS_FcalEn_checkBox()
        {
            UInt16 reg1 = (UInt16)Registers_LMX1.GetRegisterValue(0x00);
            UInt16 reg2 = (UInt16)Registers_LMX2.GetRegisterValue(0x00);

            if(((reg1 >> 3) & 0x0001) == 0x0001) 
            {
                checkBox_QS_FcalEn1.Checked = true;
            }
            else 
            {
                checkBox_QS_FcalEn1.Checked = false;
            }

            if (((reg2 >> 3) & 0x0001) == 0x0001)
            {
                checkBox_QS_FcalEn2.Checked = true;
            }
            else
            {
                checkBox_QS_FcalEn2.Checked = false;
            }

        }

        private void checkBox_QS_FcalEn1_CheckedChanged(object sender, EventArgs e)
        {
            UInt16 mask = 0 | 1 << 3;

            if (checkBox_QS_FcalEn1.Checked) 
            {
                Registers_LMX1.SendMaskRegisterTblVal(0x00, 0xFFFF, mask);
            }
            else
            {
                Registers_LMX1.SendMaskRegisterTblVal(0x00, 0x0000, mask);
            }
        }

        private void checkBox_QS_FcalEn2_CheckedChanged(object sender, EventArgs e)
        {
            UInt16 mask = 0 | 1 << 3;

            if (checkBox_QS_FcalEn2.Checked)
            {
                Registers_LMX2.SendMaskRegisterTblVal(0x00, 0xFFFF, (int)mask);
            }
            else
            {
                Registers_LMX2.SendMaskRegisterTblVal(0x00, 0x0000, (int)mask);
            }
        }




        //-------------------------------------------------------------------------------------------------------------------
        //Analyz In Circ
        //-------------------------------------------------------------------------------------------------------------------


        private void numericUpDown_AnalyzNumOfSamples_ValueChanged(object sender, EventArgs e)
        {
            AnalyzInCirc.SetNumberOfSamples();
        }

        private void button_AnalyzSwStart_Click(object sender, EventArgs e)
        {
            AnalyzInCirc.SwStart();
        }

        private void checkBox_AnalyzTrg_CheckedChanged(object sender, EventArgs e)
        {
            AnalyzInCirc.TriggerSetting_CheckBox();
        }

        private void button_AnalyzClear_Click(object sender, EventArgs e)
        {
            AnalyzInCirc.Clear();
        }

        private void button_AnalyzEnable_Click(object sender, EventArgs e)
        {
            AnalyzInCirc.EnableDisable(true);
        }

        private void button_AnalyzDisable_Click(object sender, EventArgs e)
        {
            AnalyzInCirc.EnableDisable(false);
        }

        private void button_AnalyzClearList_Click(object sender, EventArgs e)
        {
            AnalyzInCirc.ClearList();
        }

        private void button_DataReadStart_Click(object sender, EventArgs e)
        {
            AnalyzInCirc.ReadData_Start();
        }

        private void button_DataReadStop_Click(object sender, EventArgs e)
        {
            AnalyzInCirc.ReadData_Stop();
        }
    }
}
