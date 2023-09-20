using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class MultipleConfigurationFileSequencer_Data
    {
        string _Name;
        [DisplayName("Name")]
        public string p_Name { get { return _Name; } set { _Name = value; } }


        public string _Patch;
        public ConfigurationFileSequencer _ConfigSequencer;
        public bool _Assigned;

        public MultipleConfigurationFileSequencer_Data() 
        {
            _ConfigSequencer = new ConfigurationFileSequencer();
            _Assigned = false;
            _Name = "New Config (Not Assign)";
        }


    }
}
