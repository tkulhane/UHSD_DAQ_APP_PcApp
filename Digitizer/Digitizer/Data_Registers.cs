using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class Data_Registers : IFormattable
    {
        String _address;
        [DisplayName("Address")]
        public String p_address { get { return _address; } }

        String _description;
        [DisplayName("Description")]
        public String p_description { get { return _description; } }

        String _value;
        [DisplayName("Value")]
        public String p_value { get { return _value; } set { _value = value; } }


        String _ReadWrite;


        static char[] caSplit = new char[] { ';' };
        public Data_Registers(String line) 
        {
            if (String.IsNullOrEmpty(line) || !line.Contains(";"))
                return;

            String[] line_parts = line.Split(caSplit);

            _address = line_parts[0];
            _description = line_parts[1];
            _ReadWrite = line_parts[2];
            _value = line_parts[3];

            
        }

        public string FormatToCSV()
        {
            return String.Format("{0};{1};{2};{3}\n", _address, _description, _ReadWrite, _value);
        }

        public override string ToString()
        {
            return ToString(null, null);

        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            //throw new NotImplementedException();
            return String.Format("A:{0} V:{1}", _address, _value);
        }
    }
}
