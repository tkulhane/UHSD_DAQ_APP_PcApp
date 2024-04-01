using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Digitizer_ver1
{

    class ConfigurationFileSequencer
    {
        public enum eReadRequestType : byte
        {
            non,
            register,
            input
        };


        public BindingList<ConfigurationFileSequencer_Data> List_ConfigSequence = new BindingList<ConfigurationFileSequencer_Data>();

        public MultipleConfigurationFileSequencer_Data _MultiConfig_data;
        public delegate void efunction(MultipleConfigurationFileSequencer_Data.eStates state, MultipleConfigurationFileSequencer_Data MultiConfig_data);
        public efunction StateSetFunction;

        public DataGridView _dataGridView_ConfigFile;
        public BindingList<SystemSetting_RegistersFileData> List_ReigistersFile;
        
        public Reset_Control rst;
        public GPIO_Control gpio;

        public bool VisibleOnDataGrid = false;

        System.Timers.Timer TimerWait = new System.Timers.Timer();

        //aTimer.Interval = 5000;
        //aTimer.Enabled = true;



        int _lastReadValue;
        //bool _lastReadValue_Valid = false;

        bool _notIncStepSequence = false;
        eReadRequestType _ReadRequest_Type = eReadRequestType.non;
        RegistersSetting _ReadRequest_RegisterSetting;
        int _ReadRequest_Input;




        int StepSequence;
        bool SequenceDone;

        public ConfigurationFileSequencer() 
        {
            TimerWait.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        }

        //-------------------------------------------------------------------------------------------------------------------
        //File operation
        //-------------------------------------------------------------------------------------------------------------------
        public string OpenRegistersFile()
        {

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
                    return fname;
                }

                if (String.IsNullOrEmpty(fname))
                {
                    return fname;
                }

                List_ConfigSequence.Clear();

                String[] lines = File.ReadAllLines(fname, Encoding.GetEncoding("Windows-1250"));

                foreach (String s in lines)
                {
                    ConfigurationFileSequencer_Data data = new ConfigurationFileSequencer_Data(s);

                    List_ConfigSequence.Add(data);
                }


                //dataGridView_ConfigFile.DataSource = List_ConfigSequence;


                return fname;
            }
        }

        public void SaveRegistersFile()
        {

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

            foreach (ConfigurationFileSequencer_Data data in List_ConfigSequence)
            {
                //byte[] line = Encoding.ASCII.GetBytes(data.FormatToCSV());

                //fs.Write(line, 0, line.Length);
            }

            fs.Close();

        }

        public void OpenRegistersFileAsString(string fname)
        {

            if (String.IsNullOrEmpty(fname))
            {
                return;
            }

            List_ConfigSequence.Clear();

            String[] lines = File.ReadAllLines(fname, Encoding.GetEncoding("Windows-1250"));

            foreach (String s in lines)
            {
                ConfigurationFileSequencer_Data data = new ConfigurationFileSequencer_Data(s);

                List_ConfigSequence.Add(data);
            }


           

        }

        public void SaveRegistersFileAsString(string fname)
        {

            if (String.IsNullOrEmpty(fname))
            {
                return;
            }

            FileStream fs = File.OpenWrite(fname);

            foreach (ConfigurationFileSequencer_Data data in List_ConfigSequence)
            {
                //byte[] line = Encoding.ASCII.GetBytes(data.FormatToCSV());

                //fs.Write(line, 0, line.Length);
            }

            fs.Close();

        }


        //-------------------------------------------------------------------------------------------------------------------
        //DataGrid
        //-------------------------------------------------------------------------------------------------------------------
        public void SetDataGrid() 
        {
            _dataGridView_ConfigFile.DataSource = List_ConfigSequence;
            _dataGridView_ConfigFile.Update(); 
            _dataGridView_ConfigFile.Refresh();
            VisibleOnDataGrid = true;
        }

        public void ClrDataGrid()
        {
            //_dataGridView_ConfigFile.DataSource = null;
            //_dataGridView_ConfigFile.Update();
            VisibleOnDataGrid = false;
        }

        //-------------------------------------------------------------------------------------------------------------------
        //Sequence operation
        //-------------------------------------------------------------------------------------------------------------------

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if(_ReadRequest_Type == eReadRequestType.register) 
            {
                if (_ReadRequest_RegisterSetting.StateReadRegister()) 
                {
                    _lastReadValue = _ReadRequest_RegisterSetting._LastReadValue;
                    _ReadRequest_Type = eReadRequestType.non;
                }
                else 
                {
                    return;
                }

            }
            else if(_ReadRequest_Type == eReadRequestType.input) 
            {

            }


            TimerWait.Enabled = false;
            ConfigSequenceGo();
        }

        public void ConfigSequenceStart() 
        {
            if(List_ConfigSequence.Count == 0) 
            {
                return;
            }

            if (VisibleOnDataGrid)
            {
                for (int i = 0; i < _dataGridView_ConfigFile.RowCount; i++)
                {
                    _dataGridView_ConfigFile.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
            }

            StepSequence = 0;
            SequenceDone = false;

            StateSetFunction(MultipleConfigurationFileSequencer_Data.eStates.Run, _MultiConfig_data);
            ConfigSequenceGo();
        }

        public void ConfigSequenceStop()
        {
            
            SequenceDone = true;
        }

        public void ConfigSequenceGo()
        {
            if (SequenceDone)
            {
                StateSetFunction(MultipleConfigurationFileSequencer_Data.eStates.Idle, _MultiConfig_data);
                return;
            }
              
                

            //SequenceDone = false;

            
            ConfigurationFileSequencer_Data SequenceData = List_ConfigSequence[StepSequence];
            bool decodeOk = DecodeSequenceLine(SequenceData);

            if (VisibleOnDataGrid)
            {
                for(int i = 0; i < _dataGridView_ConfigFile.RowCount; i++) 
                {
                    _dataGridView_ConfigFile.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
                
                
                if (decodeOk)
                    _dataGridView_ConfigFile.Rows[StepSequence].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                else
                    _dataGridView_ConfigFile.Rows[StepSequence].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
            }

            if (StepSequence >= List_ConfigSequence.Count-1) 
            {
                StateSetFunction(MultipleConfigurationFileSequencer_Data.eStates.Idle, _MultiConfig_data);
                SequenceDone = true;

                for (int i = 0; i < _dataGridView_ConfigFile.RowCount; i++)
                {
                    _dataGridView_ConfigFile.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
                //StepSequence = 0;
            }
            else 
            {
                if (_notIncStepSequence == false) //pokud je false tak mohu pricitat step, pokud je nastaveno true (ze skoku), tak preskakuju pripocteni
                {
                    StepSequence++;
                }
                _notIncStepSequence = false;


                if (Delay_SequenceLine <= 0) 
                {
                    ConfigSequenceGo();
                }
                else 
                {
                    //ConfigSequenceGo();
                    //call timer
              
                    TimerWait.Interval = Delay_SequenceLine;
                    TimerWait.Enabled = true;
                }
                
            }

        }


        int Delay_SequenceLine;
        private bool DecodeSequenceLine(ConfigurationFileSequencer_Data SequenceData) 
        {
            Delay_SequenceLine = 0;

            string Action = SequenceData.p_Action;
            string Periphery = SequenceData.p_Periphery;
            string Value1 = SequenceData.p_Value1;
            string Value2 = SequenceData.p_Value2;
            string Value3 = SequenceData.p_Value3;
            string Value4 = SequenceData.p_Value4;



            if (Action.Equals("RESET")) 
            {
                int val;
                if (!int.TryParse(Value1, NumberStyles.HexNumber, null, out val)) return false; //parsovani hodnoty resetu
                rst.SetByName(Periphery, val);
            }
            
            else if (Action.Equals("OUTPUT"))
            {
                int val;
                if (!int.TryParse(Value1, NumberStyles.HexNumber, null, out val)) return false; //parsovani hodnoty outputu
                gpio.SetByName(Periphery, val);
            }
            
            else if (Action.Equals("REG"))
            {
                for(int i = 0; i < List_ReigistersFile.Count; i++) //prohledavam seznam a porovnavam description
                {
                    if (Periphery.Equals(List_ReigistersFile[i].p_registerSettingDescription)) //najdu description pro periferii
                    {
                       
                        if (Value1.Equals("ALL")) //pokud je value1 ALL odesílám celou tabulku
                        {
                            List_ReigistersFile[i].p_registerSetting.WriteAll();
                        }

                        else if (Value1.Equals("ALL_REV")) //pokud je value1 ALL odesílám celou tabulku
                        {
                            List_ReigistersFile[i].p_registerSetting.WriteAllReverse();
                        }

                        else 
                        {
                            int address;
                            if (!int.TryParse(Value1, NumberStyles.HexNumber, null, out address)) return false; //parsovani adresy registru


                            if (Value2.Equals("TBL")) //pokud je Value2 TBL bere se hodnota z tabulky 
                            {
                                List_ReigistersFile[i].p_registerSetting.SendRegister(address);
                            }
                            else //cokoliv jineho nez TBL (musi to byt cislo)
                            {
                                int value;
                                if (!int.TryParse(Value2, NumberStyles.HexNumber, null, out value)) return false; //parsovani hodnoty
                                List_ReigistersFile[i].p_registerSetting.SendRegister(address, value);
                            }
                        }

                    }
                }
            }

            else if (Action.Equals("REG_MASK")) 
            {
                for (int i = 0; i < List_ReigistersFile.Count; i++) //prohledavam seznam a porovnavam description
                {
                    if (Periphery.Equals(List_ReigistersFile[i].p_registerSettingDescription)) //najdu description pro periferii
                    {
                        int address;
                        int mask;
                        if (!int.TryParse(Value1, NumberStyles.HexNumber, null, out address)) return false; //parsovani adresy registru
                        if (!int.TryParse(Value3, NumberStyles.HexNumber, null, out mask)) return false;    //parsovani masky


                        if (Value2.Equals("TBL")) //pokud je Value2 TBL bere se hodnota z tabulky 
                        {
                            List_ReigistersFile[i].p_registerSetting.SendMaskRegister_Request(address, mask);
                        }
                        else //cokoliv jineho nez TBL (musi to byt cislo)
                        {
                            int value;
                            if (!int.TryParse(Value2, NumberStyles.HexNumber, null, out value)) return false; //parsovani hodnoty
                            List_ReigistersFile[i].p_registerSetting.SendMaskRegister_Request(address, value, mask);
                        }

                    }
                }
            }

            else if (Action.Equals("REG_BIT"))
            {
                for (int i = 0; i < List_ReigistersFile.Count; i++) //prohledavam seznam a porovnavam description
                {
                    if (Periphery.Equals(List_ReigistersFile[i].p_registerSettingDescription)) //najdu description pro periferii
                    {
                        int address;
                        int bit;
                        if (!int.TryParse(Value1, NumberStyles.HexNumber, null, out address)) return false; //parsovani adresy registru
                        if (!int.TryParse(Value3, NumberStyles.HexNumber, null, out bit)) return false;    //parsovani poradi bitu

                        int mask = (1 << bit);
                        int value;

                        if (Value2.Equals("1")) //pokud je Value2 TBL bere se hodnota z tabulky 
                        {
                            value = (1 << bit);
                            List_ReigistersFile[i].p_registerSetting.SendMaskRegister_Request(address, value, mask);
                        }
                        else if (Value2.Equals("0")) 
                        {
                            value = (0 << bit);
                            List_ReigistersFile[i].p_registerSetting.SendMaskRegister_Request(address, value, mask);
                        }
                        else 
                        {
                            return false;
                        }

                    }
                }
            }

            else if (Action.Equals("JUMP"))
            {
                int line;
                if (!int.TryParse(Value1, out line)) return false;
                if (line <= 0 || line >= List_ConfigSequence.Count) return false;
                line = line - 1;

                if (Periphery.Equals("NO"))
                {
                    StepSequence = line;
                    _notIncStepSequence = true;
                }
                else if (Periphery.Equals("EQUAL"))
                {
                    int conditionValue;
                    if (!int.TryParse(Value2, NumberStyles.HexNumber, null, out conditionValue)) return false;

                    if(conditionValue == _lastReadValue) 
                    {
                        StepSequence = line;
                        _notIncStepSequence = true;
                    }

                }
                else if (Periphery.Equals("NOT_EQUAL"))
                {
                    int conditionValue;
                    if (!int.TryParse(Value2, NumberStyles.HexNumber, null, out conditionValue)) return false;

                    if (conditionValue != _lastReadValue)
                    {
                        StepSequence = line;
                        _notIncStepSequence = true;
                    }
                }
                else
                {
                    return false;
                }
            }

            else if (Action.Equals("REG_READ"))
            {
                //_lastReadValue_Valid = false;


                //_lastReadValue = 0;

                for (int i = 0; i < List_ReigistersFile.Count; i++) //prohledavam seznam a porovnavam description
                {
                    if (Periphery.Equals(List_ReigistersFile[i].p_registerSettingDescription)) //najdu description pro periferii
                    {
                        int address;
                        if (!int.TryParse(Value1, NumberStyles.HexNumber, null, out address)) return false; //parsovani adresy registru

                        List_ReigistersFile[i].p_registerSetting.ReadRequestRegister(address);

                        _ReadRequest_Type = eReadRequestType.register;
                        _ReadRequest_RegisterSetting = List_ReigistersFile[i].p_registerSetting;

                        Delay_SequenceLine = 20;

                    }
                }

            }

            else if (Action.Equals("INPUT"))
            {

            }

            else if (Action.Equals("PAUSE"))
            {

            }

            else if (Action.Equals("STOP")) 
            {
                SequenceDone = false;
            }

            else if (Action.Equals("WAIT"))
            {
                int temp = 0;
                if (!int.TryParse(SequenceData.p_Value1, out temp)) return false;
                if (temp < 0) return false;
                Delay_SequenceLine = temp;
            }
            
            
            else 
            {
                return false;
            }

            return true;

        }
    }
}
