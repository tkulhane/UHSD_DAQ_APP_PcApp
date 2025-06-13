
namespace Digitizer_ver1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ConnectState = new System.Windows.Forms.Label();
            this.label_AcqState = new System.Windows.Forms.Label();
            this.checkBox_xListen2 = new System.Windows.Forms.CheckBox();
            this.checkBox_xListen3 = new System.Windows.Forms.CheckBox();
            this.label_dataErrors = new System.Windows.Forms.Label();
            this.textBox_xSendByte3 = new System.Windows.Forms.TextBox();
            this.label_xRead = new System.Windows.Forms.Label();
            this.textBox_xSendByte2 = new System.Windows.Forms.TextBox();
            this.button_xSend = new System.Windows.Forms.Button();
            this.textBox_xSendByte1 = new System.Windows.Forms.TextBox();
            this.textBox_xSendByte0 = new System.Windows.Forms.TextBox();
            this.timerRequest = new System.Windows.Forms.Timer(this.components);
            this.tabRegisters = new System.Windows.Forms.TabPage();
            this.tabControl_RegistersSetting = new System.Windows.Forms.TabControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_RegReLoadFile = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_RegAddrHEX = new System.Windows.Forms.RadioButton();
            this.radioButton_RegAddrDEC = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_RegValHEX = new System.Windows.Forms.RadioButton();
            this.radioButton_RegValDEC = new System.Windows.Forms.RadioButton();
            this.button_RegAddrFind = new System.Windows.Forms.Button();
            this.textBox_RegAddress = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_RegValue = new System.Windows.Forms.TextBox();
            this.groupBox_RegBits = new System.Windows.Forms.GroupBox();
            this.checkBox_RegBitSet0 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_RegDescription = new System.Windows.Forms.Label();
            this.label_RegRW = new System.Windows.Forms.Label();
            this.button_RegUpdateFromExtFile = new System.Windows.Forms.Button();
            this.button_RegWriteAll = new System.Windows.Forms.Button();
            this.button_RegReadAll = new System.Windows.Forms.Button();
            this.button_RegSaveToFile = new System.Windows.Forms.Button();
            this.button_RegSaveAs = new System.Windows.Forms.Button();
            this.button_RegLoadFromFile = new System.Windows.Forms.Button();
            this.tabControl_MAIN = new System.Windows.Forms.TabControl();
            this.tabManage = new System.Windows.Forms.TabPage();
            this.groupBox_ManageActions = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.checkBox_InfoPeriodicRead = new System.Windows.Forms.CheckBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label_InfoLmx2Locked = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label_InfoLmx1Locked = new System.Windows.Forms.Label();
            this.label_123 = new System.Windows.Forms.Label();
            this.label_InfoSyncib = new System.Windows.Forms.Label();
            this.label_412 = new System.Windows.Forms.Label();
            this.label_InfoXcvrLanesLocked = new System.Windows.Forms.Label();
            this.label_788 = new System.Windows.Forms.Label();
            this.label_InfoLogicRefPllsLocked = new System.Windows.Forms.Label();
            this.label454 = new System.Windows.Forms.Label();
            this.label_InfoHmcPllsLocked = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label_InfoAdcClockDetect = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label_InfoAdcJtxPllLocked = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label_InfoOnlineLMX2 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label_InfoOnlineLMX1 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label_InfoOnlineHmc = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label_InfoOnlineAdc = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label_InfoAdcMinTemp = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label_InfoAdcMaxTemp = new System.Windows.Forms.Label();
            this.listBox_MainLog = new System.Windows.Forms.ListBox();
            this.groupBox_LMXSync = new System.Windows.Forms.GroupBox();
            this.checkBox_QS_FcalEn2 = new System.Windows.Forms.CheckBox();
            this.checkBox_QS_FcalEn1 = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label_QS_CHDIV2 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label_QS_INC_DIV2 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label_QS_PLL_DEN2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label_QS_CHDIV1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label_QS_INC_DIV1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label_QS_PLL_DEN1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label_QS_Phase2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label_QS_Phase1 = new System.Windows.Forms.Label();
            this.button_QS_Sync = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown_QS_Seed2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown_QS_Seed1 = new System.Windows.Forms.NumericUpDown();
            this.tabMeasurement_Setting = new System.Windows.Forms.TabPage();
            this.button_Acq_SwTrigger = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.radioButton_TrgExtFallingOver = new System.Windows.Forms.RadioButton();
            this.radioButton_TrgExtRisingOver = new System.Windows.Forms.RadioButton();
            this.radioButton_TrgAdcFd = new System.Windows.Forms.RadioButton();
            this.radioButton_TrgExtFallingNorm = new System.Windows.Forms.RadioButton();
            this.radioButton_TrgSw = new System.Windows.Forms.RadioButton();
            this.radioButton_TrgExtRisingNorm = new System.Windows.Forms.RadioButton();
            this.radioButton_TrgSelf = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox_DataTestMux = new System.Windows.Forms.CheckBox();
            this.checkBox_TestGeneratorEnable = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_OpenDataFile = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_DataFilePath = new System.Windows.Forms.TextBox();
            this.checkBox_SaveToFile = new System.Windows.Forms.CheckBox();
            this.checkBox_SaveToRam = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.button_CountersClearAll = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label_CounterInRunEvents = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_CounterProcessedEvents = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_CounterIncomingEvents = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label43 = new System.Windows.Forms.Label();
            this.numericUpDown_Time_usec = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.numericUpDown_Time_msec = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.button_AcqStartStop = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown_AcqThreshold = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown_NumOfSamples = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AcqRepeats = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Repeats = new System.Windows.Forms.CheckBox();
            this.radioButton_AcqEventsPerTime = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_NumOfEvents = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Time_sec = new System.Windows.Forms.NumericUpDown();
            this.radioButton_AcqTime = new System.Windows.Forms.RadioButton();
            this.radioButton_AcqNumEvents = new System.Windows.Forms.RadioButton();
            this.radioButton_AcqInfinite = new System.Windows.Forms.RadioButton();
            this.tabMeasurementData = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_MeasurementData = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button_AnotherForm = new System.Windows.Forms.Button();
            this.numericUpDown_EventsMaxCount = new System.Windows.Forms.NumericUpDown();
            this.checkBox_EventsMaxCount = new System.Windows.Forms.CheckBox();
            this.dataGridView_events = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button_EventsDeleteResults = new System.Windows.Forms.Button();
            this.checkBox_EventsAutoLoad = new System.Windows.Forms.CheckBox();
            this.button_EventsClear = new System.Windows.Forms.Button();
            this.checkBox_EventsLastAutoAnalyze = new System.Windows.Forms.CheckBox();
            this.button_EventsListClear = new System.Windows.Forms.Button();
            this.checkBox_EventsLastAutoSelect = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button_EventsAnalyzeSIN = new System.Windows.Forms.Button();
            this.button_EventsLoadResult = new System.Windows.Forms.Button();
            this.button_EventsAnalyzeAdc = new System.Windows.Forms.Button();
            this.button_EventsSaveEvent = new System.Windows.Forms.Button();
            this.tabControl_Events = new System.Windows.Forms.TabControl();
            this.tabPage_TimeChart = new System.Windows.Forms.TabPage();
            this.chart_EventTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_AnalyzeAdcPicture = new System.Windows.Forms.TabPage();
            this.pictureBox_EventAdcAnalyze = new System.Windows.Forms.PictureBox();
            this.tabPage_AnalyzeSinPicture = new System.Windows.Forms.TabPage();
            this.pictureBox_EventSinAnalyze = new System.Windows.Forms.PictureBox();
            this.tabGpio = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_GpioOutputs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_GpioInputs = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_ClearRisingFalling = new System.Windows.Forms.Button();
            this.tabReset = new System.Windows.Forms.TabPage();
            this.dataGridView_Resets = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_ResetClearAll = new System.Windows.Forms.Button();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_MultipleConfigFiles = new System.Windows.Forms.DataGridView();
            this.dataGridView_ConfigFile = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_ConfigDown = new System.Windows.Forms.Button();
            this.button_ConfigUp = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button_ConfigFileReloadFile = new System.Windows.Forms.Button();
            this.button_RemoveConfig = new System.Windows.Forms.Button();
            this.button_AddNewConfig = new System.Windows.Forms.Button();
            this.button_ConfigFileLoadFromFile = new System.Windows.Forms.Button();
            this.button_ConfigFileSaveToFile = new System.Windows.Forms.Button();
            this.button_ConfigFileSaveAs = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button_ConfigRun = new System.Windows.Forms.Button();
            this.button_ConfigStop = new System.Windows.Forms.Button();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.checkBox_logComm = new System.Windows.Forms.CheckBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label_StatusTaskOfReadExecute_Data = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label_StatusTaskOfReadExecute_CMD = new System.Windows.Forms.Label();
            this.label_errorCount = new System.Windows.Forms.Label();
            this.label_StatusDataReadTask = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label_comState = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.radioButton_ddSpecNum = new System.Windows.Forms.RadioButton();
            this.label_ddSetNum = new System.Windows.Forms.Label();
            this.radioButton_ddSameAsComm = new System.Windows.Forms.RadioButton();
            this.radioButton_ddNotSet = new System.Windows.Forms.RadioButton();
            this.label32 = new System.Windows.Forms.Label();
            this.label_ddMyNum = new System.Windows.Forms.Label();
            this.button_ddRead = new System.Windows.Forms.Button();
            this.textBox_ddSpecNum = new System.Windows.Forms.TextBox();
            this.button_ddWrite = new System.Windows.Forms.Button();
            this.label_InQ = new System.Windows.Forms.Label();
            this.checkBox_cmdQuestions = new System.Windows.Forms.CheckBox();
            this.label_RecvBytes = new System.Windows.Forms.Label();
            this.label_Test = new System.Windows.Forms.Label();
            this.button_Test = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dataGridView_RegistersFiles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_OpenCloseCommunication = new System.Windows.Forms.Button();
            this.button_ScanCommunication = new System.Windows.Forms.Button();
            this.comboBox_Communication = new System.Windows.Forms.ComboBox();
            this.radioButton_PCIe = new System.Windows.Forms.RadioButton();
            this.radioButton_USB = new System.Windows.Forms.RadioButton();
            this.radioButton_UART = new System.Windows.Forms.RadioButton();
            this.tabAnalyzInCirc = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_AnalyzData = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.comboBox_AnalyzInputsSel = new System.Windows.Forms.ComboBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label_DataReadState = new System.Windows.Forms.Label();
            this.button_AnalyzClearList = new System.Windows.Forms.Button();
            this.button_DataReadStop = new System.Windows.Forms.Button();
            this.button_DataReadStart = new System.Windows.Forms.Button();
            this.label_AnalyzEmpty = new System.Windows.Forms.Label();
            this.groupBox_AnalyzTriggersBox = new System.Windows.Forms.GroupBox();
            this.checkBox_AnalyzTrg_F_8 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_R_8 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_F_7 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_R_7 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_F_6 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_R_6 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_F_5 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_R_5 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_F_4 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_R_4 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_F_3 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_R_3 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_F_2 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_R_2 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_F_1 = new System.Windows.Forms.CheckBox();
            this.checkBox_AnalyzTrg_R_1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.numericUpDown_AnalyzTrgDelay = new System.Windows.Forms.NumericUpDown();
            this.label_AnalyzEnable = new System.Windows.Forms.Label();
            this.button_AnalyzDisable = new System.Windows.Forms.Button();
            this.button_AnalyzEnable = new System.Windows.Forms.Button();
            this.button_AnalyzClear = new System.Windows.Forms.Button();
            this.button_AnalyzSwStart = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.numericUpDown_AnalyzNumOfSamples = new System.Windows.Forms.NumericUpDown();
            this.tabExtSignals = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_ExtSignalsOutputs = new System.Windows.Forms.DataGridView();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.dataGridView_ExtSignalsInputs = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button_ExtSignalsWriteSetting = new System.Windows.Forms.Button();
            this.button_ExtSignalsReadSetting = new System.Windows.Forms.Button();
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tabRegisters.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox_RegBits.SuspendLayout();
            this.tabControl_MAIN.SuspendLayout();
            this.tabManage.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox_LMXSync.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_QS_Seed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_QS_Seed1)).BeginInit();
            this.tabMeasurement_Setting.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time_usec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time_msec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcqThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcqRepeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time_sec)).BeginInit();
            this.tabMeasurementData.SuspendLayout();
            this.tableLayoutPanel_MeasurementData.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EventsMaxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_events)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabControl_Events.SuspendLayout();
            this.tabPage_TimeChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_EventTime)).BeginInit();
            this.tabPage_AnalyzeAdcPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EventAdcAnalyze)).BeginInit();
            this.tabPage_AnalyzeSinPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EventSinAnalyze)).BeginInit();
            this.tabGpio.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GpioOutputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GpioInputs)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resets)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabConfiguration.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MultipleConfigFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConfigFile)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RegistersFiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabAnalyzInCirc.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AnalyzData)).BeginInit();
            this.panel7.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox_AnalyzTriggersBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AnalyzTrgDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AnalyzNumOfSamples)).BeginInit();
            this.tabExtSignals.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExtSignalsOutputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExtSignalsInputs)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_ConnectState);
            this.panel1.Controls.Add(this.label_AcqState);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 35);
            this.panel1.TabIndex = 0;
            // 
            // label_ConnectState
            // 
            this.label_ConnectState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ConnectState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ConnectState.Location = new System.Drawing.Point(1037, 7);
            this.label_ConnectState.Name = "label_ConnectState";
            this.label_ConnectState.Size = new System.Drawing.Size(94, 20);
            this.label_ConnectState.TabIndex = 13;
            this.label_ConnectState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_AcqState
            // 
            this.label_AcqState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_AcqState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_AcqState.Location = new System.Drawing.Point(22, 5);
            this.label_AcqState.Name = "label_AcqState";
            this.label_AcqState.Size = new System.Drawing.Size(123, 24);
            this.label_AcqState.TabIndex = 9;
            this.label_AcqState.Text = "........";
            this.label_AcqState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_xListen2
            // 
            this.checkBox_xListen2.AutoSize = true;
            this.checkBox_xListen2.Location = new System.Drawing.Point(216, 74);
            this.checkBox_xListen2.Name = "checkBox_xListen2";
            this.checkBox_xListen2.Size = new System.Drawing.Size(38, 17);
            this.checkBox_xListen2.TabIndex = 32;
            this.checkBox_xListen2.Text = "L2";
            this.checkBox_xListen2.UseVisualStyleBackColor = true;
            // 
            // checkBox_xListen3
            // 
            this.checkBox_xListen3.AutoSize = true;
            this.checkBox_xListen3.Location = new System.Drawing.Point(169, 74);
            this.checkBox_xListen3.Name = "checkBox_xListen3";
            this.checkBox_xListen3.Size = new System.Drawing.Size(38, 17);
            this.checkBox_xListen3.TabIndex = 31;
            this.checkBox_xListen3.Text = "L3";
            this.checkBox_xListen3.UseVisualStyleBackColor = true;
            // 
            // label_dataErrors
            // 
            this.label_dataErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_dataErrors.Location = new System.Drawing.Point(116, 186);
            this.label_dataErrors.Name = "label_dataErrors";
            this.label_dataErrors.Size = new System.Drawing.Size(106, 21);
            this.label_dataErrors.TabIndex = 28;
            this.label_dataErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_xSendByte3
            // 
            this.textBox_xSendByte3.Location = new System.Drawing.Point(28, 33);
            this.textBox_xSendByte3.Name = "textBox_xSendByte3";
            this.textBox_xSendByte3.Size = new System.Drawing.Size(44, 20);
            this.textBox_xSendByte3.TabIndex = 19;
            // 
            // label_xRead
            // 
            this.label_xRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_xRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_xRead.Location = new System.Drawing.Point(28, 71);
            this.label_xRead.Name = "label_xRead";
            this.label_xRead.Size = new System.Drawing.Size(123, 20);
            this.label_xRead.TabIndex = 24;
            this.label_xRead.Text = "........";
            this.label_xRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_xRead.Click += new System.EventHandler(this.label_xRead_Click);
            // 
            // textBox_xSendByte2
            // 
            this.textBox_xSendByte2.Location = new System.Drawing.Point(78, 33);
            this.textBox_xSendByte2.Name = "textBox_xSendByte2";
            this.textBox_xSendByte2.Size = new System.Drawing.Size(44, 20);
            this.textBox_xSendByte2.TabIndex = 20;
            // 
            // button_xSend
            // 
            this.button_xSend.Location = new System.Drawing.Point(228, 33);
            this.button_xSend.Name = "button_xSend";
            this.button_xSend.Size = new System.Drawing.Size(75, 21);
            this.button_xSend.TabIndex = 23;
            this.button_xSend.Text = "Send";
            this.button_xSend.UseVisualStyleBackColor = true;
            this.button_xSend.Click += new System.EventHandler(this.button_xSend_Click);
            // 
            // textBox_xSendByte1
            // 
            this.textBox_xSendByte1.Location = new System.Drawing.Point(128, 33);
            this.textBox_xSendByte1.Name = "textBox_xSendByte1";
            this.textBox_xSendByte1.Size = new System.Drawing.Size(44, 20);
            this.textBox_xSendByte1.TabIndex = 21;
            // 
            // textBox_xSendByte0
            // 
            this.textBox_xSendByte0.Location = new System.Drawing.Point(178, 33);
            this.textBox_xSendByte0.Name = "textBox_xSendByte0";
            this.textBox_xSendByte0.Size = new System.Drawing.Size(44, 20);
            this.textBox_xSendByte0.TabIndex = 22;
            // 
            // timerRequest
            // 
            this.timerRequest.Enabled = true;
            this.timerRequest.Interval = 500;
            this.timerRequest.Tick += new System.EventHandler(this.timerRequest_Tick);
            // 
            // tabRegisters
            // 
            this.tabRegisters.Controls.Add(this.tabControl_RegistersSetting);
            this.tabRegisters.Controls.Add(this.panel3);
            this.tabRegisters.Location = new System.Drawing.Point(4, 22);
            this.tabRegisters.Margin = new System.Windows.Forms.Padding(2);
            this.tabRegisters.Name = "tabRegisters";
            this.tabRegisters.Padding = new System.Windows.Forms.Padding(2);
            this.tabRegisters.Size = new System.Drawing.Size(1176, 550);
            this.tabRegisters.TabIndex = 4;
            this.tabRegisters.Text = "Registers";
            this.tabRegisters.UseVisualStyleBackColor = true;
            // 
            // tabControl_RegistersSetting
            // 
            this.tabControl_RegistersSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_RegistersSetting.Location = new System.Drawing.Point(287, 2);
            this.tabControl_RegistersSetting.Name = "tabControl_RegistersSetting";
            this.tabControl_RegistersSetting.SelectedIndex = 0;
            this.tabControl_RegistersSetting.Size = new System.Drawing.Size(887, 546);
            this.tabControl_RegistersSetting.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.button_RegReLoadFile);
            this.panel3.Controls.Add(this.groupBox10);
            this.panel3.Controls.Add(this.button_RegUpdateFromExtFile);
            this.panel3.Controls.Add(this.button_RegWriteAll);
            this.panel3.Controls.Add(this.button_RegReadAll);
            this.panel3.Controls.Add(this.button_RegSaveToFile);
            this.panel3.Controls.Add(this.button_RegSaveAs);
            this.panel3.Controls.Add(this.button_RegLoadFromFile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 546);
            this.panel3.TabIndex = 1;
            // 
            // button_RegReLoadFile
            // 
            this.button_RegReLoadFile.Location = new System.Drawing.Point(13, 57);
            this.button_RegReLoadFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegReLoadFile.Name = "button_RegReLoadFile";
            this.button_RegReLoadFile.Size = new System.Drawing.Size(74, 37);
            this.button_RegReLoadFile.TabIndex = 10;
            this.button_RegReLoadFile.Text = "ReLoad File";
            this.button_RegReLoadFile.UseVisualStyleBackColor = true;
            this.button_RegReLoadFile.Click += new System.EventHandler(this.button_RegReLoadFile_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.flowLayoutPanel2);
            this.groupBox10.Controls.Add(this.flowLayoutPanel1);
            this.groupBox10.Controls.Add(this.button_RegAddrFind);
            this.groupBox10.Controls.Add(this.textBox_RegAddress);
            this.groupBox10.Controls.Add(this.button2);
            this.groupBox10.Controls.Add(this.button1);
            this.groupBox10.Controls.Add(this.textBox_RegValue);
            this.groupBox10.Controls.Add(this.groupBox_RegBits);
            this.groupBox10.Controls.Add(this.label10);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.label5);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.label_RegDescription);
            this.groupBox10.Controls.Add(this.label_RegRW);
            this.groupBox10.Location = new System.Drawing.Point(9, 229);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(245, 306);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Selected Line";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.radioButton_RegAddrHEX);
            this.flowLayoutPanel2.Controls.Add(this.radioButton_RegAddrDEC);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(142, 67);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(98, 22);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // radioButton_RegAddrHEX
            // 
            this.radioButton_RegAddrHEX.AutoSize = true;
            this.radioButton_RegAddrHEX.Checked = true;
            this.radioButton_RegAddrHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_RegAddrHEX.Location = new System.Drawing.Point(3, 3);
            this.radioButton_RegAddrHEX.Name = "radioButton_RegAddrHEX";
            this.radioButton_RegAddrHEX.Size = new System.Drawing.Size(42, 16);
            this.radioButton_RegAddrHEX.TabIndex = 14;
            this.radioButton_RegAddrHEX.TabStop = true;
            this.radioButton_RegAddrHEX.Text = "HEX";
            this.radioButton_RegAddrHEX.UseVisualStyleBackColor = true;
            this.radioButton_RegAddrHEX.CheckedChanged += new System.EventHandler(this.radioButton_RegAddr_CheckedChanged);
            // 
            // radioButton_RegAddrDEC
            // 
            this.radioButton_RegAddrDEC.AutoSize = true;
            this.radioButton_RegAddrDEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_RegAddrDEC.Location = new System.Drawing.Point(51, 3);
            this.radioButton_RegAddrDEC.Name = "radioButton_RegAddrDEC";
            this.radioButton_RegAddrDEC.Size = new System.Drawing.Size(43, 16);
            this.radioButton_RegAddrDEC.TabIndex = 15;
            this.radioButton_RegAddrDEC.Text = "DEC";
            this.radioButton_RegAddrDEC.UseVisualStyleBackColor = true;
            this.radioButton_RegAddrDEC.CheckedChanged += new System.EventHandler(this.radioButton_RegAddr_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButton_RegValHEX);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_RegValDEC);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(142, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(98, 22);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // radioButton_RegValHEX
            // 
            this.radioButton_RegValHEX.AutoSize = true;
            this.radioButton_RegValHEX.Checked = true;
            this.radioButton_RegValHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_RegValHEX.Location = new System.Drawing.Point(3, 3);
            this.radioButton_RegValHEX.Name = "radioButton_RegValHEX";
            this.radioButton_RegValHEX.Size = new System.Drawing.Size(42, 16);
            this.radioButton_RegValHEX.TabIndex = 14;
            this.radioButton_RegValHEX.TabStop = true;
            this.radioButton_RegValHEX.Text = "HEX";
            this.radioButton_RegValHEX.UseVisualStyleBackColor = true;
            this.radioButton_RegValHEX.CheckedChanged += new System.EventHandler(this.radioButton_RegVal_CheckedChanged);
            // 
            // radioButton_RegValDEC
            // 
            this.radioButton_RegValDEC.AutoSize = true;
            this.radioButton_RegValDEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_RegValDEC.Location = new System.Drawing.Point(51, 3);
            this.radioButton_RegValDEC.Name = "radioButton_RegValDEC";
            this.radioButton_RegValDEC.Size = new System.Drawing.Size(43, 16);
            this.radioButton_RegValDEC.TabIndex = 15;
            this.radioButton_RegValDEC.Text = "DEC";
            this.radioButton_RegValDEC.UseVisualStyleBackColor = true;
            this.radioButton_RegValDEC.CheckedChanged += new System.EventHandler(this.radioButton_RegVal_CheckedChanged);
            // 
            // button_RegAddrFind
            // 
            this.button_RegAddrFind.Location = new System.Drawing.Point(12, 145);
            this.button_RegAddrFind.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegAddrFind.Name = "button_RegAddrFind";
            this.button_RegAddrFind.Size = new System.Drawing.Size(69, 24);
            this.button_RegAddrFind.TabIndex = 13;
            this.button_RegAddrFind.Text = "Find Addr.";
            this.button_RegAddrFind.UseVisualStyleBackColor = true;
            this.button_RegAddrFind.Click += new System.EventHandler(this.button_RegAddrFind_Click);
            // 
            // textBox_RegAddress
            // 
            this.textBox_RegAddress.Location = new System.Drawing.Point(69, 67);
            this.textBox_RegAddress.Name = "textBox_RegAddress";
            this.textBox_RegAddress.Size = new System.Drawing.Size(67, 20);
            this.textBox_RegAddress.TabIndex = 12;
            this.textBox_RegAddress.TextChanged += new System.EventHandler(this.textBox_RegAddress_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 214);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "Write";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_RegValue
            // 
            this.textBox_RegValue.Location = new System.Drawing.Point(69, 90);
            this.textBox_RegValue.Name = "textBox_RegValue";
            this.textBox_RegValue.Size = new System.Drawing.Size(67, 20);
            this.textBox_RegValue.TabIndex = 8;
            this.textBox_RegValue.TextChanged += new System.EventHandler(this.textBox_RegValue_TextChanged);
            // 
            // groupBox_RegBits
            // 
            this.groupBox_RegBits.Controls.Add(this.checkBox_RegBitSet0);
            this.groupBox_RegBits.Controls.Add(this.checkBox10);
            this.groupBox_RegBits.Controls.Add(this.checkBox11);
            this.groupBox_RegBits.Controls.Add(this.checkBox12);
            this.groupBox_RegBits.Controls.Add(this.checkBox13);
            this.groupBox_RegBits.Controls.Add(this.checkBox14);
            this.groupBox_RegBits.Controls.Add(this.checkBox15);
            this.groupBox_RegBits.Controls.Add(this.checkBox16);
            this.groupBox_RegBits.Controls.Add(this.checkBox1);
            this.groupBox_RegBits.Controls.Add(this.checkBox2);
            this.groupBox_RegBits.Controls.Add(this.checkBox3);
            this.groupBox_RegBits.Controls.Add(this.checkBox4);
            this.groupBox_RegBits.Controls.Add(this.checkBox5);
            this.groupBox_RegBits.Controls.Add(this.checkBox6);
            this.groupBox_RegBits.Controls.Add(this.checkBox7);
            this.groupBox_RegBits.Controls.Add(this.checkBox8);
            this.groupBox_RegBits.Location = new System.Drawing.Point(95, 124);
            this.groupBox_RegBits.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_RegBits.Name = "groupBox_RegBits";
            this.groupBox_RegBits.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_RegBits.Size = new System.Drawing.Size(136, 175);
            this.groupBox_RegBits.TabIndex = 3;
            this.groupBox_RegBits.TabStop = false;
            this.groupBox_RegBits.Text = "Bit Setting";
            // 
            // checkBox_RegBitSet0
            // 
            this.checkBox_RegBitSet0.AutoSize = true;
            this.checkBox_RegBitSet0.Location = new System.Drawing.Point(79, 149);
            this.checkBox_RegBitSet0.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_RegBitSet0.Name = "checkBox_RegBitSet0";
            this.checkBox_RegBitSet0.Size = new System.Drawing.Size(32, 17);
            this.checkBox_RegBitSet0.TabIndex = 17;
            this.checkBox_RegBitSet0.Tag = "0";
            this.checkBox_RegBitSet0.Text = "0";
            this.checkBox_RegBitSet0.UseVisualStyleBackColor = true;
            this.checkBox_RegBitSet0.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(79, 130);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(32, 17);
            this.checkBox10.TabIndex = 16;
            this.checkBox10.Tag = "1";
            this.checkBox10.Text = "1";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(79, 21);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(32, 17);
            this.checkBox11.TabIndex = 15;
            this.checkBox11.Tag = "7";
            this.checkBox11.Text = "7";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(79, 39);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(32, 17);
            this.checkBox12.TabIndex = 14;
            this.checkBox12.Tag = "6";
            this.checkBox12.Text = "6";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(79, 58);
            this.checkBox13.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(32, 17);
            this.checkBox13.TabIndex = 13;
            this.checkBox13.Tag = "5";
            this.checkBox13.Text = "5";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(79, 76);
            this.checkBox14.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(32, 17);
            this.checkBox14.TabIndex = 12;
            this.checkBox14.Tag = "4";
            this.checkBox14.Text = "4";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(79, 94);
            this.checkBox15.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(32, 17);
            this.checkBox15.TabIndex = 11;
            this.checkBox15.Tag = "3";
            this.checkBox15.Text = "3";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(79, 112);
            this.checkBox16.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(32, 17);
            this.checkBox16.TabIndex = 10;
            this.checkBox16.Tag = "2";
            this.checkBox16.Text = "2";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 149);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Tag = "8";
            this.checkBox1.Text = "8";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 130);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Tag = "9";
            this.checkBox2.Text = "9";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(23, 21);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(38, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Tag = "15";
            this.checkBox3.Text = "15";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(23, 39);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(38, 17);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Tag = "14";
            this.checkBox4.Text = "14";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(23, 58);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(38, 17);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Tag = "13";
            this.checkBox5.Text = "13";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(23, 76);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(38, 17);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Tag = "12";
            this.checkBox6.Text = "12";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(23, 94);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(38, 17);
            this.checkBox7.TabIndex = 3;
            this.checkBox7.Tag = "11";
            this.checkBox7.Text = "11";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(23, 112);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(38, 17);
            this.checkBox8.TabIndex = 2;
            this.checkBox8.Tag = "10";
            this.checkBox8.Text = "10";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox_RegBitSet_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "R/W:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // label_RegDescription
            // 
            this.label_RegDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_RegDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_RegDescription.Location = new System.Drawing.Point(69, 21);
            this.label_RegDescription.Name = "label_RegDescription";
            this.label_RegDescription.Size = new System.Drawing.Size(161, 20);
            this.label_RegDescription.TabIndex = 3;
            this.label_RegDescription.Text = "label3";
            // 
            // label_RegRW
            // 
            this.label_RegRW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_RegRW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_RegRW.Location = new System.Drawing.Point(69, 44);
            this.label_RegRW.Name = "label_RegRW";
            this.label_RegRW.Size = new System.Drawing.Size(67, 20);
            this.label_RegRW.TabIndex = 2;
            this.label_RegRW.Text = "label3";
            // 
            // button_RegUpdateFromExtFile
            // 
            this.button_RegUpdateFromExtFile.Location = new System.Drawing.Point(175, 162);
            this.button_RegUpdateFromExtFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegUpdateFromExtFile.Name = "button_RegUpdateFromExtFile";
            this.button_RegUpdateFromExtFile.Size = new System.Drawing.Size(74, 37);
            this.button_RegUpdateFromExtFile.TabIndex = 8;
            this.button_RegUpdateFromExtFile.Text = "Update from Ext File";
            this.button_RegUpdateFromExtFile.UseVisualStyleBackColor = true;
            this.button_RegUpdateFromExtFile.Click += new System.EventHandler(this.button_RegUpdateFromExtFile_Click);
            // 
            // button_RegWriteAll
            // 
            this.button_RegWriteAll.Location = new System.Drawing.Point(175, 57);
            this.button_RegWriteAll.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegWriteAll.Name = "button_RegWriteAll";
            this.button_RegWriteAll.Size = new System.Drawing.Size(74, 37);
            this.button_RegWriteAll.TabIndex = 7;
            this.button_RegWriteAll.Text = "Write All";
            this.button_RegWriteAll.UseVisualStyleBackColor = true;
            this.button_RegWriteAll.Click += new System.EventHandler(this.button_RegWriteAll_Click);
            // 
            // button_RegReadAll
            // 
            this.button_RegReadAll.Location = new System.Drawing.Point(175, 16);
            this.button_RegReadAll.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegReadAll.Name = "button_RegReadAll";
            this.button_RegReadAll.Size = new System.Drawing.Size(74, 37);
            this.button_RegReadAll.TabIndex = 6;
            this.button_RegReadAll.Text = "Read All";
            this.button_RegReadAll.UseVisualStyleBackColor = true;
            this.button_RegReadAll.Click += new System.EventHandler(this.button_RegReadAll_Click);
            // 
            // button_RegSaveToFile
            // 
            this.button_RegSaveToFile.Location = new System.Drawing.Point(13, 121);
            this.button_RegSaveToFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegSaveToFile.Name = "button_RegSaveToFile";
            this.button_RegSaveToFile.Size = new System.Drawing.Size(74, 37);
            this.button_RegSaveToFile.TabIndex = 5;
            this.button_RegSaveToFile.Text = "Save to File";
            this.button_RegSaveToFile.UseVisualStyleBackColor = true;
            this.button_RegSaveToFile.Click += new System.EventHandler(this.button_SaveToFile_Click);
            // 
            // button_RegSaveAs
            // 
            this.button_RegSaveAs.Location = new System.Drawing.Point(13, 162);
            this.button_RegSaveAs.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegSaveAs.Name = "button_RegSaveAs";
            this.button_RegSaveAs.Size = new System.Drawing.Size(74, 37);
            this.button_RegSaveAs.TabIndex = 1;
            this.button_RegSaveAs.Text = "Save As";
            this.button_RegSaveAs.UseVisualStyleBackColor = true;
            this.button_RegSaveAs.Click += new System.EventHandler(this.button_SaveAs_Click);
            // 
            // button_RegLoadFromFile
            // 
            this.button_RegLoadFromFile.Location = new System.Drawing.Point(13, 16);
            this.button_RegLoadFromFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegLoadFromFile.Name = "button_RegLoadFromFile";
            this.button_RegLoadFromFile.Size = new System.Drawing.Size(74, 37);
            this.button_RegLoadFromFile.TabIndex = 0;
            this.button_RegLoadFromFile.Text = "Load from File";
            this.button_RegLoadFromFile.UseVisualStyleBackColor = true;
            this.button_RegLoadFromFile.Click += new System.EventHandler(this.button_LoadFromFile_Click);
            // 
            // tabControl_MAIN
            // 
            this.tabControl_MAIN.Controls.Add(this.tabManage);
            this.tabControl_MAIN.Controls.Add(this.tabMeasurement_Setting);
            this.tabControl_MAIN.Controls.Add(this.tabMeasurementData);
            this.tabControl_MAIN.Controls.Add(this.tabRegisters);
            this.tabControl_MAIN.Controls.Add(this.tabGpio);
            this.tabControl_MAIN.Controls.Add(this.tabReset);
            this.tabControl_MAIN.Controls.Add(this.tabConfiguration);
            this.tabControl_MAIN.Controls.Add(this.tabSetting);
            this.tabControl_MAIN.Controls.Add(this.tabAnalyzInCirc);
            this.tabControl_MAIN.Controls.Add(this.tabExtSignals);
            this.tabControl_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_MAIN.Location = new System.Drawing.Point(0, 35);
            this.tabControl_MAIN.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_MAIN.Name = "tabControl_MAIN";
            this.tabControl_MAIN.SelectedIndex = 0;
            this.tabControl_MAIN.Size = new System.Drawing.Size(1184, 576);
            this.tabControl_MAIN.TabIndex = 1;
            this.tabControl_MAIN.SelectedIndexChanged += new System.EventHandler(this.tabControl_MAIN_SelectedIndexChanged);
            // 
            // tabManage
            // 
            this.tabManage.AutoScroll = true;
            this.tabManage.Controls.Add(this.groupBox_ManageActions);
            this.tabManage.Controls.Add(this.groupBox11);
            this.tabManage.Controls.Add(this.listBox_MainLog);
            this.tabManage.Controls.Add(this.groupBox_LMXSync);
            this.tabManage.Location = new System.Drawing.Point(4, 22);
            this.tabManage.Name = "tabManage";
            this.tabManage.Size = new System.Drawing.Size(1176, 550);
            this.tabManage.TabIndex = 11;
            this.tabManage.Text = "Manage";
            this.tabManage.UseVisualStyleBackColor = true;
            // 
            // groupBox_ManageActions
            // 
            this.groupBox_ManageActions.Location = new System.Drawing.Point(19, 24);
            this.groupBox_ManageActions.Name = "groupBox_ManageActions";
            this.groupBox_ManageActions.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_ManageActions.Size = new System.Drawing.Size(180, 415);
            this.groupBox_ManageActions.TabIndex = 8;
            this.groupBox_ManageActions.TabStop = false;
            this.groupBox_ManageActions.Text = "Actions";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.checkBox_InfoPeriodicRead);
            this.groupBox11.Controls.Add(this.label51);
            this.groupBox11.Controls.Add(this.label_InfoLmx2Locked);
            this.groupBox11.Controls.Add(this.label49);
            this.groupBox11.Controls.Add(this.label_InfoLmx1Locked);
            this.groupBox11.Controls.Add(this.label_123);
            this.groupBox11.Controls.Add(this.label_InfoSyncib);
            this.groupBox11.Controls.Add(this.label_412);
            this.groupBox11.Controls.Add(this.label_InfoXcvrLanesLocked);
            this.groupBox11.Controls.Add(this.label_788);
            this.groupBox11.Controls.Add(this.label_InfoLogicRefPllsLocked);
            this.groupBox11.Controls.Add(this.label454);
            this.groupBox11.Controls.Add(this.label_InfoHmcPllsLocked);
            this.groupBox11.Controls.Add(this.label38);
            this.groupBox11.Controls.Add(this.label_InfoAdcClockDetect);
            this.groupBox11.Controls.Add(this.label34);
            this.groupBox11.Controls.Add(this.label_InfoAdcJtxPllLocked);
            this.groupBox11.Controls.Add(this.label39);
            this.groupBox11.Controls.Add(this.label_InfoOnlineLMX2);
            this.groupBox11.Controls.Add(this.label37);
            this.groupBox11.Controls.Add(this.label_InfoOnlineLMX1);
            this.groupBox11.Controls.Add(this.label35);
            this.groupBox11.Controls.Add(this.label_InfoOnlineHmc);
            this.groupBox11.Controls.Add(this.label26);
            this.groupBox11.Controls.Add(this.label_InfoOnlineAdc);
            this.groupBox11.Controls.Add(this.label33);
            this.groupBox11.Controls.Add(this.label_InfoAdcMinTemp);
            this.groupBox11.Controls.Add(this.label30);
            this.groupBox11.Controls.Add(this.label_InfoAdcMaxTemp);
            this.groupBox11.Location = new System.Drawing.Point(225, 24);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(242, 415);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "System Info";
            // 
            // checkBox_InfoPeriodicRead
            // 
            this.checkBox_InfoPeriodicRead.AutoSize = true;
            this.checkBox_InfoPeriodicRead.Checked = true;
            this.checkBox_InfoPeriodicRead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_InfoPeriodicRead.Location = new System.Drawing.Point(24, 28);
            this.checkBox_InfoPeriodicRead.Name = "checkBox_InfoPeriodicRead";
            this.checkBox_InfoPeriodicRead.Size = new System.Drawing.Size(93, 17);
            this.checkBox_InfoPeriodicRead.TabIndex = 34;
            this.checkBox_InfoPeriodicRead.Text = "Periodic Read";
            this.checkBox_InfoPeriodicRead.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(63, 225);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(77, 13);
            this.label51.TabIndex = 33;
            this.label51.Text = "LMX2 Locked:";
            // 
            // label_InfoLmx2Locked
            // 
            this.label_InfoLmx2Locked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoLmx2Locked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoLmx2Locked.Location = new System.Drawing.Point(146, 222);
            this.label_InfoLmx2Locked.Name = "label_InfoLmx2Locked";
            this.label_InfoLmx2Locked.Size = new System.Drawing.Size(74, 20);
            this.label_InfoLmx2Locked.TabIndex = 32;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(63, 205);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(77, 13);
            this.label49.TabIndex = 31;
            this.label49.Text = "LMX1 Locked:";
            // 
            // label_InfoLmx1Locked
            // 
            this.label_InfoLmx1Locked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoLmx1Locked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoLmx1Locked.Location = new System.Drawing.Point(146, 202);
            this.label_InfoLmx1Locked.Name = "label_InfoLmx1Locked";
            this.label_InfoLmx1Locked.Size = new System.Drawing.Size(74, 20);
            this.label_InfoLmx1Locked.TabIndex = 30;
            // 
            // label_123
            // 
            this.label_123.AutoSize = true;
            this.label_123.Location = new System.Drawing.Point(91, 305);
            this.label_123.Name = "label_123";
            this.label_123.Size = new System.Drawing.Size(49, 13);
            this.label_123.TabIndex = 29;
            this.label_123.Text = "SYNCIB:";
            // 
            // label_InfoSyncib
            // 
            this.label_InfoSyncib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoSyncib.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoSyncib.Location = new System.Drawing.Point(146, 302);
            this.label_InfoSyncib.Name = "label_InfoSyncib";
            this.label_InfoSyncib.Size = new System.Drawing.Size(74, 20);
            this.label_InfoSyncib.TabIndex = 28;
            // 
            // label_412
            // 
            this.label_412.AutoSize = true;
            this.label_412.Location = new System.Drawing.Point(30, 285);
            this.label_412.Name = "label_412";
            this.label_412.Size = new System.Drawing.Size(110, 13);
            this.label_412.TabIndex = 27;
            this.label_412.Text = "XCVR Lanes Locked:";
            // 
            // label_InfoXcvrLanesLocked
            // 
            this.label_InfoXcvrLanesLocked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoXcvrLanesLocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoXcvrLanesLocked.Location = new System.Drawing.Point(146, 282);
            this.label_InfoXcvrLanesLocked.Name = "label_InfoXcvrLanesLocked";
            this.label_InfoXcvrLanesLocked.Size = new System.Drawing.Size(74, 20);
            this.label_InfoXcvrLanesLocked.TabIndex = 26;
            // 
            // label_788
            // 
            this.label_788.AutoSize = true;
            this.label_788.Location = new System.Drawing.Point(21, 265);
            this.label_788.Name = "label_788";
            this.label_788.Size = new System.Drawing.Size(119, 13);
            this.label_788.TabIndex = 25;
            this.label_788.Text = "LogicRef PLLs Locked:";
            // 
            // label_InfoLogicRefPllsLocked
            // 
            this.label_InfoLogicRefPllsLocked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoLogicRefPllsLocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoLogicRefPllsLocked.Location = new System.Drawing.Point(146, 262);
            this.label_InfoLogicRefPllsLocked.Name = "label_InfoLogicRefPllsLocked";
            this.label_InfoLogicRefPllsLocked.Size = new System.Drawing.Size(74, 20);
            this.label_InfoLogicRefPllsLocked.TabIndex = 24;
            // 
            // label454
            // 
            this.label454.AutoSize = true;
            this.label454.Location = new System.Drawing.Point(40, 245);
            this.label454.Name = "label454";
            this.label454.Size = new System.Drawing.Size(100, 13);
            this.label454.TabIndex = 23;
            this.label454.Text = "HMC PLLs Locked:";
            // 
            // label_InfoHmcPllsLocked
            // 
            this.label_InfoHmcPllsLocked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoHmcPllsLocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoHmcPllsLocked.Location = new System.Drawing.Point(146, 242);
            this.label_InfoHmcPllsLocked.Name = "label_InfoHmcPllsLocked";
            this.label_InfoHmcPllsLocked.Size = new System.Drawing.Size(74, 20);
            this.label_InfoHmcPllsLocked.TabIndex = 22;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(43, 185);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(97, 13);
            this.label38.TabIndex = 21;
            this.label38.Text = "ADC Clock Detect:";
            // 
            // label_InfoAdcClockDetect
            // 
            this.label_InfoAdcClockDetect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoAdcClockDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoAdcClockDetect.Location = new System.Drawing.Point(146, 182);
            this.label_InfoAdcClockDetect.Name = "label_InfoAdcClockDetect";
            this.label_InfoAdcClockDetect.Size = new System.Drawing.Size(74, 20);
            this.label_InfoAdcClockDetect.TabIndex = 20;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(25, 165);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(115, 13);
            this.label34.TabIndex = 19;
            this.label34.Text = "ADC JTX PLL Locked:";
            // 
            // label_InfoAdcJtxPllLocked
            // 
            this.label_InfoAdcJtxPllLocked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoAdcJtxPllLocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoAdcJtxPllLocked.Location = new System.Drawing.Point(146, 162);
            this.label_InfoAdcJtxPllLocked.Name = "label_InfoAdcJtxPllLocked";
            this.label_InfoAdcJtxPllLocked.Size = new System.Drawing.Size(74, 20);
            this.label_InfoAdcJtxPllLocked.TabIndex = 18;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(69, 123);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(71, 13);
            this.label39.TabIndex = 17;
            this.label39.Text = "LMX2 Online:";
            // 
            // label_InfoOnlineLMX2
            // 
            this.label_InfoOnlineLMX2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoOnlineLMX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoOnlineLMX2.Location = new System.Drawing.Point(146, 120);
            this.label_InfoOnlineLMX2.Name = "label_InfoOnlineLMX2";
            this.label_InfoOnlineLMX2.Size = new System.Drawing.Size(74, 20);
            this.label_InfoOnlineLMX2.TabIndex = 16;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(69, 103);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(71, 13);
            this.label37.TabIndex = 15;
            this.label37.Text = "LMX1 Online:";
            // 
            // label_InfoOnlineLMX1
            // 
            this.label_InfoOnlineLMX1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoOnlineLMX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoOnlineLMX1.Location = new System.Drawing.Point(146, 100);
            this.label_InfoOnlineLMX1.Name = "label_InfoOnlineLMX1";
            this.label_InfoOnlineLMX1.Size = new System.Drawing.Size(74, 20);
            this.label_InfoOnlineLMX1.TabIndex = 14;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(73, 82);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(67, 13);
            this.label35.TabIndex = 13;
            this.label35.Text = "HMC Online:";
            // 
            // label_InfoOnlineHmc
            // 
            this.label_InfoOnlineHmc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoOnlineHmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoOnlineHmc.Location = new System.Drawing.Point(146, 80);
            this.label_InfoOnlineHmc.Name = "label_InfoOnlineHmc";
            this.label_InfoOnlineHmc.Size = new System.Drawing.Size(74, 20);
            this.label_InfoOnlineHmc.TabIndex = 12;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(75, 62);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 13);
            this.label26.TabIndex = 11;
            this.label26.Text = "ADC Online:";
            // 
            // label_InfoOnlineAdc
            // 
            this.label_InfoOnlineAdc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoOnlineAdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoOnlineAdc.Location = new System.Drawing.Point(146, 60);
            this.label_InfoOnlineAdc.Name = "label_InfoOnlineAdc";
            this.label_InfoOnlineAdc.Size = new System.Drawing.Size(74, 20);
            this.label_InfoOnlineAdc.TabIndex = 10;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(38, 365);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(102, 13);
            this.label33.TabIndex = 9;
            this.label33.Text = "ADC Min Temp [°C]:";
            // 
            // label_InfoAdcMinTemp
            // 
            this.label_InfoAdcMinTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoAdcMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoAdcMinTemp.Location = new System.Drawing.Point(146, 362);
            this.label_InfoAdcMinTemp.Name = "label_InfoAdcMinTemp";
            this.label_InfoAdcMinTemp.Size = new System.Drawing.Size(74, 20);
            this.label_InfoAdcMinTemp.TabIndex = 8;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(35, 345);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(105, 13);
            this.label30.TabIndex = 7;
            this.label30.Text = "ADC Max Temp [°C]:";
            // 
            // label_InfoAdcMaxTemp
            // 
            this.label_InfoAdcMaxTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InfoAdcMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InfoAdcMaxTemp.Location = new System.Drawing.Point(146, 342);
            this.label_InfoAdcMaxTemp.Name = "label_InfoAdcMaxTemp";
            this.label_InfoAdcMaxTemp.Size = new System.Drawing.Size(74, 20);
            this.label_InfoAdcMaxTemp.TabIndex = 6;
            // 
            // listBox_MainLog
            // 
            this.listBox_MainLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox_MainLog.FormattingEnabled = true;
            this.listBox_MainLog.Location = new System.Drawing.Point(918, 0);
            this.listBox_MainLog.Name = "listBox_MainLog";
            this.listBox_MainLog.Size = new System.Drawing.Size(258, 550);
            this.listBox_MainLog.TabIndex = 1;
            // 
            // groupBox_LMXSync
            // 
            this.groupBox_LMXSync.Controls.Add(this.checkBox_QS_FcalEn2);
            this.groupBox_LMXSync.Controls.Add(this.checkBox_QS_FcalEn1);
            this.groupBox_LMXSync.Controls.Add(this.label27);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_CHDIV2);
            this.groupBox_LMXSync.Controls.Add(this.label29);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_INC_DIV2);
            this.groupBox_LMXSync.Controls.Add(this.label31);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_PLL_DEN2);
            this.groupBox_LMXSync.Controls.Add(this.label25);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_CHDIV1);
            this.groupBox_LMXSync.Controls.Add(this.label23);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_INC_DIV1);
            this.groupBox_LMXSync.Controls.Add(this.label22);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_PLL_DEN1);
            this.groupBox_LMXSync.Controls.Add(this.label21);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_Phase2);
            this.groupBox_LMXSync.Controls.Add(this.label20);
            this.groupBox_LMXSync.Controls.Add(this.label_QS_Phase1);
            this.groupBox_LMXSync.Controls.Add(this.button_QS_Sync);
            this.groupBox_LMXSync.Controls.Add(this.label14);
            this.groupBox_LMXSync.Controls.Add(this.numericUpDown_QS_Seed2);
            this.groupBox_LMXSync.Controls.Add(this.label12);
            this.groupBox_LMXSync.Controls.Add(this.numericUpDown_QS_Seed1);
            this.groupBox_LMXSync.Location = new System.Drawing.Point(499, 24);
            this.groupBox_LMXSync.Name = "groupBox_LMXSync";
            this.groupBox_LMXSync.Size = new System.Drawing.Size(383, 320);
            this.groupBox_LMXSync.TabIndex = 0;
            this.groupBox_LMXSync.TabStop = false;
            this.groupBox_LMXSync.Text = "LMX Sync";
            // 
            // checkBox_QS_FcalEn2
            // 
            this.checkBox_QS_FcalEn2.AutoSize = true;
            this.checkBox_QS_FcalEn2.Location = new System.Drawing.Point(248, 286);
            this.checkBox_QS_FcalEn2.Name = "checkBox_QS_FcalEn2";
            this.checkBox_QS_FcalEn2.Size = new System.Drawing.Size(85, 17);
            this.checkBox_QS_FcalEn2.TabIndex = 22;
            this.checkBox_QS_FcalEn2.Text = "FCAL_EN_2";
            this.checkBox_QS_FcalEn2.UseVisualStyleBackColor = true;
            this.checkBox_QS_FcalEn2.CheckedChanged += new System.EventHandler(this.checkBox_QS_FcalEn2_CheckedChanged);
            // 
            // checkBox_QS_FcalEn1
            // 
            this.checkBox_QS_FcalEn1.AutoSize = true;
            this.checkBox_QS_FcalEn1.Location = new System.Drawing.Point(41, 286);
            this.checkBox_QS_FcalEn1.Name = "checkBox_QS_FcalEn1";
            this.checkBox_QS_FcalEn1.Size = new System.Drawing.Size(85, 17);
            this.checkBox_QS_FcalEn1.TabIndex = 21;
            this.checkBox_QS_FcalEn1.Text = "FCAL_EN_1";
            this.checkBox_QS_FcalEn1.UseVisualStyleBackColor = true;
            this.checkBox_QS_FcalEn1.CheckedChanged += new System.EventHandler(this.checkBox_QS_FcalEn1_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(256, 123);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 12);
            this.label27.TabIndex = 20;
            this.label27.Text = "CHDIV:";
            // 
            // label_QS_CHDIV2
            // 
            this.label_QS_CHDIV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_CHDIV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_CHDIV2.Location = new System.Drawing.Point(296, 121);
            this.label_QS_CHDIV2.Name = "label_QS_CHDIV2";
            this.label_QS_CHDIV2.Size = new System.Drawing.Size(50, 18);
            this.label_QS_CHDIV2.TabIndex = 19;
            this.label_QS_CHDIV2.Text = "label3";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label29.Location = new System.Drawing.Point(254, 105);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 18;
            this.label29.Text = "Inc_Div:";
            // 
            // label_QS_INC_DIV2
            // 
            this.label_QS_INC_DIV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_INC_DIV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_INC_DIV2.Location = new System.Drawing.Point(296, 103);
            this.label_QS_INC_DIV2.Name = "label_QS_INC_DIV2";
            this.label_QS_INC_DIV2.Size = new System.Drawing.Size(50, 18);
            this.label_QS_INC_DIV2.TabIndex = 17;
            this.label_QS_INC_DIV2.Text = "label3";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label31.Location = new System.Drawing.Point(246, 87);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 12);
            this.label31.TabIndex = 16;
            this.label31.Text = "PLL_DEN:";
            // 
            // label_QS_PLL_DEN2
            // 
            this.label_QS_PLL_DEN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_PLL_DEN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_PLL_DEN2.Location = new System.Drawing.Point(296, 85);
            this.label_QS_PLL_DEN2.Name = "label_QS_PLL_DEN2";
            this.label_QS_PLL_DEN2.Size = new System.Drawing.Size(50, 18);
            this.label_QS_PLL_DEN2.TabIndex = 15;
            this.label_QS_PLL_DEN2.Text = "label3";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(49, 123);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 12);
            this.label25.TabIndex = 14;
            this.label25.Text = "CHDIV:";
            // 
            // label_QS_CHDIV1
            // 
            this.label_QS_CHDIV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_CHDIV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_CHDIV1.Location = new System.Drawing.Point(89, 121);
            this.label_QS_CHDIV1.Name = "label_QS_CHDIV1";
            this.label_QS_CHDIV1.Size = new System.Drawing.Size(50, 18);
            this.label_QS_CHDIV1.TabIndex = 13;
            this.label_QS_CHDIV1.Text = "label3";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(47, 105);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 12);
            this.label23.TabIndex = 12;
            this.label23.Text = "Inc_Div:";
            // 
            // label_QS_INC_DIV1
            // 
            this.label_QS_INC_DIV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_INC_DIV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_INC_DIV1.Location = new System.Drawing.Point(89, 103);
            this.label_QS_INC_DIV1.Name = "label_QS_INC_DIV1";
            this.label_QS_INC_DIV1.Size = new System.Drawing.Size(50, 18);
            this.label_QS_INC_DIV1.TabIndex = 11;
            this.label_QS_INC_DIV1.Text = "label3";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(39, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 12);
            this.label22.TabIndex = 10;
            this.label22.Text = "PLL_DEN:";
            // 
            // label_QS_PLL_DEN1
            // 
            this.label_QS_PLL_DEN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_PLL_DEN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_PLL_DEN1.Location = new System.Drawing.Point(89, 85);
            this.label_QS_PLL_DEN1.Name = "label_QS_PLL_DEN1";
            this.label_QS_PLL_DEN1.Size = new System.Drawing.Size(50, 18);
            this.label_QS_PLL_DEN1.TabIndex = 9;
            this.label_QS_PLL_DEN1.Text = "label3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(240, 171);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "PHASE 2:";
            // 
            // label_QS_Phase2
            // 
            this.label_QS_Phase2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_Phase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_Phase2.Location = new System.Drawing.Point(243, 191);
            this.label_QS_Phase2.Name = "label_QS_Phase2";
            this.label_QS_Phase2.Size = new System.Drawing.Size(103, 20);
            this.label_QS_Phase2.TabIndex = 7;
            this.label_QS_Phase2.Text = "label3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(33, 171);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "PHASE 1:";
            // 
            // label_QS_Phase1
            // 
            this.label_QS_Phase1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_QS_Phase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_QS_Phase1.Location = new System.Drawing.Point(36, 191);
            this.label_QS_Phase1.Name = "label_QS_Phase1";
            this.label_QS_Phase1.Size = new System.Drawing.Size(103, 20);
            this.label_QS_Phase1.TabIndex = 5;
            this.label_QS_Phase1.Text = "label3";
            // 
            // button_QS_Sync
            // 
            this.button_QS_Sync.Location = new System.Drawing.Point(36, 234);
            this.button_QS_Sync.Name = "button_QS_Sync";
            this.button_QS_Sync.Size = new System.Drawing.Size(310, 31);
            this.button_QS_Sync.TabIndex = 4;
            this.button_QS_Sync.Text = "SYNC Pulse";
            this.button_QS_Sync.UseVisualStyleBackColor = true;
            this.button_QS_Sync.Click += new System.EventHandler(this.button_QS_Sync_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "MASH SEED 2:";
            // 
            // numericUpDown_QS_Seed2
            // 
            this.numericUpDown_QS_Seed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_QS_Seed2.Location = new System.Drawing.Point(243, 50);
            this.numericUpDown_QS_Seed2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_QS_Seed2.Name = "numericUpDown_QS_Seed2";
            this.numericUpDown_QS_Seed2.Size = new System.Drawing.Size(103, 26);
            this.numericUpDown_QS_Seed2.TabIndex = 2;
            this.numericUpDown_QS_Seed2.ValueChanged += new System.EventHandler(this.numericUpDown_QS_Seed2_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "MASH SEED 1:";
            // 
            // numericUpDown_QS_Seed1
            // 
            this.numericUpDown_QS_Seed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_QS_Seed1.Location = new System.Drawing.Point(36, 50);
            this.numericUpDown_QS_Seed1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_QS_Seed1.Name = "numericUpDown_QS_Seed1";
            this.numericUpDown_QS_Seed1.Size = new System.Drawing.Size(103, 26);
            this.numericUpDown_QS_Seed1.TabIndex = 0;
            this.numericUpDown_QS_Seed1.ValueChanged += new System.EventHandler(this.numericUpDown_QS_Seed1_ValueChanged);
            // 
            // tabMeasurement_Setting
            // 
            this.tabMeasurement_Setting.AutoScroll = true;
            this.tabMeasurement_Setting.Controls.Add(this.button_Acq_SwTrigger);
            this.tabMeasurement_Setting.Controls.Add(this.groupBox14);
            this.tabMeasurement_Setting.Controls.Add(this.groupBox6);
            this.tabMeasurement_Setting.Controls.Add(this.groupBox5);
            this.tabMeasurement_Setting.Controls.Add(this.groupBox4);
            this.tabMeasurement_Setting.Controls.Add(this.groupBox3);
            this.tabMeasurement_Setting.Location = new System.Drawing.Point(4, 22);
            this.tabMeasurement_Setting.Name = "tabMeasurement_Setting";
            this.tabMeasurement_Setting.Size = new System.Drawing.Size(1176, 550);
            this.tabMeasurement_Setting.TabIndex = 7;
            this.tabMeasurement_Setting.Text = "Measurement Settings";
            this.tabMeasurement_Setting.UseVisualStyleBackColor = true;
            // 
            // button_Acq_SwTrigger
            // 
            this.button_Acq_SwTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Acq_SwTrigger.Location = new System.Drawing.Point(947, 272);
            this.button_Acq_SwTrigger.Name = "button_Acq_SwTrigger";
            this.button_Acq_SwTrigger.Size = new System.Drawing.Size(180, 35);
            this.button_Acq_SwTrigger.TabIndex = 32;
            this.button_Acq_SwTrigger.Text = "SW Trigger";
            this.button_Acq_SwTrigger.UseVisualStyleBackColor = true;
            this.button_Acq_SwTrigger.Click += new System.EventHandler(this.button_Acq_SwTrigger_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.radioButton_TrgExtFallingOver);
            this.groupBox14.Controls.Add(this.radioButton_TrgExtRisingOver);
            this.groupBox14.Controls.Add(this.radioButton_TrgAdcFd);
            this.groupBox14.Controls.Add(this.radioButton_TrgExtFallingNorm);
            this.groupBox14.Controls.Add(this.radioButton_TrgSw);
            this.groupBox14.Controls.Add(this.radioButton_TrgExtRisingNorm);
            this.groupBox14.Controls.Add(this.radioButton_TrgSelf);
            this.groupBox14.Location = new System.Drawing.Point(947, 18);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(180, 238);
            this.groupBox14.TabIndex = 31;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Trigger Source";
            // 
            // radioButton_TrgExtFallingOver
            // 
            this.radioButton_TrgExtFallingOver.AutoSize = true;
            this.radioButton_TrgExtFallingOver.Location = new System.Drawing.Point(19, 128);
            this.radioButton_TrgExtFallingOver.Name = "radioButton_TrgExtFallingOver";
            this.radioButton_TrgExtFallingOver.Size = new System.Drawing.Size(135, 17);
            this.radioButton_TrgExtFallingOver.TabIndex = 40;
            this.radioButton_TrgExtFallingOver.TabStop = true;
            this.radioButton_TrgExtFallingOver.Text = "Ext Trigger Falling Over";
            this.radioButton_TrgExtFallingOver.UseVisualStyleBackColor = true;
            // 
            // radioButton_TrgExtRisingOver
            // 
            this.radioButton_TrgExtRisingOver.AutoSize = true;
            this.radioButton_TrgExtRisingOver.Location = new System.Drawing.Point(19, 105);
            this.radioButton_TrgExtRisingOver.Name = "radioButton_TrgExtRisingOver";
            this.radioButton_TrgExtRisingOver.Size = new System.Drawing.Size(134, 17);
            this.radioButton_TrgExtRisingOver.TabIndex = 39;
            this.radioButton_TrgExtRisingOver.TabStop = true;
            this.radioButton_TrgExtRisingOver.Text = "Ext Trigger Rising Over";
            this.radioButton_TrgExtRisingOver.UseVisualStyleBackColor = true;
            // 
            // radioButton_TrgAdcFd
            // 
            this.radioButton_TrgAdcFd.AutoSize = true;
            this.radioButton_TrgAdcFd.Location = new System.Drawing.Point(19, 151);
            this.radioButton_TrgAdcFd.Name = "radioButton_TrgAdcFd";
            this.radioButton_TrgAdcFd.Size = new System.Drawing.Size(64, 17);
            this.radioButton_TrgAdcFd.TabIndex = 38;
            this.radioButton_TrgAdcFd.TabStop = true;
            this.radioButton_TrgAdcFd.Text = "ADC FD";
            this.radioButton_TrgAdcFd.UseVisualStyleBackColor = true;
            this.radioButton_TrgAdcFd.CheckedChanged += new System.EventHandler(this.radioButton_TriggerSource_CheckedChanged);
            // 
            // radioButton_TrgExtFallingNorm
            // 
            this.radioButton_TrgExtFallingNorm.AutoSize = true;
            this.radioButton_TrgExtFallingNorm.Location = new System.Drawing.Point(19, 82);
            this.radioButton_TrgExtFallingNorm.Name = "radioButton_TrgExtFallingNorm";
            this.radioButton_TrgExtFallingNorm.Size = new System.Drawing.Size(137, 17);
            this.radioButton_TrgExtFallingNorm.TabIndex = 37;
            this.radioButton_TrgExtFallingNorm.TabStop = true;
            this.radioButton_TrgExtFallingNorm.Text = "Ext Trigger Falling Norm";
            this.radioButton_TrgExtFallingNorm.UseVisualStyleBackColor = true;
            this.radioButton_TrgExtFallingNorm.CheckedChanged += new System.EventHandler(this.radioButton_TriggerSource_CheckedChanged);
            // 
            // radioButton_TrgSw
            // 
            this.radioButton_TrgSw.AutoSize = true;
            this.radioButton_TrgSw.Location = new System.Drawing.Point(19, 174);
            this.radioButton_TrgSw.Name = "radioButton_TrgSw";
            this.radioButton_TrgSw.Size = new System.Drawing.Size(103, 17);
            this.radioButton_TrgSw.TabIndex = 36;
            this.radioButton_TrgSw.TabStop = true;
            this.radioButton_TrgSw.Text = "Software Trigger";
            this.radioButton_TrgSw.UseVisualStyleBackColor = true;
            this.radioButton_TrgSw.CheckedChanged += new System.EventHandler(this.radioButton_TriggerSource_CheckedChanged);
            // 
            // radioButton_TrgExtRisingNorm
            // 
            this.radioButton_TrgExtRisingNorm.AutoSize = true;
            this.radioButton_TrgExtRisingNorm.Location = new System.Drawing.Point(19, 59);
            this.radioButton_TrgExtRisingNorm.Name = "radioButton_TrgExtRisingNorm";
            this.radioButton_TrgExtRisingNorm.Size = new System.Drawing.Size(136, 17);
            this.radioButton_TrgExtRisingNorm.TabIndex = 35;
            this.radioButton_TrgExtRisingNorm.TabStop = true;
            this.radioButton_TrgExtRisingNorm.Text = "Ext Trigger Rising Norm";
            this.radioButton_TrgExtRisingNorm.UseVisualStyleBackColor = true;
            this.radioButton_TrgExtRisingNorm.CheckedChanged += new System.EventHandler(this.radioButton_TriggerSource_CheckedChanged);
            // 
            // radioButton_TrgSelf
            // 
            this.radioButton_TrgSelf.AutoSize = true;
            this.radioButton_TrgSelf.Location = new System.Drawing.Point(19, 36);
            this.radioButton_TrgSelf.Name = "radioButton_TrgSelf";
            this.radioButton_TrgSelf.Size = new System.Drawing.Size(79, 17);
            this.radioButton_TrgSelf.TabIndex = 34;
            this.radioButton_TrgSelf.TabStop = true;
            this.radioButton_TrgSelf.Text = "Self Trigger";
            this.radioButton_TrgSelf.UseVisualStyleBackColor = true;
            this.radioButton_TrgSelf.CheckedChanged += new System.EventHandler(this.radioButton_TriggerSource_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox_DataTestMux);
            this.groupBox6.Controls.Add(this.checkBox_TestGeneratorEnable);
            this.groupBox6.Location = new System.Drawing.Point(947, 332);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(180, 94);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Others";
            // 
            // checkBox_DataTestMux
            // 
            this.checkBox_DataTestMux.AutoSize = true;
            this.checkBox_DataTestMux.Location = new System.Drawing.Point(19, 34);
            this.checkBox_DataTestMux.Name = "checkBox_DataTestMux";
            this.checkBox_DataTestMux.Size = new System.Drawing.Size(98, 17);
            this.checkBox_DataTestMux.TabIndex = 1;
            this.checkBox_DataTestMux.Text = "Data/Test Mux";
            this.checkBox_DataTestMux.UseVisualStyleBackColor = true;
            this.checkBox_DataTestMux.CheckedChanged += new System.EventHandler(this.checkBox_DataTestMux_CheckedChanged);
            // 
            // checkBox_TestGeneratorEnable
            // 
            this.checkBox_TestGeneratorEnable.AutoSize = true;
            this.checkBox_TestGeneratorEnable.Location = new System.Drawing.Point(19, 67);
            this.checkBox_TestGeneratorEnable.Name = "checkBox_TestGeneratorEnable";
            this.checkBox_TestGeneratorEnable.Size = new System.Drawing.Size(133, 17);
            this.checkBox_TestGeneratorEnable.TabIndex = 0;
            this.checkBox_TestGeneratorEnable.Text = "Test Generator Enable";
            this.checkBox_TestGeneratorEnable.UseVisualStyleBackColor = true;
            this.checkBox_TestGeneratorEnable.CheckedChanged += new System.EventHandler(this.checkBox_TestGeneratorEnable_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_OpenDataFile);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.textBox_DataFilePath);
            this.groupBox5.Controls.Add(this.checkBox_SaveToFile);
            this.groupBox5.Controls.Add(this.checkBox_SaveToRam);
            this.groupBox5.Location = new System.Drawing.Point(504, 268);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(368, 158);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Store Data";
            // 
            // button_OpenDataFile
            // 
            this.button_OpenDataFile.Location = new System.Drawing.Point(268, 106);
            this.button_OpenDataFile.Name = "button_OpenDataFile";
            this.button_OpenDataFile.Size = new System.Drawing.Size(75, 30);
            this.button_OpenDataFile.TabIndex = 4;
            this.button_OpenDataFile.Text = "File";
            this.button_OpenDataFile.UseVisualStyleBackColor = true;
            this.button_OpenDataFile.Click += new System.EventHandler(this.button_OpenDataFile_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "File path:";
            // 
            // textBox_DataFilePath
            // 
            this.textBox_DataFilePath.Location = new System.Drawing.Point(23, 112);
            this.textBox_DataFilePath.Name = "textBox_DataFilePath";
            this.textBox_DataFilePath.Size = new System.Drawing.Size(229, 20);
            this.textBox_DataFilePath.TabIndex = 2;
            // 
            // checkBox_SaveToFile
            // 
            this.checkBox_SaveToFile.AutoSize = true;
            this.checkBox_SaveToFile.Location = new System.Drawing.Point(35, 58);
            this.checkBox_SaveToFile.Name = "checkBox_SaveToFile";
            this.checkBox_SaveToFile.Size = new System.Drawing.Size(82, 17);
            this.checkBox_SaveToFile.TabIndex = 1;
            this.checkBox_SaveToFile.Text = "Save to File";
            this.checkBox_SaveToFile.UseVisualStyleBackColor = true;
            // 
            // checkBox_SaveToRam
            // 
            this.checkBox_SaveToRam.AutoSize = true;
            this.checkBox_SaveToRam.Checked = true;
            this.checkBox_SaveToRam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SaveToRam.Location = new System.Drawing.Point(35, 32);
            this.checkBox_SaveToRam.Name = "checkBox_SaveToRam";
            this.checkBox_SaveToRam.Size = new System.Drawing.Size(90, 17);
            this.checkBox_SaveToRam.TabIndex = 0;
            this.checkBox_SaveToRam.Text = "Save to RAM";
            this.checkBox_SaveToRam.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Controls.Add(this.button_CountersClearAll);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label_CounterInRunEvents);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label_CounterProcessedEvents);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label_CounterIncomingEvents);
            this.groupBox4.Location = new System.Drawing.Point(504, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 238);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Event Counters";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label40.Location = new System.Drawing.Point(34, 151);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(146, 15);
            this.label40.TabIndex = 21;
            this.label40.Text = "Processed Events in Run:";
            // 
            // label41
            // 
            this.label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label41.Location = new System.Drawing.Point(186, 148);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(135, 23);
            this.label41.TabIndex = 20;
            this.label41.Text = "0";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_CountersClearAll
            // 
            this.button_CountersClearAll.Location = new System.Drawing.Point(19, 197);
            this.button_CountersClearAll.Name = "button_CountersClearAll";
            this.button_CountersClearAll.Size = new System.Drawing.Size(326, 23);
            this.button_CountersClearAll.TabIndex = 19;
            this.button_CountersClearAll.Text = "Clear All Counters";
            this.button_CountersClearAll.UseVisualStyleBackColor = true;
            this.button_CountersClearAll.Click += new System.EventHandler(this.button_CountersClearAll_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(41, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "Incoming Events in Run:";
            // 
            // label_CounterInRunEvents
            // 
            this.label_CounterInRunEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_CounterInRunEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CounterInRunEvents.Location = new System.Drawing.Point(186, 107);
            this.label_CounterInRunEvents.Name = "label_CounterInRunEvents";
            this.label_CounterInRunEvents.Size = new System.Drawing.Size(135, 23);
            this.label_CounterInRunEvents.TabIndex = 16;
            this.label_CounterInRunEvents.Text = "0";
            this.label_CounterInRunEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(57, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "All Processed Events:";
            // 
            // label_CounterProcessedEvents
            // 
            this.label_CounterProcessedEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_CounterProcessedEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CounterProcessedEvents.Location = new System.Drawing.Point(186, 66);
            this.label_CounterProcessedEvents.Name = "label_CounterProcessedEvents";
            this.label_CounterProcessedEvents.Size = new System.Drawing.Size(135, 23);
            this.label_CounterProcessedEvents.TabIndex = 12;
            this.label_CounterProcessedEvents.Text = "0";
            this.label_CounterProcessedEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(64, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "All Incoming Events:";
            // 
            // label_CounterIncomingEvents
            // 
            this.label_CounterIncomingEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_CounterIncomingEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CounterIncomingEvents.Location = new System.Drawing.Point(186, 25);
            this.label_CounterIncomingEvents.Name = "label_CounterIncomingEvents";
            this.label_CounterIncomingEvents.Size = new System.Drawing.Size(135, 23);
            this.label_CounterIncomingEvents.TabIndex = 10;
            this.label_CounterIncomingEvents.Text = "0";
            this.label_CounterIncomingEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label43);
            this.groupBox3.Controls.Add(this.numericUpDown_Time_usec);
            this.groupBox3.Controls.Add(this.label42);
            this.groupBox3.Controls.Add(this.numericUpDown_Time_msec);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.button_AcqStartStop);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.numericUpDown_AcqThreshold);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.numericUpDown_NumOfSamples);
            this.groupBox3.Controls.Add(this.numericUpDown_AcqRepeats);
            this.groupBox3.Controls.Add(this.checkBox_Repeats);
            this.groupBox3.Controls.Add(this.radioButton_AcqEventsPerTime);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numericUpDown_NumOfEvents);
            this.groupBox3.Controls.Add(this.numericUpDown_Time_sec);
            this.groupBox3.Controls.Add(this.radioButton_AcqTime);
            this.groupBox3.Controls.Add(this.radioButton_AcqNumEvents);
            this.groupBox3.Controls.Add(this.radioButton_AcqInfinite);
            this.groupBox3.Location = new System.Drawing.Point(47, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 408);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACQ";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label43.Location = new System.Drawing.Point(297, 205);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(33, 15);
            this.label43.TabIndex = 21;
            this.label43.Text = "usec";
            // 
            // numericUpDown_Time_usec
            // 
            this.numericUpDown_Time_usec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_Time_usec.Location = new System.Drawing.Point(176, 203);
            this.numericUpDown_Time_usec.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown_Time_usec.Name = "numericUpDown_Time_usec";
            this.numericUpDown_Time_usec.Size = new System.Drawing.Size(108, 22);
            this.numericUpDown_Time_usec.TabIndex = 20;
            this.numericUpDown_Time_usec.ValueChanged += new System.EventHandler(this.numericUpDown_Time_ValueChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label42.Location = new System.Drawing.Point(297, 177);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(37, 15);
            this.label42.TabIndex = 19;
            this.label42.Text = "msec";
            // 
            // numericUpDown_Time_msec
            // 
            this.numericUpDown_Time_msec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_Time_msec.Location = new System.Drawing.Point(176, 175);
            this.numericUpDown_Time_msec.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown_Time_msec.Name = "numericUpDown_Time_msec";
            this.numericUpDown_Time_msec.Size = new System.Drawing.Size(108, 22);
            this.numericUpDown_Time_msec.TabIndex = 18;
            this.numericUpDown_Time_msec.ValueChanged += new System.EventHandler(this.numericUpDown_Time_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(95, 357);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 15);
            this.label18.TabIndex = 17;
            this.label18.Text = "Threshold:";
            // 
            // button_AcqStartStop
            // 
            this.button_AcqStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AcqStartStop.Location = new System.Drawing.Point(17, 34);
            this.button_AcqStartStop.Name = "button_AcqStartStop";
            this.button_AcqStartStop.Size = new System.Drawing.Size(326, 35);
            this.button_AcqStartStop.TabIndex = 5;
            this.button_AcqStartStop.Text = "Start";
            this.button_AcqStartStop.UseVisualStyleBackColor = true;
            this.button_AcqStartStop.Click += new System.EventHandler(this.button_AcqStartStop_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(40, 326);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "Number of Samples:";
            // 
            // numericUpDown_AcqThreshold
            // 
            this.numericUpDown_AcqThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_AcqThreshold.Location = new System.Drawing.Point(176, 355);
            this.numericUpDown_AcqThreshold.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericUpDown_AcqThreshold.Name = "numericUpDown_AcqThreshold";
            this.numericUpDown_AcqThreshold.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_AcqThreshold.TabIndex = 15;
            this.numericUpDown_AcqThreshold.ValueChanged += new System.EventHandler(this.numericUpDown_AcqThreshold_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(302, 326);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 15);
            this.label16.TabIndex = 14;
            this.label16.Text = "samples";
            // 
            // numericUpDown_NumOfSamples
            // 
            this.numericUpDown_NumOfSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_NumOfSamples.Location = new System.Drawing.Point(176, 322);
            this.numericUpDown_NumOfSamples.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_NumOfSamples.Name = "numericUpDown_NumOfSamples";
            this.numericUpDown_NumOfSamples.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_NumOfSamples.TabIndex = 13;
            this.numericUpDown_NumOfSamples.ValueChanged += new System.EventHandler(this.numericUpDown_NumOfSamples_ValueChanged);
            // 
            // numericUpDown_AcqRepeats
            // 
            this.numericUpDown_AcqRepeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_AcqRepeats.Location = new System.Drawing.Point(176, 259);
            this.numericUpDown_AcqRepeats.Name = "numericUpDown_AcqRepeats";
            this.numericUpDown_AcqRepeats.Size = new System.Drawing.Size(71, 22);
            this.numericUpDown_AcqRepeats.TabIndex = 12;
            // 
            // checkBox_Repeats
            // 
            this.checkBox_Repeats.AutoSize = true;
            this.checkBox_Repeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_Repeats.Location = new System.Drawing.Point(98, 261);
            this.checkBox_Repeats.Name = "checkBox_Repeats";
            this.checkBox_Repeats.Size = new System.Drawing.Size(72, 19);
            this.checkBox_Repeats.TabIndex = 11;
            this.checkBox_Repeats.Text = "Repeats";
            this.checkBox_Repeats.UseVisualStyleBackColor = true;
            // 
            // radioButton_AcqEventsPerTime
            // 
            this.radioButton_AcqEventsPerTime.AutoSize = true;
            this.radioButton_AcqEventsPerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_AcqEventsPerTime.Location = new System.Drawing.Point(176, 86);
            this.radioButton_AcqEventsPerTime.Name = "radioButton_AcqEventsPerTime";
            this.radioButton_AcqEventsPerTime.Size = new System.Drawing.Size(124, 20);
            this.radioButton_AcqEventsPerTime.TabIndex = 10;
            this.radioButton_AcqEventsPerTime.TabStop = true;
            this.radioButton_AcqEventsPerTime.Text = "Events per Time";
            this.radioButton_AcqEventsPerTime.UseVisualStyleBackColor = true;
            this.radioButton_AcqEventsPerTime.CheckedChanged += new System.EventHandler(this.radioButton_Acq_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(297, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "events";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(297, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "sec";
            // 
            // numericUpDown_NumOfEvents
            // 
            this.numericUpDown_NumOfEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_NumOfEvents.Location = new System.Drawing.Point(176, 119);
            this.numericUpDown_NumOfEvents.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown_NumOfEvents.Name = "numericUpDown_NumOfEvents";
            this.numericUpDown_NumOfEvents.Size = new System.Drawing.Size(108, 22);
            this.numericUpDown_NumOfEvents.TabIndex = 7;
            this.numericUpDown_NumOfEvents.ValueChanged += new System.EventHandler(this.numericUpDown_NumOfEvents_ValueChanged);
            // 
            // numericUpDown_Time_sec
            // 
            this.numericUpDown_Time_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_Time_sec.Location = new System.Drawing.Point(176, 147);
            this.numericUpDown_Time_sec.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown_Time_sec.Name = "numericUpDown_Time_sec";
            this.numericUpDown_Time_sec.Size = new System.Drawing.Size(108, 22);
            this.numericUpDown_Time_sec.TabIndex = 6;
            this.numericUpDown_Time_sec.ValueChanged += new System.EventHandler(this.numericUpDown_Time_ValueChanged);
            // 
            // radioButton_AcqTime
            // 
            this.radioButton_AcqTime.AutoSize = true;
            this.radioButton_AcqTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_AcqTime.Location = new System.Drawing.Point(18, 147);
            this.radioButton_AcqTime.Name = "radioButton_AcqTime";
            this.radioButton_AcqTime.Size = new System.Drawing.Size(142, 20);
            this.radioButton_AcqTime.TabIndex = 2;
            this.radioButton_AcqTime.TabStop = true;
            this.radioButton_AcqTime.Text = "Measurement Time";
            this.radioButton_AcqTime.UseVisualStyleBackColor = true;
            this.radioButton_AcqTime.CheckedChanged += new System.EventHandler(this.radioButton_Acq_CheckedChanged);
            // 
            // radioButton_AcqNumEvents
            // 
            this.radioButton_AcqNumEvents.AutoSize = true;
            this.radioButton_AcqNumEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_AcqNumEvents.Location = new System.Drawing.Point(18, 119);
            this.radioButton_AcqNumEvents.Name = "radioButton_AcqNumEvents";
            this.radioButton_AcqNumEvents.Size = new System.Drawing.Size(132, 20);
            this.radioButton_AcqNumEvents.TabIndex = 1;
            this.radioButton_AcqNumEvents.TabStop = true;
            this.radioButton_AcqNumEvents.Text = "Number of Events";
            this.radioButton_AcqNumEvents.UseVisualStyleBackColor = true;
            this.radioButton_AcqNumEvents.CheckedChanged += new System.EventHandler(this.radioButton_Acq_CheckedChanged);
            // 
            // radioButton_AcqInfinite
            // 
            this.radioButton_AcqInfinite.AutoSize = true;
            this.radioButton_AcqInfinite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_AcqInfinite.Location = new System.Drawing.Point(18, 86);
            this.radioButton_AcqInfinite.Name = "radioButton_AcqInfinite";
            this.radioButton_AcqInfinite.Size = new System.Drawing.Size(63, 20);
            this.radioButton_AcqInfinite.TabIndex = 0;
            this.radioButton_AcqInfinite.TabStop = true;
            this.radioButton_AcqInfinite.Text = "Infinite";
            this.radioButton_AcqInfinite.UseVisualStyleBackColor = true;
            this.radioButton_AcqInfinite.CheckedChanged += new System.EventHandler(this.radioButton_Acq_CheckedChanged);
            // 
            // tabMeasurementData
            // 
            this.tabMeasurementData.Controls.Add(this.tableLayoutPanel_MeasurementData);
            this.tabMeasurementData.Location = new System.Drawing.Point(4, 22);
            this.tabMeasurementData.Margin = new System.Windows.Forms.Padding(2);
            this.tabMeasurementData.Name = "tabMeasurementData";
            this.tabMeasurementData.Padding = new System.Windows.Forms.Padding(2);
            this.tabMeasurementData.Size = new System.Drawing.Size(1176, 550);
            this.tabMeasurementData.TabIndex = 1;
            this.tabMeasurementData.Text = "Measurement Data";
            this.tabMeasurementData.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_MeasurementData
            // 
            this.tableLayoutPanel_MeasurementData.ColumnCount = 2;
            this.tableLayoutPanel_MeasurementData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MeasurementData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel_MeasurementData.Controls.Add(this.panel10, 1, 1);
            this.tableLayoutPanel_MeasurementData.Controls.Add(this.dataGridView_events, 1, 0);
            this.tableLayoutPanel_MeasurementData.Controls.Add(this.panel9, 0, 1);
            this.tableLayoutPanel_MeasurementData.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel_MeasurementData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_MeasurementData.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel_MeasurementData.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_MeasurementData.Name = "tableLayoutPanel_MeasurementData";
            this.tableLayoutPanel_MeasurementData.RowCount = 2;
            this.tableLayoutPanel_MeasurementData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MeasurementData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel_MeasurementData.Size = new System.Drawing.Size(1172, 546);
            this.tableLayoutPanel_MeasurementData.TabIndex = 20;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button_AnotherForm);
            this.panel10.Controls.Add(this.numericUpDown_EventsMaxCount);
            this.panel10.Controls.Add(this.checkBox_EventsMaxCount);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(938, 507);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(234, 39);
            this.panel10.TabIndex = 23;
            // 
            // button_AnotherForm
            // 
            this.button_AnotherForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_AnotherForm.Location = new System.Drawing.Point(195, 0);
            this.button_AnotherForm.Name = "button_AnotherForm";
            this.button_AnotherForm.Size = new System.Drawing.Size(39, 39);
            this.button_AnotherForm.TabIndex = 24;
            this.button_AnotherForm.Text = ">>";
            this.button_AnotherForm.UseVisualStyleBackColor = true;
            this.button_AnotherForm.Click += new System.EventHandler(this.button_AnotherForm_Click);
            // 
            // numericUpDown_EventsMaxCount
            // 
            this.numericUpDown_EventsMaxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_EventsMaxCount.Location = new System.Drawing.Point(104, 8);
            this.numericUpDown_EventsMaxCount.Name = "numericUpDown_EventsMaxCount";
            this.numericUpDown_EventsMaxCount.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown_EventsMaxCount.TabIndex = 14;
            // 
            // checkBox_EventsMaxCount
            // 
            this.checkBox_EventsMaxCount.AutoSize = true;
            this.checkBox_EventsMaxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_EventsMaxCount.Location = new System.Drawing.Point(13, 10);
            this.checkBox_EventsMaxCount.Name = "checkBox_EventsMaxCount";
            this.checkBox_EventsMaxCount.Size = new System.Drawing.Size(88, 19);
            this.checkBox_EventsMaxCount.TabIndex = 13;
            this.checkBox_EventsMaxCount.Text = "Max Count:";
            this.checkBox_EventsMaxCount.UseVisualStyleBackColor = true;
            // 
            // dataGridView_events
            // 
            this.dataGridView_events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_events.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_events.Location = new System.Drawing.Point(941, 3);
            this.dataGridView_events.Name = "dataGridView_events";
            this.dataGridView_events.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_events.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView_events.Size = new System.Drawing.Size(228, 501);
            this.dataGridView_events.TabIndex = 20;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button_EventsDeleteResults);
            this.panel9.Controls.Add(this.checkBox_EventsAutoLoad);
            this.panel9.Controls.Add(this.button_EventsClear);
            this.panel9.Controls.Add(this.checkBox_EventsLastAutoAnalyze);
            this.panel9.Controls.Add(this.button_EventsListClear);
            this.panel9.Controls.Add(this.checkBox_EventsLastAutoSelect);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(2, 507);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(934, 39);
            this.panel9.TabIndex = 22;
            // 
            // button_EventsDeleteResults
            // 
            this.button_EventsDeleteResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_EventsDeleteResults.Location = new System.Drawing.Point(670, 0);
            this.button_EventsDeleteResults.Name = "button_EventsDeleteResults";
            this.button_EventsDeleteResults.Size = new System.Drawing.Size(88, 39);
            this.button_EventsDeleteResults.TabIndex = 25;
            this.button_EventsDeleteResults.Text = "Delete Results";
            this.button_EventsDeleteResults.UseVisualStyleBackColor = true;
            this.button_EventsDeleteResults.Click += new System.EventHandler(this.button_EventsDeleteResults_Click);
            // 
            // checkBox_EventsAutoLoad
            // 
            this.checkBox_EventsAutoLoad.AutoSize = true;
            this.checkBox_EventsAutoLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_EventsAutoLoad.Location = new System.Drawing.Point(314, 10);
            this.checkBox_EventsAutoLoad.Name = "checkBox_EventsAutoLoad";
            this.checkBox_EventsAutoLoad.Size = new System.Drawing.Size(81, 19);
            this.checkBox_EventsAutoLoad.TabIndex = 24;
            this.checkBox_EventsAutoLoad.Text = "Auto Load";
            this.checkBox_EventsAutoLoad.UseVisualStyleBackColor = true;
            // 
            // button_EventsClear
            // 
            this.button_EventsClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_EventsClear.Location = new System.Drawing.Point(758, 0);
            this.button_EventsClear.Name = "button_EventsClear";
            this.button_EventsClear.Size = new System.Drawing.Size(88, 39);
            this.button_EventsClear.TabIndex = 23;
            this.button_EventsClear.Text = "Clear Event";
            this.button_EventsClear.UseVisualStyleBackColor = true;
            this.button_EventsClear.Click += new System.EventHandler(this.button_EventsClear_Click);
            // 
            // checkBox_EventsLastAutoAnalyze
            // 
            this.checkBox_EventsLastAutoAnalyze.AutoSize = true;
            this.checkBox_EventsLastAutoAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_EventsLastAutoAnalyze.Location = new System.Drawing.Point(155, 10);
            this.checkBox_EventsLastAutoAnalyze.Name = "checkBox_EventsLastAutoAnalyze";
            this.checkBox_EventsLastAutoAnalyze.Size = new System.Drawing.Size(121, 19);
            this.checkBox_EventsLastAutoAnalyze.TabIndex = 16;
            this.checkBox_EventsLastAutoAnalyze.Text = "Last Auto Analyze";
            this.checkBox_EventsLastAutoAnalyze.UseVisualStyleBackColor = true;
            // 
            // button_EventsListClear
            // 
            this.button_EventsListClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_EventsListClear.Location = new System.Drawing.Point(846, 0);
            this.button_EventsListClear.Name = "button_EventsListClear";
            this.button_EventsListClear.Size = new System.Drawing.Size(88, 39);
            this.button_EventsListClear.TabIndex = 19;
            this.button_EventsListClear.Text = "Clear All";
            this.button_EventsListClear.UseVisualStyleBackColor = true;
            this.button_EventsListClear.Click += new System.EventHandler(this.button_EventsListClear_Click);
            // 
            // checkBox_EventsLastAutoSelect
            // 
            this.checkBox_EventsLastAutoSelect.AutoSize = true;
            this.checkBox_EventsLastAutoSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_EventsLastAutoSelect.Location = new System.Drawing.Point(28, 10);
            this.checkBox_EventsLastAutoSelect.Name = "checkBox_EventsLastAutoSelect";
            this.checkBox_EventsLastAutoSelect.Size = new System.Drawing.Size(113, 19);
            this.checkBox_EventsLastAutoSelect.TabIndex = 15;
            this.checkBox_EventsLastAutoSelect.Text = "Last Auto Select";
            this.checkBox_EventsLastAutoSelect.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(932, 501);
            this.panel4.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControl_Events, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(932, 501);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button_EventsAnalyzeSIN);
            this.panel8.Controls.Add(this.button_EventsLoadResult);
            this.panel8.Controls.Add(this.button_EventsAnalyzeAdc);
            this.panel8.Controls.Add(this.button_EventsSaveEvent);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(926, 37);
            this.panel8.TabIndex = 22;
            // 
            // button_EventsAnalyzeSIN
            // 
            this.button_EventsAnalyzeSIN.Location = new System.Drawing.Point(285, 3);
            this.button_EventsAnalyzeSIN.Name = "button_EventsAnalyzeSIN";
            this.button_EventsAnalyzeSIN.Size = new System.Drawing.Size(130, 30);
            this.button_EventsAnalyzeSIN.TabIndex = 25;
            this.button_EventsAnalyzeSIN.Text = "Analyze SIN";
            this.button_EventsAnalyzeSIN.UseVisualStyleBackColor = true;
            this.button_EventsAnalyzeSIN.Click += new System.EventHandler(this.button_EventsAnalyzeSIN_Click);
            // 
            // button_EventsLoadResult
            // 
            this.button_EventsLoadResult.Location = new System.Drawing.Point(450, 3);
            this.button_EventsLoadResult.Name = "button_EventsLoadResult";
            this.button_EventsLoadResult.Size = new System.Drawing.Size(130, 30);
            this.button_EventsLoadResult.TabIndex = 24;
            this.button_EventsLoadResult.Text = "Load Result";
            this.button_EventsLoadResult.UseVisualStyleBackColor = true;
            this.button_EventsLoadResult.Click += new System.EventHandler(this.button_EventsLoadResult_Click);
            // 
            // button_EventsAnalyzeAdc
            // 
            this.button_EventsAnalyzeAdc.Location = new System.Drawing.Point(149, 3);
            this.button_EventsAnalyzeAdc.Name = "button_EventsAnalyzeAdc";
            this.button_EventsAnalyzeAdc.Size = new System.Drawing.Size(130, 30);
            this.button_EventsAnalyzeAdc.TabIndex = 23;
            this.button_EventsAnalyzeAdc.Text = "Analyze ADC";
            this.button_EventsAnalyzeAdc.UseVisualStyleBackColor = true;
            this.button_EventsAnalyzeAdc.Click += new System.EventHandler(this.button_EventsAnalyzeAdc_Click);
            // 
            // button_EventsSaveEvent
            // 
            this.button_EventsSaveEvent.Location = new System.Drawing.Point(13, 3);
            this.button_EventsSaveEvent.Name = "button_EventsSaveEvent";
            this.button_EventsSaveEvent.Size = new System.Drawing.Size(130, 30);
            this.button_EventsSaveEvent.TabIndex = 22;
            this.button_EventsSaveEvent.Text = "Save Event";
            this.button_EventsSaveEvent.UseVisualStyleBackColor = true;
            this.button_EventsSaveEvent.Click += new System.EventHandler(this.button_EventsSaveEvent_Click);
            // 
            // tabControl_Events
            // 
            this.tabControl_Events.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl_Events.Controls.Add(this.tabPage_TimeChart);
            this.tabControl_Events.Controls.Add(this.tabPage_AnalyzeAdcPicture);
            this.tabControl_Events.Controls.Add(this.tabPage_AnalyzeSinPicture);
            this.tabControl_Events.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Events.Location = new System.Drawing.Point(0, 43);
            this.tabControl_Events.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl_Events.Multiline = true;
            this.tabControl_Events.Name = "tabControl_Events";
            this.tabControl_Events.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl_Events.SelectedIndex = 0;
            this.tabControl_Events.Size = new System.Drawing.Size(932, 458);
            this.tabControl_Events.TabIndex = 23;
            // 
            // tabPage_TimeChart
            // 
            this.tabPage_TimeChart.Controls.Add(this.chart_EventTime);
            this.tabPage_TimeChart.Location = new System.Drawing.Point(23, 4);
            this.tabPage_TimeChart.Name = "tabPage_TimeChart";
            this.tabPage_TimeChart.Size = new System.Drawing.Size(905, 450);
            this.tabPage_TimeChart.TabIndex = 0;
            this.tabPage_TimeChart.Text = "Time Chart";
            this.tabPage_TimeChart.UseVisualStyleBackColor = true;
            // 
            // chart_EventTime
            // 
            this.chart_EventTime.BorderlineColor = System.Drawing.Color.Black;
            this.chart_EventTime.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart_EventTime.ChartAreas.Add(chartArea1);
            this.chart_EventTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart_EventTime.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Name = "Legend1";
            this.chart_EventTime.Legends.Add(legend1);
            this.chart_EventTime.Location = new System.Drawing.Point(0, 0);
            this.chart_EventTime.Margin = new System.Windows.Forms.Padding(2);
            this.chart_EventTime.Name = "chart_EventTime";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Data";
            this.chart_EventTime.Series.Add(series1);
            this.chart_EventTime.Size = new System.Drawing.Size(905, 450);
            this.chart_EventTime.TabIndex = 21;
            this.chart_EventTime.Text = "chart_data";
            this.chart_EventTime.Click += new System.EventHandler(this.chart_EventTime_Click);
            // 
            // tabPage_AnalyzeAdcPicture
            // 
            this.tabPage_AnalyzeAdcPicture.Controls.Add(this.pictureBox_EventAdcAnalyze);
            this.tabPage_AnalyzeAdcPicture.Location = new System.Drawing.Point(23, 4);
            this.tabPage_AnalyzeAdcPicture.Name = "tabPage_AnalyzeAdcPicture";
            this.tabPage_AnalyzeAdcPicture.Size = new System.Drawing.Size(905, 450);
            this.tabPage_AnalyzeAdcPicture.TabIndex = 1;
            this.tabPage_AnalyzeAdcPicture.Text = "Analyze ADC Chart";
            this.tabPage_AnalyzeAdcPicture.UseVisualStyleBackColor = true;
            // 
            // pictureBox_EventAdcAnalyze
            // 
            this.pictureBox_EventAdcAnalyze.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_EventAdcAnalyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_EventAdcAnalyze.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_EventAdcAnalyze.Name = "pictureBox_EventAdcAnalyze";
            this.pictureBox_EventAdcAnalyze.Size = new System.Drawing.Size(905, 450);
            this.pictureBox_EventAdcAnalyze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_EventAdcAnalyze.TabIndex = 0;
            this.pictureBox_EventAdcAnalyze.TabStop = false;
            this.pictureBox_EventAdcAnalyze.Click += new System.EventHandler(this.pictureBox_EventAnalyze_Click);
            // 
            // tabPage_AnalyzeSinPicture
            // 
            this.tabPage_AnalyzeSinPicture.Controls.Add(this.pictureBox_EventSinAnalyze);
            this.tabPage_AnalyzeSinPicture.Location = new System.Drawing.Point(23, 4);
            this.tabPage_AnalyzeSinPicture.Name = "tabPage_AnalyzeSinPicture";
            this.tabPage_AnalyzeSinPicture.Size = new System.Drawing.Size(905, 450);
            this.tabPage_AnalyzeSinPicture.TabIndex = 2;
            this.tabPage_AnalyzeSinPicture.Text = "Analyze SIN Chart";
            this.tabPage_AnalyzeSinPicture.UseVisualStyleBackColor = true;
            // 
            // pictureBox_EventSinAnalyze
            // 
            this.pictureBox_EventSinAnalyze.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_EventSinAnalyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_EventSinAnalyze.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_EventSinAnalyze.Name = "pictureBox_EventSinAnalyze";
            this.pictureBox_EventSinAnalyze.Size = new System.Drawing.Size(905, 450);
            this.pictureBox_EventSinAnalyze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_EventSinAnalyze.TabIndex = 1;
            this.pictureBox_EventSinAnalyze.TabStop = false;
            // 
            // tabGpio
            // 
            this.tabGpio.Controls.Add(this.tableLayoutPanel1);
            this.tabGpio.Controls.Add(this.panel2);
            this.tabGpio.Location = new System.Drawing.Point(4, 22);
            this.tabGpio.Name = "tabGpio";
            this.tabGpio.Size = new System.Drawing.Size(1176, 550);
            this.tabGpio.TabIndex = 9;
            this.tabGpio.Text = "GPIOs";
            this.tabGpio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_GpioOutputs, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_GpioInputs, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(121, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1055, 550);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView_GpioOutputs
            // 
            this.dataGridView_GpioOutputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GpioOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_GpioOutputs.Location = new System.Drawing.Point(530, 23);
            this.dataGridView_GpioOutputs.Name = "dataGridView_GpioOutputs";
            this.dataGridView_GpioOutputs.ReadOnly = true;
            this.dataGridView_GpioOutputs.Size = new System.Drawing.Size(522, 575);
            this.dataGridView_GpioOutputs.TabIndex = 5;
            this.dataGridView_GpioOutputs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GpioOutputs_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label1.Size = new System.Drawing.Size(521, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "INPUTs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(530, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label2.Size = new System.Drawing.Size(522, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "OUTPUTs";
            // 
            // dataGridView_GpioInputs
            // 
            this.dataGridView_GpioInputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GpioInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_GpioInputs.Location = new System.Drawing.Point(3, 23);
            this.dataGridView_GpioInputs.Name = "dataGridView_GpioInputs";
            this.dataGridView_GpioInputs.ReadOnly = true;
            this.dataGridView_GpioInputs.Size = new System.Drawing.Size(521, 575);
            this.dataGridView_GpioInputs.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_ClearRisingFalling);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 550);
            this.panel2.TabIndex = 2;
            // 
            // button_ClearRisingFalling
            // 
            this.button_ClearRisingFalling.Location = new System.Drawing.Point(20, 23);
            this.button_ClearRisingFalling.Margin = new System.Windows.Forms.Padding(2);
            this.button_ClearRisingFalling.Name = "button_ClearRisingFalling";
            this.button_ClearRisingFalling.Size = new System.Drawing.Size(74, 37);
            this.button_ClearRisingFalling.TabIndex = 6;
            this.button_ClearRisingFalling.Text = "Clear Rising Falling";
            this.button_ClearRisingFalling.UseVisualStyleBackColor = true;
            this.button_ClearRisingFalling.Click += new System.EventHandler(this.button_ClearRisingFalling_Click);
            // 
            // tabReset
            // 
            this.tabReset.Controls.Add(this.dataGridView_Resets);
            this.tabReset.Controls.Add(this.label4);
            this.tabReset.Controls.Add(this.panel6);
            this.tabReset.Location = new System.Drawing.Point(4, 22);
            this.tabReset.Name = "tabReset";
            this.tabReset.Size = new System.Drawing.Size(1176, 550);
            this.tabReset.TabIndex = 10;
            this.tabReset.Text = "RESETs";
            this.tabReset.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Resets
            // 
            this.dataGridView_Resets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Resets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Resets.Location = new System.Drawing.Point(446, 21);
            this.dataGridView_Resets.Name = "dataGridView_Resets";
            this.dataGridView_Resets.ReadOnly = true;
            this.dataGridView_Resets.Size = new System.Drawing.Size(730, 529);
            this.dataGridView_Resets.TabIndex = 8;
            this.dataGridView_Resets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Resets_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(446, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "RESETs";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button_Reset);
            this.panel6.Controls.Add(this.button_ResetClearAll);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(446, 550);
            this.panel6.TabIndex = 3;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(157, 21);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(74, 37);
            this.button_Reset.TabIndex = 9;
            this.button_Reset.Text = "FPGA RESET";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_ResetClearAll
            // 
            this.button_ResetClearAll.Location = new System.Drawing.Point(17, 21);
            this.button_ResetClearAll.Margin = new System.Windows.Forms.Padding(2);
            this.button_ResetClearAll.Name = "button_ResetClearAll";
            this.button_ResetClearAll.Size = new System.Drawing.Size(74, 37);
            this.button_ResetClearAll.TabIndex = 8;
            this.button_ResetClearAll.Text = "Clear All Resets";
            this.button_ResetClearAll.UseVisualStyleBackColor = true;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Controls.Add(this.tableLayoutPanel3);
            this.tabConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Size = new System.Drawing.Size(1176, 550);
            this.tabConfiguration.TabIndex = 8;
            this.tabConfiguration.Text = "Configuration";
            this.tabConfiguration.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.splitContainer1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1176, 550);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(337, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_MultipleConfigFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_ConfigFile);
            this.splitContainer1.Size = new System.Drawing.Size(836, 544);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 18;
            // 
            // dataGridView_MultipleConfigFiles
            // 
            this.dataGridView_MultipleConfigFiles.AllowUserToAddRows = false;
            this.dataGridView_MultipleConfigFiles.AllowUserToDeleteRows = false;
            this.dataGridView_MultipleConfigFiles.AllowUserToResizeColumns = false;
            this.dataGridView_MultipleConfigFiles.AllowUserToResizeRows = false;
            this.dataGridView_MultipleConfigFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MultipleConfigFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MultipleConfigFiles.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_MultipleConfigFiles.MultiSelect = false;
            this.dataGridView_MultipleConfigFiles.Name = "dataGridView_MultipleConfigFiles";
            this.dataGridView_MultipleConfigFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_MultipleConfigFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_MultipleConfigFiles.Size = new System.Drawing.Size(418, 544);
            this.dataGridView_MultipleConfigFiles.TabIndex = 17;
            this.dataGridView_MultipleConfigFiles.SelectionChanged += new System.EventHandler(this.dataGridView_MultipleConfigFiles_SelectionChanged);
            // 
            // dataGridView_ConfigFile
            // 
            this.dataGridView_ConfigFile.AllowUserToAddRows = false;
            this.dataGridView_ConfigFile.AllowUserToDeleteRows = false;
            this.dataGridView_ConfigFile.AllowUserToResizeColumns = false;
            this.dataGridView_ConfigFile.AllowUserToResizeRows = false;
            this.dataGridView_ConfigFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ConfigFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ConfigFile.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ConfigFile.MultiSelect = false;
            this.dataGridView_ConfigFile.Name = "dataGridView_ConfigFile";
            this.dataGridView_ConfigFile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_ConfigFile.Size = new System.Drawing.Size(414, 544);
            this.dataGridView_ConfigFile.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.button_ConfigDown);
            this.panel5.Controls.Add(this.button_ConfigUp);
            this.panel5.Controls.Add(this.groupBox7);
            this.panel5.Controls.Add(this.groupBox9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 544);
            this.panel5.TabIndex = 19;
            // 
            // button_ConfigDown
            // 
            this.button_ConfigDown.Location = new System.Drawing.Point(52, 417);
            this.button_ConfigDown.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigDown.Name = "button_ConfigDown";
            this.button_ConfigDown.Size = new System.Drawing.Size(56, 37);
            this.button_ConfigDown.TabIndex = 18;
            this.button_ConfigDown.Text = "DOWN";
            this.button_ConfigDown.UseVisualStyleBackColor = true;
            this.button_ConfigDown.Click += new System.EventHandler(this.button_ConfigDown_Click);
            // 
            // button_ConfigUp
            // 
            this.button_ConfigUp.Location = new System.Drawing.Point(52, 376);
            this.button_ConfigUp.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigUp.Name = "button_ConfigUp";
            this.button_ConfigUp.Size = new System.Drawing.Size(56, 37);
            this.button_ConfigUp.TabIndex = 17;
            this.button_ConfigUp.Text = "UP";
            this.button_ConfigUp.UseVisualStyleBackColor = true;
            this.button_ConfigUp.Click += new System.EventHandler(this.button_ConfigUp_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button_ConfigFileReloadFile);
            this.groupBox7.Controls.Add(this.button_RemoveConfig);
            this.groupBox7.Controls.Add(this.button_AddNewConfig);
            this.groupBox7.Controls.Add(this.button_ConfigFileLoadFromFile);
            this.groupBox7.Controls.Add(this.button_ConfigFileSaveToFile);
            this.groupBox7.Controls.Add(this.button_ConfigFileSaveAs);
            this.groupBox7.Location = new System.Drawing.Point(21, 25);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(228, 230);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Configuration File";
            // 
            // button_ConfigFileReloadFile
            // 
            this.button_ConfigFileReloadFile.Location = new System.Drawing.Point(122, 91);
            this.button_ConfigFileReloadFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigFileReloadFile.Name = "button_ConfigFileReloadFile";
            this.button_ConfigFileReloadFile.Size = new System.Drawing.Size(74, 37);
            this.button_ConfigFileReloadFile.TabIndex = 18;
            this.button_ConfigFileReloadFile.Text = "ReLoad File";
            this.button_ConfigFileReloadFile.UseVisualStyleBackColor = true;
            this.button_ConfigFileReloadFile.Click += new System.EventHandler(this.button_ConfigFileReloadFile_Click);
            // 
            // button_RemoveConfig
            // 
            this.button_RemoveConfig.Location = new System.Drawing.Point(122, 32);
            this.button_RemoveConfig.Margin = new System.Windows.Forms.Padding(2);
            this.button_RemoveConfig.Name = "button_RemoveConfig";
            this.button_RemoveConfig.Size = new System.Drawing.Size(74, 37);
            this.button_RemoveConfig.TabIndex = 17;
            this.button_RemoveConfig.Text = "Remove";
            this.button_RemoveConfig.UseVisualStyleBackColor = true;
            this.button_RemoveConfig.Click += new System.EventHandler(this.button_RemoveConfig_Click);
            // 
            // button_AddNewConfig
            // 
            this.button_AddNewConfig.Location = new System.Drawing.Point(31, 32);
            this.button_AddNewConfig.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddNewConfig.Name = "button_AddNewConfig";
            this.button_AddNewConfig.Size = new System.Drawing.Size(74, 37);
            this.button_AddNewConfig.TabIndex = 16;
            this.button_AddNewConfig.Text = "Add New";
            this.button_AddNewConfig.UseVisualStyleBackColor = true;
            this.button_AddNewConfig.Click += new System.EventHandler(this.button_AddNewConfig_Click);
            // 
            // button_ConfigFileLoadFromFile
            // 
            this.button_ConfigFileLoadFromFile.Location = new System.Drawing.Point(31, 91);
            this.button_ConfigFileLoadFromFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigFileLoadFromFile.Name = "button_ConfigFileLoadFromFile";
            this.button_ConfigFileLoadFromFile.Size = new System.Drawing.Size(74, 37);
            this.button_ConfigFileLoadFromFile.TabIndex = 9;
            this.button_ConfigFileLoadFromFile.Text = "Load from File";
            this.button_ConfigFileLoadFromFile.UseVisualStyleBackColor = true;
            this.button_ConfigFileLoadFromFile.Click += new System.EventHandler(this.button_ConfigFileLoadFromFile_Click);
            // 
            // button_ConfigFileSaveToFile
            // 
            this.button_ConfigFileSaveToFile.Location = new System.Drawing.Point(31, 173);
            this.button_ConfigFileSaveToFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigFileSaveToFile.Name = "button_ConfigFileSaveToFile";
            this.button_ConfigFileSaveToFile.Size = new System.Drawing.Size(74, 37);
            this.button_ConfigFileSaveToFile.TabIndex = 11;
            this.button_ConfigFileSaveToFile.Text = "Save to File";
            this.button_ConfigFileSaveToFile.UseVisualStyleBackColor = true;
            this.button_ConfigFileSaveToFile.Click += new System.EventHandler(this.button_ConfigFileSaveToFile_Click);
            // 
            // button_ConfigFileSaveAs
            // 
            this.button_ConfigFileSaveAs.Location = new System.Drawing.Point(122, 173);
            this.button_ConfigFileSaveAs.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigFileSaveAs.Name = "button_ConfigFileSaveAs";
            this.button_ConfigFileSaveAs.Size = new System.Drawing.Size(74, 37);
            this.button_ConfigFileSaveAs.TabIndex = 10;
            this.button_ConfigFileSaveAs.Text = "Save As";
            this.button_ConfigFileSaveAs.UseVisualStyleBackColor = true;
            this.button_ConfigFileSaveAs.Click += new System.EventHandler(this.button_ConfigFileSaveAs_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button_ConfigRun);
            this.groupBox9.Controls.Add(this.button_ConfigStop);
            this.groupBox9.Location = new System.Drawing.Point(21, 277);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(228, 94);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Sequence Action";
            // 
            // button_ConfigRun
            // 
            this.button_ConfigRun.Location = new System.Drawing.Point(31, 32);
            this.button_ConfigRun.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigRun.Name = "button_ConfigRun";
            this.button_ConfigRun.Size = new System.Drawing.Size(74, 37);
            this.button_ConfigRun.TabIndex = 13;
            this.button_ConfigRun.Text = "Config Run";
            this.button_ConfigRun.UseVisualStyleBackColor = true;
            this.button_ConfigRun.Click += new System.EventHandler(this.button_ConfigRun_Click);
            // 
            // button_ConfigStop
            // 
            this.button_ConfigStop.Location = new System.Drawing.Point(122, 32);
            this.button_ConfigStop.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigStop.Name = "button_ConfigStop";
            this.button_ConfigStop.Size = new System.Drawing.Size(74, 37);
            this.button_ConfigStop.TabIndex = 14;
            this.button_ConfigStop.Text = "Config Stop";
            this.button_ConfigStop.UseVisualStyleBackColor = true;
            this.button_ConfigStop.Click += new System.EventHandler(this.button_ConfigStop_Click);
            // 
            // tabSetting
            // 
            this.tabSetting.AutoScroll = true;
            this.tabSetting.Controls.Add(this.groupBox18);
            this.tabSetting.Controls.Add(this.groupBox17);
            this.tabSetting.Controls.Add(this.groupBox15);
            this.tabSetting.Controls.Add(this.groupBox13);
            this.tabSetting.Controls.Add(this.label_InQ);
            this.tabSetting.Controls.Add(this.checkBox_cmdQuestions);
            this.tabSetting.Controls.Add(this.label_RecvBytes);
            this.tabSetting.Controls.Add(this.label_Test);
            this.tabSetting.Controls.Add(this.button_Test);
            this.tabSetting.Controls.Add(this.groupBox8);
            this.tabSetting.Controls.Add(this.groupBox1);
            this.tabSetting.Location = new System.Drawing.Point(4, 22);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(1176, 550);
            this.tabSetting.TabIndex = 6;
            this.tabSetting.Text = "System Setting";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.checkBox_logComm);
            this.groupBox18.Location = new System.Drawing.Point(419, 283);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(339, 112);
            this.groupBox18.TabIndex = 33;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "XXX";
            // 
            // checkBox_logComm
            // 
            this.checkBox_logComm.AutoSize = true;
            this.checkBox_logComm.Location = new System.Drawing.Point(17, 28);
            this.checkBox_logComm.Name = "checkBox_logComm";
            this.checkBox_logComm.Size = new System.Drawing.Size(119, 17);
            this.checkBox_logComm.TabIndex = 34;
            this.checkBox_logComm.Text = "Log Communication";
            this.checkBox_logComm.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.checkBox_xListen2);
            this.groupBox17.Controls.Add(this.button_xSend);
            this.groupBox17.Controls.Add(this.checkBox_xListen3);
            this.groupBox17.Controls.Add(this.textBox_xSendByte0);
            this.groupBox17.Controls.Add(this.textBox_xSendByte1);
            this.groupBox17.Controls.Add(this.textBox_xSendByte2);
            this.groupBox17.Controls.Add(this.label_xRead);
            this.groupBox17.Controls.Add(this.textBox_xSendByte3);
            this.groupBox17.Location = new System.Drawing.Point(47, 283);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(339, 112);
            this.groupBox17.TabIndex = 32;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Custom Command";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label55);
            this.groupBox15.Controls.Add(this.label_dataErrors);
            this.groupBox15.Controls.Add(this.label54);
            this.groupBox15.Controls.Add(this.label53);
            this.groupBox15.Controls.Add(this.label52);
            this.groupBox15.Controls.Add(this.label_StatusTaskOfReadExecute_Data);
            this.groupBox15.Controls.Add(this.label48);
            this.groupBox15.Controls.Add(this.label_StatusTaskOfReadExecute_CMD);
            this.groupBox15.Controls.Add(this.label_errorCount);
            this.groupBox15.Controls.Add(this.label_StatusDataReadTask);
            this.groupBox15.Controls.Add(this.label46);
            this.groupBox15.Controls.Add(this.label_comState);
            this.groupBox15.Location = new System.Drawing.Point(525, 47);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(233, 230);
            this.groupBox15.TabIndex = 31;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Communication Status";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label55.Location = new System.Drawing.Point(25, 188);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(85, 15);
            this.label55.TabIndex = 38;
            this.label55.Text = "Errors In Data:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label54.Location = new System.Drawing.Point(45, 154);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(65, 15);
            this.label54.TabIndex = 37;
            this.label54.Text = "Data Task:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label53.Location = new System.Drawing.Point(43, 134);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(67, 15);
            this.label53.TabIndex = 36;
            this.label53.Text = "CMD Task:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label52.Location = new System.Drawing.Point(41, 114);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(69, 15);
            this.label52.TabIndex = 35;
            this.label52.Text = "Read Task:";
            // 
            // label_StatusTaskOfReadExecute_Data
            // 
            this.label_StatusTaskOfReadExecute_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_StatusTaskOfReadExecute_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_StatusTaskOfReadExecute_Data.Location = new System.Drawing.Point(116, 152);
            this.label_StatusTaskOfReadExecute_Data.Name = "label_StatusTaskOfReadExecute_Data";
            this.label_StatusTaskOfReadExecute_Data.Size = new System.Drawing.Size(106, 20);
            this.label_StatusTaskOfReadExecute_Data.TabIndex = 34;
            this.label_StatusTaskOfReadExecute_Data.Text = "0";
            this.label_StatusTaskOfReadExecute_Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label48.Location = new System.Drawing.Point(68, 66);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(72, 15);
            this.label48.TabIndex = 15;
            this.label48.Text = "Error Count:";
            // 
            // label_StatusTaskOfReadExecute_CMD
            // 
            this.label_StatusTaskOfReadExecute_CMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_StatusTaskOfReadExecute_CMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_StatusTaskOfReadExecute_CMD.Location = new System.Drawing.Point(116, 132);
            this.label_StatusTaskOfReadExecute_CMD.Name = "label_StatusTaskOfReadExecute_CMD";
            this.label_StatusTaskOfReadExecute_CMD.Size = new System.Drawing.Size(106, 20);
            this.label_StatusTaskOfReadExecute_CMD.TabIndex = 33;
            this.label_StatusTaskOfReadExecute_CMD.Text = "0";
            this.label_StatusTaskOfReadExecute_CMD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_errorCount
            // 
            this.label_errorCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_errorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_errorCount.Location = new System.Drawing.Point(147, 64);
            this.label_errorCount.Name = "label_errorCount";
            this.label_errorCount.Size = new System.Drawing.Size(75, 20);
            this.label_errorCount.TabIndex = 14;
            this.label_errorCount.Text = "0";
            this.label_errorCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_StatusDataReadTask
            // 
            this.label_StatusDataReadTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_StatusDataReadTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_StatusDataReadTask.Location = new System.Drawing.Point(116, 112);
            this.label_StatusDataReadTask.Name = "label_StatusDataReadTask";
            this.label_StatusDataReadTask.Size = new System.Drawing.Size(106, 20);
            this.label_StatusDataReadTask.TabIndex = 32;
            this.label_StatusDataReadTask.Text = "0";
            this.label_StatusDataReadTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label46.Location = new System.Drawing.Point(12, 36);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(128, 15);
            this.label46.TabIndex = 13;
            this.label46.Text = "Communication State:";
            // 
            // label_comState
            // 
            this.label_comState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_comState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_comState.Location = new System.Drawing.Point(147, 34);
            this.label_comState.Name = "label_comState";
            this.label_comState.Size = new System.Drawing.Size(75, 20);
            this.label_comState.TabIndex = 12;
            this.label_comState.Text = "0";
            this.label_comState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label36);
            this.groupBox13.Controls.Add(this.radioButton_ddSpecNum);
            this.groupBox13.Controls.Add(this.label_ddSetNum);
            this.groupBox13.Controls.Add(this.radioButton_ddSameAsComm);
            this.groupBox13.Controls.Add(this.radioButton_ddNotSet);
            this.groupBox13.Controls.Add(this.label32);
            this.groupBox13.Controls.Add(this.label_ddMyNum);
            this.groupBox13.Controls.Add(this.button_ddRead);
            this.groupBox13.Controls.Add(this.textBox_ddSpecNum);
            this.groupBox13.Controls.Add(this.button_ddWrite);
            this.groupBox13.Location = new System.Drawing.Point(286, 47);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(233, 230);
            this.groupBox13.TabIndex = 30;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Data Destination";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(47, 116);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(66, 13);
            this.label36.TabIndex = 35;
            this.label36.Text = "Set Number:";
            // 
            // radioButton_ddSpecNum
            // 
            this.radioButton_ddSpecNum.AutoSize = true;
            this.radioButton_ddSpecNum.Location = new System.Drawing.Point(28, 76);
            this.radioButton_ddSpecNum.Name = "radioButton_ddSpecNum";
            this.radioButton_ddSpecNum.Size = new System.Drawing.Size(103, 17);
            this.radioButton_ddSpecNum.TabIndex = 36;
            this.radioButton_ddSpecNum.TabStop = true;
            this.radioButton_ddSpecNum.Text = "Specific Number";
            this.radioButton_ddSpecNum.UseVisualStyleBackColor = true;
            this.radioButton_ddSpecNum.CheckedChanged += new System.EventHandler(this.radioButton_dataDestination_CheckedChanged);
            // 
            // label_ddSetNum
            // 
            this.label_ddSetNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ddSetNum.Location = new System.Drawing.Point(116, 112);
            this.label_ddSetNum.Name = "label_ddSetNum";
            this.label_ddSetNum.Size = new System.Drawing.Size(65, 20);
            this.label_ddSetNum.TabIndex = 34;
            this.label_ddSetNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_ddSameAsComm
            // 
            this.radioButton_ddSameAsComm.AutoSize = true;
            this.radioButton_ddSameAsComm.Location = new System.Drawing.Point(28, 53);
            this.radioButton_ddSameAsComm.Name = "radioButton_ddSameAsComm";
            this.radioButton_ddSameAsComm.Size = new System.Drawing.Size(141, 17);
            this.radioButton_ddSameAsComm.TabIndex = 35;
            this.radioButton_ddSameAsComm.TabStop = true;
            this.radioButton_ddSameAsComm.Text = "Same as Communication";
            this.radioButton_ddSameAsComm.UseVisualStyleBackColor = true;
            this.radioButton_ddSameAsComm.CheckedChanged += new System.EventHandler(this.radioButton_dataDestination_CheckedChanged);
            // 
            // radioButton_ddNotSet
            // 
            this.radioButton_ddNotSet.AutoSize = true;
            this.radioButton_ddNotSet.Location = new System.Drawing.Point(28, 30);
            this.radioButton_ddNotSet.Name = "radioButton_ddNotSet";
            this.radioButton_ddNotSet.Size = new System.Drawing.Size(61, 17);
            this.radioButton_ddNotSet.TabIndex = 34;
            this.radioButton_ddNotSet.TabStop = true;
            this.radioButton_ddNotSet.Text = "Not Set";
            this.radioButton_ddNotSet.UseVisualStyleBackColor = true;
            this.radioButton_ddNotSet.CheckedChanged += new System.EventHandler(this.radioButton_dataDestination_CheckedChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(49, 141);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(64, 13);
            this.label32.TabIndex = 33;
            this.label32.Text = "My Number:";
            // 
            // label_ddMyNum
            // 
            this.label_ddMyNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ddMyNum.Location = new System.Drawing.Point(116, 137);
            this.label_ddMyNum.Name = "label_ddMyNum";
            this.label_ddMyNum.Size = new System.Drawing.Size(65, 20);
            this.label_ddMyNum.TabIndex = 32;
            this.label_ddMyNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ddRead
            // 
            this.button_ddRead.Location = new System.Drawing.Point(133, 174);
            this.button_ddRead.Name = "button_ddRead";
            this.button_ddRead.Size = new System.Drawing.Size(72, 35);
            this.button_ddRead.TabIndex = 31;
            this.button_ddRead.Text = "Read";
            this.button_ddRead.UseVisualStyleBackColor = true;
            this.button_ddRead.Click += new System.EventHandler(this.button_ddRead_Click);
            // 
            // textBox_ddSpecNum
            // 
            this.textBox_ddSpecNum.Location = new System.Drawing.Point(137, 75);
            this.textBox_ddSpecNum.Name = "textBox_ddSpecNum";
            this.textBox_ddSpecNum.Size = new System.Drawing.Size(44, 20);
            this.textBox_ddSpecNum.TabIndex = 28;
            this.textBox_ddSpecNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_ddWrite
            // 
            this.button_ddWrite.Location = new System.Drawing.Point(28, 174);
            this.button_ddWrite.Name = "button_ddWrite";
            this.button_ddWrite.Size = new System.Drawing.Size(72, 35);
            this.button_ddWrite.TabIndex = 5;
            this.button_ddWrite.Text = "Write";
            this.button_ddWrite.UseVisualStyleBackColor = true;
            this.button_ddWrite.Click += new System.EventHandler(this.button_ddWrite_Click);
            // 
            // label_InQ
            // 
            this.label_InQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_InQ.Location = new System.Drawing.Point(303, 438);
            this.label_InQ.Name = "label_InQ";
            this.label_InQ.Size = new System.Drawing.Size(83, 21);
            this.label_InQ.TabIndex = 27;
            this.label_InQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_cmdQuestions
            // 
            this.checkBox_cmdQuestions.AutoSize = true;
            this.checkBox_cmdQuestions.Checked = true;
            this.checkBox_cmdQuestions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_cmdQuestions.Location = new System.Drawing.Point(69, 466);
            this.checkBox_cmdQuestions.Name = "checkBox_cmdQuestions";
            this.checkBox_cmdQuestions.Size = new System.Drawing.Size(100, 17);
            this.checkBox_cmdQuestions.TabIndex = 26;
            this.checkBox_cmdQuestions.Text = "CMD Questions";
            this.checkBox_cmdQuestions.UseVisualStyleBackColor = true;
            // 
            // label_RecvBytes
            // 
            this.label_RecvBytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_RecvBytes.Location = new System.Drawing.Point(303, 417);
            this.label_RecvBytes.Name = "label_RecvBytes";
            this.label_RecvBytes.Size = new System.Drawing.Size(83, 21);
            this.label_RecvBytes.TabIndex = 25;
            this.label_RecvBytes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Test
            // 
            this.label_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Test.Location = new System.Drawing.Point(136, 417);
            this.label_Test.Name = "label_Test";
            this.label_Test.Size = new System.Drawing.Size(83, 21);
            this.label_Test.TabIndex = 4;
            this.label_Test.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Test.Click += new System.EventHandler(this.label_Test_Click);
            // 
            // button_Test
            // 
            this.button_Test.Location = new System.Drawing.Point(53, 417);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(75, 21);
            this.button_Test.TabIndex = 5;
            this.button_Test.Text = "Test";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dataGridView_RegistersFiles);
            this.groupBox8.Location = new System.Drawing.Point(822, 24);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(325, 495);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Registers Configuration Files";
            // 
            // dataGridView_RegistersFiles
            // 
            this.dataGridView_RegistersFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RegistersFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_RegistersFiles.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_RegistersFiles.Name = "dataGridView_RegistersFiles";
            this.dataGridView_RegistersFiles.Size = new System.Drawing.Size(319, 476);
            this.dataGridView_RegistersFiles.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_OpenCloseCommunication);
            this.groupBox1.Controls.Add(this.button_ScanCommunication);
            this.groupBox1.Controls.Add(this.comboBox_Communication);
            this.groupBox1.Controls.Add(this.radioButton_PCIe);
            this.groupBox1.Controls.Add(this.radioButton_USB);
            this.groupBox1.Controls.Add(this.radioButton_UART);
            this.groupBox1.Location = new System.Drawing.Point(47, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication";
            // 
            // button_OpenCloseCommunication
            // 
            this.button_OpenCloseCommunication.Location = new System.Drawing.Point(28, 174);
            this.button_OpenCloseCommunication.Name = "button_OpenCloseCommunication";
            this.button_OpenCloseCommunication.Size = new System.Drawing.Size(177, 35);
            this.button_OpenCloseCommunication.TabIndex = 5;
            this.button_OpenCloseCommunication.Text = "Open/Close";
            this.button_OpenCloseCommunication.UseVisualStyleBackColor = true;
            this.button_OpenCloseCommunication.Click += new System.EventHandler(this.button_OpenCloseCommunication_Click);
            // 
            // button_ScanCommunication
            // 
            this.button_ScanCommunication.Location = new System.Drawing.Point(130, 39);
            this.button_ScanCommunication.Name = "button_ScanCommunication";
            this.button_ScanCommunication.Size = new System.Drawing.Size(75, 63);
            this.button_ScanCommunication.TabIndex = 4;
            this.button_ScanCommunication.Text = "Scan";
            this.button_ScanCommunication.UseVisualStyleBackColor = true;
            this.button_ScanCommunication.Click += new System.EventHandler(this.button_ScanCommunication_Click);
            // 
            // comboBox_Communication
            // 
            this.comboBox_Communication.FormattingEnabled = true;
            this.comboBox_Communication.Location = new System.Drawing.Point(28, 122);
            this.comboBox_Communication.Name = "comboBox_Communication";
            this.comboBox_Communication.Size = new System.Drawing.Size(177, 21);
            this.comboBox_Communication.TabIndex = 3;
            // 
            // radioButton_PCIe
            // 
            this.radioButton_PCIe.AutoSize = true;
            this.radioButton_PCIe.Location = new System.Drawing.Point(28, 85);
            this.radioButton_PCIe.Name = "radioButton_PCIe";
            this.radioButton_PCIe.Size = new System.Drawing.Size(48, 17);
            this.radioButton_PCIe.TabIndex = 2;
            this.radioButton_PCIe.TabStop = true;
            this.radioButton_PCIe.Text = "PCIe";
            this.radioButton_PCIe.UseVisualStyleBackColor = true;
            // 
            // radioButton_USB
            // 
            this.radioButton_USB.AutoSize = true;
            this.radioButton_USB.Location = new System.Drawing.Point(28, 62);
            this.radioButton_USB.Name = "radioButton_USB";
            this.radioButton_USB.Size = new System.Drawing.Size(47, 17);
            this.radioButton_USB.TabIndex = 1;
            this.radioButton_USB.TabStop = true;
            this.radioButton_USB.Text = "USB";
            this.radioButton_USB.UseVisualStyleBackColor = true;
            // 
            // radioButton_UART
            // 
            this.radioButton_UART.AutoSize = true;
            this.radioButton_UART.Location = new System.Drawing.Point(28, 39);
            this.radioButton_UART.Name = "radioButton_UART";
            this.radioButton_UART.Size = new System.Drawing.Size(55, 17);
            this.radioButton_UART.TabIndex = 0;
            this.radioButton_UART.TabStop = true;
            this.radioButton_UART.Text = "UART";
            this.radioButton_UART.UseVisualStyleBackColor = true;
            this.radioButton_UART.CheckedChanged += new System.EventHandler(this.radioButton_Communication_CheckedChanged);
            // 
            // tabAnalyzInCirc
            // 
            this.tabAnalyzInCirc.Controls.Add(this.tableLayoutPanel4);
            this.tabAnalyzInCirc.Location = new System.Drawing.Point(4, 22);
            this.tabAnalyzInCirc.Name = "tabAnalyzInCirc";
            this.tabAnalyzInCirc.Size = new System.Drawing.Size(1176, 550);
            this.tabAnalyzInCirc.TabIndex = 12;
            this.tabAnalyzInCirc.Text = "Analyzator";
            this.tabAnalyzInCirc.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 575F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridView_AnalyzData, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1176, 550);
            this.tableLayoutPanel4.TabIndex = 28;
            // 
            // dataGridView_AnalyzData
            // 
            this.dataGridView_AnalyzData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AnalyzData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_AnalyzData.Location = new System.Drawing.Point(578, 3);
            this.dataGridView_AnalyzData.Name = "dataGridView_AnalyzData";
            this.dataGridView_AnalyzData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_AnalyzData.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView_AnalyzData.Size = new System.Drawing.Size(595, 544);
            this.dataGridView_AnalyzData.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.groupBox16);
            this.panel7.Controls.Add(this.groupBox12);
            this.panel7.Controls.Add(this.groupBox_AnalyzTriggersBox);
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(569, 544);
            this.panel7.TabIndex = 28;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.comboBox_AnalyzInputsSel);
            this.groupBox16.Location = new System.Drawing.Point(298, 255);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(252, 80);
            this.groupBox16.TabIndex = 27;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Inputs:";
            // 
            // comboBox_AnalyzInputsSel
            // 
            this.comboBox_AnalyzInputsSel.FormattingEnabled = true;
            this.comboBox_AnalyzInputsSel.Location = new System.Drawing.Point(15, 33);
            this.comboBox_AnalyzInputsSel.Name = "comboBox_AnalyzInputsSel";
            this.comboBox_AnalyzInputsSel.Size = new System.Drawing.Size(219, 21);
            this.comboBox_AnalyzInputsSel.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label28);
            this.groupBox12.Controls.Add(this.label_DataReadState);
            this.groupBox12.Controls.Add(this.button_AnalyzClearList);
            this.groupBox12.Controls.Add(this.button_DataReadStop);
            this.groupBox12.Controls.Add(this.button_DataReadStart);
            this.groupBox12.Controls.Add(this.label_AnalyzEmpty);
            this.groupBox12.Location = new System.Drawing.Point(298, 25);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(252, 208);
            this.groupBox12.TabIndex = 26;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Data Read";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label28.Location = new System.Drawing.Point(31, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 15);
            this.label28.TabIndex = 26;
            this.label28.Text = "All FIFO:";
            // 
            // label_DataReadState
            // 
            this.label_DataReadState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_DataReadState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_DataReadState.Location = new System.Drawing.Point(92, 29);
            this.label_DataReadState.Name = "label_DataReadState";
            this.label_DataReadState.Size = new System.Drawing.Size(65, 25);
            this.label_DataReadState.TabIndex = 25;
            this.label_DataReadState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_AnalyzClearList
            // 
            this.button_AnalyzClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AnalyzClearList.Location = new System.Drawing.Point(15, 168);
            this.button_AnalyzClearList.Name = "button_AnalyzClearList";
            this.button_AnalyzClearList.Size = new System.Drawing.Size(219, 25);
            this.button_AnalyzClearList.TabIndex = 24;
            this.button_AnalyzClearList.Text = "Clear List";
            this.button_AnalyzClearList.UseVisualStyleBackColor = true;
            this.button_AnalyzClearList.Click += new System.EventHandler(this.button_AnalyzClearList_Click);
            // 
            // button_DataReadStop
            // 
            this.button_DataReadStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_DataReadStop.Location = new System.Drawing.Point(163, 29);
            this.button_DataReadStop.Name = "button_DataReadStop";
            this.button_DataReadStop.Size = new System.Drawing.Size(71, 25);
            this.button_DataReadStop.TabIndex = 24;
            this.button_DataReadStop.Text = "Stop";
            this.button_DataReadStop.UseVisualStyleBackColor = true;
            this.button_DataReadStop.Click += new System.EventHandler(this.button_DataReadStop_Click);
            // 
            // button_DataReadStart
            // 
            this.button_DataReadStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_DataReadStart.Location = new System.Drawing.Point(15, 29);
            this.button_DataReadStart.Name = "button_DataReadStart";
            this.button_DataReadStart.Size = new System.Drawing.Size(71, 25);
            this.button_DataReadStart.TabIndex = 23;
            this.button_DataReadStart.Text = "Start";
            this.button_DataReadStart.UseVisualStyleBackColor = true;
            this.button_DataReadStart.Click += new System.EventHandler(this.button_DataReadStart_Click);
            // 
            // label_AnalyzEmpty
            // 
            this.label_AnalyzEmpty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_AnalyzEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_AnalyzEmpty.Location = new System.Drawing.Point(92, 84);
            this.label_AnalyzEmpty.Name = "label_AnalyzEmpty";
            this.label_AnalyzEmpty.Size = new System.Drawing.Size(110, 24);
            this.label_AnalyzEmpty.TabIndex = 21;
            this.label_AnalyzEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_AnalyzTriggersBox
            // 
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_F_8);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_R_8);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_F_7);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_R_7);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_F_6);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_R_6);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_F_5);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_R_5);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_F_4);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_R_4);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_F_3);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_R_3);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_F_2);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_R_2);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_F_1);
            this.groupBox_AnalyzTriggersBox.Controls.Add(this.checkBox_AnalyzTrg_R_1);
            this.groupBox_AnalyzTriggersBox.Location = new System.Drawing.Point(15, 293);
            this.groupBox_AnalyzTriggersBox.Name = "groupBox_AnalyzTriggersBox";
            this.groupBox_AnalyzTriggersBox.Size = new System.Drawing.Size(252, 229);
            this.groupBox_AnalyzTriggersBox.TabIndex = 6;
            this.groupBox_AnalyzTriggersBox.TabStop = false;
            this.groupBox_AnalyzTriggersBox.Text = "Triggers";
            this.groupBox_AnalyzTriggersBox.Enter += new System.EventHandler(this.groupBox_AnalyzTriggersBox_Enter);
            // 
            // checkBox_AnalyzTrg_F_8
            // 
            this.checkBox_AnalyzTrg_F_8.AutoSize = true;
            this.checkBox_AnalyzTrg_F_8.Location = new System.Drawing.Point(140, 199);
            this.checkBox_AnalyzTrg_F_8.Name = "checkBox_AnalyzTrg_F_8";
            this.checkBox_AnalyzTrg_F_8.Size = new System.Drawing.Size(65, 17);
            this.checkBox_AnalyzTrg_F_8.TabIndex = 16;
            this.checkBox_AnalyzTrg_F_8.Text = "Falling 8";
            this.checkBox_AnalyzTrg_F_8.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_F_8.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_R_8
            // 
            this.checkBox_AnalyzTrg_R_8.AutoSize = true;
            this.checkBox_AnalyzTrg_R_8.Location = new System.Drawing.Point(16, 199);
            this.checkBox_AnalyzTrg_R_8.Name = "checkBox_AnalyzTrg_R_8";
            this.checkBox_AnalyzTrg_R_8.Size = new System.Drawing.Size(64, 17);
            this.checkBox_AnalyzTrg_R_8.TabIndex = 15;
            this.checkBox_AnalyzTrg_R_8.Text = "Rising 8";
            this.checkBox_AnalyzTrg_R_8.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_R_8.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_F_7
            // 
            this.checkBox_AnalyzTrg_F_7.AutoSize = true;
            this.checkBox_AnalyzTrg_F_7.Location = new System.Drawing.Point(140, 176);
            this.checkBox_AnalyzTrg_F_7.Name = "checkBox_AnalyzTrg_F_7";
            this.checkBox_AnalyzTrg_F_7.Size = new System.Drawing.Size(65, 17);
            this.checkBox_AnalyzTrg_F_7.TabIndex = 14;
            this.checkBox_AnalyzTrg_F_7.Text = "Falling 7";
            this.checkBox_AnalyzTrg_F_7.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_F_7.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_R_7
            // 
            this.checkBox_AnalyzTrg_R_7.AutoSize = true;
            this.checkBox_AnalyzTrg_R_7.Location = new System.Drawing.Point(16, 176);
            this.checkBox_AnalyzTrg_R_7.Name = "checkBox_AnalyzTrg_R_7";
            this.checkBox_AnalyzTrg_R_7.Size = new System.Drawing.Size(64, 17);
            this.checkBox_AnalyzTrg_R_7.TabIndex = 13;
            this.checkBox_AnalyzTrg_R_7.Text = "Rising 7";
            this.checkBox_AnalyzTrg_R_7.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_R_7.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_F_6
            // 
            this.checkBox_AnalyzTrg_F_6.AutoSize = true;
            this.checkBox_AnalyzTrg_F_6.Location = new System.Drawing.Point(140, 153);
            this.checkBox_AnalyzTrg_F_6.Name = "checkBox_AnalyzTrg_F_6";
            this.checkBox_AnalyzTrg_F_6.Size = new System.Drawing.Size(65, 17);
            this.checkBox_AnalyzTrg_F_6.TabIndex = 12;
            this.checkBox_AnalyzTrg_F_6.Text = "Falling 6";
            this.checkBox_AnalyzTrg_F_6.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_F_6.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_R_6
            // 
            this.checkBox_AnalyzTrg_R_6.AutoSize = true;
            this.checkBox_AnalyzTrg_R_6.Location = new System.Drawing.Point(16, 153);
            this.checkBox_AnalyzTrg_R_6.Name = "checkBox_AnalyzTrg_R_6";
            this.checkBox_AnalyzTrg_R_6.Size = new System.Drawing.Size(64, 17);
            this.checkBox_AnalyzTrg_R_6.TabIndex = 11;
            this.checkBox_AnalyzTrg_R_6.Text = "Rising 6";
            this.checkBox_AnalyzTrg_R_6.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_R_6.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_F_5
            // 
            this.checkBox_AnalyzTrg_F_5.AutoSize = true;
            this.checkBox_AnalyzTrg_F_5.Location = new System.Drawing.Point(140, 130);
            this.checkBox_AnalyzTrg_F_5.Name = "checkBox_AnalyzTrg_F_5";
            this.checkBox_AnalyzTrg_F_5.Size = new System.Drawing.Size(65, 17);
            this.checkBox_AnalyzTrg_F_5.TabIndex = 10;
            this.checkBox_AnalyzTrg_F_5.Text = "Falling 5";
            this.checkBox_AnalyzTrg_F_5.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_F_5.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_R_5
            // 
            this.checkBox_AnalyzTrg_R_5.AutoSize = true;
            this.checkBox_AnalyzTrg_R_5.Location = new System.Drawing.Point(16, 130);
            this.checkBox_AnalyzTrg_R_5.Name = "checkBox_AnalyzTrg_R_5";
            this.checkBox_AnalyzTrg_R_5.Size = new System.Drawing.Size(64, 17);
            this.checkBox_AnalyzTrg_R_5.TabIndex = 9;
            this.checkBox_AnalyzTrg_R_5.Text = "Rising 5";
            this.checkBox_AnalyzTrg_R_5.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_R_5.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_F_4
            // 
            this.checkBox_AnalyzTrg_F_4.AutoSize = true;
            this.checkBox_AnalyzTrg_F_4.Location = new System.Drawing.Point(140, 107);
            this.checkBox_AnalyzTrg_F_4.Name = "checkBox_AnalyzTrg_F_4";
            this.checkBox_AnalyzTrg_F_4.Size = new System.Drawing.Size(65, 17);
            this.checkBox_AnalyzTrg_F_4.TabIndex = 8;
            this.checkBox_AnalyzTrg_F_4.Text = "Falling 4";
            this.checkBox_AnalyzTrg_F_4.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_F_4.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_R_4
            // 
            this.checkBox_AnalyzTrg_R_4.AutoSize = true;
            this.checkBox_AnalyzTrg_R_4.Location = new System.Drawing.Point(16, 107);
            this.checkBox_AnalyzTrg_R_4.Name = "checkBox_AnalyzTrg_R_4";
            this.checkBox_AnalyzTrg_R_4.Size = new System.Drawing.Size(64, 17);
            this.checkBox_AnalyzTrg_R_4.TabIndex = 7;
            this.checkBox_AnalyzTrg_R_4.Text = "Rising 4";
            this.checkBox_AnalyzTrg_R_4.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_R_4.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_F_3
            // 
            this.checkBox_AnalyzTrg_F_3.AutoSize = true;
            this.checkBox_AnalyzTrg_F_3.Location = new System.Drawing.Point(140, 84);
            this.checkBox_AnalyzTrg_F_3.Name = "checkBox_AnalyzTrg_F_3";
            this.checkBox_AnalyzTrg_F_3.Size = new System.Drawing.Size(65, 17);
            this.checkBox_AnalyzTrg_F_3.TabIndex = 6;
            this.checkBox_AnalyzTrg_F_3.Text = "Falling 3";
            this.checkBox_AnalyzTrg_F_3.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_F_3.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_R_3
            // 
            this.checkBox_AnalyzTrg_R_3.AutoSize = true;
            this.checkBox_AnalyzTrg_R_3.Location = new System.Drawing.Point(16, 84);
            this.checkBox_AnalyzTrg_R_3.Name = "checkBox_AnalyzTrg_R_3";
            this.checkBox_AnalyzTrg_R_3.Size = new System.Drawing.Size(64, 17);
            this.checkBox_AnalyzTrg_R_3.TabIndex = 5;
            this.checkBox_AnalyzTrg_R_3.Text = "Rising 3";
            this.checkBox_AnalyzTrg_R_3.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_R_3.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_F_2
            // 
            this.checkBox_AnalyzTrg_F_2.AutoSize = true;
            this.checkBox_AnalyzTrg_F_2.Location = new System.Drawing.Point(140, 61);
            this.checkBox_AnalyzTrg_F_2.Name = "checkBox_AnalyzTrg_F_2";
            this.checkBox_AnalyzTrg_F_2.Size = new System.Drawing.Size(65, 17);
            this.checkBox_AnalyzTrg_F_2.TabIndex = 4;
            this.checkBox_AnalyzTrg_F_2.Text = "Falling 2";
            this.checkBox_AnalyzTrg_F_2.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_F_2.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_R_2
            // 
            this.checkBox_AnalyzTrg_R_2.AutoSize = true;
            this.checkBox_AnalyzTrg_R_2.Location = new System.Drawing.Point(16, 61);
            this.checkBox_AnalyzTrg_R_2.Name = "checkBox_AnalyzTrg_R_2";
            this.checkBox_AnalyzTrg_R_2.Size = new System.Drawing.Size(64, 17);
            this.checkBox_AnalyzTrg_R_2.TabIndex = 3;
            this.checkBox_AnalyzTrg_R_2.Text = "Rising 2";
            this.checkBox_AnalyzTrg_R_2.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_R_2.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_F_1
            // 
            this.checkBox_AnalyzTrg_F_1.AutoSize = true;
            this.checkBox_AnalyzTrg_F_1.Location = new System.Drawing.Point(140, 38);
            this.checkBox_AnalyzTrg_F_1.Name = "checkBox_AnalyzTrg_F_1";
            this.checkBox_AnalyzTrg_F_1.Size = new System.Drawing.Size(65, 17);
            this.checkBox_AnalyzTrg_F_1.TabIndex = 2;
            this.checkBox_AnalyzTrg_F_1.Text = "Falling 1";
            this.checkBox_AnalyzTrg_F_1.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_F_1.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // checkBox_AnalyzTrg_R_1
            // 
            this.checkBox_AnalyzTrg_R_1.AutoSize = true;
            this.checkBox_AnalyzTrg_R_1.Location = new System.Drawing.Point(16, 38);
            this.checkBox_AnalyzTrg_R_1.Name = "checkBox_AnalyzTrg_R_1";
            this.checkBox_AnalyzTrg_R_1.Size = new System.Drawing.Size(64, 17);
            this.checkBox_AnalyzTrg_R_1.TabIndex = 1;
            this.checkBox_AnalyzTrg_R_1.Text = "Rising 1";
            this.checkBox_AnalyzTrg_R_1.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzTrg_R_1.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzTrg_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label47);
            this.groupBox2.Controls.Add(this.label50);
            this.groupBox2.Controls.Add(this.numericUpDown_AnalyzTrgDelay);
            this.groupBox2.Controls.Add(this.label_AnalyzEnable);
            this.groupBox2.Controls.Add(this.button_AnalyzDisable);
            this.groupBox2.Controls.Add(this.button_AnalyzEnable);
            this.groupBox2.Controls.Add(this.button_AnalyzClear);
            this.groupBox2.Controls.Add(this.button_AnalyzSwStart);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.numericUpDown_AnalyzNumOfSamples);
            this.groupBox2.Location = new System.Drawing.Point(15, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 243);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analyzator Setting";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label47.Location = new System.Drawing.Point(9, 115);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(83, 15);
            this.label47.TabIndex = 28;
            this.label47.Text = "Trigger Delay:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label50.Location = new System.Drawing.Point(207, 115);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(35, 15);
            this.label50.TabIndex = 27;
            this.label50.Text = "clock";
            // 
            // numericUpDown_AnalyzTrgDelay
            // 
            this.numericUpDown_AnalyzTrgDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_AnalyzTrgDelay.Location = new System.Drawing.Point(137, 111);
            this.numericUpDown_AnalyzTrgDelay.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_AnalyzTrgDelay.Name = "numericUpDown_AnalyzTrgDelay";
            this.numericUpDown_AnalyzTrgDelay.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown_AnalyzTrgDelay.TabIndex = 26;
            this.numericUpDown_AnalyzTrgDelay.ValueChanged += new System.EventHandler(this.numericUpDown_AnalyzTrgDelay_ValueChanged);
            // 
            // label_AnalyzEnable
            // 
            this.label_AnalyzEnable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_AnalyzEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_AnalyzEnable.Location = new System.Drawing.Point(92, 29);
            this.label_AnalyzEnable.Name = "label_AnalyzEnable";
            this.label_AnalyzEnable.Size = new System.Drawing.Size(65, 25);
            this.label_AnalyzEnable.TabIndex = 25;
            this.label_AnalyzEnable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_AnalyzDisable
            // 
            this.button_AnalyzDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AnalyzDisable.Location = new System.Drawing.Point(163, 29);
            this.button_AnalyzDisable.Name = "button_AnalyzDisable";
            this.button_AnalyzDisable.Size = new System.Drawing.Size(71, 25);
            this.button_AnalyzDisable.TabIndex = 24;
            this.button_AnalyzDisable.Text = "Disable";
            this.button_AnalyzDisable.UseVisualStyleBackColor = true;
            this.button_AnalyzDisable.Click += new System.EventHandler(this.button_AnalyzDisable_Click);
            // 
            // button_AnalyzEnable
            // 
            this.button_AnalyzEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AnalyzEnable.Location = new System.Drawing.Point(15, 29);
            this.button_AnalyzEnable.Name = "button_AnalyzEnable";
            this.button_AnalyzEnable.Size = new System.Drawing.Size(71, 25);
            this.button_AnalyzEnable.TabIndex = 23;
            this.button_AnalyzEnable.Text = "Enable";
            this.button_AnalyzEnable.UseVisualStyleBackColor = true;
            this.button_AnalyzEnable.Click += new System.EventHandler(this.button_AnalyzEnable_Click);
            // 
            // button_AnalyzClear
            // 
            this.button_AnalyzClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AnalyzClear.Location = new System.Drawing.Point(35, 198);
            this.button_AnalyzClear.Name = "button_AnalyzClear";
            this.button_AnalyzClear.Size = new System.Drawing.Size(179, 25);
            this.button_AnalyzClear.TabIndex = 22;
            this.button_AnalyzClear.Text = "Clear";
            this.button_AnalyzClear.UseVisualStyleBackColor = true;
            this.button_AnalyzClear.Click += new System.EventHandler(this.button_AnalyzClear_Click);
            // 
            // button_AnalyzSwStart
            // 
            this.button_AnalyzSwStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AnalyzSwStart.Location = new System.Drawing.Point(35, 157);
            this.button_AnalyzSwStart.Name = "button_AnalyzSwStart";
            this.button_AnalyzSwStart.Size = new System.Drawing.Size(179, 25);
            this.button_AnalyzSwStart.TabIndex = 20;
            this.button_AnalyzSwStart.Text = "SW Start";
            this.button_AnalyzSwStart.UseVisualStyleBackColor = true;
            this.button_AnalyzSwStart.Click += new System.EventHandler(this.button_AnalyzSwStart_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(9, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 15);
            this.label19.TabIndex = 19;
            this.label19.Text = "Number of Samples:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.Location = new System.Drawing.Point(207, 82);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 15);
            this.label24.TabIndex = 18;
            this.label24.Text = "clock";
            // 
            // numericUpDown_AnalyzNumOfSamples
            // 
            this.numericUpDown_AnalyzNumOfSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_AnalyzNumOfSamples.Location = new System.Drawing.Point(137, 78);
            this.numericUpDown_AnalyzNumOfSamples.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_AnalyzNumOfSamples.Name = "numericUpDown_AnalyzNumOfSamples";
            this.numericUpDown_AnalyzNumOfSamples.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown_AnalyzNumOfSamples.TabIndex = 17;
            this.numericUpDown_AnalyzNumOfSamples.ValueChanged += new System.EventHandler(this.numericUpDown_AnalyzNumOfSamples_ValueChanged);
            // 
            // tabExtSignals
            // 
            this.tabExtSignals.Controls.Add(this.tableLayoutPanel5);
            this.tabExtSignals.Controls.Add(this.panel11);
            this.tabExtSignals.Location = new System.Drawing.Point(4, 22);
            this.tabExtSignals.Name = "tabExtSignals";
            this.tabExtSignals.Size = new System.Drawing.Size(1176, 550);
            this.tabExtSignals.TabIndex = 13;
            this.tabExtSignals.Text = "EXT Signals";
            this.tabExtSignals.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.dataGridView_ExtSignalsOutputs, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label44, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label45, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.dataGridView_ExtSignalsInputs, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(255, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(921, 550);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // dataGridView_ExtSignalsOutputs
            // 
            this.dataGridView_ExtSignalsOutputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ExtSignalsOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ExtSignalsOutputs.Location = new System.Drawing.Point(463, 23);
            this.dataGridView_ExtSignalsOutputs.Name = "dataGridView_ExtSignalsOutputs";
            this.dataGridView_ExtSignalsOutputs.Size = new System.Drawing.Size(455, 524);
            this.dataGridView_ExtSignalsOutputs.TabIndex = 35;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Dock = System.Windows.Forms.DockStyle.Top;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label44.Location = new System.Drawing.Point(3, 0);
            this.label44.Name = "label44";
            this.label44.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label44.Size = new System.Drawing.Size(454, 20);
            this.label44.TabIndex = 3;
            this.label44.Text = "External INPUTs";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Dock = System.Windows.Forms.DockStyle.Top;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label45.Location = new System.Drawing.Point(463, 0);
            this.label45.Name = "label45";
            this.label45.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label45.Size = new System.Drawing.Size(455, 20);
            this.label45.TabIndex = 1;
            this.label45.Text = "External OUTPUTs";
            // 
            // dataGridView_ExtSignalsInputs
            // 
            this.dataGridView_ExtSignalsInputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ExtSignalsInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ExtSignalsInputs.Location = new System.Drawing.Point(3, 23);
            this.dataGridView_ExtSignalsInputs.Name = "dataGridView_ExtSignalsInputs";
            this.dataGridView_ExtSignalsInputs.Size = new System.Drawing.Size(454, 524);
            this.dataGridView_ExtSignalsInputs.TabIndex = 33;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button_ExtSignalsWriteSetting);
            this.panel11.Controls.Add(this.button_ExtSignalsReadSetting);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(255, 550);
            this.panel11.TabIndex = 4;
            // 
            // button_ExtSignalsWriteSetting
            // 
            this.button_ExtSignalsWriteSetting.Location = new System.Drawing.Point(24, 95);
            this.button_ExtSignalsWriteSetting.Margin = new System.Windows.Forms.Padding(2);
            this.button_ExtSignalsWriteSetting.Name = "button_ExtSignalsWriteSetting";
            this.button_ExtSignalsWriteSetting.Size = new System.Drawing.Size(117, 37);
            this.button_ExtSignalsWriteSetting.TabIndex = 7;
            this.button_ExtSignalsWriteSetting.Text = "Write Setting";
            this.button_ExtSignalsWriteSetting.UseVisualStyleBackColor = true;
            this.button_ExtSignalsWriteSetting.Click += new System.EventHandler(this.button_ExtSignalsWriteSetting_Click);
            // 
            // button_ExtSignalsReadSetting
            // 
            this.button_ExtSignalsReadSetting.Location = new System.Drawing.Point(24, 29);
            this.button_ExtSignalsReadSetting.Margin = new System.Windows.Forms.Padding(2);
            this.button_ExtSignalsReadSetting.Name = "button_ExtSignalsReadSetting";
            this.button_ExtSignalsReadSetting.Size = new System.Drawing.Size(117, 37);
            this.button_ExtSignalsReadSetting.TabIndex = 6;
            this.button_ExtSignalsReadSetting.Text = "Read Setting";
            this.button_ExtSignalsReadSetting.UseVisualStyleBackColor = true;
            this.button_ExtSignalsReadSetting.Click += new System.EventHandler(this.button_ExtSignalsReadSetting_Click);
            // 
            // timerForm
            // 
            this.timerForm.Enabled = true;
            this.timerForm.Interval = 50;
            this.timerForm.Tick += new System.EventHandler(this.timerForm_Tick);
            // 
            // timerInfo
            // 
            this.timerInfo.Enabled = true;
            this.timerInfo.Interval = 2000;
            this.timerInfo.Tick += new System.EventHandler(this.timerInfo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.tabControl_MAIN);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Ultra High Speed Digitizer DAQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabRegisters.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox_RegBits.ResumeLayout(false);
            this.groupBox_RegBits.PerformLayout();
            this.tabControl_MAIN.ResumeLayout(false);
            this.tabManage.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox_LMXSync.ResumeLayout(false);
            this.groupBox_LMXSync.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_QS_Seed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_QS_Seed1)).EndInit();
            this.tabMeasurement_Setting.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time_usec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time_msec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcqThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcqRepeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time_sec)).EndInit();
            this.tabMeasurementData.ResumeLayout(false);
            this.tableLayoutPanel_MeasurementData.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EventsMaxCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_events)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tabControl_Events.ResumeLayout(false);
            this.tabPage_TimeChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_EventTime)).EndInit();
            this.tabPage_AnalyzeAdcPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EventAdcAnalyze)).EndInit();
            this.tabPage_AnalyzeSinPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EventSinAnalyze)).EndInit();
            this.tabGpio.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GpioOutputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GpioInputs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabReset.ResumeLayout(false);
            this.tabReset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resets)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabConfiguration.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MultipleConfigFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConfigFile)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tabSetting.ResumeLayout(false);
            this.tabSetting.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RegistersFiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabAnalyzInCirc.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AnalyzData)).EndInit();
            this.panel7.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox_AnalyzTriggersBox.ResumeLayout(false);
            this.groupBox_AnalyzTriggersBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AnalyzTrgDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AnalyzNumOfSamples)).EndInit();
            this.tabExtSignals.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExtSignalsOutputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExtSignalsInputs)).EndInit();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerRequest;
        private System.Windows.Forms.TabPage tabRegisters;
        private System.Windows.Forms.TabControl tabControl_RegistersSetting;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox_RegBits;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Button button_RegSaveAs;
        private System.Windows.Forms.Button button_RegLoadFromFile;
        private System.Windows.Forms.TabControl tabControl_MAIN;
        private System.Windows.Forms.TabPage tabMeasurement_Setting;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_AcqEventsPerTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumOfEvents;
        private System.Windows.Forms.NumericUpDown numericUpDown_Time_sec;
        private System.Windows.Forms.Button button_AcqStartStop;
        private System.Windows.Forms.RadioButton radioButton_AcqTime;
        private System.Windows.Forms.RadioButton radioButton_AcqNumEvents;
        private System.Windows.Forms.RadioButton radioButton_AcqInfinite;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_CountersClearAll;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_CounterInRunEvents;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_CounterProcessedEvents;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_CounterIncomingEvents;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox_SaveToRam;
        private System.Windows.Forms.Button button_OpenDataFile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_DataFilePath;
        private System.Windows.Forms.CheckBox checkBox_SaveToFile;
        private System.Windows.Forms.NumericUpDown numericUpDown_AcqRepeats;
        private System.Windows.Forms.CheckBox checkBox_Repeats;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox_TestGeneratorEnable;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown_AcqThreshold;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumOfSamples;
        private System.Windows.Forms.Label label_AcqState;
        private System.Windows.Forms.TabPage tabConfiguration;
        private System.Windows.Forms.Button button_RegSaveToFile;
        private System.Windows.Forms.Button button_RegWriteAll;
        private System.Windows.Forms.Button button_RegReadAll;
        private System.Windows.Forms.DataGridView dataGridView_ConfigFile;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_ConfigFileLoadFromFile;
        private System.Windows.Forms.Button button_ConfigFileSaveToFile;
        private System.Windows.Forms.Button button_ConfigFileSaveAs;
        private System.Windows.Forms.Button button_ConfigRun;
        private System.Windows.Forms.Button button_ConfigStop;
        private System.Windows.Forms.Label label_xRead;
        private System.Windows.Forms.Button button_xSend;
        private System.Windows.Forms.TextBox textBox_xSendByte0;
        private System.Windows.Forms.TextBox textBox_xSendByte1;
        private System.Windows.Forms.TextBox textBox_xSendByte2;
        private System.Windows.Forms.TextBox textBox_xSendByte3;
        private System.Windows.Forms.TabPage tabGpio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_GpioOutputs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_GpioInputs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_ClearRisingFalling;
        private System.Windows.Forms.Button button_AddNewConfig;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TabPage tabReset;
        private System.Windows.Forms.DataGridView dataGridView_Resets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_ResetClearAll;
        private System.Windows.Forms.TabPage tabMeasurementData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MeasurementData;
        private System.Windows.Forms.DataGridView dataGridView_events;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_EventsListClear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_EventTime;
        public System.Windows.Forms.Label label_dataErrors;
        private System.Windows.Forms.Button button_RegUpdateFromExtFile;
        private System.Windows.Forms.DataGridView dataGridView_MultipleConfigFiles;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_RemoveConfig;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label_RegDescription;
        private System.Windows.Forms.Label label_RegRW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_RegValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_RegBitSet0;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.TextBox textBox_RegAddress;
        private System.Windows.Forms.Button button_RegAddrFind;
        private System.Windows.Forms.TabPage tabManage;
        private System.Windows.Forms.GroupBox groupBox_LMXSync;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_QS_Phase2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label_QS_Phase1;
        private System.Windows.Forms.Button button_QS_Sync;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown_QS_Seed2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown_QS_Seed1;
        private System.Windows.Forms.Label label_QS_PLL_DEN1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label_QS_CHDIV1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label_QS_INC_DIV1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label_QS_CHDIV2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label_QS_INC_DIV2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label_QS_PLL_DEN2;
        private System.Windows.Forms.CheckBox checkBox_QS_FcalEn2;
        private System.Windows.Forms.CheckBox checkBox_QS_FcalEn1;
        private System.Windows.Forms.RadioButton radioButton_RegValDEC;
        private System.Windows.Forms.RadioButton radioButton_RegValHEX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton_RegAddrHEX;
        private System.Windows.Forms.RadioButton radioButton_RegAddrDEC;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timerForm;
        private System.Windows.Forms.TabPage tabAnalyzInCirc;
        private System.Windows.Forms.GroupBox groupBox_AnalyzTriggersBox;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_F_8;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_R_8;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_F_7;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_R_7;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_F_6;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_R_6;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_F_5;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_R_5;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_F_4;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_R_4;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_F_3;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_R_3;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_F_2;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_R_2;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_F_1;
        private System.Windows.Forms.CheckBox checkBox_AnalyzTrg_R_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_AnalyzSwStart;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown numericUpDown_AnalyzNumOfSamples;
        private System.Windows.Forms.Label label_AnalyzEmpty;
        private System.Windows.Forms.Button button_AnalyzClear;
        private System.Windows.Forms.Label label_AnalyzEnable;
        private System.Windows.Forms.Button button_AnalyzDisable;
        private System.Windows.Forms.Button button_AnalyzEnable;
        private System.Windows.Forms.Button button_AnalyzClearList;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label_DataReadState;
        private System.Windows.Forms.Button button_DataReadStop;
        private System.Windows.Forms.Button button_DataReadStart;
        private System.Windows.Forms.DataGridView dataGridView_AnalyzData;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button button_ddRead;
        private System.Windows.Forms.TextBox textBox_ddSpecNum;
        private System.Windows.Forms.Button button_ddWrite;
        public System.Windows.Forms.Label label_InQ;
        private System.Windows.Forms.CheckBox checkBox_cmdQuestions;
        public System.Windows.Forms.Label label_RecvBytes;
        public System.Windows.Forms.Label label_Test;
        private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dataGridView_RegistersFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_OpenCloseCommunication;
        private System.Windows.Forms.Button button_ScanCommunication;
        private System.Windows.Forms.ComboBox comboBox_Communication;
        private System.Windows.Forms.RadioButton radioButton_PCIe;
        private System.Windows.Forms.RadioButton radioButton_USB;
        private System.Windows.Forms.RadioButton radioButton_UART;
        private System.Windows.Forms.Label label32;
        public System.Windows.Forms.Label label_ddMyNum;
        private System.Windows.Forms.RadioButton radioButton_ddSpecNum;
        private System.Windows.Forms.RadioButton radioButton_ddSameAsComm;
        private System.Windows.Forms.RadioButton radioButton_ddNotSet;
        private System.Windows.Forms.CheckBox checkBox_xListen2;
        private System.Windows.Forms.CheckBox checkBox_xListen3;
        private System.Windows.Forms.Button button_ConfigDown;
        private System.Windows.Forms.Button button_ConfigUp;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.RadioButton radioButton_TrgSw;
        private System.Windows.Forms.RadioButton radioButton_TrgExtRisingNorm;
        private System.Windows.Forms.RadioButton radioButton_TrgSelf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radioButton_TrgAdcFd;
        private System.Windows.Forms.RadioButton radioButton_TrgExtFallingNorm;
        private System.Windows.Forms.CheckBox checkBox_DataTestMux;
        private System.Windows.Forms.Button button_EventsSaveEvent;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ListBox listBox_MainLog;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label_InfoAdcMaxTemp;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label_InfoAdcMinTemp;
        private System.Windows.Forms.Timer timerInfo;
        private System.Windows.Forms.Button button_Acq_SwTrigger;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label_InfoOnlineLMX2;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label_InfoOnlineLMX1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label_InfoOnlineHmc;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label_InfoOnlineAdc;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label_InfoLmx2Locked;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label_InfoLmx1Locked;
        private System.Windows.Forms.Label label_123;
        private System.Windows.Forms.Label label_InfoSyncib;
        private System.Windows.Forms.Label label_412;
        private System.Windows.Forms.Label label_InfoXcvrLanesLocked;
        private System.Windows.Forms.Label label_788;
        private System.Windows.Forms.Label label_InfoLogicRefPllsLocked;
        private System.Windows.Forms.Label label454;
        private System.Windows.Forms.Label label_InfoHmcPllsLocked;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label_InfoAdcClockDetect;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label_InfoAdcJtxPllLocked;
        private System.Windows.Forms.CheckBox checkBox_InfoPeriodicRead;
        private System.Windows.Forms.Label label36;
        public System.Windows.Forms.Label label_ddSetNum;
        private System.Windows.Forms.Button button_EventsAnalyzeAdc;
        private System.Windows.Forms.Button button_AnotherForm;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown numericUpDown_EventsMaxCount;
        private System.Windows.Forms.CheckBox checkBox_EventsMaxCount;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.CheckBox checkBox_EventsLastAutoSelect;
        private System.Windows.Forms.Button button_EventsClear;
        private System.Windows.Forms.CheckBox checkBox_EventsLastAutoAnalyze;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabControl_Events;
        private System.Windows.Forms.TabPage tabPage_TimeChart;
        private System.Windows.Forms.TabPage tabPage_AnalyzeAdcPicture;
        private System.Windows.Forms.PictureBox pictureBox_EventAdcAnalyze;
        private System.Windows.Forms.Button button_EventsLoadResult;
        private System.Windows.Forms.CheckBox checkBox_EventsAutoLoad;
        private System.Windows.Forms.Button button_RegReLoadFile;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.NumericUpDown numericUpDown_Time_msec;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.NumericUpDown numericUpDown_Time_usec;
        private System.Windows.Forms.TabPage tabExtSignals;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dataGridView_ExtSignalsInputs;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button_ExtSignalsReadSetting;
        private System.Windows.Forms.Button button_ExtSignalsWriteSetting;
        private System.Windows.Forms.DataGridView dataGridView_ExtSignalsOutputs;
        private System.Windows.Forms.Button button_EventsDeleteResults;
        private System.Windows.Forms.Button button_EventsAnalyzeSIN;
        private System.Windows.Forms.GroupBox groupBox_ManageActions;
        private System.Windows.Forms.TabPage tabPage_AnalyzeSinPicture;
        private System.Windows.Forms.PictureBox pictureBox_EventSinAnalyze;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label_errorCount;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label_comState;
        private System.Windows.Forms.Label label_StatusDataReadTask;
        private System.Windows.Forms.Label label_StatusTaskOfReadExecute_Data;
        private System.Windows.Forms.Label label_StatusTaskOfReadExecute_CMD;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.NumericUpDown numericUpDown_AnalyzTrgDelay;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.ComboBox comboBox_AnalyzInputsSel;
        private System.Windows.Forms.Button button_ConfigFileReloadFile;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.RadioButton radioButton_TrgExtFallingOver;
        private System.Windows.Forms.RadioButton radioButton_TrgExtRisingOver;
        private System.Windows.Forms.Label label_ConnectState;
        private System.Windows.Forms.CheckBox checkBox_logComm;
    }
}

