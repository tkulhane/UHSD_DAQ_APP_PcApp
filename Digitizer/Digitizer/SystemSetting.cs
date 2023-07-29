using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class SystemSetting
    {
        public Communication communication;
        
        static string SettingFileName = "AppSetting.txt";

     

        public void SettingLoad()
        {
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



    }
}
