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
        
        private BindingList<ConfigurationFileSequencer_Data> List_ConfigSequence = new BindingList<ConfigurationFileSequencer_Data>();

        public DataGridView dataGridView_ConfigFile;
        public BindingList<SystemSetting_RegistersFileData> List_ReigistersFile;


        System.Timers.Timer TimerWait = new System.Timers.Timer();
        
        //aTimer.Interval = 5000;
        //aTimer.Enabled = true;

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


                dataGridView_ConfigFile.DataSource = List_ConfigSequence;


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


            dataGridView_ConfigFile.DataSource = List_ConfigSequence;

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
        //Sequence operation
        //-------------------------------------------------------------------------------------------------------------------

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            TimerWait.Enabled = false;
            ConfigSequenceGo();
        }

        public void ConfigSequenceGo() 
        {
            if(StepSequence == 0)
            {
                for(int i = 0; i < List_ConfigSequence.Count; i++) 
                {
                    dataGridView_ConfigFile.Rows[StepSequence].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
            }   
            
            SequenceDone = false;

            ConfigurationFileSequencer_Data SequenceData = List_ConfigSequence[StepSequence];
            DecodeSequenceLine(SequenceData);


            dataGridView_ConfigFile.Rows[StepSequence].DefaultCellStyle.BackColor = System.Drawing.Color.Green;

            if(StepSequence >= List_ConfigSequence.Count-1) 
            {
                SequenceDone = true;
                StepSequence = 0;
            }
            else 
            {
                StepSequence++;
                
                if(Delay_SequenceLine <= 0) 
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



            if (Action.Equals("RESET")) 
            {

            }
            else if (Action.Equals("REG"))
            {
                for(int i = 0; i < List_ReigistersFile.Count; i++) //prohledavam seznam a porovnavam description
                {
                    if (Periphery.Equals(List_ReigistersFile[i].p_registerSettingDescription)) //najdu description pro periferii
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
                            List_ReigistersFile[i].p_registerSetting.SendRegister(address,value);
                        }

                    }
                }
            }
            else if (Action.Equals("WAIT"))
            {
                int temp = 0;
                if (!int.TryParse(SequenceData.p_Value1, out temp)) return false;
                if (temp < 0) return false;
                Delay_SequenceLine = temp;
            }

            return true;

        }
    }
}
