using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class Acquisition_Control
    {

        const float fpgaLogicClock = (float)125000000;

        public enum eCommandCode_Trigger : byte
        {

            CMD_TRG_ENABLE = 0x01,
            CMD_TRG_MODE = 0x02,
            CMD_TRG_ABORT_MODE = 0x03,
            CMD_TRG_TRIGGER_SELECT = 0x04,

            CMD_TRG_SW_TRIGGER = 0x10,

            CMD_TRG_THRESHOLD = 0x11,

            CMD_TRG_SAMPLE_PER_EVENT_L = 0x12,
            CMD_TRG_SAMPLE_PER_EVENT_M = 0x13,

            CMD_TRG_SET_NUMBERS_OF_EVENTS_L = 0x14,
            CMD_TRG_SET_NUMBERS_OF_EVENTS_M = 0x15,
            CMD_TRG_SET_TIME_FOR_RUN_L = 0x16,
            CMD_TRG_SET_TIME_FOR_RUN_M = 0x17,

            CMD_TRG_COUNTERS_RESET = 0x20,

            CMD_TRG_COUNTER_EVENT_INCOMING_L = 0x21,
            CMD_TRG_COUNTER_EVENT_INCOMING_M = 0x22,
            CMD_TRG_COUNTER_EVENT_PROCESSED_L = 0x23,
            CMD_TRG_COUNTER_EVENT_PROCESSED_M = 0x24,
            CMD_TRG_COUNTER_EVENT_INRUN_L = 0x25,
            CMD_TRG_COUNTER_EVENT_INRUN_M = 0x26,

            CMD_TRG_TEST_GENERATOR_ENABLE = 0x41,
            CMD_TRG_DATA_TEST_MUX = 0x42


        }

        public enum eCommandCode_AcqMode : byte
        {
            ACQ_MODE_INFINITE = 0,
            ACQ_MODE_EVENTS = 1,
            ACQ_MODE_TIME = 2,
            ACQ_MODE_EVENTS_PER_TIME = 3
        }


        public delegate void efunction(Communication.eCommandCode CMD, byte d1, byte d2, byte d3);
        public efunction SendCommand;

        public RadioButton radioButton_AcqInfinite;
        public RadioButton radioButton_AcqNumEvents;
        public RadioButton radioButton_AcqTime;
        public RadioButton radioButton_AcqEventsPerTime;

        public RadioButton radioButton_TrgSelf;
        public RadioButton radioButton_TrgExtRisingNorm;
        public RadioButton radioButton_TrgExtFallingNorm;
        public RadioButton radioButton_TrgExtRisingOver;
        public RadioButton radioButton_TrgExtFallingOver;
        public RadioButton radioButton_TrgAdcFd;
        public RadioButton radioButton_TrgSw;

        public NumericUpDown numericUpDown_NumOfEvents;
        public NumericUpDown numericUpDown_Time_sec;
        public NumericUpDown numericUpDown_Time_msec;
        public NumericUpDown numericUpDown_Time_usec;

        public NumericUpDown numericUpDown_NumOfSamples;
        public NumericUpDown numericUpDown_AcqThreshold;
        public NumericUpDown numericUpDown_AcqRepeats;

        public Label label_CounterIncomingEvents;
        public Label label_CounterProcessedEvents;
        public Label label_CounterInRunEvents;

        public Label label_AcqState;
        public CheckBox checkBox_TestGeneratorEnable;
        public CheckBox checkBox_DataTestMux;
        public Button button_AcqStartStop;

        public bool AcqState = false;

        //public  Acquisition_Control() 
        //{
            //StartStopButtonState(false);
        //} 


        public void UpdateAcqState(bool State) 
        {
            if (State) 
            {
                button_AcqStartStop.BackColor = System.Drawing.Color.Red;
                button_AcqStartStop.Text = "STOP";
                label_AcqState.BackColor = System.Drawing.Color.Green;
                label_AcqState.Text = "Acquisition RUN";

                AcqState = true;
            }
            else
            {
                button_AcqStartStop.BackColor = System.Drawing.Color.Green;
                button_AcqStartStop.Text = "START";
                label_AcqState.BackColor = System.Drawing.Color.Red;
                label_AcqState.Text = "Acquisition STOP";

                AcqState = false;
            }
        }

        public void StartStop() 
        {
            //AcqState = !AcqState; 
            
            if (AcqState == false) 
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_ENABLE, 0x00, 0x01);
                UpdateAcqState(true);
            }
            else 
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_ENABLE, 0x00, 0x00);
                UpdateAcqState(false);
            }

            //UpdateAcqState(AcqState);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_ENABLE, 0, 0);
        }

        public void AcqRunSetting() 
        {
            eCommandCode_AcqMode AcqMode = eCommandCode_AcqMode.ACQ_MODE_INFINITE;

            if (radioButton_AcqInfinite.Checked) 
            {
                numericUpDown_NumOfEvents.Enabled = false;
                numericUpDown_Time_sec.Enabled = false;
                numericUpDown_Time_msec.Enabled = false;
                numericUpDown_Time_usec.Enabled = false;

                numericUpDown_AcqRepeats.Enabled = false;

                AcqMode = eCommandCode_AcqMode.ACQ_MODE_INFINITE;
            }
            else if(radioButton_AcqNumEvents.Checked)
            {

                numericUpDown_NumOfEvents.Enabled = true;
                numericUpDown_Time_sec.Enabled = false;
                numericUpDown_Time_msec.Enabled = false;
                numericUpDown_Time_usec.Enabled = false;

                numericUpDown_AcqRepeats.Enabled = true;

                AcqMode = eCommandCode_AcqMode.ACQ_MODE_EVENTS;
            }
            else if (radioButton_AcqTime.Checked) 
            {
                numericUpDown_NumOfEvents.Enabled = false;
                numericUpDown_Time_sec.Enabled = true;
                numericUpDown_Time_msec.Enabled = true;
                numericUpDown_Time_usec.Enabled = true;

                numericUpDown_AcqRepeats.Enabled = false;

                AcqMode = eCommandCode_AcqMode.ACQ_MODE_TIME;

            }
            else if(radioButton_AcqEventsPerTime.Checked)
            {
                numericUpDown_NumOfEvents.Enabled = true;
                numericUpDown_Time_sec.Enabled = true;
                numericUpDown_Time_msec.Enabled = true;
                numericUpDown_Time_usec.Enabled = true;

                numericUpDown_AcqRepeats.Enabled = true;

                AcqMode = eCommandCode_AcqMode.ACQ_MODE_EVENTS_PER_TIME;

            }

            else 
            {
                numericUpDown_NumOfEvents.Enabled = false;
                numericUpDown_Time_sec.Enabled = false;
                numericUpDown_Time_msec.Enabled = false;
                numericUpDown_Time_usec.Enabled = false;

                numericUpDown_AcqRepeats.Enabled = false;
                return;
            }

            SetNumberOfEvents();
            SetRunTime();
            SetAcqMode(AcqMode);
        }

        public void AcqTriggerSelect() 
        {
            if (radioButton_TrgSelf.Checked) 
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TRIGGER_SELECT, 0x00, 0x00);
            }
            else if (radioButton_TrgExtRisingNorm.Checked) 
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TRIGGER_SELECT, 0x00, 0x01);
            }
            else if (radioButton_TrgExtFallingNorm.Checked)
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TRIGGER_SELECT, 0x00, 0x02);
            }
            else if (radioButton_TrgExtRisingOver.Checked)
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TRIGGER_SELECT, 0x00, 0x03);
            }
            else if (radioButton_TrgExtFallingOver.Checked)
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TRIGGER_SELECT, 0x00, 0x04);
            }
            else if (radioButton_TrgAdcFd.Checked)
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TRIGGER_SELECT, 0x00, 0x05);
            }
            else if (radioButton_TrgSw.Checked) 
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TRIGGER_SELECT, 0x00, 0x08);
            }
        }

        public void RB_TriggerSelectUpdate(uint value)
        {
            radioButton_TrgSelf.Checked = false;
            radioButton_TrgExtRisingNorm.Checked = false;
            radioButton_TrgExtRisingNorm.Checked = false;
            radioButton_TrgExtRisingOver.Checked = false;
            radioButton_TrgExtRisingOver.Checked = false;
            radioButton_TrgAdcFd.Checked = false;
            radioButton_TrgSw.Checked = false;

            switch (value) 
            {
                case 0:
                    radioButton_TrgSelf.Checked = true;
                    break;

                case 1:
                    radioButton_TrgExtRisingNorm.Checked = true;
                    break;

                case 2:
                    radioButton_TrgExtFallingNorm.Checked = true;
                    break;

                case 3:
                    radioButton_TrgExtRisingOver.Checked = true;
                    break;

                case 4:
                    radioButton_TrgExtFallingOver.Checked = true;
                    break;

                case 5:
                    radioButton_TrgAdcFd.Checked = true;
                    break;

                case 8:
                    radioButton_TrgSw.Checked = true;
                    break;

                default:
                    break;
            }
            

        }

        public void SwTrigger() 
        {
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SW_TRIGGER, 0x00, 0x01);
        }

        public void SetNumberOfEvents() 
        {
            UInt32 val = (UInt32)numericUpDown_NumOfEvents.Value;
            byte b0 = (byte)((val >> 0) & 0xFF);
            byte b1 = (byte)((val >> 8) & 0xFF);
            byte b2 = (byte)((val >> 16) & 0xFF);
            byte b3 = (byte)((val >> 24) & 0xFF);

            SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SET_NUMBERS_OF_EVENTS_L, b1, b0);
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SET_NUMBERS_OF_EVENTS_M, b3, b2);
        }

        public void SetRunTime()
        {
            int val_sec = (int)numericUpDown_Time_sec.Value;
            int val_msec = (int)numericUpDown_Time_msec.Value;
            int val_usec = (int)numericUpDown_Time_usec.Value;

            UInt32 val = (UInt32)(((float)val_sec * (fpgaLogicClock)) + ((float)val_msec * (1E-3) * (fpgaLogicClock)) + ((float)val_usec * (1E-6) * (fpgaLogicClock)));

            byte b0 = (byte)((val >> 0) & 0xFF);
            byte b1 = (byte)((val >> 8) & 0xFF);
            byte b2 = (byte)((val >> 16) & 0xFF);
            byte b3 = (byte)((val >> 24) & 0xFF);

            SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SET_TIME_FOR_RUN_L, b1, b0);
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SET_TIME_FOR_RUN_M, b3, b2);
        }

        public void SetAcqMode(eCommandCode_AcqMode AcqMode) 
        {
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_MODE, 0, (byte)AcqMode);
        }

        public void SetNumberOfSamples()
        {
            UInt32 val = (UInt32)numericUpDown_NumOfSamples.Value;
            byte b0 = (byte)((val >> 0) & 0xFF);
            byte b1 = (byte)((val >> 8) & 0xFF);
            byte b2 = (byte)((val >> 16) & 0xFF);
            byte b3 = (byte)((val >> 24) & 0xFF);

            SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SAMPLE_PER_EVENT_L, b1, b0);
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SAMPLE_PER_EVENT_M, b3, b2);
        }

        public void SetThreshold()
        {
            UInt16 val = (UInt16)numericUpDown_AcqThreshold.Value;
            byte b0 = (byte)((val >> 0) & 0xFF);
            byte b1 = (byte)((val >> 8) & 0xFF);

            SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_THRESHOLD, b1, b0);
        }

        public void TestGeneratorEnable() 
        {
            if (checkBox_TestGeneratorEnable.Checked)
                {
                    SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TEST_GENERATOR_ENABLE, 0x00, 0x01);
                }
                else
                {
                    SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TEST_GENERATOR_ENABLE, 0x00, 0x00);
                }
        }

        public void DataTestMuxSel()
        {
            if (checkBox_DataTestMux.Checked)
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_DATA_TEST_MUX, 0x00, 0x01);
            }
            else
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_DATA_TEST_MUX, 0x00, 0x00);
            }
        }

        int Read_Setting_step = 0;
        public void ReadSettingAndValues() //ctu vse napr jen pri prepnuti karty
        {

            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_ENABLE, 0, 0);

            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_INCOMING_L, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_INCOMING_M, 0, 0);
 
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_PROCESSED_L, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_PROCESSED_M, 0, 0);

            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TEST_GENERATOR_ENABLE, 0, 0);

            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_THRESHOLD, 0, 0);

            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SAMPLE_PER_EVENT_L, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SAMPLE_PER_EVENT_M, 0, 0);

            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SET_NUMBERS_OF_EVENTS_L, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SET_NUMBERS_OF_EVENTS_M, 0, 0);

            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SET_TIME_FOR_RUN_L, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_SET_TIME_FOR_RUN_M, 0, 0);

            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TRIGGER_SELECT, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_MODE, 0, 0);

        }

        public void ReadValues() //ctu jen countery a stav akvizice - timer
        {
            //if(AcqState)
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_ENABLE, 0, 0);

            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_INCOMING_L, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_INCOMING_M, 0, 0);

            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_PROCESSED_L, 0, 0);
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_PROCESSED_M, 0, 0);

            //SendCommand(Communication.eCommandCode.CMD_CONST_GET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_TEST_GENERATOR_ENABLE, 0, 0);

        }

        public void ClearCounters() 
        {
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_TriggerRegisters, (byte)eCommandCode_Trigger.CMD_TRG_COUNTERS_RESET, 0, 0);
        }


        UInt32 _AcqTimeInTicks;
        public void UpdateTimeLabels(UInt16 ticks, int shift)
        {

            UInt32 mask = (UInt32)(0x0000FFFF << shift);
            mask = ~mask;

            //uprava LSB
            //_AcqTimeInTicks = (_AcqTimeInTicks & 0xFFFF0000) | ((UInt32)ticks << 0);
            //uprava MSB
            //_AcqTimeInTicks = (_AcqTimeInTicks & 0x0000FFFF) | ((UInt32)ticks << 16);

            _AcqTimeInTicks = (_AcqTimeInTicks & mask) | ((UInt32)ticks << shift);


            int sec = (int)(_AcqTimeInTicks * (1.0 / fpgaLogicClock));
            int msec = (int)(_AcqTimeInTicks * ((1.0 / fpgaLogicClock) * 1E3) - (sec * 1E3));
            int usec = (int)(_AcqTimeInTicks * ((1.0 / fpgaLogicClock) * 1E6) - (sec * 1E6) - (msec * 1E3));

            numericUpDown_Time_sec.Value = sec;
            numericUpDown_Time_msec.Value = msec;
            numericUpDown_Time_usec.Value = usec;

        }

        public void UpdateModeRadioButtons(int val) 
        {
            radioButton_AcqInfinite.Checked = false;
            radioButton_AcqNumEvents.Checked = false;
            radioButton_AcqTime.Checked = false;
            radioButton_AcqEventsPerTime.Checked = false;

            switch (val) 
            {
                case ((int)eCommandCode_AcqMode.ACQ_MODE_INFINITE):
                    radioButton_AcqInfinite.Checked = true;
                    break;

                case ((int)eCommandCode_AcqMode.ACQ_MODE_EVENTS):
                    radioButton_AcqNumEvents.Checked = true;
                    break;

                case ((int)eCommandCode_AcqMode.ACQ_MODE_TIME):
                    radioButton_AcqTime.Checked = true;
                    break;

                case ((int)eCommandCode_AcqMode.ACQ_MODE_EVENTS_PER_TIME):
                    radioButton_AcqEventsPerTime.Checked = true;
                    break;

                default:
                    break;
            }

        }


        public void UpdateFromCommunication(byte data_0, byte data_1, byte data_2)
        {

            UInt32 temp = 0;
            UInt16 val = 0;

            switch (data_0)
            {
                //enable
                case (byte)eCommandCode_Trigger.CMD_TRG_ENABLE:
                    if ((data_2 & 0x01) == 0x01)
                    {
                        UpdateAcqState(true);
                    }
                    else
                    {
                        UpdateAcqState(false);
                    }
                    break;

                //mode
                case (byte)eCommandCode_Trigger.CMD_TRG_MODE:
                    UpdateModeRadioButtons(data_2);
                    break;

                //threshold
                case (byte)eCommandCode_Trigger.CMD_TRG_THRESHOLD:
                    numericUpDown_AcqThreshold.Value = (data_1 << 8) | data_2;
                    break;

                //Sample per event L
                case (byte)eCommandCode_Trigger.CMD_TRG_SAMPLE_PER_EVENT_L:
                    temp = (UInt32)numericUpDown_NumOfSamples.Value;
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0xFFFF0000) | ((UInt32)val << 0);
                    numericUpDown_NumOfSamples.Value = temp;
                    break;

                //Sample per event M
                case (byte)eCommandCode_Trigger.CMD_TRG_SAMPLE_PER_EVENT_M:
                    temp = (UInt32)numericUpDown_NumOfSamples.Value;
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0x0000FFFF) | ((UInt32)val << 16);
                    numericUpDown_NumOfSamples.Value = temp;
                    break;

                //set num of events L
                case (byte)eCommandCode_Trigger.CMD_TRG_SET_NUMBERS_OF_EVENTS_L:
                    temp = (UInt32)numericUpDown_NumOfEvents.Value;
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0xFFFF0000) | ((UInt32)val << 0);
                    numericUpDown_NumOfEvents.Value = temp;
                    break;

                //set num of events M
                case (byte)eCommandCode_Trigger.CMD_TRG_SET_NUMBERS_OF_EVENTS_M:
                    temp = (UInt32)numericUpDown_NumOfEvents.Value;
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0x0000FFFF) | ((UInt32)val << 16);
                    numericUpDown_NumOfEvents.Value = temp;
                    break;

                //set time run L
                case (byte)eCommandCode_Trigger.CMD_TRG_SET_TIME_FOR_RUN_L:
                    UpdateTimeLabels((UInt16)((data_1 << 8) | data_2), 0);
                    break;

                //set time M
                case (byte)eCommandCode_Trigger.CMD_TRG_SET_TIME_FOR_RUN_M:
                    UpdateTimeLabels((UInt16)((data_1 << 8) | data_2), 16);
                    break;




                //Counter incoming L
                case (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_INCOMING_L:
                    temp = UInt32.Parse(label_CounterIncomingEvents.Text);
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0xFFFF0000) | ((UInt32)val << 0);
                    label_CounterIncomingEvents.Text = temp.ToString();
                    break;

                //Counter incoming M
                case (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_INCOMING_M:
                    temp = UInt32.Parse(label_CounterIncomingEvents.Text);
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0x0000FFFF) | ((UInt32)val << 16);
                    label_CounterIncomingEvents.Text = temp.ToString();
                    break;

                //Counter processed L
                case (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_PROCESSED_L:
                    temp = UInt32.Parse(label_CounterProcessedEvents.Text);
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0xFFFF0000) | ((UInt32)val << 0);
                    label_CounterProcessedEvents.Text = temp.ToString();
                    break;

                //Counter processed M
                case (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_PROCESSED_M:
                    temp = UInt32.Parse(label_CounterProcessedEvents.Text);
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0x0000FFFF) | ((UInt32)val << 16);
                    label_CounterProcessedEvents.Text = temp.ToString();
                    break;

                //Counter inrun L
                case (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_INRUN_L:
                    temp = UInt32.Parse(label_CounterInRunEvents.Text);
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0xFFFF0000) | ((UInt32)val << 0);
                    label_CounterInRunEvents.Text = temp.ToString();
                    break;

                //Counter inrun M
                case (byte)eCommandCode_Trigger.CMD_TRG_COUNTER_EVENT_INRUN_M:
                    temp = UInt32.Parse(label_CounterInRunEvents.Text);
                    val = (UInt16)((data_1 << 8) | data_2);
                    temp = (temp & 0x0000FFFF) | ((UInt32)val << 16);
                    label_CounterInRunEvents.Text = temp.ToString();
                    break;



                //test generator enable
                case (byte)eCommandCode_Trigger.CMD_TRG_TEST_GENERATOR_ENABLE:
                    if ((data_2 & 0x01) == 0x01)
                    {
                        checkBox_TestGeneratorEnable.Checked = true;
                    }
                    else
                    {
                        checkBox_TestGeneratorEnable.Checked = false;
                    }
                    break;

                //trigger select
                case (byte)eCommandCode_Trigger.CMD_TRG_TRIGGER_SELECT:
                    RB_TriggerSelectUpdate(data_2);
                    break;


            }
        }

    }
}
