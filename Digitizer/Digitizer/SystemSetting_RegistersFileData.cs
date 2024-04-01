using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class SystemSetting_RegistersFileData
    {
        RegistersSetting _registerSetting;
        public RegistersSetting p_registerSetting { get { return _registerSetting; } set { _registerSetting = value; } }

        

        string _registerSettingDescription;
        [DisplayName("Registers")]
        public string p_registerSettingDescription { get { return _registerSettingDescription; } set { _registerSettingDescription = value; } }

        string _registerSettingFile;
        [DisplayName("File Path")]
        public string p_registerSettingFile { get { return _registerSettingFile; } set { _registerSettingFile = value; } }


        public SystemSetting_RegistersFileData(RegistersSetting registerSetting, string description) 
        {
            _registerSetting = registerSetting;
            _registerSettingDescription = description;
            _registerSettingFile = String.Empty;
        }

        public string DataString() 
        {
            return _registerSettingDescription + ";" + _registerSettingFile;
        }

    }
}
