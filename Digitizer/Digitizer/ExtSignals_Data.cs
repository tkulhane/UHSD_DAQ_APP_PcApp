using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class ExtSignals_Data
    {
        public int NUM;
        
        public string SIG;
        [DisplayName("Signal")]
        public String p_SIG { get { return SIG; } }
    }

    class ExtSignals_Ports 
    {
        public int Port;
        [DisplayName("Port")]
        public int p_Port { get { return Port; } }
    }
}
