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
            //using (StreamReader reader = new StreamReader(SettingFileName, Encoding.UTF8)) 
            //{

            //}

            string[] lines = File.ReadAllLines(SettingFileName, Encoding.UTF8);

        }


        public void SettingSave()
        {
            using (StreamWriter writetext = new StreamWriter(SettingFileName))
            {
                
                writetext.WriteLine("writing in text file");
            }

        }



    }
}
