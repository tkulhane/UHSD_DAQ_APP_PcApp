using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class AnalyzInCirc_Data
    {

        int _Number;
        [DisplayName("Number")]
        public int p_Number { get { return _Number; }  }

        string _Value1;
        [DisplayName("Value 1")]
        public string p_Value1 { get { return _Value1; } }

        string _Value2;
        [DisplayName("Value 2")]
        public string p_Value2 { get { return _Value2; } }


        public AnalyzInCirc_Data(int number) 
        {


            _Number = number;

        }

        public void AddData(int index, string data) 
        {

            switch (index) 
            {
                case 0:
                    _Value1 = data;
                    break;

                case 1:
                    _Value2 = data;
                    break;

                default:
                    break;
            }
        }

    }
}
