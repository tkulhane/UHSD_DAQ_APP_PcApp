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


        static string SettingFileName = "AppSetting.txt";

        public BindingList<SystemSetting_RegistersFileData> List_ReigistersFile = new BindingList<SystemSetting_RegistersFileData>();



        public void SettingLoad()
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
                communication.OpenBySettingString(reader.ReadLine());

                for (int i = 0; i < List_ReigistersFile.Count; i++)
                {
                    UpdateRowRegistersFile(i, reader.ReadLine());
                }

            }

            OpenRegistersFiles();
        }


        public void SettingSave()
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


        public void CreateRegistersInList(Registers_Setting registerSetting)
        {
            

            SystemSetting_RegistersFileData data = new SystemSetting_RegistersFileData(registerSetting, registerSetting.p_description);

            List_ReigistersFile.Add(data);
            dataGridView_RegistersFiles.Update();
        }

        public void AddFileRegistersInList(Registers_Setting registerSetting, string file)
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


        public string GetFileStringForRegisters(Registers_Setting registerSetting) 
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

        static char[] caSplit = new char[] { ';' };
        private void UpdateRowRegistersFile(int row, string s)
        {
            string[] s_parts = s.Split(caSplit);

            List_ReigistersFile[row].p_registerSettingFile = s_parts[1];
            dataGridView_RegistersFiles.Update();

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
