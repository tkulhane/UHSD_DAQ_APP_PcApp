using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class Communication
    {
        public enum eCommandCode : byte
        {

            CMD_CONST_Loopback = 0x01,

            CMD_CONST_SET_System_Controler = 0x03,
            CMD_CONST_GET_System_Controler = 0x04,

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


        UART_Communication uart = new UART_Communication();
        public eCommunicationType SelectedType;
        eCommunicationType OpenedType;

        public eCommandCode CommandID;
        public byte[] CommandData = new byte[3];

        public byte[] ReceivedData = new byte[4];

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

            comboBox_Ports.Items.Clear();

            if(SelectedType == eCommunicationType.uart) 
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

            if (OpenedType == eCommunicationType.usb)
            {
            //    .StopRead();
            //    .ClosePort();
                OpenedType = eCommunicationType.non;
                EnableDisableControls(true);
                return;
            }



            if(SelectedType == eCommunicationType.uart) 
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
                OpenedType = eCommunicationType.usb;
                EnableDisableControls(false);
            }

        }

        public void SendCommand(eCommandCode CMD, byte[] data)
        {
            byte id = (byte)(0x80 | (byte)CMD);

            uart.SendCommand(id, data[0], data[1], data[2]);
        }

        public void SendCommand(eCommandCode CMD, byte data_0, byte data_1, byte data_2)
        {
            byte id = (byte)(0x80 | (byte)CMD);

            uart.SendCommand(id, data_0, data_1, data_2);
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

            uart.SendCommand(id, (byte)((i_address >> 8) & 0x00FF), (byte)(i_address & 0x00FF), i_value);
        }

        public void SendCommand_XXX(int CMD, int address, int value)
        {
            byte id = (byte)(0x80 | (byte)CMD);

            uart.SendCommand(id, (byte)((address >> 8) & 0x00FF), (byte)(address & 0x00FF), (byte)value);
        }



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

        private void EnableDisableControls(bool state) 
        {
            comboBox_Ports.Enabled = state;
            radioButton_UART.Enabled = state;
            radioButton_USB.Enabled = state;
            radioButton_PCIe.Enabled = state;
            button_Scan.Enabled = state;
            //button_OpenClose.Enabled = state;
    }




    }
}
