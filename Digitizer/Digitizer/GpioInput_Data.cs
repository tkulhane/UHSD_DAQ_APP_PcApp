using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class GpioInput_Data
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

        int _rising;
        [DisplayName("Rising")]
        public int p_rising { get { return _rising; } set { _rising = value; } }

        int _falling;
        [DisplayName("Falling")]
        public int p_falling { get { return _falling; } set { _falling = value; } }



        public GpioInput_Data(int Number, string Name) 
        {
            _number = Number;
            _name = Name;
            _value = 0;
            _rising = 0;
            _falling = 0;
        }


    }
}
