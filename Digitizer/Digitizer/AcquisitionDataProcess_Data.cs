using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitizer_ver1
{
    class AcquisitionDataProcess_Data
    {
        int _eventNum;
        [DisplayName("Event")]
        public int p_eventNum { get { return _eventNum; } }

        int _eventSize;
        [DisplayName("Size")]
        public int p_eventSize { get { return _eventSize; } }



        public BindingList<int> List_SampleData = new BindingList<int>();




        public AcquisitionDataProcess_Data(int eventNum)
        {
            _eventNum = eventNum;
            _eventSize = 0;
        }

        public void ActualingSize(int size)
        {
            _eventSize = size;
        }

        public void IncreaseSize(int Increase)
        {
            _eventSize = _eventSize + Increase;
        }

        public void AddSample(int Sample) 
        {
            List_SampleData.Add(Sample);
        }

        public void AddSampleAndSize(int Sample)
        {
            List_SampleData.Add(Sample);
            _eventSize = _eventSize + 1;
        }

    }

    /*
    class EventMeasurement_Data
    {

        int _sample;
        [DisplayName("Sample")]
        public int p_sample { get { return _sample; } }

    }
    */

}
