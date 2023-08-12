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

            //nacteni poctu pripojenych zarizeni
            ftStatus = d3xxDevice.GetNumberOfDevicesConnected(out ftdiDeviceCount);
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
                string s = DeviceInfo.Description.ToString();
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
            return d3xxDevice.IsOpen;
        }

        public uint SendCommand(byte ID, byte data_1, byte data_2, byte data_3) 
        {
            FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OK;
            
            byte[] buffer = { ID, data_1, data_2, data_3 };
            uint transfered = 0;
            
            d3xxDevice.WritePipe(0x02, buffer, (uint)buffer.Length, ref transfered);

            if (ftStatus != FTDI.FT_STATUS.FT_OK)
            {
                string msg = "Failed to send data (error " + ftStatus.ToString() + ")";
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            if(buffer.Length != transfered) 
            {
                string msg = "Failed to send data (error " + ftStatus.ToString() + ")";
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

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

                byte[] readData = new byte[4];
                UInt32 numBytesRead = 0;

                ftStatus = d3xxDevice.ReadPipe(0x82, readData, (UInt32)readData.Length, ref numBytesRead);
                if (ftStatus != FTDI.FT_STATUS.FT_OK)
                {
                    string msg = "Failed to read data (error " + ftStatus.ToString() + ")";
                    MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(numBytesRead == 0) 
                {
                    continue;
                }
                else if(numBytesRead == readData.Length) 
                {
                    //nahodit nejakou chybu?
                    return; //nebo jen continue?
                }

                for(int i = 0; i < readData.Length; i++) 
                {
                    queue.Enqueue(readData[i]);
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


    }
}
