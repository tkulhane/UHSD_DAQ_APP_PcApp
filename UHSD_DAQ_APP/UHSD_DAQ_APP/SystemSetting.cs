using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class SystemSetting
    {
        public Communication communication;
        public DataGridView dataGridView_RegistersFiles;

        public MultipleConfigurationFileSequencer configurationFiles;

        static string SettingFileName = "AppSetting.txt";

        public BindingList<SystemSetting_RegistersFileData> List_ReigistersFile = new BindingList<SystemSetting_RegistersFileData>();

        static char[] caSplit = new char[] { ';' };


        public void SettingLoadOld()
        {
            dataGridView_RegistersFiles.DataSource = List_ReigistersFile;
            dataGridView_RegistersFiles.Columns[0].Visible = false;

            if (!File.Exists(SettingFileName)) 
            {
                MessageBox.Show("The configuration file does not exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                

            using (StreamReader reader = new StreamReader(SettingFileName, Encoding.UTF8))
            {
                //precteni nastaveni komhnikace
                communication.OpenBySettingString(reader.ReadLine());

                //nacteni souboru registru
                for (int i = 0; i < List_ReigistersFile.Count; i++)
                {
                    UpdateRowRegistersFile(i, reader.ReadLine());
                }

            }

            OpenRegistersFiles();
        }

        public void SettingLoad()
        {
            dataGridView_RegistersFiles.DataSource = List_ReigistersFile;
            dataGridView_RegistersFiles.Columns[0].Visible = false;

            if (!File.Exists(SettingFileName))
            {
                MessageBox.Show("The configuration file does not exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String[] lines = File.ReadAllLines(SettingFileName, Encoding.GetEncoding("Windows-1250"));

            foreach (String s in lines)
            {
                SettingLoad_ProcessLine(s);
                
            }

            OpenRegistersFiles();
        }


        public void SettingLoad_ProcessLine(string line) 
        {
            if (line == string.Empty) return;

            String[] lineParts = line.Split(caSplit);
            if (lineParts.Length < 3) return;


            if (lineParts[0].Equals("communication"))
            {
                communication.OpenBySettingString(lineParts[1] + ";" + lineParts[2]);
            }
            else if (lineParts[0].Equals("data_destination"))
            {
                communication.communicationControl.SetFromString(lineParts[1] + ";" + lineParts[2]);
            }
            else if (lineParts[0].Equals("register")) 
            {
                UpdateRowRegisterFile(lineParts[1], lineParts[2]);
            }
            else if (lineParts[0].Equals("config"))
            {
                configurationFiles.OpenFromSetting(lineParts[1], lineParts[2]);
            }
            


        }





        public void SettingSaveOld()
        {
            System.IO.File.WriteAllText(SettingFileName, string.Empty);

            using (StreamWriter writer = new StreamWriter(SettingFileName))
            {

                writer.WriteLine(communication.GetSettingString());

                for (int i = 0; i < List_ReigistersFile.Count; i++)
                {
                    writer.WriteLine(List_ReigistersFile[i].DataString());
                }



            }

        }

        public void SettingSave() 
        {
            System.IO.File.WriteAllText(SettingFileName, string.Empty);

            using (StreamWriter writer = new StreamWriter(SettingFileName))
            {
                
                //ulozeni komunikace
                writer.WriteLine("communication;" + communication.GetSettingString());

                writer.WriteLine("data_destination;"+communication.communicationControl.GetSettingString());

                //ulozeni registru
                foreach (SystemSetting_RegistersFileData data in List_ReigistersFile) 
                {
                    string line = "register" + ";" + data.DataString();
                    writer.WriteLine(line);
                }

                //ulozeni configuracnich souboru
                int countOfConfigs = configurationFiles.GetCountOfConfigFiles();
                for (int i = 0; i < countOfConfigs; i++) 
                {
                    string line = "config" + ";" + configurationFiles.GetStringForSettingSave(i);
                    writer.WriteLine(line);
                }

            }

        }


        public void CreateRegistersInList(RegistersSetting registerSetting)
        {
            

            SystemSetting_RegistersFileData data = new SystemSetting_RegistersFileData(registerSetting, registerSetting.p_description);

            List_ReigistersFile.Add(data);
            dataGridView_RegistersFiles.Update();
        }

        public void AddFileRegistersInList(RegistersSetting registerSetting, string file)
        {
            for (int i = 0; i < List_ReigistersFile.Count; i++)
            {
                if (registerSetting.Equals(List_ReigistersFile[i].p_registerSetting))
                {
                    List_ReigistersFile[i].p_registerSettingFile = file;
                }
            }

            dataGridView_RegistersFiles.Update();

        }


        public string GetFileStringForRegisters(RegistersSetting registerSetting) 
        {
            string file = String.Empty;
            
            for (int i = 0; i < List_ReigistersFile.Count; i++)
            {
                if (registerSetting.Equals(List_ReigistersFile[i].p_registerSetting))
                {
                    file = List_ReigistersFile[i].p_registerSettingFile;
                }
            }

            return file;
        }

        //static char[] caSplit = new char[] { ';' };
        private void UpdateRowRegistersFile(int row, string s)
        {
            if (String.IsNullOrEmpty(s) || !s.Contains(";"))
            {
                return;
            }

            string[] s_parts = s.Split(caSplit);

            if (s_parts.Length < 2) return;

            List_ReigistersFile[row].p_registerSettingFile = s_parts[1];
            dataGridView_RegistersFiles.Update();

        }

        private void UpdateRowRegisterFile(string register, string file) 
        {
            if (String.IsNullOrEmpty(register) || String.IsNullOrEmpty(file))
            {
                return;
            }

            for(int i = 0; i < List_ReigistersFile.Count; i++) 
            {
                if(List_ReigistersFile[i].p_registerSetting.p_description.Equals(register))
                {
                    List_ReigistersFile[i].p_registerSettingFile = file;
                }
            }
            
        }

        private void OpenRegistersFiles() 
        {
            for (int i = 0; i < List_ReigistersFile.Count; i++)
            {
                SystemSetting_RegistersFileData data = List_ReigistersFile[i];

                data.p_registerSetting.OpenRegistersFileAsString(data.p_registerSettingFile);
                //data.p_registerSetting.OpenRegistersFile();
            }
        }

        

    }
}
