using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class SystemManage_ActionsData
    {
        public string _userText;
        public string _configFileName;
        public int _actionNumber = -1;

        SystemManage_ActionsData(string userText, string configFileName, int actionNumber) 
        {
            _userText = userText;
            _configFileName = configFileName;
            _actionNumber = actionNumber;
        }


        static char[] caSplit = new char[] { ';' };
        public SystemManage_ActionsData(string lineOfFile, int actionNumber)
        {

            if (String.IsNullOrEmpty(lineOfFile) || !lineOfFile.Contains(";"))
            {
                return;
            }


            String[] line_parts = lineOfFile.Split(caSplit);

            if (line_parts.Length < 2) return;

            _userText = line_parts[0];
            _configFileName = line_parts[1];


            _actionNumber = actionNumber;

        }

    }
}
