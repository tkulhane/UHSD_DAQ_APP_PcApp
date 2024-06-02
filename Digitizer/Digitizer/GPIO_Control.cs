using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class GPIO_Control
    {
        public enum eCommandCode_GPIO : byte
        {

            CMD_GPIO_OUTPUT_STATE = 0x11,
            CMD_GPIO_OUTPUT_TOOGLE = 0x12,
            CMD_GPIO_OUTPUT_SET = 0x13,
            CMD_GPIO_OUTPUT_CLEAR = 0x14,
            CMD_GPIO_OUTPUT_PULSE = 0x15,
            CMD_GPIO_PULSE_LENGTH_L = 0x1A,
            CMD_GPIO_PULSE_LENGTH_M = 0x1B,

            CMD_GPIO_INPUT_STATE = 0x21,
            CMD_GPIO_INPUT_RISING = 0x22,
            CMD_GPIO_INPUT_FALLING = 0x23,
            CMD_GPIO_INPUT_RISING_COUNTER = 0x24,
            CMD_GPIO_INPUT_FALLING_COUNTER = 0x25,

            CMD_GPIO_INPUT_RISING_CLEAR = 0xA1,
            CMD_GPIO_INPUT_FALLING_CLEAR = 0xA2,
            CMD_GPIO_INPUT_RISING_COUNTER_CLEAR = 0xA3,
            CMD_GPIO_INPUT_FALLING_COUNTER_CLEAR = 0xA4,
            CMD_GPIO_INPUT_COUNTERs_OR_MASK = 0xAA

        }


        private BindingList<GpioInput_Data> List_GpioInput = new BindingList<GpioInput_Data>();
        private BindingList<GpioOutput_Data> List_GpioOutput = new BindingList<GpioOutput_Data>();

        public delegate void efunction(Communication.eCommandCode CMD, byte d1, byte d2, byte d3);
        public efunction SendCommand;

        public DataGridView DataGrid_GpioInput;
        public DataGridView DataGrid_GpioOutput;

        bool _ReadRequest = true;
        int _ReadRequest_Number = 0;
        public int _LastReadValue = 0;


        public void LoadGpio()
        {
            //Inputs
            InputAdd(0, "BTN");
            InputAdd(1, "ADC-GPIO-0");
            InputAdd(2, "ADC-GPIO-1");
            InputAdd(3, "ADC-GPIO-2");
            InputAdd(4, "ADC-GPIO-3");
            InputAdd(5, "ADC-GPIO-4");
            InputAdd(6, "ADC-FD");
            InputAdd(7, "HMC-GPIO-0");

            InputAdd(8, "HMC-GPIO-1");
            InputAdd(9, "SMPS-PWR-GOOD");
            InputAdd(10, "LDO-PWR-GOOD");
            InputAdd(11, "ADC-PWR-GOOD");

            InputAdd(12, "GPI-0");
            InputAdd(13, "GPI-1");
            InputAdd(14, "GPI-2");
            InputAdd(15, "GPI-3");


            //Outputs
            OutputAdd(0, "ADC-PWDN");
            OutputAdd(1, "HMC-SYNC");
            

            OutputAdd(4, "HMC-GPIO-2");
            OutputAdd(5, "HMC-GPIO-3");

            OutputAdd(6, "BOARD-PWR-RUN");
            OutputAdd(7, "ADC-PWR-RUN");
            OutputAdd(10, "LED_2");
            OutputAdd(11, "LED_3");

            OutputAdd(12, "GPO-0");
            OutputAdd(13, "GPO-0");
            OutputAdd(14, "GPO-0");
            OutputAdd(15, "GPO-0");

            OutputAdd(2, "LMX-SYNC");

            OutputAdd(3, "SYNCIB");

            //datagrid
            DataGridsLoad();
        }

        private void DataGridsLoad()
        {
            DataGrid_GpioInput.DataSource = List_GpioInput;
            DataGrid_GpioInput.Update();


            DataGrid_GpioOutput.DataSource = List_GpioOutput;

            DataGridViewButtonColumn btn_pulse = new DataGridViewButtonColumn();
            btn_pulse.HeaderText = "PULSE";
            btn_pulse.Text = "PULSE";
            btn_pulse.Name = "button_GpioPulse";
            btn_pulse.UseColumnTextForButtonValue = true;
            DataGrid_GpioOutput.Columns.Add(btn_pulse);

            DataGridViewButtonColumn btn_set = new DataGridViewButtonColumn();
            btn_set.HeaderText = "SET";
            btn_set.Text = "SET";
            btn_set.Name = "button_GpioSet";
            btn_set.UseColumnTextForButtonValue = true;
            DataGrid_GpioOutput.Columns.Add(btn_set);

            DataGridViewButtonColumn btn_clear = new DataGridViewButtonColumn();
            btn_clear.HeaderText = "CLEAR";
            btn_clear.Text = "CLEAR";
            btn_clear.Name = "button_GpioClear";
            btn_clear.UseColumnTextForButtonValue = true;
            DataGrid_GpioOutput.Columns.Add(btn_clear);


            DataGrid_GpioOutput.Update();

            for (int i = 0; i < DataGrid_GpioInput.Columns.Count; i++)
            {
                DataGrid_GpioInput.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            for (int i = 0; i < DataGrid_GpioOutput.Columns.Count; i++)
            {
                DataGrid_GpioOutput.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void InputAdd(int Number, string Name)
        {
            GpioInput_Data data = new GpioInput_Data(Number, Name);
            List_GpioInput.Add(data);
        }

        private void OutputAdd(int Number, string Name)
        {
            GpioOutput_Data data = new GpioOutput_Data(Number, Name);
            List_GpioOutput.Add(data);
        }

        public void UpdateFromCommunication(byte data_0, byte data_1, byte data_2)
        {

            switch ((eCommandCode_GPIO)data_0)
            {
                case eCommandCode_GPIO.CMD_GPIO_OUTPUT_STATE:
                    UpdateOutputValue(data_1, data_2);
                    break;

                case eCommandCode_GPIO.CMD_GPIO_INPUT_STATE:
                    UpdateInputValue(data_1, data_2);
                    break;

                case eCommandCode_GPIO.CMD_GPIO_INPUT_RISING:
                    UpdateInputRising(data_1, data_2);
                    break;

                case eCommandCode_GPIO.CMD_GPIO_INPUT_FALLING:
                    UpdateInputFalling(data_1, data_2);
                    break;

                case eCommandCode_GPIO.CMD_GPIO_INPUT_RISING_COUNTER:
                    //UpdateInputRisingCount(data_1, data_2);
                    break;

                case eCommandCode_GPIO.CMD_GPIO_INPUT_FALLING_COUNTER:
                    //UpdateInputFallingCount(data_1, data_2);
                    break;



            }
        }

        private void UpdateOutputValue(byte data_1, byte data_2) 
        {
            UInt16 data = (UInt16)((data_1 << 8) + data_2);

            int value_cell = DataGrid_GpioOutput.Columns["p_value"].Index;

            for (int i = 0; i< List_GpioOutput.Count; i++) 
            {
                List_GpioOutput[i].p_value = (data >> List_GpioOutput[i].p_number) & 0x0001;
                DataGrid_GpioOutput.UpdateCellValue(value_cell, i);
            }
        }

        private void UpdateInputValue(byte data_1, byte data_2)
        {
            UInt16 data = (UInt16)((data_1 << 8) + data_2);

            int value_cell = DataGrid_GpioInput.Columns["p_value"].Index;

            for (int i = 0; i < List_GpioInput.Count; i++)
            {
                List_GpioInput[i].p_value = (data >> List_GpioInput[i].p_number) & 0x0001;
                DataGrid_GpioInput.UpdateCellValue(value_cell, i);

                if(_ReadRequest == true) 
                {
                    if(_ReadRequest_Number == i) 
                    {
                        _LastReadValue = List_GpioInput[i].p_value;
                        _ReadRequest = false;
                    }
                }

            }
        }

        private void UpdateInputRising(byte data_1, byte data_2)
        {
            UInt16 data = (UInt16)((data_1 << 8) + data_2);

            int value_cell = DataGrid_GpioInput.Columns["p_rising"].Index;
            

            for (int i = 0; i < List_GpioInput.Count; i++)
            {
                List_GpioInput[i].p_rising = (data >> List_GpioInput[i].p_number) & 0x0001;
                DataGrid_GpioInput.UpdateCellValue(value_cell, i);
            }
        }

        private void UpdateInputFalling(byte data_1, byte data_2)
        {
            UInt16 data = (UInt16)((data_1 << 8) + data_2);

            int value_cell = DataGrid_GpioInput.Columns["p_falling"].Index;

            for (int i = 0; i < List_GpioInput.Count; i++)
            {
                List_GpioInput[i].p_falling = (data >> List_GpioInput[i].p_number) & 0x0001;
                DataGrid_GpioInput.UpdateCellValue(value_cell, i);
            }
        }


        public void SetByName(string Name, int value)
        {
            for (int i = 0; i < List_GpioOutput.Count; i++)
            {
                if (Name.Equals(List_GpioOutput[i].p_name))
                {
                    SetByIndex(i, value);
                }
            }
        }

        public void SetByIndex(int index, int value)
        {
            GpioOutput_Data data = List_GpioOutput[index];
            int Number = data.p_number;
            if (Number < 0) return;
            int reg = 0 | 1 << Number;

            if (value == 1)
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_OUTPUT_SET, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
            }
            else if (value == 0)
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_OUTPUT_CLEAR, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
            }
            else
            {
                return;
            }
        }

        public void PulseByName(string Name) 
        {
            for (int i = 0; i < List_GpioOutput.Count; i++)
            {
                if (Name.Equals(List_GpioOutput[i].p_name))
                {
                    PulseByIndex(i);
                }
            }
        }

        public void PulseByIndex(int index) 
        {
            int reg = 0 | 1 << index;
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_OUTPUT_PULSE, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
        }



        public void DataGridView_Output_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GpioOutput_Data data = List_GpioOutput[e.RowIndex];

            int Number = data.p_number;

            if (Number < 0) return;

            int index_set = DataGrid_GpioOutput.Columns["button_GpioSet"].Index;
            int index_clear = DataGrid_GpioOutput.Columns["button_GpioClear"].Index;
            int index_pulse = DataGrid_GpioOutput.Columns["button_GpioPulse"].Index;

            int reg = 0 | 1 << Number;

            //MessageBox.Show(reg.ToString("x"));

            if (e.ColumnIndex == index_set)
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_OUTPUT_SET, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
            }
            else if (e.ColumnIndex == index_clear)
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_OUTPUT_CLEAR, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
            }
            else if (e.ColumnIndex == index_pulse)
            {
                SendCommand(Communication.eCommandCode.CMD_CONST_SET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_OUTPUT_PULSE, (byte)((reg >> 8) & 0x00FF), (byte)(reg & 0x00FF));
            }

            SendCommand(Communication.eCommandCode.CMD_CONST_GET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_OUTPUT_STATE, 0,0);
        }

        int step = 0;
        public void ReadStateCommands() 
        {
            switch (step) 
            {
                case 0:
                    SendCommand(Communication.eCommandCode.CMD_CONST_GET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_OUTPUT_STATE, 0, 0);
                    SendCommand(Communication.eCommandCode.CMD_CONST_GET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_INPUT_STATE, 0, 0);
                    break;

                case 1:
                    SendCommand(Communication.eCommandCode.CMD_CONST_GET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_INPUT_RISING, 0, 0);
                    SendCommand(Communication.eCommandCode.CMD_CONST_GET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_INPUT_FALLING, 0, 0);
                    break;

                //case 2:
                //    SendCommand(Communication.eCommandCode.CMD_CONST_GET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_INPUT_RISING_COUNTER, 0, 0);
                //    SendCommand(Communication.eCommandCode.CMD_CONST_GET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_INPUT_FALLING_COUNTER, 0, 0);
                //    break;
            }

            step++;
            if (step > 1) step = 0;

        }

        public void ClearRisingFalling() 
        {
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_INPUT_RISING_CLEAR, 0xFF, 0xFF);
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_INPUT_FALLING_CLEAR, 0xFF, 0xFF);
        }

        public void ClearRisingFallingCounters()
        {
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_INPUT_RISING_COUNTER_CLEAR, 0xFF, 0xFF);
            SendCommand(Communication.eCommandCode.CMD_CONST_SET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_INPUT_FALLING_COUNTER_CLEAR, 0xFF, 0xFF);
        }


        public void ReadRequestInput(string Name) 
        {
            SendCommand(Communication.eCommandCode.CMD_CONST_GET_GPIO, (byte)eCommandCode_GPIO.CMD_GPIO_INPUT_STATE, 0, 0);

            for (int i = 0; i < List_GpioInput.Count; i++)
            {
                if (Name.Equals(List_GpioInput[i].p_name))
                {
                    _ReadRequest = true;
                    _ReadRequest_Number = i;
                }
            }

        }

        public bool StateReadInput()
        {
            return !_ReadRequest;
        }

    }
}
