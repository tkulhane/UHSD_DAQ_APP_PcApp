
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown_testPeriod = new System.Windows.Forms.NumericUpDown();
            this.label_TestResult = new System.Windows.Forms.Label();
            this.button_ValidateTest = new System.Windows.Forms.Button();
            this.button_AutoTest = new System.Windows.Forms.Button();
            this.label_Test = new System.Windows.Forms.Label();
            this.button_Test = new System.Windows.Forms.Button();
            this.button_OpenClose = new System.Windows.Forms.Button();
            this.comboBox_Ports = new System.Windows.Forms.ComboBox();
            this.button_Scan = new System.Windows.Forms.Button();
            this.tabControl_MAIN = new System.Windows.Forms.TabControl();
            this.Measurement = new System.Windows.Forms.TabPage();
            this.button_datatest = new System.Windows.Forms.Button();
            this.dataGridView_data = new System.Windows.Forms.DataGridView();
            this.ADC_Registers = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_bit_0 = new System.Windows.Forms.CheckBox();
            this.checkBox_bit_1 = new System.Windows.Forms.CheckBox();
            this.checkBox_bit_7 = new System.Windows.Forms.CheckBox();
            this.checkBox_bit_6 = new System.Windows.Forms.CheckBox();
            this.checkBox_bit_5 = new System.Windows.Forms.CheckBox();
            this.checkBox_bit_4 = new System.Windows.Forms.CheckBox();
            this.checkBox_bit_3 = new System.Windows.Forms.CheckBox();
            this.checkBox_bit_2 = new System.Windows.Forms.CheckBox();
            this.button_SaveToFile = new System.Windows.Forms.Button();
            this.button_LoadFromFile = new System.Windows.Forms.Button();
            this.dataGridView_ADCregisters = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.button_SaveToFile_FPGAregisters = new System.Windows.Forms.Button();
            this.button_LoadFromFile_FPGAregisters = new System.Windows.Forms.Button();
            this.dataGridView_FPGAregisters = new System.Windows.Forms.DataGridView();
            this.timer_info = new System.Windows.Forms.Timer(this.components);
            this.timer_AutoTest = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox_TRG_Enable = new System.Windows.Forms.CheckBox();
            this.checkBox_TRG_TestGen_Enable = new System.Windows.Forms.CheckBox();
            this.numericUpDown_Threshold = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Num_Of_Samples = new System.Windows.Forms.NumericUpDown();
            this.label_Incoming_Events = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Processed_Events = new System.Windows.Forms.Label();
            this.button_TRG_Read_Conters = new System.Windows.Forms.Button();
            this.button_Clear_Counters = new System.Windows.Forms.Button();
            this.button_Read_Setting = new System.Windows.Forms.Button();
            this.label_dbg1 = new System.Windows.Forms.Label();
            this.label_dbg2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_set_num_of_events = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_testPeriod)).BeginInit();
            this.tabControl_MAIN.SuspendLayout();
            this.Measurement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).BeginInit();
            this.ADC_Registers.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ADCregisters)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FPGAregisters)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Num_Of_Samples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_set_num_of_events)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Reset);
            this.panel1.Controls.Add(this.numericUpDown_testPeriod);
            this.panel1.Controls.Add(this.label_TestResult);
            this.panel1.Controls.Add(this.button_ValidateTest);
            this.panel1.Controls.Add(this.button_AutoTest);
            this.panel1.Controls.Add(this.label_Test);
            this.panel1.Controls.Add(this.button_Test);
            this.panel1.Controls.Add(this.button_OpenClose);
            this.panel1.Controls.Add(this.comboBox_Ports);
            this.panel1.Controls.Add(this.button_Scan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 39);
            this.panel1.TabIndex = 0;
            // 
            // numericUpDown_testPeriod
            // 
            this.numericUpDown_testPeriod.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_testPeriod.Location = new System.Drawing.Point(863, 7);
            this.numericUpDown_testPeriod.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_testPeriod.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown_testPeriod.Name = "numericUpDown_testPeriod";
            this.numericUpDown_testPeriod.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown_testPeriod.TabIndex = 7;
            this.numericUpDown_testPeriod.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown_testPeriod.ValueChanged += new System.EventHandler(this.numericUpDown_testPeriod_ValueChanged);
            // 
            // label_TestResult
            // 
            this.label_TestResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_TestResult.Location = new System.Drawing.Point(703, 7);
            this.label_TestResult.Name = "label_TestResult";
            this.label_TestResult.Size = new System.Drawing.Size(140, 21);
            this.label_TestResult.TabIndex = 6;
            this.label_TestResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ValidateTest
            // 
            this.button_ValidateTest.Location = new System.Drawing.Point(602, 7);
            this.button_ValidateTest.Name = "button_ValidateTest";
            this.button_ValidateTest.Size = new System.Drawing.Size(95, 21);
            this.button_ValidateTest.TabIndex = 5;
            this.button_ValidateTest.Text = "Validate Test";
            this.button_ValidateTest.UseVisualStyleBackColor = true;
            this.button_ValidateTest.Click += new System.EventHandler(this.button_ValidateTest_Click);
            // 
            // button_AutoTest
            // 
            this.button_AutoTest.Location = new System.Drawing.Point(521, 7);
            this.button_AutoTest.Name = "button_AutoTest";
            this.button_AutoTest.Size = new System.Drawing.Size(75, 21);
            this.button_AutoTest.TabIndex = 4;
            this.button_AutoTest.Text = "Auto Test";
            this.button_AutoTest.UseVisualStyleBackColor = true;
            this.button_AutoTest.Click += new System.EventHandler(this.button_AutoTest_Click);
            // 
            // label_Test
            // 
            this.label_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Test.Location = new System.Drawing.Point(393, 7);
            this.label_Test.Name = "label_Test";
            this.label_Test.Size = new System.Drawing.Size(83, 21);
            this.label_Test.TabIndex = 0;
            this.label_Test.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Test.Click += new System.EventHandler(this.label_Test_Click);
            // 
            // button_Test
            // 
            this.button_Test.Location = new System.Drawing.Point(310, 7);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(75, 21);
            this.button_Test.TabIndex = 3;
            this.button_Test.Text = "Test";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // button_OpenClose
            // 
            this.button_OpenClose.Location = new System.Drawing.Point(196, 7);
            this.button_OpenClose.Name = "button_OpenClose";
            this.button_OpenClose.Size = new System.Drawing.Size(75, 21);
            this.button_OpenClose.TabIndex = 2;
            this.button_OpenClose.Text = "Open/Close";
            this.button_OpenClose.UseVisualStyleBackColor = true;
            this.button_OpenClose.Click += new System.EventHandler(this.button_OpenClose_Click);
            // 
            // comboBox_Ports
            // 
            this.comboBox_Ports.FormattingEnabled = true;
            this.comboBox_Ports.Location = new System.Drawing.Point(93, 7);
            this.comboBox_Ports.Name = "comboBox_Ports";
            this.comboBox_Ports.Size = new System.Drawing.Size(97, 21);
            this.comboBox_Ports.TabIndex = 1;
            // 
            // button_Scan
            // 
            this.button_Scan.Location = new System.Drawing.Point(12, 7);
            this.button_Scan.Name = "button_Scan";
            this.button_Scan.Size = new System.Drawing.Size(75, 21);
            this.button_Scan.TabIndex = 0;
            this.button_Scan.Text = "Scan";
            this.button_Scan.UseVisualStyleBackColor = true;
            this.button_Scan.Click += new System.EventHandler(this.button_Scan_Click);
            // 
            // tabControl_MAIN
            // 
            this.tabControl_MAIN.Controls.Add(this.Measurement);
            this.tabControl_MAIN.Controls.Add(this.ADC_Registers);
            this.tabControl_MAIN.Controls.Add(this.tabPage2);
            this.tabControl_MAIN.Controls.Add(this.tabPage1);
            this.tabControl_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_MAIN.Location = new System.Drawing.Point(0, 39);
            this.tabControl_MAIN.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_MAIN.Name = "tabControl_MAIN";
            this.tabControl_MAIN.SelectedIndex = 0;
            this.tabControl_MAIN.Size = new System.Drawing.Size(1102, 570);
            this.tabControl_MAIN.TabIndex = 1;
            // 
            // Measurement
            // 
            this.Measurement.Controls.Add(this.button_datatest);
            this.Measurement.Controls.Add(this.dataGridView_data);
            this.Measurement.Location = new System.Drawing.Point(4, 22);
            this.Measurement.Margin = new System.Windows.Forms.Padding(2);
            this.Measurement.Name = "Measurement";
            this.Measurement.Padding = new System.Windows.Forms.Padding(2);
            this.Measurement.Size = new System.Drawing.Size(1094, 544);
            this.Measurement.TabIndex = 1;
            this.Measurement.Text = "Measurement";
            this.Measurement.UseVisualStyleBackColor = true;
            // 
            // button_datatest
            // 
            this.button_datatest.Location = new System.Drawing.Point(24, 33);
            this.button_datatest.Name = "button_datatest";
            this.button_datatest.Size = new System.Drawing.Size(75, 21);
            this.button_datatest.TabIndex = 2;
            this.button_datatest.Text = "ADD";
            this.button_datatest.UseVisualStyleBackColor = true;
            this.button_datatest.Click += new System.EventHandler(this.button_datatest_Click);
            // 
            // dataGridView_data
            // 
            this.dataGridView_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_data.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_data.Location = new System.Drawing.Point(486, 2);
            this.dataGridView_data.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_data.Name = "dataGridView_data";
            this.dataGridView_data.RowHeadersWidth = 82;
            this.dataGridView_data.RowTemplate.Height = 33;
            this.dataGridView_data.Size = new System.Drawing.Size(606, 540);
            this.dataGridView_data.TabIndex = 1;
            // 
            // ADC_Registers
            // 
            this.ADC_Registers.Controls.Add(this.panel2);
            this.ADC_Registers.Controls.Add(this.dataGridView_ADCregisters);
            this.ADC_Registers.Location = new System.Drawing.Point(4, 22);
            this.ADC_Registers.Margin = new System.Windows.Forms.Padding(2);
            this.ADC_Registers.Name = "ADC_Registers";
            this.ADC_Registers.Padding = new System.Windows.Forms.Padding(2);
            this.ADC_Registers.Size = new System.Drawing.Size(1094, 544);
            this.ADC_Registers.TabIndex = 2;
            this.ADC_Registers.Text = "ADC Registers";
            this.ADC_Registers.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button_SaveToFile);
            this.panel2.Controls.Add(this.button_LoadFromFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 540);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 295);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_bit_0);
            this.groupBox1.Controls.Add(this.checkBox_bit_1);
            this.groupBox1.Controls.Add(this.checkBox_bit_7);
            this.groupBox1.Controls.Add(this.checkBox_bit_6);
            this.groupBox1.Controls.Add(this.checkBox_bit_5);
            this.groupBox1.Controls.Add(this.checkBox_bit_4);
            this.groupBox1.Controls.Add(this.checkBox_bit_3);
            this.groupBox1.Controls.Add(this.checkBox_bit_2);
            this.groupBox1.Location = new System.Drawing.Point(26, 329);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(78, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bit Setting";
            // 
            // checkBox_bit_0
            // 
            this.checkBox_bit_0.AutoSize = true;
            this.checkBox_bit_0.Location = new System.Drawing.Point(12, 161);
            this.checkBox_bit_0.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_bit_0.Name = "checkBox_bit_0";
            this.checkBox_bit_0.Size = new System.Drawing.Size(32, 17);
            this.checkBox_bit_0.TabIndex = 9;
            this.checkBox_bit_0.Text = "0";
            this.checkBox_bit_0.UseVisualStyleBackColor = true;
            // 
            // checkBox_bit_1
            // 
            this.checkBox_bit_1.AutoSize = true;
            this.checkBox_bit_1.Location = new System.Drawing.Point(12, 142);
            this.checkBox_bit_1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_bit_1.Name = "checkBox_bit_1";
            this.checkBox_bit_1.Size = new System.Drawing.Size(32, 17);
            this.checkBox_bit_1.TabIndex = 8;
            this.checkBox_bit_1.Text = "1";
            this.checkBox_bit_1.UseVisualStyleBackColor = true;
            // 
            // checkBox_bit_7
            // 
            this.checkBox_bit_7.AutoSize = true;
            this.checkBox_bit_7.Location = new System.Drawing.Point(12, 33);
            this.checkBox_bit_7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_bit_7.Name = "checkBox_bit_7";
            this.checkBox_bit_7.Size = new System.Drawing.Size(32, 17);
            this.checkBox_bit_7.TabIndex = 7;
            this.checkBox_bit_7.Text = "7";
            this.checkBox_bit_7.UseVisualStyleBackColor = true;
            // 
            // checkBox_bit_6
            // 
            this.checkBox_bit_6.AutoSize = true;
            this.checkBox_bit_6.Location = new System.Drawing.Point(12, 51);
            this.checkBox_bit_6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_bit_6.Name = "checkBox_bit_6";
            this.checkBox_bit_6.Size = new System.Drawing.Size(32, 17);
            this.checkBox_bit_6.TabIndex = 6;
            this.checkBox_bit_6.Text = "6";
            this.checkBox_bit_6.UseVisualStyleBackColor = true;
            // 
            // checkBox_bit_5
            // 
            this.checkBox_bit_5.AutoSize = true;
            this.checkBox_bit_5.Location = new System.Drawing.Point(12, 70);
            this.checkBox_bit_5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_bit_5.Name = "checkBox_bit_5";
            this.checkBox_bit_5.Size = new System.Drawing.Size(32, 17);
            this.checkBox_bit_5.TabIndex = 5;
            this.checkBox_bit_5.Text = "5";
            this.checkBox_bit_5.UseVisualStyleBackColor = true;
            // 
            // checkBox_bit_4
            // 
            this.checkBox_bit_4.AutoSize = true;
            this.checkBox_bit_4.Location = new System.Drawing.Point(12, 88);
            this.checkBox_bit_4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_bit_4.Name = "checkBox_bit_4";
            this.checkBox_bit_4.Size = new System.Drawing.Size(32, 17);
            this.checkBox_bit_4.TabIndex = 4;
            this.checkBox_bit_4.Text = "4";
            this.checkBox_bit_4.UseVisualStyleBackColor = true;
            // 
            // checkBox_bit_3
            // 
            this.checkBox_bit_3.AutoSize = true;
            this.checkBox_bit_3.Location = new System.Drawing.Point(12, 106);
            this.checkBox_bit_3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_bit_3.Name = "checkBox_bit_3";
            this.checkBox_bit_3.Size = new System.Drawing.Size(32, 17);
            this.checkBox_bit_3.TabIndex = 3;
            this.checkBox_bit_3.Text = "3";
            this.checkBox_bit_3.UseVisualStyleBackColor = true;
            // 
            // checkBox_bit_2
            // 
            this.checkBox_bit_2.AutoSize = true;
            this.checkBox_bit_2.Location = new System.Drawing.Point(12, 124);
            this.checkBox_bit_2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_bit_2.Name = "checkBox_bit_2";
            this.checkBox_bit_2.Size = new System.Drawing.Size(32, 17);
            this.checkBox_bit_2.TabIndex = 2;
            this.checkBox_bit_2.Text = "2";
            this.checkBox_bit_2.UseVisualStyleBackColor = true;
            // 
            // button_SaveToFile
            // 
            this.button_SaveToFile.Location = new System.Drawing.Point(130, 16);
            this.button_SaveToFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_SaveToFile.Name = "button_SaveToFile";
            this.button_SaveToFile.Size = new System.Drawing.Size(74, 37);
            this.button_SaveToFile.TabIndex = 1;
            this.button_SaveToFile.Text = "Save to File";
            this.button_SaveToFile.UseVisualStyleBackColor = true;
            this.button_SaveToFile.Click += new System.EventHandler(this.button_SaveToFile_Click);
            // 
            // button_LoadFromFile
            // 
            this.button_LoadFromFile.Location = new System.Drawing.Point(13, 16);
            this.button_LoadFromFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_LoadFromFile.Name = "button_LoadFromFile";
            this.button_LoadFromFile.Size = new System.Drawing.Size(74, 37);
            this.button_LoadFromFile.TabIndex = 0;
            this.button_LoadFromFile.Text = "Load from File";
            this.button_LoadFromFile.UseVisualStyleBackColor = true;
            this.button_LoadFromFile.Click += new System.EventHandler(this.button_LoadFromFile_Click);
            // 
            // dataGridView_ADCregisters
            // 
            this.dataGridView_ADCregisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ADCregisters.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_ADCregisters.Location = new System.Drawing.Point(238, 2);
            this.dataGridView_ADCregisters.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_ADCregisters.Name = "dataGridView_ADCregisters";
            this.dataGridView_ADCregisters.RowHeadersWidth = 82;
            this.dataGridView_ADCregisters.RowTemplate.Height = 33;
            this.dataGridView_ADCregisters.Size = new System.Drawing.Size(854, 540);
            this.dataGridView_ADCregisters.TabIndex = 0;
            this.dataGridView_ADCregisters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ADCregisters_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dataGridView_FPGAregisters);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1094, 544);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Registers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.button_SaveToFile_FPGAregisters);
            this.panel3.Controls.Add(this.button_LoadFromFile_FPGAregisters);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 540);
            this.panel3.TabIndex = 1;
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
            // button_SaveToFile_FPGAregisters
            // 
            this.button_SaveToFile_FPGAregisters.Location = new System.Drawing.Point(130, 16);
            this.button_SaveToFile_FPGAregisters.Margin = new System.Windows.Forms.Padding(2);
            this.button_SaveToFile_FPGAregisters.Name = "button_SaveToFile_FPGAregisters";
            this.button_SaveToFile_FPGAregisters.Size = new System.Drawing.Size(74, 37);
            this.button_SaveToFile_FPGAregisters.TabIndex = 1;
            this.button_SaveToFile_FPGAregisters.Text = "Save to File";
            this.button_SaveToFile_FPGAregisters.UseVisualStyleBackColor = true;
            this.button_SaveToFile_FPGAregisters.Click += new System.EventHandler(this.button_SaveToFile_Click);
            // 
            // button_LoadFromFile_FPGAregisters
            // 
            this.button_LoadFromFile_FPGAregisters.Location = new System.Drawing.Point(13, 16);
            this.button_LoadFromFile_FPGAregisters.Margin = new System.Windows.Forms.Padding(2);
            this.button_LoadFromFile_FPGAregisters.Name = "button_LoadFromFile_FPGAregisters";
            this.button_LoadFromFile_FPGAregisters.Size = new System.Drawing.Size(74, 37);
            this.button_LoadFromFile_FPGAregisters.TabIndex = 0;
            this.button_LoadFromFile_FPGAregisters.Text = "Load from File";
            this.button_LoadFromFile_FPGAregisters.UseVisualStyleBackColor = true;
            this.button_LoadFromFile_FPGAregisters.Click += new System.EventHandler(this.button_LoadFromFile_Click);
            // 
            // dataGridView_FPGAregisters
            // 
            this.dataGridView_FPGAregisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FPGAregisters.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_FPGAregisters.Location = new System.Drawing.Point(238, 2);
            this.dataGridView_FPGAregisters.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_FPGAregisters.Name = "dataGridView_FPGAregisters";
            this.dataGridView_FPGAregisters.RowHeadersWidth = 82;
            this.dataGridView_FPGAregisters.RowTemplate.Height = 33;
            this.dataGridView_FPGAregisters.Size = new System.Drawing.Size(854, 540);
            this.dataGridView_FPGAregisters.TabIndex = 0;
            this.dataGridView_FPGAregisters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ADCregisters_CellContentClick);
            // 
            // timer_info
            // 
            this.timer_info.Enabled = true;
            this.timer_info.Tick += new System.EventHandler(this.timer_info_Tick);
            // 
            // timer_AutoTest
            // 
            this.timer_AutoTest.Interval = 4000;
            this.timer_AutoTest.Tick += new System.EventHandler(this.timer_AutoTest_Tick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.numericUpDown_set_num_of_events);
            this.tabPage1.Controls.Add(this.label_dbg2);
            this.tabPage1.Controls.Add(this.label_dbg1);
            this.tabPage1.Controls.Add(this.button_Read_Setting);
            this.tabPage1.Controls.Add(this.button_Clear_Counters);
            this.tabPage1.Controls.Add(this.button_TRG_Read_Conters);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label_Processed_Events);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label_Incoming_Events);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numericUpDown_Num_Of_Samples);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDown_Threshold);
            this.tabPage1.Controls.Add(this.checkBox_TRG_TestGen_Enable);
            this.tabPage1.Controls.Add(this.checkBox_TRG_Enable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1094, 544);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Trigger";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox_TRG_Enable
            // 
            this.checkBox_TRG_Enable.AutoSize = true;
            this.checkBox_TRG_Enable.Location = new System.Drawing.Point(39, 49);
            this.checkBox_TRG_Enable.Name = "checkBox_TRG_Enable";
            this.checkBox_TRG_Enable.Size = new System.Drawing.Size(95, 17);
            this.checkBox_TRG_Enable.TabIndex = 0;
            this.checkBox_TRG_Enable.Text = "Trigger Enable";
            this.checkBox_TRG_Enable.UseVisualStyleBackColor = true;
            this.checkBox_TRG_Enable.CheckedChanged += new System.EventHandler(this.checkBox_TRG_Enable_CheckedChanged);
            // 
            // checkBox_TRG_TestGen_Enable
            // 
            this.checkBox_TRG_TestGen_Enable.AutoSize = true;
            this.checkBox_TRG_TestGen_Enable.Location = new System.Drawing.Point(39, 72);
            this.checkBox_TRG_TestGen_Enable.Name = "checkBox_TRG_TestGen_Enable";
            this.checkBox_TRG_TestGen_Enable.Size = new System.Drawing.Size(133, 17);
            this.checkBox_TRG_TestGen_Enable.TabIndex = 1;
            this.checkBox_TRG_TestGen_Enable.Text = "Test Generator Enable";
            this.checkBox_TRG_TestGen_Enable.UseVisualStyleBackColor = true;
            this.checkBox_TRG_TestGen_Enable.CheckedChanged += new System.EventHandler(this.checkBox_TRG_TestGen_Enable_CheckedChanged);
            // 
            // numericUpDown_Threshold
            // 
            this.numericUpDown_Threshold.Location = new System.Drawing.Point(389, 46);
            this.numericUpDown_Threshold.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericUpDown_Threshold.Name = "numericUpDown_Threshold";
            this.numericUpDown_Threshold.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown_Threshold.TabIndex = 2;
            this.numericUpDown_Threshold.ValueChanged += new System.EventHandler(this.numericUpDown_Threshold_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Threshold:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number Of Samples:";
            // 
            // numericUpDown_Num_Of_Samples
            // 
            this.numericUpDown_Num_Of_Samples.Location = new System.Drawing.Point(389, 71);
            this.numericUpDown_Num_Of_Samples.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_Num_Of_Samples.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown_Num_Of_Samples.Name = "numericUpDown_Num_Of_Samples";
            this.numericUpDown_Num_Of_Samples.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown_Num_Of_Samples.TabIndex = 4;
            this.numericUpDown_Num_Of_Samples.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown_Num_Of_Samples.ValueChanged += new System.EventHandler(this.numericUpDown_Num_Of_Samples_ValueChanged);
            // 
            // label_Incoming_Events
            // 
            this.label_Incoming_Events.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Incoming_Events.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Incoming_Events.Location = new System.Drawing.Point(167, 211);
            this.label_Incoming_Events.Name = "label_Incoming_Events";
            this.label_Incoming_Events.Size = new System.Drawing.Size(135, 23);
            this.label_Incoming_Events.TabIndex = 6;
            this.label_Incoming_Events.Text = "0";
            this.label_Incoming_Events.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(61, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Incoming Events:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(54, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Processed Events:";
            // 
            // label_Processed_Events
            // 
            this.label_Processed_Events.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Processed_Events.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Processed_Events.Location = new System.Drawing.Point(167, 253);
            this.label_Processed_Events.Name = "label_Processed_Events";
            this.label_Processed_Events.Size = new System.Drawing.Size(135, 23);
            this.label_Processed_Events.TabIndex = 8;
            this.label_Processed_Events.Text = "0";
            this.label_Processed_Events.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_TRG_Read_Conters
            // 
            this.button_TRG_Read_Conters.Location = new System.Drawing.Point(60, 307);
            this.button_TRG_Read_Conters.Name = "button_TRG_Read_Conters";
            this.button_TRG_Read_Conters.Size = new System.Drawing.Size(117, 23);
            this.button_TRG_Read_Conters.TabIndex = 10;
            this.button_TRG_Read_Conters.Text = "Read Counters";
            this.button_TRG_Read_Conters.UseVisualStyleBackColor = true;
            this.button_TRG_Read_Conters.Click += new System.EventHandler(this.button_TRG_Read_Conters_Click);
            // 
            // button_Clear_Counters
            // 
            this.button_Clear_Counters.Location = new System.Drawing.Point(183, 307);
            this.button_Clear_Counters.Name = "button_Clear_Counters";
            this.button_Clear_Counters.Size = new System.Drawing.Size(117, 23);
            this.button_Clear_Counters.TabIndex = 11;
            this.button_Clear_Counters.Text = "Clear Counters";
            this.button_Clear_Counters.UseVisualStyleBackColor = true;
            this.button_Clear_Counters.Click += new System.EventHandler(this.button_Clear_Counters_Click);
            // 
            // button_Read_Setting
            // 
            this.button_Read_Setting.Location = new System.Drawing.Point(39, 108);
            this.button_Read_Setting.Name = "button_Read_Setting";
            this.button_Read_Setting.Size = new System.Drawing.Size(117, 23);
            this.button_Read_Setting.TabIndex = 12;
            this.button_Read_Setting.Text = "Read Setting";
            this.button_Read_Setting.UseVisualStyleBackColor = true;
            this.button_Read_Setting.Click += new System.EventHandler(this.button_Read_Setting_Click);
            // 
            // label_dbg1
            // 
            this.label_dbg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_dbg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dbg1.Location = new System.Drawing.Point(699, 99);
            this.label_dbg1.Name = "label_dbg1";
            this.label_dbg1.Size = new System.Drawing.Size(64, 23);
            this.label_dbg1.TabIndex = 13;
            this.label_dbg1.Text = "0";
            this.label_dbg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_dbg2
            // 
            this.label_dbg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_dbg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dbg2.Location = new System.Drawing.Point(699, 132);
            this.label_dbg2.Name = "label_dbg2";
            this.label_dbg2.Size = new System.Drawing.Size(64, 23);
            this.label_dbg2.TabIndex = 14;
            this.label_dbg2.Text = "0";
            this.label_dbg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Set Finite Number Of Events:";
            // 
            // numericUpDown_set_num_of_events
            // 
            this.numericUpDown_set_num_of_events.Location = new System.Drawing.Point(389, 132);
            this.numericUpDown_set_num_of_events.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_set_num_of_events.Name = "numericUpDown_set_num_of_events";
            this.numericUpDown_set_num_of_events.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown_set_num_of_events.TabIndex = 15;
            this.numericUpDown_set_num_of_events.ValueChanged += new System.EventHandler(this.numericUpDown_set_num_of_events_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "(0 in infinite)";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 609);
            this.Controls.Add(this.tabControl_MAIN);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_testPeriod)).EndInit();
            this.tabControl_MAIN.ResumeLayout(false);
            this.Measurement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).EndInit();
            this.ADC_Registers.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ADCregisters)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FPGAregisters)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Num_Of_Samples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_set_num_of_events)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl_MAIN;
        private System.Windows.Forms.TabPage Measurement;
        private System.Windows.Forms.TabPage ADC_Registers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_ADCregisters;
        private System.Windows.Forms.Button button_LoadFromFile;
        private System.Windows.Forms.Button button_SaveToFile;
        private System.Windows.Forms.CheckBox checkBox_bit_2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_bit_0;
        private System.Windows.Forms.CheckBox checkBox_bit_1;
        private System.Windows.Forms.CheckBox checkBox_bit_7;
        private System.Windows.Forms.CheckBox checkBox_bit_6;
        private System.Windows.Forms.CheckBox checkBox_bit_5;
        private System.Windows.Forms.CheckBox checkBox_bit_4;
        private System.Windows.Forms.CheckBox checkBox_bit_3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_OpenClose;
        private System.Windows.Forms.ComboBox comboBox_Ports;
        private System.Windows.Forms.Button button_Scan;
        private System.Windows.Forms.Button button_Test;
        public System.Windows.Forms.Label label_Test;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Button button_SaveToFile_FPGAregisters;
        private System.Windows.Forms.Button button_LoadFromFile_FPGAregisters;
        private System.Windows.Forms.DataGridView dataGridView_FPGAregisters;
        private System.Windows.Forms.Timer timer_info;
        private System.Windows.Forms.Button button_AutoTest;
        private System.Windows.Forms.Timer timer_AutoTest;
        private System.Windows.Forms.Button button_ValidateTest;
        public System.Windows.Forms.Label label_TestResult;
        private System.Windows.Forms.NumericUpDown numericUpDown_testPeriod;
        private System.Windows.Forms.DataGridView dataGridView_data;
        private System.Windows.Forms.Button button_datatest;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_Clear_Counters;
        private System.Windows.Forms.Button button_TRG_Read_Conters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Processed_Events;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Incoming_Events;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Num_Of_Samples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Threshold;
        private System.Windows.Forms.CheckBox checkBox_TRG_TestGen_Enable;
        private System.Windows.Forms.CheckBox checkBox_TRG_Enable;
        private System.Windows.Forms.Button button_Read_Setting;
        private System.Windows.Forms.Label label_dbg2;
        private System.Windows.Forms.Label label_dbg1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_set_num_of_events;
        private System.Windows.Forms.Button button_Reset;
    }
}

