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
        public enum eStates : byte
        {
            NotAssign,
            Idle,
            Run,
            RunFault,
            LoadFault
        }


        string _Name;
        [DisplayName("Name")]
        public string p_Name { get { return _Name; } set { _Name = value; } }

        string _State;
        [DisplayName("State")]
        public string p_State { get { return _State; }}


        public string _Patch;
        public ConfigurationFileSequencer _ConfigSequencer;
        public bool _Assigned;

        public MultipleConfigurationFileSequencer_Data() 
        {
            _ConfigSequencer = new ConfigurationFileSequencer();
            _Assigned = false;
            _Name = "New Config (Not Assign)";

            SetState(eStates.NotAssign);
        }

        public MultipleConfigurationFileSequencer_Data(string name, string file)
        {
            _ConfigSequencer = new ConfigurationFileSequencer();
            _Assigned = true;
            _Name = name;

            SetState(eStates.Idle);
        }

        public void SetState(eStates state) 
        {
            switch (state) 
            {
                case eStates.NotAssign:
                    _State = "Not Assign";
                    break;

                case eStates.Idle:
                    _State = "Idle";
                    break;

                case eStates.Run:
                    _State = "Run";
                    break;

                case eStates.RunFault:
                    _State = "Run Fault";
                    break;

                case eStates.LoadFault:
                    _State = "Load Fault";
                    break;

                default:
                    _State = "???";
                    break;

            }
        }

    }
}
