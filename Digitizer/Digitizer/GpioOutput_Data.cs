using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class GpioOutput_Data
    {
        int _number;
        [DisplayName("Number")]
        public int p_number { get { return _number; } }

        string _name;
        [DisplayName("Name")]
        public String p_name { get { return _name; } }

        int _value;
        [DisplayName("Value")]
        public int p_value { get { return _value; } set { _value = value; } }

        public GpioOutput_Data(int Number, string Name) 
        {
            _number = Number;
            _name = Name;
            _value = 0;
        }


    }
}
