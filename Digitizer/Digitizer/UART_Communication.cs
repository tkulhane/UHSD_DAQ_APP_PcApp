using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class UART_Communication
    {
        private SerialPort serialport = new SerialPort();

        public delegate void efunction();
        efunction ExecuteFunction;
        Timer read_timer = new Timer();

        public string[] PortScan() 
        {
            return SerialPort.GetPortNames();
        }

        public bool IsOpen()
        {
            return serialport.IsOpen;
        }

        public bool OpenPort(string name)
        {
            serialport.PortName = name;
            serialport.BaudRate = 115200;
            

            try
            {
                serialport.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Open Serial Port Fault", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ClosePort() 
        {
            serialport.Close();
        }

        public void SendCommand(byte ID, byte data_1, byte data_2, byte data_3) 
        {
            if (!serialport.IsOpen) return;

            byte[] buffer = { ID, data_1, data_2, data_3 };

            byte[] txBuffer = new byte[2 * 4 + 2];
            int txBufferPos = 0;
            byte c;

            txBuffer[txBufferPos++] = 0x02;

            for (int i = 0; i < 4; i++)
            {

                // first nibble
                c = (byte)(buffer[i] >> 4);
                txBuffer[txBufferPos++] = (byte)((c << 4) | (c ^ 0x0F));

                // second nibble
                c = (byte)(buffer[i] & 0x0F);
                txBuffer[txBufferPos++] = (byte)((c << 4) | (c ^ 0x0F));
            }

            txBuffer[txBufferPos++] = 0x03;

            serialport.Write(txBuffer,0,txBuffer.Length);
        }

        public bool BeginRead(efunction f)
        {
            if (!serialport.IsOpen)
            {
                return false;
            }

            read_timer.Tick += new System.EventHandler(Read_UART);
            read_timer.Interval = 5;
            read_timer.Enabled = true;
            

            ExecuteFunction = f;

            return true;
        }

        public void StopRead() 
        {
            read_timer.Enabled = false;
        }




        public byte[] dataBuffer = new byte[4];
        
        private int dataBuf_pos = 0;
        private int next_nibble = 0;
        private byte temporary_nibble = 0;

        private void Read_UART(object sender, EventArgs e)
        {
            if (!serialport.IsOpen)
            {
                return;
            }

            while (serialport.BytesToRead > 0)
            {
                byte b = (byte)serialport.ReadByte();

                if (b == 0x02) //STX detect
                {
                    //dataBuf_pos = 0;
                    next_nibble = 1;
                }
                if (b == 0x03) //ETX detect
                {


                    if (next_nibble == 0) 
                    {
                        next_nibble = 0;
                        dataBuf_pos = 0;
                        return;
                    }

                    if (dataBuf_pos != 4)
                    {
                        next_nibble = 0;
                        dataBuf_pos = 0;
                        return;
                    }

                    next_nibble = 0;
                    dataBuf_pos = 0;

                    ExecuteFunction();

                }
                else
                {

                    if ((b >> 4) != ((b & 0x0F) ^ 0x0F)) //nibble is bad
                        return;

                    if (dataBuf_pos > 3)
                        return;

                    if (next_nibble == 1)
                    {

                        temporary_nibble = b;

                        next_nibble = 2;
                    }
                    else if (next_nibble == 2)
                    {

                        dataBuffer[dataBuf_pos] = (byte)(((temporary_nibble) & 0xF0) + ((b >> 4) & 0x0F));

                        dataBuf_pos++;

                        next_nibble = 1;
                    }
                }
            }
        
        }


    }
}
