using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class Communication
    {
        public enum eCommandCode : byte
        {

            CMD_CONST_Loopback = 0x01,

            CMD_CONST_SET_Reset_Controler = 0x03,
            CMD_CONST_GET_Reset_Controler = 0x04,

            CMD_CONST_SET_TestRegisters = 0x11,
            CMD_CONST_GET_TestRegisters = 0x12,

            CMD_CONST_SET_AdcRegisters = 0x21,
            CMD_CONST_GET_AdcRegisters = 0x22,

            CMD_CONST_SET_HmcRegisters = 0x23,
            CMD_CONST_GET_HmcRegisters = 0x24,

            CMD_CONST_SET_Lmx1Registers = 0x25,
            CMD_CONST_GET_Lmx1Registers = 0x26,

            CMD_CONST_SET_Lmx2Registers = 0x27,
            CMD_CONST_GET_Lmx2Registers = 0x28,

            CMD_CONST_SET_TriggerRegisters = 0x31,
            CMD_CONST_GET_TriggerRegisters = 0x32,

            CMD_CONST_SET_GPIO = 0x33,
            CMD_CONST_GET_GPIO = 0x34,

            CMD_CONST_SET_CommunicationControl = 0x35,
            CMD_CONST_GET_CommunicationControl = 0x36,

            CMD_CONST_SET_TransceiversControl = 0x37,
            CMD_CONST_GET_TransceiversControl = 0x38,

            CMD_CONST_SET_AnalyzInCirc = 0x39,
            CMD_CONST_GET_AnalyzInCirc = 0x40,


            CMD_CONST_EVENT_HEAD = 0x7A,
            CMD_CONST_EVENT_TAIL = 0x7B,
            CMD_CONST_PACKET_HEAD = 0x7C,
            CMD_CONST_PACKET_TAIL = 0x7D

        }


        public enum eCommunicationType : byte
        {
            non,
            uart,
            usb,
            pcie
        };

        public delegate void efunction();
        public efunction ExecuteData;
        public efunction ExecuteCommand;
        

        public ComboBox comboBox_Ports;
        public RadioButton radioButton_UART;
        public RadioButton radioButton_USB;
        public RadioButton radioButton_PCIe;
        public Button button_Scan;
        public Button button_OpenClose;

        //public TextBox textBox_ddSpecNum;
        //public CheckBox checkBox_ddSameAsComm;
        //public Label label_ddMyNum;


        UART_Communication uart = new UART_Communication();
        usb_3_0 usb = new usb_3_0();

        public CommunicationControl communicationControl = new CommunicationControl(eCommandCode.CMD_CONST_GET_CommunicationControl, eCommandCode.CMD_CONST_SET_CommunicationControl);
        

        public eCommunicationType SelectedType;
        eCommunicationType OpenedType;

        public eCommandCode CommandID;
        public byte[] CommandData = new byte[3];

        public byte[] ReceivedData = new byte[4];

        Thread ThreadOfDataRead;
        bool ThreadOfDataRead_stop = false;

        


        public Communication()
        {
            usb.ErrorHandlerFunction = ErrorHandlerFunction;

            communicationControl.SendCommand = SendCommand;
            communicationControl.ErrorHandlerFunction = ErrorHandlerFunction;


        }






        private void ErrorHandlerFunction(string message)
        {
            //ToDo: dodelat
            
            if (message != string.Empty)
            {
                MessageBox.Show(message, "Communication ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseAll();

        }


        public void Scan()
        {


            if (radioButton_UART.Checked) 
            {
                SelectedType = eCommunicationType.uart;
            }
            else if (radioButton_USB.Checked)
            {
                SelectedType = eCommunicationType.usb;
            }
            else if (radioButton_PCIe.Checked)
            {
                SelectedType = eCommunicationType.pcie;
            }
            else 
            {
                SelectedType = eCommunicationType.non;
            }


            if (SelectedType == eCommunicationType.non) return;

            comboBox_Ports.SelectedIndex = -1;
            comboBox_Ports.Items.Clear();
            

            if (SelectedType == eCommunicationType.uart) 
            {
                foreach (String s in uart.PortScan())
                {
                    comboBox_Ports.Items.Add(s);
                }

                if (comboBox_Ports.Items.Count > 0)
                {
                    comboBox_Ports.SelectedIndex = 0;
                }
            }
            else if(SelectedType == eCommunicationType.usb) 
            {
                usb.DevicesScan(comboBox_Ports);
                
                if (comboBox_Ports.Items.Count > 0)
                {
                    comboBox_Ports.SelectedIndex = 0;
                }
            }





        }


        public void CloseAll() 
        {
            if (uart.IsOpen() || OpenedType == eCommunicationType.uart)
            {
                uart.StopRead();
                uart.ClosePort();
                OpenedType = eCommunicationType.non;
                EnableDisableControls(true);
                //return;
            }

            if (usb.IsOpen() || OpenedType == eCommunicationType.usb)
            //if (OpenedType == eCommunicationType.usb)
            {
                StopDataRead();
                usb.StopReceiving();
                usb.Close();
                OpenedType = eCommunicationType.non;
                EnableDisableControls(true);
                //return;
            }
        }

        public void OpenClose()
        {
            
            if (uart.IsOpen() || OpenedType == eCommunicationType.uart)
            {
                uart.StopRead();
                uart.ClosePort();
                OpenedType = eCommunicationType.non;
                EnableDisableControls(true);
                return;
            }

            if (usb.IsOpen() || OpenedType == eCommunicationType.usb)
            //if (OpenedType == eCommunicationType.usb)
            {
                StopDataRead();
                usb.StopReceiving();
                usb.Close();
                OpenedType = eCommunicationType.non;
                EnableDisableControls(true);
                return;
            }

            
            //CloseAll();

            if (SelectedType == eCommunicationType.uart) 
            {
                if (comboBox_Ports.SelectedIndex < 0)
                {
                    MessageBox.Show("Nevybran port", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string port = comboBox_Ports.SelectedItem as String;

                    try
                    {
                        uart.OpenPort(port);
                        uart.BeginRead(ReadData);

                        OpenedType = eCommunicationType.uart;
                        EnableDisableControls(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if(SelectedType == eCommunicationType.usb) 
            {
                if (comboBox_Ports.SelectedIndex < 0)
                {
                    MessageBox.Show("Nevybran port", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string port = comboBox_Ports.SelectedItem as String;

                    try
                    {
                        usb.OpenByString(port);
                        usb.StartReceiving();
                        StartDataRead();

                        OpenedType = eCommunicationType.usb;
                        
                        EnableDisableControls(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }


            communicationControl.CommunicationOpen();

        }

        public void SendCommand(eCommandCode CMD, byte[] data)
        {
            byte id = (byte)(0x80 | (byte)CMD);

            if(SelectedType == eCommunicationType.non) 
            {
                return;
            }
            else if(SelectedType == eCommunicationType.uart) 
            {
                uart.SendCommand(id, data[0], data[1], data[2]);
            }
            else if (SelectedType == eCommunicationType.usb)
            {
                usb.SendCommand(id, data[0], data[1], data[2]);
            }
        }

        public void SendCommand(eCommandCode CMD, byte data_0, byte data_1, byte data_2)
        {
            byte id = (byte)(0x80 | (byte)CMD);

            if (SelectedType == eCommunicationType.non)
            {
                return;
            }
            else if (SelectedType == eCommunicationType.uart)
            {
                uart.SendCommand(id, data_0, data_1, data_2);
            }
            else if (SelectedType == eCommunicationType.usb)
            {
                usb.SendCommand(id, data_0, data_1, data_2);
            }

        }

        public void SendCommand(eCommandCode CMD, string address, string value)
        {
            byte id = (byte)(0x80 | (byte)CMD);

            int i_address = 0;
            if (!int.TryParse(address, System.Globalization.NumberStyles.HexNumber, null, out i_address))
            {
                return;
            }

            byte i_value = 0;
            if (!byte.TryParse(value, System.Globalization.NumberStyles.HexNumber, null, out i_value))
            {
                return;
            }



            if (SelectedType == eCommunicationType.non)
            {
                return;
            }
            else if (SelectedType == eCommunicationType.uart)
            {
                uart.SendCommand(id, (byte)((i_address >> 8) & 0x00FF), (byte)(i_address & 0x00FF), i_value);
            }
            else if (SelectedType == eCommunicationType.usb)
            {
                usb.SendCommand(id, (byte)((i_address >> 8) & 0x00FF), (byte)(i_address & 0x00FF), i_value);
            }

        }

        
        /*
        public void SendCommand_XXX(int CMD, int address, int value)
        {
            byte id = (byte)(0x80 | (byte)CMD);

            uart.SendCommand(id, (byte)((address >> 8) & 0x00FF), (byte)(address & 0x00FF), (byte)value);
        }
        */


        private void ReadData() 
        {
            byte[] data = uart.dataBuffer;
            ReceivedData = data;

            if ((data[0] & 0x80) >> 7 == 0) 
            {
                ExecuteData();
            }
            else 
            {

                CommandID = (eCommandCode)(data[0] & 0x7F);
                CommandData[0] = data[1];
                CommandData[1] = data[2];
                CommandData[2] = data[3];

                if(CommandID == eCommandCode.CMD_CONST_EVENT_HEAD || CommandID == eCommandCode.CMD_CONST_EVENT_TAIL || 
                    CommandID == eCommandCode.CMD_CONST_PACKET_HEAD || CommandID == eCommandCode.CMD_CONST_PACKET_TAIL) 
                {
                    ExecuteData();
                    return;
                }

                ExecuteCommand();
            }

        }

        private void ReadData_USB()
        {
            byte[] data = new byte[4];
            

            while (!ThreadOfDataRead_stop)
            {

                if (usb.BytesInqueue() < data.Length)
                {
                    continue;
                }
                
                //bool isSuccessful = usb.GetDataBytes(out data, (uint)data.Length);
                bool isSuccessful = usb.GetDataWord(out data);
                if (isSuccessful == false)
                {
                    continue;
                }


                ReceivedData = data;

                if ((data[0] & 0x80) >> 7 == 0)
                {
                    ExecuteData();
                }
                else
                {

                    CommandID = (eCommandCode)(data[0] & 0x7F);
                    CommandData[0] = data[1];
                    CommandData[1] = data[2];
                    CommandData[2] = data[3];

                    if (CommandID == eCommandCode.CMD_CONST_EVENT_HEAD || CommandID == eCommandCode.CMD_CONST_EVENT_TAIL ||
                        CommandID == eCommandCode.CMD_CONST_PACKET_HEAD || CommandID == eCommandCode.CMD_CONST_PACKET_TAIL)
                    {
                        ExecuteData();
                        
                    }
                    else 
                    {
                        ExecuteCommand();
                    }

                    
                }

            }

        }

        private void StartDataRead() 
        {
            if (SelectedType == eCommunicationType.non) return;
            
            ThreadOfDataRead = new Thread(this.ReadData_USB);
            ThreadOfDataRead_stop = false;
            ThreadOfDataRead.Start();
        }

        private void StopDataRead() 
        {
            if (ThreadOfDataRead == null) return;

            ThreadOfDataRead_stop = true;
            ThreadOfDataRead = null;
        }

        private void EnableDisableControls(bool state) 
        {
            if (!state) 
            {
                communicationControl.ActivityMonitor_Start();
            }
            else 
            {
                communicationControl.ActivityMonitor_Stop();
            }
            
            comboBox_Ports.Enabled = state;
            radioButton_UART.Enabled = state;
            radioButton_USB.Enabled = state;
            radioButton_PCIe.Enabled = state;
            button_Scan.Enabled = state;
            //button_OpenClose.Enabled = state;
        }


        public bool OpenAutomatic(eCommunicationType type, string name) 
        {
            
            radioButton_UART.Checked = false;
            radioButton_USB.Checked = false;
            radioButton_PCIe.Checked = false;
            
            if(type == eCommunicationType.uart) 
            {
                radioButton_UART.Checked = true;
            }
            else if (type == eCommunicationType.usb)
            {
                radioButton_USB.Checked = true;
            }
            else if (type == eCommunicationType.pcie)
            {
                radioButton_PCIe.Checked = true;
            }


            Scan();

            

            int Selected = -1;
            int count = comboBox_Ports.Items.Count;
            for (int i = 0; (i <= (count - 1)); i++)
            {
                comboBox_Ports.SelectedIndex = i;
                string port = comboBox_Ports.SelectedItem as String;

                if (name.Equals(port))
                {
                    Selected = i;
                    
                }

            }

            if(Selected > 0) 
            {
                comboBox_Ports.SelectedIndex = Selected;
                OpenClose();
                return true;
            }

            comboBox_Ports.SelectedIndex = Selected = -1;

            return false;
        
        }


        static char[] caSplit = new char[] { ';' };
        public bool OpenBySettingString(string s)
        {
            string[] s_parts = s.Split(caSplit);


            radioButton_UART.Checked = false;
            radioButton_USB.Checked = false;
            radioButton_PCIe.Checked = false;

            if (s_parts[0].Equals("uart"))
            {
                radioButton_UART.Checked = true;
            }
            else if (s_parts[0].Equals("usb"))
            {
                radioButton_USB.Checked = true;
            }
            else if (s_parts[0].Equals("pcie"))
            {
                radioButton_PCIe.Checked = true;
            }
            else 
            {
                return false;
            }


            Scan();

            

            int Selected = -1;
            int count = comboBox_Ports.Items.Count;
            for (int i = 0; (i <= (count - 1)); i++)
            {
                comboBox_Ports.SelectedIndex = i;
                string port = comboBox_Ports.SelectedItem as String;

                if (s_parts[1].Equals(port))
                {
                    Selected = i;
                    
                }

            }

            if (Selected >= 0)
            {
                comboBox_Ports.SelectedIndex = Selected;
                OpenClose();
                return true;
            }

            comboBox_Ports.SelectedIndex = Selected = -1;

            return false;

        }

        public string GetSettingString() 
        {
            string s;

            eCommunicationType type = OpenedType;
            string port = comboBox_Ports.SelectedItem as String;

            if(type == eCommunicationType.uart) 
            {
                s = "uart" + caSplit[0] + port;
            }
            else if (type == eCommunicationType.usb)
            {
                s = "usb" + caSplit[0] + port;
            }
            else if (type == eCommunicationType.pcie)
            {
                s = "pcie" + caSplit[0] + port;
            }
            else 
            {
                s = "non" + caSplit[0] + port;
            }

            return s;
        }


        private void comm_log(byte[] data)
        {
            //using (StreamWriter writer = new StreamWriter("comm_log.txt"))
            using (StreamWriter writer = File.AppendText("comm_log.txt"))
            {
                string s = String.Empty;

                for (int i = 0; i < 4; i++)
                {
                    s += data[i].ToString("X2") + " ";
                }



                writer.WriteLine(s);
            }
        }


        public UInt64 USB_RecvBytes()
        {
            return usb.GetReceivedBytes();
        }

        public int USB_InQ()
        {
            return usb.BytesInqueue();
        }

        public void UsbPortCycle() 
        {
            usb.PortCycle();
        }

    }
}
