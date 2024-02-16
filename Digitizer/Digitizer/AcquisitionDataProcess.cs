using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Digitizer_ver1
{
    class AcquisitionDataProcess
    {

        public DataGridView dataGridView_Events;
        public Chart chart_data;
        public CheckBox checkBox_SaveToRam;
        public CheckBox checkBox_SaveToFile;

        BindingList<AcquisitionDataProcess_Data> List_EventsData = new BindingList<AcquisitionDataProcess_Data>();

        AcquisitionDataProcess_Data ActualEventData;

        UInt64 EventsCount_Started = 0;
        UInt64 EventsCount_Completed = 0;
        UInt64 PacketCounter = 0;
        int FrameInPacketCounter = 0;

        int frameOrder_Last;
        int frameOrder;

        bool SavingInRam = false;
        bool SavingInFile = false;

        public int ErrorCounter = 0;

        public void SetAcquisitionDataProcess() 
        {
            dataGridView_Events.DataSource = List_EventsData;

            for (int i = 0; i < dataGridView_Events.Columns.Count; i++)
            {
                dataGridView_Events.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        public void ExecuteData(byte[] data)
        {

            string logStr = string.Empty;
            string logErr = string.Empty;

            if (data[0] == 0xFA) //Event head - actualing Number Of Event
            {
                if (EventsCount_Completed != EventsCount_Started)
                {
                    //error
                    ErrorCounter++;
                    logErr += "Event Counts ";
                    logErr += "S=" + EventsCount_Started.ToString();
                    logErr += " C=" + EventsCount_Completed.ToString();
                }
                EventsCount_Started++;

                ActualEventData = null;
                ActualEventData = new AcquisitionDataProcess_Data(data[3]);

                logStr += "Event Head; Event Num = " + ActualEventData.p_eventNum.ToString();

            }

            else if (data[0] == 0xFB) //Event tail - store event
            {
                if(PacketCounter != data[3]) 
                {
                    //error
                    ErrorCounter++;
                    logErr += "Packet Order ";
                }
                PacketCounter = 0;

                EventsCount_Completed++;
                if(EventsCount_Completed != EventsCount_Started) 
                {
                    //Error
                    ErrorCounter++;
                    logErr += "Event Counts ";
                    logErr += "S=" + EventsCount_Started.ToString();
                    logErr += " C=" + EventsCount_Completed.ToString();
                }

                SaveEventData();

                logStr += "Event Tail; Packet Count = " + data[3].ToString();
                logStr += Environment.NewLine;
            }

            else if (data[0] == 0xFC) //Packet head
            {
                PacketCounter++;

                logStr += "Packet Head; Packet Num = " + data[3].ToString();
            }

            else if (data[0] == 0xFD) //Packet tail
            {
                if(FrameInPacketCounter != data[3]) 
                {
                    //error
                    ErrorCounter++;
                    logErr += "Frame Count ";
                }
                FrameInPacketCounter = 0;

                logStr += "Packet Tail; Frames Count = " + data[3].ToString();
            }

            else if ((data[0] & 0x80) >> 7 == 0) // data frame
            {
                
                frameOrder_Last = frameOrder;
                frameOrder = data[0];

                if(FrameInPacketCounter == 0) 
                {
                    if(frameOrder != 0) 
                    {
                        //error
                        ErrorCounter++;
                        logErr += "Frame Order 0 ";
                    }
                }

                else if(frameOrder != frameOrder_Last + 1) 
                {
                    //error
                    ErrorCounter++;
                    logErr += "Frame Order ";
                    logErr += "C=" + frameOrder.ToString();
                    logErr += " L=" + frameOrder_Last.ToString();
                }

                FrameInPacketCounter++;

                

                int sample1 = data[3] + ((data[2] & 0x0F) << 8);
                int sample2 = ((data[2] & 0xF0) >> 4) + (data[1] << 4);

                ActualEventData.AddSampleAndSize(sample1);
                ActualEventData.AddSampleAndSize(sample2);

                logStr += "Frame = " + frameOrder.ToString();
                logStr += "; Sample 1 = " + sample1.ToString();
                logStr += "; Sample 2 = " + sample2.ToString();

                

            }
            /*
            logStr += Environment.NewLine;
            using (StreamWriter writer = File.AppendText("log_Communication_data.txt"))
            {
                writer.Write(logStr);
            }

            if(logErr != string.Empty) logErr += Environment.NewLine;
            using (StreamWriter writer = File.AppendText("log_Error_data.txt"))
            {
                writer.Write(logErr);
            }
            */


        }


        private void SaveEventData() 
        {
            if (SavingInRam) 
            {
                List_EventsData.Add(ActualEventData);
                dataGridView_Events.Update();
            }
            if (SavingInFile) 
            {

            }
        }


        public void UpdateSaving() 
        {
            SavingInRam = checkBox_SaveToRam.Checked;
            SavingInFile = checkBox_SaveToFile.Checked;
        }

        public void chart_data_Click(object sender, EventArgs e)
        {

            int selectedRows = dataGridView_Events.SelectedRows.Count;

            if (selectedRows == 0)
            {
                return;
            }

            //chart_data.Series["Data"].Points.Clear();
            chart_data.Series.Clear();

            for (int r = 0; r < selectedRows; r++)
            {

                int selectedIndex = dataGridView_Events.SelectedRows[r].Index;
                // EventInfo SelectedEvent = list_events[selectedIndex];
                AcquisitionDataProcess_Data ActualEventData = List_EventsData[selectedIndex];

                //int EventStartIndex = SelectedEvent.p_eventStart;
                //int EventEndIndex = EventStartIndex + SelectedEvent.p_eventSize - 1;

                chart_data.Series.Add(r.ToString());
                chart_data.Series[r.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_data.Series[r.ToString()].LegendText = ActualEventData.p_eventNum.ToString();
                chart_data.Series[r.ToString()].BorderWidth = 3;


                for (int i = 0; i < ActualEventData.List_SampleData.Count; i++)
                {
                    chart_data.Series[r.ToString()].Points.AddY(ActualEventData.List_SampleData[i]);
                }

            }

            chart_data.DataBind();
        }


        public void ClearEventsList() 
        {
            List_EventsData.Clear();
        }


    }
}
