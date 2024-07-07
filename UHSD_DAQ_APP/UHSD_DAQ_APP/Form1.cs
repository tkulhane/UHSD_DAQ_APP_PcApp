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
using System.Windows;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //acq data
            AcqData.checkBox_SaveToRam = checkBox_SaveToRam;
            AcqData.checkBox_SaveToFile = checkBox_SaveToFile;
            AcqData.dataGridView_Events = dataGridView_events;
            AcqData.chart_data = chart_EventTime;
            AcqData.checkBox_EventsLastAutoSelect = checkBox_EventsLastAutoSelect;
            AcqData.checkBox_EventsLastAutoAnalyze = checkBox_EventsLastAutoAnalyze;
            AcqData.checkBox_EventsMaxCount = checkBox_EventsMaxCount;
            AcqData.numericUpDown_EventsMaxCount = numericUpDown_EventsMaxCount;
            AcqData.checkBox_EventsAutoLoad = checkBox_EventsAutoLoad;
            AcqData.pictureBox_EventAdcAnalyze = pictureBox_EventAdcAnalyze;
            AcqData.pictureBox_EventSinAnalyze = pictureBox_EventSinAnalyze;
            AcqData.textBox_DataFilePath = textBox_DataFilePath;

            AcqData.SetAcquisitionDataProcess();

            //setting form elements for communication class
            communication.comboBox_Ports = comboBox_Communication;
            communication.radioButton_UART = radioButton_UART;
            communication.radioButton_USB = radioButton_USB;
            communication.radioButton_PCIe = radioButton_PCIe;
            communication.button_Scan = button_ScanCommunication;
            communication.button_OpenClose = button_OpenCloseCommunication;

            communication.communicationControl.radioButton_ddNotSet = radioButton_ddNotSet;
            communication.communicationControl.radioButton_ddSameAsComm = radioButton_ddSameAsComm;
            communication.communicationControl.radioButton_ddSpecNum = radioButton_ddSpecNum;
            communication.communicationControl.textBox_ddSpecNum = textBox_ddSpecNum;
            communication.communicationControl.label_ddMyNum = label_ddMyNum;
            communication.ExecuteCommand = ExecuteCommand;
            communication.ExecuteData = ExecuteData;

            //Acquisition_Control
            AcqControl.SendCommand = communication.SendCommand;
            AcqControl.radioButton_AcqInfinite = radioButton_AcqInfinite;
            AcqControl.radioButton_AcqNumEvents = radioButton_AcqNumEvents;
            AcqControl.radioButton_AcqTime = radioButton_AcqTime;
            AcqControl.radioButton_AcqEventsPerTime = radioButton_AcqEventsPerTime;
            AcqControl.numericUpDown_NumOfEvents = numericUpDown_NumOfEvents;
            AcqControl.numericUpDown_Time_sec = numericUpDown_Time_sec;
            AcqControl.numericUpDown_Time_msec = numericUpDown_Time_msec;
            AcqControl.numericUpDown_Time_usec = numericUpDown_Time_usec;
            AcqControl.numericUpDown_NumOfSamples = numericUpDown_NumOfSamples;
            AcqControl.numericUpDown_AcqThreshold = numericUpDown_AcqThreshold;
            AcqControl.numericUpDown_AcqRepeats = numericUpDown_AcqRepeats;
            AcqControl.label_CounterIncomingEvents = label_CounterIncomingEvents;
            AcqControl.label_CounterProcessedEvents = label_CounterProcessedEvents;
            AcqControl.label_CounterInRunEvents = label_CounterInRunEvents;
            AcqControl.label_AcqState = label_AcqState;
            AcqControl.checkBox_TestGeneratorEnable = checkBox_TestGeneratorEnable;
            AcqControl.checkBox_DataTestMux = checkBox_DataTestMux;
            AcqControl.button_AcqStartStop = button_AcqStartStop;
            
            AcqControl.radioButton_TrgSelf = radioButton_TrgSelf;
            AcqControl.radioButton_TrgExtRising = radioButton_TrgExtRising;
            AcqControl.radioButton_TrgExtFalling = radioButton_TrgExtFalling;
            AcqControl.radioButton_TrgAdcFd = radioButton_TrgAdcFd;
            AcqControl.radioButton_TrgSw = radioButton_TrgSw;

            AcqControl.UpdateAcqState(false);

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
            MultiConfigSequence.dataGridView_ConfigFile = dataGridView_ConfigFile;
            MultiConfigSequence.MultipleConfigFiles = dataGridView_MultipleConfigFiles;
            MultiConfigSequence.List_ReigistersFile = sysSetting.List_ReigistersFile;
            MultiConfigSequence.rst = rst;
            MultiConfigSequence.gpio = gpio;
            MultiConfigSequence.listBox_MainLog = listBox_MainLog;
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

            //multi registers setting
            MultiRegistersSetting.SendFunction = communication.SendCommand;
            MultiRegistersSetting.sysSetting = sysSetting;
            MultiRegistersSetting.tabControl_RegistersSetting = tabControl_RegistersSetting;
            MultiRegistersSetting.textBox_RegAddress = textBox_RegAddress;
            MultiRegistersSetting.textBox_RegValue = textBox_RegValue;
            MultiRegistersSetting.label_RegRW = label_RegRW;
            MultiRegistersSetting.label_RegDescription = label_RegDescription;
            MultiRegistersSetting.groupBox_RegBits = groupBox_RegBits;
            MultiRegistersSetting.radioButton_RegAddrHEX = radioButton_RegAddrHEX;
            MultiRegistersSetting.radioButton_RegAddrDEC = radioButton_RegAddrDEC;
            MultiRegistersSetting.radioButton_RegValHEX = radioButton_RegValHEX;
            MultiRegistersSetting.radioButton_RegValDEC = radioButton_RegValDEC;

            //System Setting
            sysSetting.communication = communication;
            sysSetting.dataGridView_RegistersFiles = dataGridView_RegistersFiles;
            sysSetting.configurationFiles = MultiConfigSequence;

            //Ext Signals
            extSignals.SendCommand = communication.SendCommand;
            extSignals.DataGrid_Inputs = dataGridView_ExtSignalsInputs;
            extSignals.DataGrid_Outputs = dataGridView_ExtSignalsOutputs;
            extSignals.DataGridsLoad();

            //create registers
            MultiRegistersSetting.CreateRegister("ADC", RegistersSetting.eAddressValueSize.Address16_Value8, Communication.eCommandCode.CMD_CONST_GET_AdcRegisters, Communication.eCommandCode.CMD_CONST_SET_AdcRegisters,RegistersSetting.eExtFileType.Non);
            MultiRegistersSetting.CreateRegister("HMC", RegistersSetting.eAddressValueSize.Address16_Value8, Communication.eCommandCode.CMD_CONST_GET_HmcRegisters, Communication.eCommandCode.CMD_CONST_SET_HmcRegisters, RegistersSetting.eExtFileType.Python);
            MultiRegistersSetting.CreateRegister("LMX1", RegistersSetting.eAddressValueSize.Address8_Value16, Communication.eCommandCode.CMD_CONST_GET_Lmx1Registers, Communication.eCommandCode.CMD_CONST_SET_Lmx1Registers, RegistersSetting.eExtFileType.Txt);
            MultiRegistersSetting.CreateRegister("LMX2", RegistersSetting.eAddressValueSize.Address8_Value16, Communication.eCommandCode.CMD_CONST_GET_Lmx2Registers, Communication.eCommandCode.CMD_CONST_SET_Lmx2Registers, RegistersSetting.eExtFileType.Txt);
            MultiRegistersSetting.CreateRegister("FpgaTest", RegistersSetting.eAddressValueSize.Address8_Value8, Communication.eCommandCode.CMD_CONST_GET_TestRegisters, Communication.eCommandCode.CMD_CONST_SET_TestRegisters, RegistersSetting.eExtFileType.Non);
            MultiRegistersSetting.CreateRegister("Transcievers", RegistersSetting.eAddressValueSize.Address8_Value16, Communication.eCommandCode.CMD_CONST_GET_TransceiversControl, Communication.eCommandCode.CMD_CONST_SET_TransceiversControl, RegistersSetting.eExtFileType.Non);

            MultiRegistersSetting.CreateRegister("Clock_Switch", RegistersSetting.eAddressValueSize.Address8_Value16, Communication.eCommandCode.CMD_CONST_GET_Clock_Controler, Communication.eCommandCode.CMD_CONST_SET_Clock_Controler, RegistersSetting.eExtFileType.Non);
            MultiRegistersSetting.CreateRegister("EXT_Signals", RegistersSetting.eAddressValueSize.Address8_Value16, Communication.eCommandCode.CMD_CONST_GET_ExtSignals, Communication.eCommandCode.CMD_CONST_SET_ExtSignals, RegistersSetting.eExtFileType.Non);


            //Manage System
            systemManage.groupBox_ManageActions = groupBox_ManageActions;
            systemManage.SequenceStart = MultiConfigSequence.SequenceStart;
            systemManage.InitActions();


            //system setting load
            sysSetting.SettingLoad();


            AcqControl.ReadSettingAndValues();




        }


        private void Form1_Load(object sender, EventArgs e)
        {
            communication.communicationControl.CommunicationOpen();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sysSetting.SettingSave();
            communication.CloseAll();
        }





        Communication communication = new Communication();
        AcquisitionDataProcess AcqData = new AcquisitionDataProcess();
        Acquisition_Control AcqControl = new Acquisition_Control();
        SystemSetting sysSetting = new SystemSetting();
        GPIO_Control gpio = new GPIO_Control();
        Reset_Control rst = new Reset_Control();
        AnalyzInCirc AnalyzInCirc = new AnalyzInCirc();
        ExtSignals extSignals = new ExtSignals();
        SystemManage systemManage = new SystemManage();

        MultipleRegistersSetting MultiRegistersSetting = new MultipleRegistersSetting();


        MultipleConfigurationFileSequencer MultiConfigSequence = new MultipleConfigurationFileSequencer();


        BindingList<EventData> list_data = new BindingList<EventData>();
        BindingList<EventInfo> list_events = new BindingList<EventInfo>();

        //int EventNow = 0;

        EventInfo EventNow = new EventInfo(-1, -1);



        private void timerForm_Tick(object sender, EventArgs e)
        {

            if (communication.communicationControl.ActivityErrorDelayed == true)
                label_comState.Text = "nOK";
            else
                label_comState.Text = "OK";


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




        private void ExecuteCommand(byte[] data)
        {
            Communication.eCommandCode ID = (Communication.eCommandCode)(data[0] & 0x7F);
            //byte[] data = communication.CommandData;

            int int_ID = (int)ID;


            label_Test.Text = int_ID.ToString("X2") + " " + data[1].ToString("X2") + " " + data[2].ToString("X2") + " " + data[3].ToString("X2");

            Updade_label_xRead((byte)ID, data[0], data[1], data[2]);


            //search and update register
            RegistersSetting RS = MultiRegistersSetting.GetRegister(ID);
            if(RS != null)
            {
                RS.UpdateRegisters(data[1], data[2], data[3]);
            }
            

            switch (ID)
            {


                case Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters:
                    AcqControl.UpdateFromCommunication(data[1], data[2], data[3]);
                    break;

                case Communication.eCommandCode.CMD_CONST_GET_GPIO:
                    gpio.UpdateFromCommunication(data[1], data[2], data[3]);
                    break;

                case Communication.eCommandCode.CMD_CONST_GET_Reset_Controler:
                    rst.UpdateFromCommunication(data[1], data[2], data[3]);
                    break;

                case Communication.eCommandCode.CMD_CONST_GET_CommunicationControl:
                    communication.communicationControl.UpdateFromCommunication(data[1], data[2], data[3]);
                    break;

                case Communication.eCommandCode.CMD_CONST_GET_AnalyzInCirc:
                    AnalyzInCirc.UpdateFromCommunication(data[1], data[2], data[3]);
                    break;

                case Communication.eCommandCode.CMD_CONST_GET_ExtSignals:
                    extSignals.UpdateFromCommunication(data[1], data[2], data[3]);
                    break;


            }
        }

        private void ExecuteData(byte[] data)
        {
            //byte[] data = communication.ReceivedData;

            AcqData.ExecuteData(data);
        }

        //-------------------------------------------------------------------------------------------------------------------
        //TabControl
        //-------------------------------------------------------------------------------------------------------------------
        private void tabControl_MAIN_SelectedIndexChanged(object sender, EventArgs e)
        {

            int sel = tabControl_MAIN.SelectedIndex;


            if (sel == tabControl_MAIN.TabPages.IndexOf(tabManage)) 
            {
                Update_label_QS_Phase1();
                Update_label_QS_Phase2();
                Update_QS_FcalEn_checkBox();
            }
            else if (sel == tabControl_MAIN.TabPages.IndexOf(tabMeasurement_Setting))
            {
                AcqControl.ReadSettingAndValues();
            }
            else if (sel == tabControl_MAIN.TabPages.IndexOf(tabMeasurementData))
            {

            }
            else if (sel == tabControl_MAIN.TabPages.IndexOf(tabRegisters))
            {

            }
            else if (sel == tabControl_MAIN.TabPages.IndexOf(tabGpio))
            {

            }
            else if (sel == tabControl_MAIN.TabPages.IndexOf(tabReset))
            {

            }
            else if (sel == tabControl_MAIN.TabPages.IndexOf(tabConfiguration))
            {

            }
            else if (sel == tabControl_MAIN.TabPages.IndexOf(tabSetting))
            {

            }
            else if (sel == tabControl_MAIN.TabPages.IndexOf(tabAnalyzInCirc))
            {
                AnalyzInCirc.GetSetting();
                AnalyzInCirc.GetSetting_2();
            }
            else if (sel == tabControl_MAIN.TabPages.IndexOf(tabExtSignals))
            {
                extSignals.ReadSetting();
            }


            




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
            string description = tabControl_RegistersSetting.TabPages[selected].Text;

            MultiRegistersSetting.LoadFromFile(description);

        }

        private void button_RegReLoadFile_Click(object sender, EventArgs e)
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;
            string description = tabControl_RegistersSetting.TabPages[selected].Text;

            MultiRegistersSetting.ReLoadFile(description);
        }

        private void button_SaveToFile_Click(object sender, EventArgs e)
        {

            int selected = tabControl_RegistersSetting.SelectedIndex;
            string description = tabControl_RegistersSetting.TabPages[selected].Text;

            MultiRegistersSetting.SaveToFile(description);

        }

        private void button_SaveAs_Click(object sender, EventArgs e)
        {

            int selected = tabControl_RegistersSetting.SelectedIndex;
            string description = tabControl_RegistersSetting.TabPages[selected].Text;

            MultiRegistersSetting.SaveAs(description);

        }

        private void checkBox_RegBitSet_CheckedChanged(object sender, EventArgs e)
        {
            MultiRegistersSetting.RegBitSet_CheckedChanged(sender, e);
        }

        private void textBox_RegAddress_TextChanged(object sender, EventArgs e)
        {
            MultiRegistersSetting.RegAddress_TextChanged(sender, e);
        }

        private void textBox_RegValue_TextChanged(object sender, EventArgs e)
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;
            string description = tabControl_RegistersSetting.TabPages[selected].Text;

            MultiRegistersSetting.RegValue_TextChanged(description, sender, e);

        }

        private void button_RegAddrFind_Click(object sender, EventArgs e)
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;
            string description = tabControl_RegistersSetting.TabPages[selected].Text;

            MultiRegistersSetting.RegAddrFind_Click(description, sender, e);

        }
        
        private void radioButton_RegAddr_CheckedChanged(object sender, EventArgs e)
        {
            MultiRegistersSetting.Grids_SelectedChanged(null, null);
        }

        private void radioButton_RegVal_CheckedChanged(object sender, EventArgs e)
        {
            MultiRegistersSetting.Grids_SelectedChanged(null, null);
        }

        private void button_RegReadAll_Click(object sender, EventArgs e)
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;
            string description = tabControl_RegistersSetting.TabPages[selected].Text;

            MultiRegistersSetting.RegReadAll(description);

        }

        private void button_RegWriteAll_Click(object sender, EventArgs e)
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;
            string description = tabControl_RegistersSetting.TabPages[selected].Text;

            MultiRegistersSetting.RegWriteAll(description);

        }

        private void button_RegUpdateFromExtFile_Click(object sender, EventArgs e)
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;
            string description = tabControl_RegistersSetting.TabPages[selected].Text;

            MultiRegistersSetting.UpdateFromExtFile(description);

        }

        //-------------------------------------------------------------------------------------------------------------------
        //Measurement Data
        //-------------------------------------------------------------------------------------------------------------------
        private void chart_EventTime_Click(object sender, EventArgs e)
        {
            AcqData.chart_EventTime_Click(sender, e);
        }

        private void pictureBox_EventAnalyze_Click(object sender, EventArgs e)
        {

        }

        private void button_EventsListClear_Click(object sender, EventArgs e)
        {
            AcqData.ClearEventsList();
        }

        private void button_EventsSaveEvent_Click(object sender, EventArgs e)
        {
            AcqData.SaveEvent();
        }

        private void button_EventsAnalyzeAdc_Click(object sender, EventArgs e)
        {
            AcqData.AnalyzeAdcStart();
        }

        private void button_EventsAnalyzeSIN_Click(object sender, EventArgs e)
        {
            AcqData.AnalyzeSinStart();

        }

        private void button_AnotherForm_Click(object sender, EventArgs e)
        {

            Form_MeasurementData form = new Form_MeasurementData();
            form.ReturnParent = tableLayoutPanel_MeasurementData.Parent;
            form.TableControl = tableLayoutPanel_MeasurementData;
            form.button_AnotherForm = button_AnotherForm;
            button_AnotherForm.Enabled = false;

            tableLayoutPanel_MeasurementData.Parent = form;
            form.Show();

            //DialogResult fdr = form.DialogResult;


        }

        private void button_EventsLoadResult_Click(object sender, EventArgs e)
        {
            AcqData.LoadEventResults();
        }

        private void button_EventsClear_Click(object sender, EventArgs e)
        {

        }

        private void button_EventsDeleteResults_Click(object sender, EventArgs e)
        {
            AcqData.DeleteResultsFiles();
        }

        private void button_OpenDataFile_Click(object sender, EventArgs e)
        {
            AcqData.AssignDataFile();
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

        private void button_ddWrite_Click(object sender, EventArgs e)
        {
            communication.communicationControl.WriteSetting();
        }

        private void button_ddRead_Click(object sender, EventArgs e)
        {
            communication.communicationControl.ReadSetting();
        }

        private void radioButton_dataDestination_CheckedChanged(object sender, EventArgs e)
        {
            communication.communicationControl.radioButtonsSetting_CheckedChanged();
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

        private void checkBox_DataTestMux_CheckedChanged(object sender, EventArgs e)
        {
            AcqControl.DataTestMuxSel();
        }

        private void checkBox_TestGeneratorEnable_CheckedChanged(object sender, EventArgs e)
        {
            AcqControl.TestGeneratorEnable();
        }

        private void radioButton_TriggerSource_CheckedChanged(object sender, EventArgs e)
        {
            AcqControl.AcqTriggerSelect();
        }

        private void button_Acq_SwTrigger_Click(object sender, EventArgs e)
        {
            AcqControl.SwTrigger();
        }

        private void button_CountersClearAll_Click(object sender, EventArgs e)
        {
            AcqControl.ClearCounters();
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

        private void button_ConfigUp_Click(object sender, EventArgs e)
        {
            MultiConfigSequence.MoveConfigItemUp();
        }

        private void button_ConfigDown_Click(object sender, EventArgs e)
        {
            MultiConfigSequence.MoveConfigItemDown();
        }


        //-------------------------------------------------------------------------------------------------------------------
        //xSend
        //-------------------------------------------------------------------------------------------------------------------
        byte[] xSendedBytes = new byte[4];
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


            xSendedBytes[3] = b3;
            xSendedBytes[2] = b2;
            xSendedBytes[1] = b1;
            xSendedBytes[0] = b0;

            communication.SendCommand((Communication.eCommandCode)b3, b2, b1, b0);
        }

        private void Updade_label_xRead(byte ID, byte b2, byte b1, byte b0) 
        {

            if ((!checkBox_xListen3.Checked || xSendedBytes[3] == ID) && (!checkBox_xListen2.Checked || xSendedBytes[2] == b2)) 
            {
                label_xRead.Text = ID.ToString("X2") + " " + b2.ToString("X2") + " " + b1.ToString("X2") + " " + b0.ToString("X2");
            }

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
        //System Manage
        //-------------------------------------------------------------------------------------------------------------------

        private void numericUpDown_QS_Seed1_ValueChanged(object sender, EventArgs e)
        {
            UInt32 value = (UInt32)numericUpDown_QS_Seed1.Value;

            RegistersSetting RS = MultiRegistersSetting.GetRegister("LMX1");

            RS.UpdateRegistersNoRequest(0x29, (int)(value & 0x0000FFFF));
            RS.UpdateRegistersNoRequest(0x28, (int)((value >> 16) & 0x0000FFFF));

            Update_label_QS_Phase1();


            RS.SendRegister(0x29);
            RS.SendRegister(0x28);
        }

        private void numericUpDown_QS_Seed2_ValueChanged(object sender, EventArgs e)
        {
            UInt32 value = (UInt32)numericUpDown_QS_Seed2.Value;

            RegistersSetting RS = MultiRegistersSetting.GetRegister("LMX2");

            RS.UpdateRegistersNoRequest(0x29, (int)(value & 0x0000FFFF));
            RS.UpdateRegistersNoRequest(0x28, (int)((value >> 16) & 0x0000FFFF));

            Update_label_QS_Phase2();

            RS.SendRegister(0x29);
            RS.SendRegister(0x28);
        }

        private void Update_label_QS_Phase1() 
        {

            RegistersSetting RS = MultiRegistersSetting.GetRegister("LMX1");

            label_QS_PLL_DEN1.Text = String.Empty;
            label_QS_INC_DIV1.Text = String.Empty;
            label_QS_CHDIV1.Text = String.Empty;
            label_QS_Phase1.Text = String.Empty;

            UInt32 SEED_value = (UInt32)((RS.GetRegisterValue(0x28) << 16) | RS.GetRegisterValue(0x29));
            numericUpDown_QS_Seed1.Value = SEED_value;

            UInt32 PLL_DEN = (UInt32)((RS.GetRegisterValue(0x26) << 16) | RS.GetRegisterValue(0x27));
            UInt16 reg0 = (UInt16)RS.GetRegisterValue(0x00);
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
            UInt16 CHDIV_reg = (UInt16)((RS.GetRegisterValue(0x4B) & 0x07C0) >> 6);

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

            RegistersSetting RS = MultiRegistersSetting.GetRegister("LMX2");

            label_QS_PLL_DEN2.Text = String.Empty;
            label_QS_INC_DIV2.Text = String.Empty;
            label_QS_CHDIV2.Text = String.Empty;
            label_QS_Phase2.Text = String.Empty;

            UInt32 SEED_value = (UInt32)((RS.GetRegisterValue(0x28) << 16) | RS.GetRegisterValue(0x29));
            numericUpDown_QS_Seed2.Value = SEED_value;

            UInt32 PLL_DEN = (UInt32)((RS.GetRegisterValue(0x26) << 16) | RS.GetRegisterValue(0x27));
            UInt16 reg0 = (UInt16)RS.GetRegisterValue(0x00);
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
            UInt16 CHDIV_reg = (UInt16)((RS.GetRegisterValue(0x4B) & 0x07C0) >> 6);

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

            RegistersSetting RS1 = MultiRegistersSetting.GetRegister("LMX1");
            RegistersSetting RS2 = MultiRegistersSetting.GetRegister("LMX2");

            UInt16 reg1 = (UInt16)RS1.GetRegisterValue(0x00);
            UInt16 reg2 = (UInt16)RS2.GetRegisterValue(0x00);

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
            RegistersSetting RS = MultiRegistersSetting.GetRegister("LMX1");

            UInt16 mask = 0 | 1 << 3;

            if (checkBox_QS_FcalEn1.Checked) 
            {
                RS.SendMaskRegisterTblVal(0x00, 0xFFFF, mask);
            }
            else
            {
                RS.SendMaskRegisterTblVal(0x00, 0x0000, mask);
            }
        }

        private void checkBox_QS_FcalEn2_CheckedChanged(object sender, EventArgs e)
        {
            RegistersSetting RS = MultiRegistersSetting.GetRegister("LMX2");

            UInt16 mask = 0 | 1 << 3;

            if (checkBox_QS_FcalEn2.Checked)
            {
                RS.SendMaskRegisterTblVal(0x00, 0xFFFF, (int)mask);
            }
            else
            {
                RS.SendMaskRegisterTblVal(0x00, 0x0000, (int)mask);
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

        private void groupBox_AnalyzTriggersBox_Enter(object sender, EventArgs e)
        {
            AnalyzInCirc.GetSetting_2();
        }




        //-------------------------------------------------------------------------------------------------------------------
        //System Info
        //-------------------------------------------------------------------------------------------------------------------
        private void timerInfo_Tick(object sender, EventArgs e)
        {
            if (checkBox_InfoPeriodicRead.Checked) 
            {
                SystemInfo_States();
            }
            else 
            {
                _validCounter = 0;
            }
        }


        private void SystemInfo_AdcTemp(bool valid) 
        {
            RegistersSetting RS = MultiRegistersSetting.GetRegister("ADC");

            RS.ReadRegister(0x1609);
            RS.ReadRegister(0x160A);
            RS.ReadRegister(0x160D);
            RS.ReadRegister(0x160E);

            float tempMax = ((Int16)RS.GetRegisterValue(0x160A) << 8 | RS.GetRegisterValue(0x1609)) * (float)Math.Pow(2, -7);
            float tempMin = ((Int16)RS.GetRegisterValue(0x160E) << 8 | RS.GetRegisterValue(0x160D)) * (float)Math.Pow(2, -7);

            if (!valid)
            {
                label_InfoAdcMaxTemp.Text = String.Empty;
                label_InfoAdcMinTemp.Text = String.Empty;
                return;
            }

            label_InfoAdcMaxTemp.Text = tempMax.ToString();
            label_InfoAdcMinTemp.Text = tempMin.ToString();


        }

        private void SystemInfo_UpdateStateLabel(Label label, bool state, bool valid) 
        {
            string[] stateText = { "FALSE", "TRUE" };
            System.Drawing.Color[] stateColor = { Color.Red, Color.Green };

            if (!valid) 
            {
                label.Text = String.Empty;
                label.BackColor = Color.White;
                return;
            }

            if (state)
            {
                label.Text = stateText[1];
                label.BackColor = stateColor[1];
            }
            else
            {
                label.Text = stateText[0];
                label.BackColor = stateColor[0];
            }
        }

        private int SystemInfo_ReadGetVal(string regDesc, int addr) 
        {
            MultiRegistersSetting.GetRegister(regDesc).ReadRegister(addr);
            return MultiRegistersSetting.GetRegister(regDesc).GetRegisterValue(addr);
        }


        int _validCounter = 0;
        private void SystemInfo_States() 
        {
            bool allValidMask = true;
            
            MultiRegistersSetting.GetRegister("LMX1").SendRegister(0x18, 0x71A);
            MultiRegistersSetting.GetRegister("LMX2").SendRegister(0x18, 0x71A);

            bool Online_ADC = false;
            bool Online_HMC = false;
            bool Online_LMX1 = false;
            bool Online_LMX2 = false;

            bool AdcJtxPllLocked = false;
            bool InfoAdcClockDetect = false;
            bool InfoLmx1Locked = false;
            bool InfoLmx2Locked = false;
            bool HmcPllsLocked = false;
            bool LogicRefPllsLocked = false;
            bool XcvrLanesLocked = false;
            bool Syncib = false;

            if (SystemInfo_ReadGetVal("ADC", 0x4) == 0xE5) Online_ADC = true;
            if (SystemInfo_ReadGetVal("HMC", 0x79) == 0x52) Online_HMC = true;
            if (SystemInfo_ReadGetVal("LMX1", 0x18) == 0x71A) Online_LMX1 = true;
            if (SystemInfo_ReadGetVal("LMX2", 0x18) == 0x71A) Online_LMX2 = true;

            if ((SystemInfo_ReadGetVal("ADC", 0x501) & 0x80) >= 1) AdcJtxPllLocked = true;
            if ((SystemInfo_ReadGetVal("ADC", 0x151D) & 0x01) >= 1) InfoAdcClockDetect = true;

            if (((SystemInfo_ReadGetVal("LMX1", 0x6E) >> 9 ) & 0x3) == 2) InfoLmx1Locked = true;
            if (((SystemInfo_ReadGetVal("LMX2", 0x6E) >> 9) & 0x3) == 2) InfoLmx2Locked = true;
            if (((SystemInfo_ReadGetVal("HMC", 0x7D) >> 3) & 0x1) == 1) HmcPllsLocked = true;
            if (SystemInfo_ReadGetVal("Clock_Switch", 0x5) == 3) LogicRefPllsLocked = true;


            if (_validCounter < 1) 
            {
                _validCounter++;
                allValidMask = false;
            }

            SystemInfo_UpdateStateLabel(label_InfoOnlineAdc, Online_ADC, allValidMask);
            SystemInfo_UpdateStateLabel(label_InfoOnlineHmc, Online_HMC, allValidMask);
            SystemInfo_UpdateStateLabel(label_InfoOnlineLMX1, Online_LMX1, allValidMask);
            SystemInfo_UpdateStateLabel(label_InfoOnlineLMX2, Online_LMX2, allValidMask);

            SystemInfo_UpdateStateLabel(label_InfoAdcJtxPllLocked, AdcJtxPllLocked, Online_ADC & allValidMask);
            SystemInfo_UpdateStateLabel(label_InfoAdcClockDetect, InfoAdcClockDetect, Online_ADC & allValidMask);
            SystemInfo_UpdateStateLabel(label_InfoLmx1Locked, InfoLmx1Locked, Online_LMX1 & allValidMask);
            SystemInfo_UpdateStateLabel(label_InfoLmx2Locked, InfoLmx2Locked, Online_LMX1 & allValidMask);
            SystemInfo_UpdateStateLabel(label_InfoHmcPllsLocked, HmcPllsLocked, Online_HMC & allValidMask);
            SystemInfo_UpdateStateLabel(label_InfoLogicRefPllsLocked, LogicRefPllsLocked, true & allValidMask);
            SystemInfo_UpdateStateLabel(label_InfoXcvrLanesLocked, XcvrLanesLocked, true & allValidMask);
            SystemInfo_UpdateStateLabel(label_InfoSyncib, Syncib, true & allValidMask);

            SystemInfo_AdcTemp(Online_ADC & allValidMask);



        }



        private void button_ExtSignalsWriteSetting_Click(object sender, EventArgs e)
        {
            //extSignals.UpdateInputComboBox(2, 5);
            //extSignals.UpdateOutputComboBox(4, 10);
        }

        private void button_ExtSignalsReadSetting_Click(object sender, EventArgs e)
        {
            extSignals.ReadSetting();
        }


    }
}
