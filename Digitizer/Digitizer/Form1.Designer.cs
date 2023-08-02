
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_AcqState = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.timer_info = new System.Windows.Forms.Timer(this.components);
            this.tabRegisters = new System.Windows.Forms.TabPage();
            this.tabControl_RegistersSetting = new System.Windows.Forms.TabControl();
            this.tabPage_ADC = new System.Windows.Forms.TabPage();
            this.dataGridView_ADCReg = new System.Windows.Forms.DataGridView();
            this.tabPage_HMC = new System.Windows.Forms.TabPage();
            this.dataGridView_HMCReg = new System.Windows.Forms.DataGridView();
            this.tabPage_LMX1 = new System.Windows.Forms.TabPage();
            this.dataGridView_LMX1Reg = new System.Windows.Forms.DataGridView();
            this.tabPage_LMX2 = new System.Windows.Forms.TabPage();
            this.dataGridView_LMX2Reg = new System.Windows.Forms.DataGridView();
            this.tabPage_TestReg = new System.Windows.Forms.TabPage();
            this.dataGridView_TestReg = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_RegWriteAll = new System.Windows.Forms.Button();
            this.button_RegReadAll = new System.Windows.Forms.Button();
            this.button_RegSaveToFile = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.button_RegSaveAs = new System.Windows.Forms.Button();
            this.button_RegLoadFromFile = new System.Windows.Forms.Button();
            this.MeasurementData = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chart_data = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label_E = new System.Windows.Forms.Label();
            this.dataGridView_events = new System.Windows.Forms.DataGridView();
            this.dataGridView_data = new System.Windows.Forms.DataGridView();
            this.tabControl_MAIN = new System.Windows.Forms.TabControl();
            this.tabMeasurement_Setting = new System.Windows.Forms.TabPage();
            this.button_ReadAcqState = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox_TestGeneratorEnable = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_OpenDataFile = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_DataFilePath = new System.Windows.Forms.TextBox();
            this.checkBox_SaveToFile = new System.Windows.Forms.CheckBox();
            this.checkBox_SaveToRam = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_CountersClearAll = new System.Windows.Forms.Button();
            this.button_CountersClearInRun = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label_CounterInRunEvents = new System.Windows.Forms.Label();
            this.button_CountersClearProcessed = new System.Windows.Forms.Button();
            this.button_CountersClearIncoming = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label_CounterProcessedEvents = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_CounterIncomingEvents = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown_AcqThreshold = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.button_AcqStartStop = new System.Windows.Forms.Button();
            this.numericUpDown_NumOfSamples = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AcqRepeats = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Repeats = new System.Windows.Forms.CheckBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_NumOfEvents = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Time = new System.Windows.Forms.NumericUpDown();
            this.radioButton_AcqTime = new System.Windows.Forms.RadioButton();
            this.radioButton_AcqNumEvents = new System.Windows.Forms.RadioButton();
            this.radioButton_AcqInfinite = new System.Windows.Forms.RadioButton();
            this.Configuration = new System.Windows.Forms.TabPage();
            this.button_ConfigRun = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button_ConfigFileLoadFromFile = new System.Windows.Forms.Button();
            this.button_ConfigFileSaveToFile = new System.Windows.Forms.Button();
            this.button_ConfigFileSaveAs = new System.Windows.Forms.Button();
            this.dataGridView_ConfigFile = new System.Windows.Forms.DataGridView();
            this.Setting = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dataGridView_RegistersFiles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_OpenCloseCommunication = new System.Windows.Forms.Button();
            this.button_ScanCommunication = new System.Windows.Forms.Button();
            this.comboBox_Communication = new System.Windows.Forms.ComboBox();
            this.radioButton_PCIe = new System.Windows.Forms.RadioButton();
            this.radioButton_USB = new System.Windows.Forms.RadioButton();
            this.radioButton_UART = new System.Windows.Forms.RadioButton();
            this.label_Test = new System.Windows.Forms.Label();
            this.button_Test = new System.Windows.Forms.Button();
            this.button_led0on = new System.Windows.Forms.Button();
            this.button_led0off = new System.Windows.Forms.Button();
            this.button_led0tgl = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabRegisters.SuspendLayout();
            this.tabControl_RegistersSetting.SuspendLayout();
            this.tabPage_ADC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ADCReg)).BeginInit();
            this.tabPage_HMC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HMCReg)).BeginInit();
            this.tabPage_LMX1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LMX1Reg)).BeginInit();
            this.tabPage_LMX2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LMX2Reg)).BeginInit();
            this.tabPage_TestReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TestReg)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MeasurementData.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_events)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).BeginInit();
            this.tabControl_MAIN.SuspendLayout();
            this.tabMeasurement_Setting.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcqThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcqRepeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).BeginInit();
            this.Configuration.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConfigFile)).BeginInit();
            this.Setting.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RegistersFiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_AcqState);
            this.panel1.Controls.Add(this.button_Reset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 39);
            this.panel1.TabIndex = 0;
            // 
            // label_AcqState
            // 
            this.label_AcqState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_AcqState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_AcqState.Location = new System.Drawing.Point(225, 6);
            this.label_AcqState.Name = "label_AcqState";
            this.label_AcqState.Size = new System.Drawing.Size(123, 24);
            this.label_AcqState.TabIndex = 9;
            this.label_AcqState.Text = "........";
            this.label_AcqState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(1009, 7);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(67, 21);
            this.button_Reset.TabIndex = 8;
            this.button_Reset.Text = "RESET";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // timer_info
            // 
            this.timer_info.Enabled = true;
            this.timer_info.Tick += new System.EventHandler(this.timer_info_Tick);
            // 
            // tabRegisters
            // 
            this.tabRegisters.Controls.Add(this.tabControl_RegistersSetting);
            this.tabRegisters.Controls.Add(this.panel3);
            this.tabRegisters.Location = new System.Drawing.Point(4, 22);
            this.tabRegisters.Margin = new System.Windows.Forms.Padding(2);
            this.tabRegisters.Name = "tabRegisters";
            this.tabRegisters.Padding = new System.Windows.Forms.Padding(2);
            this.tabRegisters.Size = new System.Drawing.Size(1176, 546);
            this.tabRegisters.TabIndex = 4;
            this.tabRegisters.Text = "Registers";
            this.tabRegisters.UseVisualStyleBackColor = true;
            // 
            // tabControl_RegistersSetting
            // 
            this.tabControl_RegistersSetting.Controls.Add(this.tabPage_ADC);
            this.tabControl_RegistersSetting.Controls.Add(this.tabPage_HMC);
            this.tabControl_RegistersSetting.Controls.Add(this.tabPage_LMX1);
            this.tabControl_RegistersSetting.Controls.Add(this.tabPage_LMX2);
            this.tabControl_RegistersSetting.Controls.Add(this.tabPage_TestReg);
            this.tabControl_RegistersSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_RegistersSetting.Location = new System.Drawing.Point(222, 2);
            this.tabControl_RegistersSetting.Name = "tabControl_RegistersSetting";
            this.tabControl_RegistersSetting.SelectedIndex = 0;
            this.tabControl_RegistersSetting.Size = new System.Drawing.Size(952, 542);
            this.tabControl_RegistersSetting.TabIndex = 2;
            // 
            // tabPage_ADC
            // 
            this.tabPage_ADC.Controls.Add(this.dataGridView_ADCReg);
            this.tabPage_ADC.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ADC.Name = "tabPage_ADC";
            this.tabPage_ADC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ADC.Size = new System.Drawing.Size(944, 516);
            this.tabPage_ADC.TabIndex = 0;
            this.tabPage_ADC.Text = "ADC";
            this.tabPage_ADC.UseVisualStyleBackColor = true;
            // 
            // dataGridView_ADCReg
            // 
            this.dataGridView_ADCReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ADCReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ADCReg.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_ADCReg.Name = "dataGridView_ADCReg";
            this.dataGridView_ADCReg.Size = new System.Drawing.Size(938, 510);
            this.dataGridView_ADCReg.TabIndex = 0;
            this.dataGridView_ADCReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllRegistersGrids_CellContentClick);
            // 
            // tabPage_HMC
            // 
            this.tabPage_HMC.Controls.Add(this.dataGridView_HMCReg);
            this.tabPage_HMC.Location = new System.Drawing.Point(4, 22);
            this.tabPage_HMC.Name = "tabPage_HMC";
            this.tabPage_HMC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HMC.Size = new System.Drawing.Size(944, 516);
            this.tabPage_HMC.TabIndex = 1;
            this.tabPage_HMC.Text = "HMC";
            this.tabPage_HMC.UseVisualStyleBackColor = true;
            // 
            // dataGridView_HMCReg
            // 
            this.dataGridView_HMCReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HMCReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_HMCReg.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_HMCReg.Name = "dataGridView_HMCReg";
            this.dataGridView_HMCReg.Size = new System.Drawing.Size(938, 510);
            this.dataGridView_HMCReg.TabIndex = 1;
            this.dataGridView_HMCReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllRegistersGrids_CellContentClick);
            // 
            // tabPage_LMX1
            // 
            this.tabPage_LMX1.Controls.Add(this.dataGridView_LMX1Reg);
            this.tabPage_LMX1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_LMX1.Name = "tabPage_LMX1";
            this.tabPage_LMX1.Size = new System.Drawing.Size(944, 516);
            this.tabPage_LMX1.TabIndex = 2;
            this.tabPage_LMX1.Text = "LMX1";
            this.tabPage_LMX1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_LMX1Reg
            // 
            this.dataGridView_LMX1Reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LMX1Reg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_LMX1Reg.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_LMX1Reg.Name = "dataGridView_LMX1Reg";
            this.dataGridView_LMX1Reg.Size = new System.Drawing.Size(944, 516);
            this.dataGridView_LMX1Reg.TabIndex = 2;
            this.dataGridView_LMX1Reg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllRegistersGrids_CellContentClick);
            // 
            // tabPage_LMX2
            // 
            this.tabPage_LMX2.Controls.Add(this.dataGridView_LMX2Reg);
            this.tabPage_LMX2.Location = new System.Drawing.Point(4, 22);
            this.tabPage_LMX2.Name = "tabPage_LMX2";
            this.tabPage_LMX2.Size = new System.Drawing.Size(944, 516);
            this.tabPage_LMX2.TabIndex = 3;
            this.tabPage_LMX2.Text = "LMX2";
            this.tabPage_LMX2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_LMX2Reg
            // 
            this.dataGridView_LMX2Reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LMX2Reg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_LMX2Reg.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_LMX2Reg.Name = "dataGridView_LMX2Reg";
            this.dataGridView_LMX2Reg.Size = new System.Drawing.Size(944, 516);
            this.dataGridView_LMX2Reg.TabIndex = 2;
            this.dataGridView_LMX2Reg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllRegistersGrids_CellContentClick);
            // 
            // tabPage_TestReg
            // 
            this.tabPage_TestReg.Controls.Add(this.dataGridView_TestReg);
            this.tabPage_TestReg.Location = new System.Drawing.Point(4, 22);
            this.tabPage_TestReg.Name = "tabPage_TestReg";
            this.tabPage_TestReg.Size = new System.Drawing.Size(944, 516);
            this.tabPage_TestReg.TabIndex = 4;
            this.tabPage_TestReg.Text = "TestRegisters";
            this.tabPage_TestReg.UseVisualStyleBackColor = true;
            // 
            // dataGridView_TestReg
            // 
            this.dataGridView_TestReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TestReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_TestReg.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_TestReg.MultiSelect = false;
            this.dataGridView_TestReg.Name = "dataGridView_TestReg";
            this.dataGridView_TestReg.Size = new System.Drawing.Size(944, 516);
            this.dataGridView_TestReg.TabIndex = 3;
            this.dataGridView_TestReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllRegistersGrids_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_RegWriteAll);
            this.panel3.Controls.Add(this.button_RegReadAll);
            this.panel3.Controls.Add(this.button_RegSaveToFile);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.button_RegSaveAs);
            this.panel3.Controls.Add(this.button_RegLoadFromFile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 542);
            this.panel3.TabIndex = 1;
            // 
            // button_RegWriteAll
            // 
            this.button_RegWriteAll.Location = new System.Drawing.Point(132, 57);
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
            this.button_RegReadAll.Location = new System.Drawing.Point(132, 16);
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
            this.button_RegSaveToFile.Location = new System.Drawing.Point(13, 57);
            this.button_RegSaveToFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_RegSaveToFile.Name = "button_RegSaveToFile";
            this.button_RegSaveToFile.Size = new System.Drawing.Size(74, 37);
            this.button_RegSaveToFile.TabIndex = 5;
            this.button_RegSaveToFile.Text = "Save to File";
            this.button_RegSaveToFile.UseVisualStyleBackColor = true;
            this.button_RegSaveToFile.Click += new System.EventHandler(this.button_SaveToFile_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 295);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 20);
            this.textBox2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Location = new System.Drawing.Point(26, 329);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(78, 188);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bit Setting";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 161);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "0";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 142);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 33);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(32, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "7";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(12, 51);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(32, 17);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "6";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(12, 70);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(32, 17);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(12, 88);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(32, 17);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "4";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(12, 106);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(32, 17);
            this.checkBox7.TabIndex = 3;
            this.checkBox7.Text = "3";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(12, 124);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(32, 17);
            this.checkBox8.TabIndex = 2;
            this.checkBox8.Text = "2";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // button_RegSaveAs
            // 
            this.button_RegSaveAs.Location = new System.Drawing.Point(13, 98);
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
            // MeasurementData
            // 
            this.MeasurementData.Controls.Add(this.panel5);
            this.MeasurementData.Controls.Add(this.panel4);
            this.MeasurementData.Controls.Add(this.dataGridView_events);
            this.MeasurementData.Controls.Add(this.dataGridView_data);
            this.MeasurementData.Location = new System.Drawing.Point(4, 22);
            this.MeasurementData.Margin = new System.Windows.Forms.Padding(2);
            this.MeasurementData.Name = "MeasurementData";
            this.MeasurementData.Padding = new System.Windows.Forms.Padding(2);
            this.MeasurementData.Size = new System.Drawing.Size(1176, 546);
            this.MeasurementData.TabIndex = 1;
            this.MeasurementData.Text = "Measurement Data";
            this.MeasurementData.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chart_data);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 130);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel5.Size = new System.Drawing.Size(642, 414);
            this.panel5.TabIndex = 6;
            // 
            // chart_data
            // 
            this.chart_data.BorderlineColor = System.Drawing.Color.Black;
            this.chart_data.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chart_data.ChartAreas.Add(chartArea2);
            this.chart_data.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_data.Legends.Add(legend2);
            this.chart_data.Location = new System.Drawing.Point(0, 0);
            this.chart_data.Margin = new System.Windows.Forms.Padding(2);
            this.chart_data.Name = "chart_data";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Data";
            this.chart_data.Series.Add(series2);
            this.chart_data.Size = new System.Drawing.Size(637, 414);
            this.chart_data.TabIndex = 4;
            this.chart_data.Text = "chart_data";
            this.chart_data.Click += new System.EventHandler(this.chart_data_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.label_E);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(642, 128);
            this.panel4.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(468, 60);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 30);
            this.button8.TabIndex = 15;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(468, 21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 30);
            this.button7.TabIndex = 14;
            this.button7.Text = "Open Data File";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label_E
            // 
            this.label_E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_E.Location = new System.Drawing.Point(22, 34);
            this.label_E.Name = "label_E";
            this.label_E.Size = new System.Drawing.Size(243, 82);
            this.label_E.TabIndex = 13;
            this.label_E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_events
            // 
            this.dataGridView_events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_events.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_events.Location = new System.Drawing.Point(644, 2);
            this.dataGridView_events.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_events.Name = "dataGridView_events";
            this.dataGridView_events.RowHeadersWidth = 82;
            this.dataGridView_events.RowTemplate.Height = 33;
            this.dataGridView_events.Size = new System.Drawing.Size(265, 542);
            this.dataGridView_events.TabIndex = 4;
            // 
            // dataGridView_data
            // 
            this.dataGridView_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_data.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_data.Location = new System.Drawing.Point(909, 2);
            this.dataGridView_data.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_data.Name = "dataGridView_data";
            this.dataGridView_data.RowHeadersWidth = 82;
            this.dataGridView_data.RowTemplate.Height = 33;
            this.dataGridView_data.Size = new System.Drawing.Size(265, 542);
            this.dataGridView_data.TabIndex = 1;
            // 
            // tabControl_MAIN
            // 
            this.tabControl_MAIN.Controls.Add(this.tabMeasurement_Setting);
            this.tabControl_MAIN.Controls.Add(this.MeasurementData);
            this.tabControl_MAIN.Controls.Add(this.tabRegisters);
            this.tabControl_MAIN.Controls.Add(this.Configuration);
            this.tabControl_MAIN.Controls.Add(this.Setting);
            this.tabControl_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_MAIN.Location = new System.Drawing.Point(0, 39);
            this.tabControl_MAIN.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_MAIN.Name = "tabControl_MAIN";
            this.tabControl_MAIN.SelectedIndex = 0;
            this.tabControl_MAIN.Size = new System.Drawing.Size(1184, 572);
            this.tabControl_MAIN.TabIndex = 1;
            // 
            // tabMeasurement_Setting
            // 
            this.tabMeasurement_Setting.Controls.Add(this.button_ReadAcqState);
            this.tabMeasurement_Setting.Controls.Add(this.groupBox6);
            this.tabMeasurement_Setting.Controls.Add(this.groupBox5);
            this.tabMeasurement_Setting.Controls.Add(this.groupBox4);
            this.tabMeasurement_Setting.Controls.Add(this.groupBox3);
            this.tabMeasurement_Setting.Location = new System.Drawing.Point(4, 22);
            this.tabMeasurement_Setting.Name = "tabMeasurement_Setting";
            this.tabMeasurement_Setting.Size = new System.Drawing.Size(1176, 546);
            this.tabMeasurement_Setting.TabIndex = 7;
            this.tabMeasurement_Setting.Text = "Measurement Settings";
            this.tabMeasurement_Setting.UseVisualStyleBackColor = true;
            // 
            // button_ReadAcqState
            // 
            this.button_ReadAcqState.Location = new System.Drawing.Point(497, 441);
            this.button_ReadAcqState.Name = "button_ReadAcqState";
            this.button_ReadAcqState.Size = new System.Drawing.Size(75, 30);
            this.button_ReadAcqState.TabIndex = 5;
            this.button_ReadAcqState.Text = "Read";
            this.button_ReadAcqState.UseVisualStyleBackColor = true;
            this.button_ReadAcqState.Click += new System.EventHandler(this.button_ReadAcqState_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox_TestGeneratorEnable);
            this.groupBox6.Location = new System.Drawing.Point(512, 251);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(368, 158);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Others";
            // 
            // checkBox_TestGeneratorEnable
            // 
            this.checkBox_TestGeneratorEnable.AutoSize = true;
            this.checkBox_TestGeneratorEnable.Location = new System.Drawing.Point(35, 32);
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
            this.groupBox5.Location = new System.Drawing.Point(47, 362);
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
            this.checkBox_SaveToRam.Location = new System.Drawing.Point(35, 32);
            this.checkBox_SaveToRam.Name = "checkBox_SaveToRam";
            this.checkBox_SaveToRam.Size = new System.Drawing.Size(90, 17);
            this.checkBox_SaveToRam.TabIndex = 0;
            this.checkBox_SaveToRam.Text = "Save to RAM";
            this.checkBox_SaveToRam.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_CountersClearAll);
            this.groupBox4.Controls.Add(this.button_CountersClearInRun);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label_CounterInRunEvents);
            this.groupBox4.Controls.Add(this.button_CountersClearProcessed);
            this.groupBox4.Controls.Add(this.button_CountersClearIncoming);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label_CounterProcessedEvents);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label_CounterIncomingEvents);
            this.groupBox4.Location = new System.Drawing.Point(512, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 189);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Event Counters";
            // 
            // button_CountersClearAll
            // 
            this.button_CountersClearAll.Location = new System.Drawing.Point(18, 150);
            this.button_CountersClearAll.Name = "button_CountersClearAll";
            this.button_CountersClearAll.Size = new System.Drawing.Size(326, 23);
            this.button_CountersClearAll.TabIndex = 19;
            this.button_CountersClearAll.Text = "Clear All Counters";
            this.button_CountersClearAll.UseVisualStyleBackColor = true;
            // 
            // button_CountersClearInRun
            // 
            this.button_CountersClearInRun.Location = new System.Drawing.Point(303, 107);
            this.button_CountersClearInRun.Name = "button_CountersClearInRun";
            this.button_CountersClearInRun.Size = new System.Drawing.Size(57, 23);
            this.button_CountersClearInRun.TabIndex = 18;
            this.button_CountersClearInRun.Text = "Clear";
            this.button_CountersClearInRun.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(6, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "Processed Events in Run:";
            // 
            // label_CounterInRunEvents
            // 
            this.label_CounterInRunEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_CounterInRunEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CounterInRunEvents.Location = new System.Drawing.Point(158, 107);
            this.label_CounterInRunEvents.Name = "label_CounterInRunEvents";
            this.label_CounterInRunEvents.Size = new System.Drawing.Size(135, 23);
            this.label_CounterInRunEvents.TabIndex = 16;
            this.label_CounterInRunEvents.Text = "0";
            this.label_CounterInRunEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_CountersClearProcessed
            // 
            this.button_CountersClearProcessed.Location = new System.Drawing.Point(303, 66);
            this.button_CountersClearProcessed.Name = "button_CountersClearProcessed";
            this.button_CountersClearProcessed.Size = new System.Drawing.Size(57, 23);
            this.button_CountersClearProcessed.TabIndex = 15;
            this.button_CountersClearProcessed.Text = "Clear";
            this.button_CountersClearProcessed.UseVisualStyleBackColor = true;
            // 
            // button_CountersClearIncoming
            // 
            this.button_CountersClearIncoming.Location = new System.Drawing.Point(303, 25);
            this.button_CountersClearIncoming.Name = "button_CountersClearIncoming";
            this.button_CountersClearIncoming.Size = new System.Drawing.Size(57, 23);
            this.button_CountersClearIncoming.TabIndex = 14;
            this.button_CountersClearIncoming.Text = "Clear";
            this.button_CountersClearIncoming.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(29, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Processed Events All:";
            // 
            // label_CounterProcessedEvents
            // 
            this.label_CounterProcessedEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_CounterProcessedEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CounterProcessedEvents.Location = new System.Drawing.Point(158, 66);
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
            this.label11.Location = new System.Drawing.Point(36, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "All Incoming Events:";
            // 
            // label_CounterIncomingEvents
            // 
            this.label_CounterIncomingEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_CounterIncomingEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CounterIncomingEvents.Location = new System.Drawing.Point(158, 25);
            this.label_CounterIncomingEvents.Name = "label_CounterIncomingEvents";
            this.label_CounterIncomingEvents.Size = new System.Drawing.Size(135, 23);
            this.label_CounterIncomingEvents.TabIndex = 10;
            this.label_CounterIncomingEvents.Text = "0";
            this.label_CounterIncomingEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.numericUpDown_AcqThreshold);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.button_AcqStartStop);
            this.groupBox3.Controls.Add(this.numericUpDown_NumOfSamples);
            this.groupBox3.Controls.Add(this.numericUpDown_AcqRepeats);
            this.groupBox3.Controls.Add(this.checkBox_Repeats);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numericUpDown_NumOfEvents);
            this.groupBox3.Controls.Add(this.numericUpDown_Time);
            this.groupBox3.Controls.Add(this.radioButton_AcqTime);
            this.groupBox3.Controls.Add(this.radioButton_AcqNumEvents);
            this.groupBox3.Controls.Add(this.radioButton_AcqInfinite);
            this.groupBox3.Location = new System.Drawing.Point(47, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 317);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACQ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(95, 279);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 15);
            this.label18.TabIndex = 17;
            this.label18.Text = "Threshold:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(40, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "Number of Samples:";
            // 
            // numericUpDown_AcqThreshold
            // 
            this.numericUpDown_AcqThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_AcqThreshold.Location = new System.Drawing.Point(176, 277);
            this.numericUpDown_AcqThreshold.Maximum = new decimal(new int[] {
            1023,
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
            this.label16.Location = new System.Drawing.Point(302, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 15);
            this.label16.TabIndex = 14;
            this.label16.Text = "samples";
            // 
            // button_AcqStartStop
            // 
            this.button_AcqStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AcqStartStop.Location = new System.Drawing.Point(17, 27);
            this.button_AcqStartStop.Name = "button_AcqStartStop";
            this.button_AcqStartStop.Size = new System.Drawing.Size(326, 35);
            this.button_AcqStartStop.TabIndex = 5;
            this.button_AcqStartStop.Text = "Start";
            this.button_AcqStartStop.UseVisualStyleBackColor = true;
            this.button_AcqStartStop.Click += new System.EventHandler(this.button_AcqStartStop_Click);
            // 
            // numericUpDown_NumOfSamples
            // 
            this.numericUpDown_NumOfSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_NumOfSamples.Location = new System.Drawing.Point(176, 244);
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
            this.numericUpDown_AcqRepeats.Location = new System.Drawing.Point(176, 184);
            this.numericUpDown_AcqRepeats.Name = "numericUpDown_AcqRepeats";
            this.numericUpDown_AcqRepeats.Size = new System.Drawing.Size(71, 22);
            this.numericUpDown_AcqRepeats.TabIndex = 12;
            // 
            // checkBox_Repeats
            // 
            this.checkBox_Repeats.AutoSize = true;
            this.checkBox_Repeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_Repeats.Location = new System.Drawing.Point(98, 186);
            this.checkBox_Repeats.Name = "checkBox_Repeats";
            this.checkBox_Repeats.Size = new System.Drawing.Size(72, 19);
            this.checkBox_Repeats.TabIndex = 11;
            this.checkBox_Repeats.Text = "Repeats";
            this.checkBox_Repeats.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton4.Location = new System.Drawing.Point(176, 86);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(124, 20);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Events per Time";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(302, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "events";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(302, 151);
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
            this.numericUpDown_NumOfEvents.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_NumOfEvents.TabIndex = 7;
            this.numericUpDown_NumOfEvents.ValueChanged += new System.EventHandler(this.numericUpDown_NumOfEvents_ValueChanged);
            // 
            // numericUpDown_Time
            // 
            this.numericUpDown_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_Time.Location = new System.Drawing.Point(176, 147);
            this.numericUpDown_Time.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown_Time.Name = "numericUpDown_Time";
            this.numericUpDown_Time.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_Time.TabIndex = 6;
            this.numericUpDown_Time.ValueChanged += new System.EventHandler(this.numericUpDown_Time_ValueChanged);
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
            // Configuration
            // 
            this.Configuration.Controls.Add(this.button_ConfigRun);
            this.Configuration.Controls.Add(this.groupBox7);
            this.Configuration.Controls.Add(this.dataGridView_ConfigFile);
            this.Configuration.Location = new System.Drawing.Point(4, 22);
            this.Configuration.Name = "Configuration";
            this.Configuration.Size = new System.Drawing.Size(1176, 546);
            this.Configuration.TabIndex = 8;
            this.Configuration.Text = "Configuration";
            this.Configuration.UseVisualStyleBackColor = true;
            // 
            // button_ConfigRun
            // 
            this.button_ConfigRun.Location = new System.Drawing.Point(219, 94);
            this.button_ConfigRun.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigRun.Name = "button_ConfigRun";
            this.button_ConfigRun.Size = new System.Drawing.Size(74, 37);
            this.button_ConfigRun.TabIndex = 13;
            this.button_ConfigRun.Text = "Config Run";
            this.button_ConfigRun.UseVisualStyleBackColor = true;
            this.button_ConfigRun.Click += new System.EventHandler(this.button_ConfigRun_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button_ConfigFileLoadFromFile);
            this.groupBox7.Controls.Add(this.button_ConfigFileSaveToFile);
            this.groupBox7.Controls.Add(this.button_ConfigFileSaveAs);
            this.groupBox7.Location = new System.Drawing.Point(62, 57);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(127, 178);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Configuration File";
            // 
            // button_ConfigFileLoadFromFile
            // 
            this.button_ConfigFileLoadFromFile.Location = new System.Drawing.Point(26, 37);
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
            this.button_ConfigFileSaveToFile.Location = new System.Drawing.Point(26, 78);
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
            this.button_ConfigFileSaveAs.Location = new System.Drawing.Point(26, 119);
            this.button_ConfigFileSaveAs.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConfigFileSaveAs.Name = "button_ConfigFileSaveAs";
            this.button_ConfigFileSaveAs.Size = new System.Drawing.Size(74, 37);
            this.button_ConfigFileSaveAs.TabIndex = 10;
            this.button_ConfigFileSaveAs.Text = "Save As";
            this.button_ConfigFileSaveAs.UseVisualStyleBackColor = true;
            this.button_ConfigFileSaveAs.Click += new System.EventHandler(this.button_ConfigFileSaveAs_Click);
            // 
            // dataGridView_ConfigFile
            // 
            this.dataGridView_ConfigFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ConfigFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_ConfigFile.Location = new System.Drawing.Point(489, 0);
            this.dataGridView_ConfigFile.Name = "dataGridView_ConfigFile";
            this.dataGridView_ConfigFile.Size = new System.Drawing.Size(687, 546);
            this.dataGridView_ConfigFile.TabIndex = 2;
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.button_led0tgl);
            this.Setting.Controls.Add(this.button_led0off);
            this.Setting.Controls.Add(this.button_led0on);
            this.Setting.Controls.Add(this.label_Test);
            this.Setting.Controls.Add(this.button_Test);
            this.Setting.Controls.Add(this.groupBox8);
            this.Setting.Controls.Add(this.groupBox1);
            this.Setting.Location = new System.Drawing.Point(4, 22);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(1176, 546);
            this.Setting.TabIndex = 6;
            this.Setting.Text = "System Setting";
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dataGridView_RegistersFiles);
            this.groupBox8.Location = new System.Drawing.Point(775, 24);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(372, 495);
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
            this.dataGridView_RegistersFiles.Size = new System.Drawing.Size(366, 476);
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
            this.button_OpenCloseCommunication.Location = new System.Drawing.Point(28, 166);
            this.button_OpenCloseCommunication.Name = "button_OpenCloseCommunication";
            this.button_OpenCloseCommunication.Size = new System.Drawing.Size(177, 35);
            this.button_OpenCloseCommunication.TabIndex = 5;
            this.button_OpenCloseCommunication.Text = "Open/Close";
            this.button_OpenCloseCommunication.UseVisualStyleBackColor = true;
            this.button_OpenCloseCommunication.Click += new System.EventHandler(this.button_OpenCloseCommunication_Click);
            // 
            // button_ScanCommunication
            // 
            this.button_ScanCommunication.Location = new System.Drawing.Point(130, 47);
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
            this.comboBox_Communication.Location = new System.Drawing.Point(28, 130);
            this.comboBox_Communication.Name = "comboBox_Communication";
            this.comboBox_Communication.Size = new System.Drawing.Size(177, 21);
            this.comboBox_Communication.TabIndex = 3;
            // 
            // radioButton_PCIe
            // 
            this.radioButton_PCIe.AutoSize = true;
            this.radioButton_PCIe.Location = new System.Drawing.Point(28, 93);
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
            this.radioButton_USB.Location = new System.Drawing.Point(28, 70);
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
            this.radioButton_UART.Location = new System.Drawing.Point(28, 47);
            this.radioButton_UART.Name = "radioButton_UART";
            this.radioButton_UART.Size = new System.Drawing.Size(55, 17);
            this.radioButton_UART.TabIndex = 0;
            this.radioButton_UART.TabStop = true;
            this.radioButton_UART.Text = "UART";
            this.radioButton_UART.UseVisualStyleBackColor = true;
            this.radioButton_UART.CheckedChanged += new System.EventHandler(this.radioButton_Communication_CheckedChanged);
            // 
            // label_Test
            // 
            this.label_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Test.Location = new System.Drawing.Point(164, 290);
            this.label_Test.Name = "label_Test";
            this.label_Test.Size = new System.Drawing.Size(83, 21);
            this.label_Test.TabIndex = 4;
            this.label_Test.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Test.Click += new System.EventHandler(this.label_Test_Click);
            // 
            // button_Test
            // 
            this.button_Test.Location = new System.Drawing.Point(81, 290);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(75, 21);
            this.button_Test.TabIndex = 5;
            this.button_Test.Text = "Test";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // button_led0on
            // 
            this.button_led0on.Location = new System.Drawing.Point(350, 59);
            this.button_led0on.Name = "button_led0on";
            this.button_led0on.Size = new System.Drawing.Size(75, 21);
            this.button_led0on.TabIndex = 6;
            this.button_led0on.Text = "led on";
            this.button_led0on.UseVisualStyleBackColor = true;
            this.button_led0on.Click += new System.EventHandler(this.button_led0);
            // 
            // button_led0off
            // 
            this.button_led0off.Location = new System.Drawing.Point(431, 59);
            this.button_led0off.Name = "button_led0off";
            this.button_led0off.Size = new System.Drawing.Size(75, 21);
            this.button_led0off.TabIndex = 7;
            this.button_led0off.Text = "led off";
            this.button_led0off.UseVisualStyleBackColor = true;
            this.button_led0off.Click += new System.EventHandler(this.button_led0);
            // 
            // button_led0tgl
            // 
            this.button_led0tgl.Location = new System.Drawing.Point(528, 59);
            this.button_led0tgl.Name = "button_led0tgl";
            this.button_led0tgl.Size = new System.Drawing.Size(75, 21);
            this.button_led0tgl.TabIndex = 8;
            this.button_led0tgl.Text = "led toogle";
            this.button_led0tgl.UseVisualStyleBackColor = true;
            this.button_led0tgl.Click += new System.EventHandler(this.button_led0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.tabControl_MAIN);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.tabRegisters.ResumeLayout(false);
            this.tabControl_RegistersSetting.ResumeLayout(false);
            this.tabPage_ADC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ADCReg)).EndInit();
            this.tabPage_HMC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HMCReg)).EndInit();
            this.tabPage_LMX1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LMX1Reg)).EndInit();
            this.tabPage_LMX2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LMX2Reg)).EndInit();
            this.tabPage_TestReg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TestReg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.MeasurementData.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_events)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).EndInit();
            this.tabControl_MAIN.ResumeLayout(false);
            this.tabMeasurement_Setting.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcqThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AcqRepeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumOfEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).EndInit();
            this.Configuration.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ConfigFile)).EndInit();
            this.Setting.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RegistersFiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer_info;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.TabPage tabRegisters;
        private System.Windows.Forms.TabControl tabControl_RegistersSetting;
        private System.Windows.Forms.TabPage tabPage_ADC;
        private System.Windows.Forms.DataGridView dataGridView_ADCReg;
        private System.Windows.Forms.TabPage tabPage_HMC;
        private System.Windows.Forms.DataGridView dataGridView_HMCReg;
        private System.Windows.Forms.TabPage tabPage_LMX1;
        private System.Windows.Forms.DataGridView dataGridView_LMX1Reg;
        private System.Windows.Forms.TabPage tabPage_LMX2;
        private System.Windows.Forms.DataGridView dataGridView_LMX2Reg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.TabPage MeasurementData;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_data;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label_E;
        private System.Windows.Forms.DataGridView dataGridView_events;
        private System.Windows.Forms.DataGridView dataGridView_data;
        private System.Windows.Forms.TabControl tabControl_MAIN;
        private System.Windows.Forms.TabPage tabPage_TestReg;
        private System.Windows.Forms.DataGridView dataGridView_TestReg;
        private System.Windows.Forms.TabPage Setting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_OpenCloseCommunication;
        private System.Windows.Forms.Button button_ScanCommunication;
        private System.Windows.Forms.ComboBox comboBox_Communication;
        private System.Windows.Forms.RadioButton radioButton_PCIe;
        private System.Windows.Forms.RadioButton radioButton_USB;
        private System.Windows.Forms.RadioButton radioButton_UART;
        private System.Windows.Forms.TabPage tabMeasurement_Setting;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumOfEvents;
        private System.Windows.Forms.NumericUpDown numericUpDown_Time;
        private System.Windows.Forms.Button button_AcqStartStop;
        private System.Windows.Forms.RadioButton radioButton_AcqTime;
        private System.Windows.Forms.RadioButton radioButton_AcqNumEvents;
        private System.Windows.Forms.RadioButton radioButton_AcqInfinite;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_CountersClearAll;
        private System.Windows.Forms.Button button_CountersClearInRun;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_CounterInRunEvents;
        private System.Windows.Forms.Button button_CountersClearProcessed;
        private System.Windows.Forms.Button button_CountersClearIncoming;
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
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox_TestGeneratorEnable;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown_AcqThreshold;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumOfSamples;
        private System.Windows.Forms.Label label_AcqState;
        private System.Windows.Forms.Button button_ReadAcqState;
        private System.Windows.Forms.TabPage Configuration;
        private System.Windows.Forms.Button button_RegSaveToFile;
        private System.Windows.Forms.Button button_RegWriteAll;
        private System.Windows.Forms.Button button_RegReadAll;
        private System.Windows.Forms.DataGridView dataGridView_ConfigFile;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_ConfigFileLoadFromFile;
        private System.Windows.Forms.Button button_ConfigFileSaveToFile;
        private System.Windows.Forms.Button button_ConfigFileSaveAs;
        private System.Windows.Forms.Button button_ConfigRun;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dataGridView_RegistersFiles;
        public System.Windows.Forms.Label label_Test;
        private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.Button button_led0off;
        private System.Windows.Forms.Button button_led0on;
        private System.Windows.Forms.Button button_led0tgl;
    }
}

