using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

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

        public TextBox textBox_ddSpecNum;
        public Label label_ddMyNum;
        //public Label label_ddSetNum;
        public RadioButton radioButton_ddNotSet;
        public RadioButton radioButton_ddSameAsComm;
        public RadioButton radioButton_ddSpecNum;


        public bool ActivityError = false;
        public bool ActivityErrorDelayed = false;
        public int ActivityErrorDelayed_Counter = 0;

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

        public void CommunicationOpen()
        {
            WriteSetting();
            WriteSetting();
            ReadSetting();
        }

        public void WriteSetting() 
        {

            if (radioButton_ddNotSet.Checked) 
            {

            }
            else if (radioButton_ddSameAsComm.Checked) 
            {
                SendCommand(CommunicationControl_ID_SET, (byte)eCommandCode_CommunicationControl.CMD_COMSW_DATA_DESTINATION_CMD_SOURCE, 0, 0);
            }
            else if (radioButton_ddSpecNum.Checked) 
            {
                uint destNum = 0;

                if (uint.TryParse(textBox_ddSpecNum.Text, out destNum))
                {
                    SendCommand(CommunicationControl_ID_SET, (byte)eCommandCode_CommunicationControl.CMD_COMSW_DATA_DESTINATION, 0, (byte)destNum);
                }
            }


        }

        public void ReadSetting() 
        {
            SendCommand(CommunicationControl_ID_GET, (byte)eCommandCode_CommunicationControl.CMD_COMSW_DATA_DESTINATION, 0, 0);
            SendCommand(CommunicationControl_ID_GET, (byte)eCommandCode_CommunicationControl.CMD_COMSW_CMD_COM_SOURCE, 0, 0);
        }


        public void UpdateFromCommunication(byte data_0, byte data_1, byte data_2)
        {

            switch ((eCommandCode_CommunicationControl)data_0)
            {

                case eCommandCode_CommunicationControl.CMD_COMSW_DATA_DESTINATION:
                    textBox_ddSpecNum.Text = data_2.ToString();
                    break;

                case eCommandCode_CommunicationControl.CMD_COMSW_CMD_COM_SOURCE:
                    label_ddMyNum.Text = data_2.ToString();
                    break;

                case eCommandCode_CommunicationControl.CMD_COMSW_ACTIVITY_MSG:
                        Last_ActivityMessage_Receive[0] = data_1;
                        Last_ActivityMessage_Receive[1] = data_2;
                    break;

                default:
                    break;

            }

        }

        static char[] caSplit = new char[] { ';' };

        public string GetSettingString() 
        {
            string s = String.Empty;

            if (radioButton_ddNotSet.Checked)
            {
                s = "NOTSET" + caSplit[0];
            }
            else if (radioButton_ddSameAsComm.Checked)
            {
                s = "SaC" + caSplit[0];
            }
            else if (radioButton_ddSpecNum.Checked)
            {
                uint destNum = 0;

                if (uint.TryParse(textBox_ddSpecNum.Text, out destNum))
                {
                    s = "SPEC" + caSplit[0] + destNum.ToString();
                }
            }

            return s;
        }

        public void SetFromString(string s) 
        {
            string[] s_parts = s.Split(caSplit);

            radioButton_ddNotSet.Checked = false;
            radioButton_ddSameAsComm.Checked = false;
            radioButton_ddSpecNum.Checked = false;


            if (s_parts[0].Equals("NOTSET")) 
            {
                radioButton_ddNotSet.Checked = true;
            }
            else if (s_parts[0].Equals("SaC"))
            {
                radioButton_ddSameAsComm.Checked = true;
            }
            else if (s_parts[0].Equals("SPEC"))
            {
                radioButton_ddSpecNum.Checked = true;

                if (s_parts.Length > 1) 
                {
                    textBox_ddSpecNum.Text = s_parts[1].ToString();
                }
                
            }
        }


        public void radioButtonsSetting_CheckedChanged() 
        {
            if (radioButton_ddSpecNum.Checked) 
            {
                textBox_ddSpecNum.Enabled = true;
            }
            else 
            {
                textBox_ddSpecNum.Text = String.Empty;
                textBox_ddSpecNum.Enabled = false;
            }
        }


        private void TimerActivityWatch_Event(object source, ElapsedEventArgs e)
        {
            //porovnani prijate a odeslane zpravy
            if(!(Last_ActivityMessage_Receive[0] == Last_ActivityMessage_Send[0] && Last_ActivityMessage_Receive[1] == Last_ActivityMessage_Send[1])) //nejsou stejne 
            {
                ActivityError = true;
                ActivityErrorDelayed_Counter += 50;

                /*
                if(Last_ActivityMessage_Receive[0] != Last_ActivityMessage_Receive[1]) 
                {
                    string s = Last_ActivityMessage_Receive[0].ToString("x") + "!" + Last_ActivityMessage_Send[0].ToString("x");
                    s += ".....";
                    s += Last_ActivityMessage_Receive[1].ToString("x") + "!" + Last_ActivityMessage_Send[1].ToString("x");

                    MessageBox.Show(s);
                }
                */

                
            }
            else
            {
                if(ActivityErrorDelayed_Counter > 0) 
                {
                    ActivityErrorDelayed_Counter--;
                }
            }

            if(ActivityErrorDelayed_Counter == 0)
            {
                ActivityErrorDelayed = false;
            }
            else 
            {
                ActivityErrorDelayed = true;
            }
            
            
            Last_ActivityMessage_Send[0] = (byte)(Last_ActivityMessage_Send[1] + 1);//0x00;
            Last_ActivityMessage_Send[1] = (byte)(Last_ActivityMessage_Send[1] + 1);

            SendCommand(CommunicationControl_ID_GET, (byte)eCommandCode_CommunicationControl.CMD_COMSW_ACTIVITY_MSG, Last_ActivityMessage_Send[0], Last_ActivityMessage_Send[1]);
        }

        /*
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
        */

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
