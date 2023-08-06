using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    
    class ResetControl_Data
    {
        public enum eExtIntRes : int
        {
            External_Reset,
            Internal_Reset
        }


        int _number;
        [DisplayName("Number")]
        public int p_number { get { return _number; } }

        string _name;
        [DisplayName("Name")]
        public String p_name { get { return _name; } }

        int _value;
        [DisplayName("Value")]
        public int p_value { get { return _value; } set { _value = value; } }

        public readonly eExtIntRes _Res_ExtInt;

        public ResetControl_Data(eExtIntRes Res_ExtInt, int Number, string Name) 
        {
            _Res_ExtInt = Res_ExtInt;
            _number = Number;
            _name = Name;
            _value = 0;
        }


    }
}
