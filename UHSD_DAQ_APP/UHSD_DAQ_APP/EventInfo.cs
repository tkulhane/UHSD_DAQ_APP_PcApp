using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class EventInfo : IFormattable
    {


        int _eventNum;
        [DisplayName("Event")]
        public int p_eventNum { get { return _eventNum; } }


        int _eventSize;
        [DisplayName("Size")]
        public int p_eventSize { get { return _eventSize; } }


        int _eventStart;
        [DisplayName("Start")]
        public int p_eventStart { get { return _eventStart; } }


        public EventInfo(int e, int start) 
        {
            _eventNum = e;
            _eventSize = 0;
            _eventStart = start;
        }

        public void ActualingSize(int size)
        {
            _eventSize = size;
        }

        public void IncreaseSize(int Increase)
        {
            _eventSize = _eventSize + Increase;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }
    }
}
