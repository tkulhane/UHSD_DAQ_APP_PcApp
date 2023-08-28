using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTD3XX_NET;

namespace Digitizer_ver1
{
    class usb_3_0
    {

        FTDI d3xxDevice;
        List<FTDI.FT_DEVICE_INFO> ListDeviceInfo;

        ConcurrentQueue<byte> queue = new ConcurrentQueue<byte>();
        UInt64 ReceivedBytes;
        Thread ThreadOfReceiving;
        bool ThreadOfReceiving_stop = false;

        public UInt32 DevicesScan(ComboBox comboBox_Devices) 
        {
            UInt32 ftdiDeviceCount = 0;

            FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OK;
            d3xxDevice = new FTDI();
            
            /*
            //nacteni poctu pripojenych zarizeni
            ftStatus = d3xxDevice.GetNumberOfDevicesConnected(out ftdiDeviceCount);
            //MessageBox.Show(ftdiDeviceCount.ToString(), "xxx", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                string msg = "Failed to get number of devices(error " + ftStatus.ToString() + ")";
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            //zadne zarizeni neni dostupne - return
            if (ftdiDeviceCount == 0)
            {
                return 0;
            }
            */

            ftStatus = d3xxDevice.CreateDeviceInfoList(out ftdiDeviceCount);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                string msg = "Failed to get number of devices (create device info list)(error " + ftStatus.ToString() + ")";
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            //zadne zarizeni neni dostupne - return
            if (ftdiDeviceCount == 0)
            {
                return 0;
            }


            ftStatus = d3xxDevice.GetDeviceInfoList(out ListDeviceInfo);
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                string msg = "Failed to get Info of Devices(error " + ftStatus.ToString() + ")";
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            if (ListDeviceInfo.Count == 0) return 0;

            if (comboBox_Devices == null) return ftdiDeviceCount;

            comboBox_Devices.Items.Clear();

            foreach (var DeviceInfo in ListDeviceInfo)
            {
                string s = d3xxDevice.GetDescription(DeviceInfo);
                //string s = DeviceInfo.Description.ToString();
                comboBox_Devices.Items.Add(s);
            }


            return ftdiDeviceCount;
        }


        public void OpenByString(string s)
        {
            FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OK;

            ftStatus = d3xxDevice.OpenByDescription(s);

            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                string msg = "Failed to open device (error " + ftStatus.ToString() + ")";
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            //DisablePipeTimeout(d3xxDevice, 0x02);
            DisablePipeTimeout(d3xxDevice, 0x82);



            int count = d3xxDevice.DataPipeInformation.Count;
            //MessageBox.Show(d3xxDevice.IsOpen.ToString() + " usb3: " + d3xxDevice.IsUSB3.ToString(), "MSG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Pipes: " + count.ToString(), "MSG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string p = "Pipes: ";

            foreach (var desc in d3xxDevice.DataPipeInformation) 
            {
                p += desc.PipeId.ToString("X");
                p += ", ";
            }

            //MessageBox.Show(p, "MSG", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public void Close() 
        {
            FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OK;
            ftStatus = d3xxDevice.Close();
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                string msg = "Failed to close device (error " + ftStatus.ToString() + ")";
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public bool IsOpen() 
        {
            if (d3xxDevice == null) return false;
            return d3xxDevice.IsOpen;
        }

        public void PortCycle() 
        {
            d3xxDevice.CycleDevicePort();
        }

        public uint SendCommand(byte ID, byte data_1, byte data_2, byte data_3) 
        {
            if (!d3xxDevice.IsOpen) return 0 ;

            FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OK;

            //byte[] buffer = { ID, data_1, data_2, data_3 };
            byte[] buffer = { data_3, data_2, data_1, ID };
            UInt32 transfered = 0;

            /*
            UInt32 loopBytes = 256;
            byte[] buffer = new byte[loopBytes];

            for (UInt32 j = 0; j < buffer.Length; j++)
            {
                buffer[j] = 0xAA;
            }
            */

            //NativeOverlapped overlappedWrite = new NativeOverlapped();

            ftStatus = d3xxDevice.WritePipe(0x02, buffer, (UInt32)buffer.Length, ref transfered);
            //d3xxDevice.WritePipeEx(0x02, buffer, (uint)buffer.Length, ref transfered, ref overlappedWrite);
            //d3xxDevice.AbortPipe(0x02);

            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                d3xxDevice.Close();


                string msg = "Failed to send data (error " + ftStatus.ToString() + ")";
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                d3xxDevice.AbortPipe(0x02);
                return 0;
            }

            if(buffer.Length != transfered) 
            {
                string msg = "Failed to send data - Length Does Not Match :" + (buffer.Length).ToString() + " != " + transfered.ToString();
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            //MessageBox.Show(transfered.ToString(), "Send", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return transfered;
        }

        public void QueueClear()
        {
            //ReceivedBytes = 0;
            //queue.Clear();
        }

        public UInt64 GetReceivedBytes()
        {
            return ReceivedBytes;
        }

        public void ResetReceivedBytes()
        {
            ReceivedBytes = 0;
        }

        public void Receive() 
        {
            while (!ThreadOfReceiving_stop) //prijem dokud neni zastavene vlakno
            {
                if (!d3xxDevice.IsOpen) return;

                FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OK;

                byte[] readData = new byte[2048];
                UInt32 numBytesRead = 0;

                ftStatus = d3xxDevice.ReadPipe(0x82, readData, (UInt32)readData.Length, ref numBytesRead);
                if (ftStatus != FTDI.FT_STATUS.FT_OK)
                {
                    if (ThreadOfReceiving_stop) return;
                    
                    string msg = "Failed to read data (error " + ftStatus.ToString() + ")";
                    MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(numBytesRead == 0) 
                {
                    continue;
                }

                //for(int i = 0; i < readData.Length; i++) 
                for(int i = 0; i < numBytesRead; i++) 
                {
                    queue.Enqueue(readData[i]);

                    //queue.Enqueue(readData[readData.Length - 1 - i]);
                    ReceivedBytes++;

                }

            }
        }


        public void StartReceiving()
        {
            if (!d3xxDevice.IsOpen) return;
            ThreadOfReceiving = new Thread(this.Receive);
            ThreadOfReceiving.Start();
        }

        public void StopReceiving()
        {
            if (ThreadOfReceiving == null) return;

            ThreadOfReceiving_stop = true;
            ThreadOfReceiving = null;
        }

        public bool GetDataBytes(out byte[] data, uint NumOfBytes)
        {
            bool isSuccessful = true;
            byte[] readData = new byte[NumOfBytes];

            for (int i = 0; i < NumOfBytes; i++) 
            {
                byte read = 0;

                if(!queue.TryDequeue(out read)) 
                {
                    isSuccessful = false;
                }

                readData[i] = read;
            }
             
            data = readData;
            return isSuccessful;
        }

        public bool GetDataWord(out byte[] data)
        {
            bool isSuccessful = true;
            byte[] readData = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                byte read = 0;

                if (!queue.TryDequeue(out read))
                {
                    isSuccessful = false;
                }

                readData[4-1 - i] = read;
            }

            data = readData;
            return isSuccessful;
        }

        public bool GetDataByte(out byte data)
        {
            byte read = 0;
            bool isSuccessful = queue.TryDequeue(out read);
            data = read;

            return isSuccessful;
        }

        public int BytesInqueue()
        {
            return queue.Count;
        }

        public static void DisablePipeTimeout(FTDI d3xxDevice, byte bReadPipe)
        {
            FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OK;

            if (!d3xxDevice.IsOpen)
            {
                return;
            }

            if (d3xxDevice.LibraryVersion > 0x01010000 &&
                d3xxDevice.DriverVersion > 0x01010000)
            {
                // Disable timeout by setting to 0
                ftStatus = d3xxDevice.SetPipeTimeout(bReadPipe, 0);
                if (ftStatus != FTDI.FT_STATUS.FT_OK)
                {
                    //Debug.Log("\tSetPipeTimeout 0x{0:X2} {1}", bReadPipe, 0);

                    string msg = "Set Pipe Timeout Error (error " + ftStatus.ToString() + ")";
                    MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }


    }
}
