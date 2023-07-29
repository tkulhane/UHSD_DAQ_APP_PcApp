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

        private BindingList<SystemSetting_RegistersFileData> List_ReigistersFile = new BindingList<SystemSetting_RegistersFileData>();



        public void SettingLoad()
        {
            dataGridView_RegistersFiles.DataSource = List_ReigistersFile;

            using (StreamReader reader = new StreamReader(SettingFileName, Encoding.UTF8)) 
            {
                communication.OpenBySettingString(reader.ReadLine());

            }

            //string[] lines = File.ReadAllLines(SettingFileName, Encoding.UTF8);

        }


        public void SettingSave()
        {
            System.IO.File.WriteAllText(SettingFileName, string.Empty);

            using (StreamWriter writer = new StreamWriter(SettingFileName))
            {

                writer.WriteLine(communication.GetSettingString());
            }

        }
        

        public void CreateRegistersInList(Registers_Setting registerSetting) 
        {
            SystemSetting_RegistersFileData data = new SystemSetting_RegistersFileData(registerSetting);

            List_ReigistersFile.Add(data);
            dataGridView_RegistersFiles.Update();
        }

        public void AddFileRegistersInList(Registers_Setting registerSetting, string file) 
        {
            for(int i = 0; i < List_ReigistersFile.Count; i++) 
            {
                if (registerSetting.Equals(List_ReigistersFile[i].p_registerSetting)) 
                {
                    List_ReigistersFile[i].p_registerSettingFile = file;
                }
            }

            dataGridView_RegistersFiles.Update();

        }



    }
}
