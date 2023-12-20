using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Digitizer_ver1
{
    class CommunicationControl
    {

        public enum eCommandCode_CommunicationControl : byte
        {

            CMD_COMSW_DATA_DESTINATION = 0x11,
            CMD_COMSW_DATA_DESTINATION_CMD_SOURCE = 0x12,
            CMD_COMSW_CMD_COM_SOURCE = 0x31,        
            CMD_COMSW_ACTIVITY_MSG  = 0xA1,           
            CMD_COMSW_CONNECTED_COM  = 0xA5             

        }

        public delegate void efunction1(Communication.eCommandCode CMD, byte d1, byte d2, byte d3);
        public efunction1 SendCommand;

        public delegate void efunction2(string message);
        public efunction2 ErrorHandlerFunction;


        public bool ActivityError = false;

        System.Timers.Timer TimerActivityWatch = new System.Timers.Timer();

        public byte[] Last_ActivityMessage_Send = new byte[2];
        public byte[] Last_ActivityMessage_Receive = new byte[2];
        private Communication.eCommandCode CommunicationControl_ID_GET;
        private Communication.eCommandCode CommunicationControl_ID_SET;

        public CommunicationControl(Communication.eCommandCode ID_GET, Communication.eCommandCode ID_SET) 
        {
            TimerActivityWatch.Elapsed += new ElapsedEventHandler(TimerActivityWatch_Event);

            TimerActivityWatch.Interval = 500;

            CommunicationControl_ID_GET = ID_GET;
            CommunicationControl_ID_SET = ID_SET;
        }
        

        private void TimerActivityWatch_Event(object source, ElapsedEventArgs e)
        {
            //porovnani prijate a odeslane zpravy
            if(!(Last_ActivityMessage_Receive[0] == Last_ActivityMessage_Send[0] && Last_ActivityMessage_Receive[1] == Last_ActivityMessage_Send[1])) //nejsou stejne 
            {
                ActivityError = true;
            }
            
            
            Last_ActivityMessage_Send[0] = 0x00;
            Last_ActivityMessage_Send[1] = (byte)(Last_ActivityMessage_Send[1] + 1);

            SendCommand(CommunicationControl_ID_GET, (byte)eCommandCode_CommunicationControl.CMD_COMSW_ACTIVITY_MSG, Last_ActivityMessage_Send[0], Last_ActivityMessage_Send[1]);
        }

        public void ActivityWatchUpdate(byte data_0, byte data_1, byte data_2)
        {
            switch ((eCommandCode_CommunicationControl)data_0)
            {
                case eCommandCode_CommunicationControl.CMD_COMSW_ACTIVITY_MSG:
                        Last_ActivityMessage_Receive[0] = data_1;
                        Last_ActivityMessage_Receive[1] = data_2;
                    break;

                default:
                    break;

            }
        }


        public void ActivityMonitor_Start() 
        {
            Last_ActivityMessage_Send[0] = 0x00;
            Last_ActivityMessage_Send[1] = 0x00;

            Last_ActivityMessage_Receive[0] = 0x00;
            Last_ActivityMessage_Receive[1] = 0x00;

            TimerActivityWatch.Enabled = true;

            ActivityError = false;
        }

        public void ActivityMonitor_Stop()
        {
            TimerActivityWatch.Enabled = false;
        }

    }
}
