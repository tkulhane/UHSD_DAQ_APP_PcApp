using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class EventData : IFormattable
    {
        int _event;
        [DisplayName("Event")]
        public int p_event { get { return _event; } }

        int _sample;
        [DisplayName("Sample")]
        public int p_sample { get { return _sample; } }


        public EventData(int e, int s) 
        {
            _event = e;
            _sample = s;
        }


        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

    }


}
