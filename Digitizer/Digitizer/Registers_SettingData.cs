using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class Registers_SettingData
    {

        public enum eReadWrite : byte
        {
            non,
            read_write,
            read,
            write
        }

        int _address;
        [DisplayName("Address")]
        public int p_address { get { return _address; } }

        string _description;
        [DisplayName("Description")]
        public String p_description { get { return _description; } }

        string _StrReadWrite;
        [DisplayName("Read/Write")]
        public String p__StrReadWrite { get { return _StrReadWrite; } }

        string _value;
        [DisplayName("Value")]
        public string p_value { get { return _value; } set { _value = value; } }


        
        eReadWrite _ReadWrite;




        static char[] caSplit = new char[] { ';' };
        public Registers_SettingData(String line)
        {
            if (String.IsNullOrEmpty(line) || !line.Contains(";"))
                return;

            String[] line_parts = line.Split(caSplit);

            int temp_intValue;

            if (!int.TryParse(line_parts[0], NumberStyles.HexNumber, null, out _address)) return;
            if (!int.TryParse(line_parts[3], NumberStyles.HexNumber, null, out temp_intValue)) return;

            _ReadWrite = ParseReadWrite(line_parts[2]);
            if (_ReadWrite == eReadWrite.non) _StrReadWrite = "-";
            else if (_ReadWrite == eReadWrite.read) _StrReadWrite = "R";
            else if (_ReadWrite == eReadWrite.read_write) _StrReadWrite = "R/W";
            else if (_ReadWrite == eReadWrite.write) _StrReadWrite = "W";

            _description = line_parts[1];
            _value = temp_intValue.ToString("X");
            
            //_ReadWrite = line_parts[2];

            //_address = line_parts[0];
            //_value = line_parts[3];


        }

        public eReadWrite ParseReadWrite(string s)
        {
            eReadWrite temp_ReadWrite = eReadWrite.non;

            if (string.Equals(s, "R/W", StringComparison.OrdinalIgnoreCase)) temp_ReadWrite = eReadWrite.read_write;
            else if (string.Equals(s, "RW", StringComparison.OrdinalIgnoreCase)) temp_ReadWrite = eReadWrite.read_write;
            else if (string.Equals(s, "R", StringComparison.OrdinalIgnoreCase)) temp_ReadWrite = eReadWrite.read;
            else if (string.Equals(s, "W", StringComparison.OrdinalIgnoreCase)) temp_ReadWrite = eReadWrite.write;

            return temp_ReadWrite;
        }

        public string FormatToCSV()
        {
            return String.Format("{0:X};{1};{2};{3:X}\n", _address, _description, _ReadWrite, _value);
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
