using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class SystemSetting_RegistersFileData
    {
        Registers_Setting _registerSetting;
        public Registers_Setting p_registerSetting { get { return _registerSetting; } set { _registerSetting = value; } }

        string _registerSettingFile;
        public string p_registerSettingFile { get { return _registerSettingFile; } set { _registerSettingFile = value; } }


        public SystemSetting_RegistersFileData(Registers_Setting registerSetting) 
        {
            _registerSetting = registerSetting;
            _registerSettingFile = String.Empty;
        }

    }
}
