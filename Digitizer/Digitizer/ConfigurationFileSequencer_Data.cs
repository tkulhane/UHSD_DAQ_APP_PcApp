using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class ConfigurationFileSequencer_Data
    {
        string _Action;
        [DisplayName("Action")]
        public string p_Action { get { return _Action; } set { _Action = value; } }

        string _Periphery;
        [DisplayName("Periphery")]
        public string p_Periphery { get { return _Periphery; } set { _Periphery = value; } }

        string _Value1;
        [DisplayName("Value 1")]
        public string p_Value1 { get { return _Value1; } set { _Value1 = value; } }

        string _Value2;
        [DisplayName("Value 2")]
        public string p_Value2 { get { return _Value2; } set { _Value2 = value; } }

        string _Value3;
        [DisplayName("Value 3")]
        public string p_Value3 { get { return _Value3; } set { _Value3 = value; } }

        string _Value4;
        [DisplayName("Value 4")]
        public string p_Value4 { get { return _Value4; } set { _Value4 = value; } }

        string _Description;
        [DisplayName("Description")]
        public string p_Description { get { return _Description; } set { _Description = value; } }



        static char[] caSplit = new char[] { ';' };
        public ConfigurationFileSequencer_Data(String line)
        {
            if (String.IsNullOrEmpty(line) || !line.Contains(";"))
            {
                return;
            }


            String[] line_parts = line.Split(caSplit);

            if (line_parts.Length < 7) return;

            _Action = line_parts[0];
            _Periphery = line_parts[1];
            _Value1 = line_parts[2];
            _Value2 = line_parts[3];
            _Value3 = line_parts[4];
            _Value4 = line_parts[5];
            _Description = line_parts[6];

        }


    }
}
