using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class Registers_Setting
    {
        public enum eAddressValueSize : byte
        {
            Address8_Value8,
            Address16_Value8,
            Address8_Value16
        }

       

        private BindingList<Registers_SettingData> List_RegistersSetting = new BindingList<Registers_SettingData>();

        public DataGridView DataGrid_RegistersSetting;

        public delegate void efunction(Communication.eCommandCode CMD_ID, byte data_0, byte data_1, byte data_2);
        public efunction SendFunction;

        private eAddressValueSize Registers_AddressValueSize;
        private Communication.eCommandCode Registers_ID_GET;
        private Communication.eCommandCode Registers_ID_SET;

        private bool _ReadRequestMask = false;
        private int _ReadRequestMask_Address = 0;
        private int _ReadRequestMask_Value = 0;
        private int _ReadRequestMask_Mask = 0;

        private bool _ReadRequest = false;
        private int _ReadRequest_Address = 0;
        public int _LastReadValue = 0;



        string _description;
        [DisplayName("Description")]
        public String p_description { get { return _description; } }

        public Registers_Setting(DataGridView Registers_GridView, efunction SendForFunction, eAddressValueSize Sizes , Communication.eCommandCode ID_GET, Communication.eCommandCode ID_SET)
        {
            DataGrid_RegistersSetting = Registers_GridView;
            SendFunction = SendForFunction;
            Registers_AddressValueSize = Sizes;
            Registers_ID_GET = ID_GET;
            Registers_ID_SET = ID_SET;
        }


        public Registers_Setting(string description,eAddressValueSize Sizes, Communication.eCommandCode ID_GET, Communication.eCommandCode ID_SET)
        {
            _description = description;
            Registers_AddressValueSize = Sizes;
            Registers_ID_GET = ID_GET;
            Registers_ID_SET = ID_SET;
        }


        public int GetValueSize() 
        {
            if(Registers_AddressValueSize == eAddressValueSize.Address8_Value8) 
            {
                return 8;
            }
            else if (Registers_AddressValueSize == eAddressValueSize.Address8_Value16)
            {
                return 16;
            }
            else if (Registers_AddressValueSize == eAddressValueSize.Address16_Value8)
            {
                return 8;
            }
            else 
            {
                return 0;
            }

        }

        public int GetAddressSize()
        {
            if (Registers_AddressValueSize == eAddressValueSize.Address8_Value8)
            {
                return 8;
            }
            else if (Registers_AddressValueSize == eAddressValueSize.Address8_Value16)
            {
                return 8;
            }
            else if (Registers_AddressValueSize == eAddressValueSize.Address16_Value8)
            {
                return 16;
            }
            else
            {
                return 0;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------
        //File operation
        //-------------------------------------------------------------------------------------------------------------------
        public string OpenRegistersFileAsString(string fname)
        {


            if (String.IsNullOrEmpty(fname)) return fname;

            List_RegistersSetting.Clear();

            String[] lines;
            try 
            {
                 lines = File.ReadAllLines(fname, Encoding.GetEncoding("Windows-1250"));
            }
            catch 
            {
                return fname;
            }

            foreach (String s in lines)
            {
                Registers_SettingData data = new Registers_SettingData(s, Registers_AddressValueSize);
                if (data.dataOk == false)
                {
                    MessageBox.Show("Wrong value when parsing config file.", "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                List_RegistersSetting.Add(data);
            }



            DataGrid_RegistersSetting.DataSource = List_RegistersSetting;
            DataGrid_RegistersSetting.Show();

            if (DataGrid_RegistersSetting.Columns.Count >= 5)
            {
                return fname;
            }


            DataGridViewButtonColumn btn_read = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn_write = new DataGridViewButtonColumn();

            
            btn_write.HeaderText = "Write";
            btn_write.Text = "Write";
            btn_write.Name = "button_ADCregisterWrite";
            btn_write.UseColumnTextForButtonValue = true;

            
            btn_read.HeaderText = "Read";
            btn_read.Text = "Read";
            btn_read.Name = "button_ADCregisterRead";
            btn_read.UseColumnTextForButtonValue = true;

            
            DataGrid_RegistersSetting.Columns.Add(btn_read);
            DataGrid_RegistersSetting.Columns.Add(btn_write);

            DataGrid_RegistersSetting.Columns[0].DefaultCellStyle.Format = "X";
            //DataGrid_RegistersSetting.Columns[3].DefaultCellStyle.Format = "X";

            DataGrid_RegistersSetting.Update();

            return fname;

        }

        public string OpenRegistersFile()
        {

            String fname = String.Empty;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Soubory dat (*.csv)|*.csv|Vsechny|*.*";

                if (DialogResult.OK == ofd.ShowDialog())
                {
                    fname = ofd.FileName;
                }
                else
                {
                    return fname;
                }

                if (String.IsNullOrEmpty(fname))
                {
                    return fname;
                }

            }
                List_RegistersSetting.Clear();

                String[] lines = File.ReadAllLines(fname, Encoding.GetEncoding("Windows-1250"));

                foreach (String s in lines)
                {
                    Registers_SettingData data = new Registers_SettingData(s, Registers_AddressValueSize);
                    if(data.dataOk == false)
                    {
                        MessageBox.Show("Wrong value when parsing config file.", "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    List_RegistersSetting.Add(data);
                }



                DataGrid_RegistersSetting.DataSource = List_RegistersSetting;

                if (DataGrid_RegistersSetting.Columns.Count >= 5)
                {
                    return fname;
                }


                DataGridViewButtonColumn btn_read = new DataGridViewButtonColumn();
                DataGridViewButtonColumn btn_write = new DataGridViewButtonColumn();

                btn_read.HeaderText = "Write";
                btn_read.Text = "Write";
                btn_read.Name = "button_ADCregisterWrite";
                btn_read.UseColumnTextForButtonValue = true;

                btn_write.HeaderText = "Read";
                btn_write.Text = "Read";
                btn_write.Name = "button_ADCregisterRead";
                btn_write.UseColumnTextForButtonValue = true;

                DataGrid_RegistersSetting.Columns.Add(btn_write);
                DataGrid_RegistersSetting.Columns.Add(btn_read);

                DataGrid_RegistersSetting.Columns[0].DefaultCellStyle.Format = "X";
                //DataGrid_RegistersSetting.Columns[3].DefaultCellStyle.Format = "X";

                return fname;
            
        }

        public void SaveRegistersFile()
        {

            String fname = String.Empty;

            using (SaveFileDialog ofd = new SaveFileDialog())
            {
                ofd.Filter = "Soubory dat (*.csv)|*.csv|Vsechny|*.*";

                if (DialogResult.OK == ofd.ShowDialog())
                {

                    fname = ofd.FileName;
                }
                else
                {
                    return;
                }

                if (String.IsNullOrEmpty(fname))
                {
                    return;
                }
            }

            if (String.IsNullOrEmpty(fname))
            {
                return;
            }

            FileStream fs = File.OpenWrite(fname);

            foreach (Registers_SettingData data in List_RegistersSetting)
            {
                byte[] line = Encoding.ASCII.GetBytes(data.FormatToCSV());

                fs.Write(line, 0, line.Length);
            }

            fs.Close();

        }

        public void SaveRegistersFileAsString(string fname)
        {

            if (String.IsNullOrEmpty(fname))
            {
                return;
            }

            FileStream fs = File.OpenWrite(fname);

            foreach (Registers_SettingData data in List_RegistersSetting)
            {
                byte[] line = Encoding.ASCII.GetBytes(data.FormatToCSV());

                fs.Write(line, 0, line.Length);
            }

            fs.Close();

        }

        //-------------------------------------------------------------------------------------------------------------------
        //update from ext file (txt or py) 
        //-------------------------------------------------------------------------------------------------------------------

        public void UpdateFromPyFile() 
        {
            if (List_RegistersSetting.Count == 0) return;

            String fname = String.Empty;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Soubory dat (*.py)|*.py|Vsechny|*.*";

                if (DialogResult.OK == ofd.ShowDialog())
                {
                    fname = ofd.FileName;
                }
                else
                {
                    return;
                }

                if (String.IsNullOrEmpty(fname))
                {
                    return;
                }

            }


            String[] lines = File.ReadAllLines(fname, Encoding.GetEncoding("Windows-1250"));

            foreach (String s in lines)
            {
                ParsingPyLine(s);

            }


        }

        public void ParsingPyLine(string line) 
        {
            line = line.Trim();

            char[] SplitChars = new char[] { '(', ')', ',' };

            String[] line_parts = line.Split(SplitChars);

            if (line_parts.Length != 4 || line_parts[0].Length <= 0) return;
            if (line_parts[0][0].Equals('#')) return;

            if (line_parts[0].Equals("dut.write"))
            {
                string s_address = line_parts[1].Trim();
                string s_value = line_parts[2].Trim();

                int address;
                int value;
                
                if(!(s_address.StartsWith("0x") && int.TryParse(s_address.Substring(2), NumberStyles.HexNumber, null, out address))) return;
                if(!(s_value.StartsWith("0x") && int.TryParse(s_value.Substring(2), NumberStyles.HexNumber, null, out value))) return;

                //MessageBox.Show(address.ToString() +"  "+ value.ToString());

                UpdateRegistersNoRequest(address, value);
            }

            
            string s = String.Empty;
            for(int i = 0; i < line_parts.Length; i++) 
            {
                s += "-" + i.ToString() + "="  + line_parts[i] + "-";
            }

            //MessageBox.Show(line_parts.Length.ToString() + "..... " + s);
        }


        public void UpdateFromTxtFile()
        {
            if (List_RegistersSetting.Count == 0) return;

            String fname = String.Empty;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Soubory dat (*.txt)|*.txt|Vsechny|*.*";

                if (DialogResult.OK == ofd.ShowDialog())
                {
                    fname = ofd.FileName;
                }
                else
                {
                    return;
                }

                if (String.IsNullOrEmpty(fname))
                {
                    return;
                }

            }


            String[] lines = File.ReadAllLines(fname, Encoding.GetEncoding("Windows-1250"));

            foreach (String s in lines)
            {
                ParsingTxtLine(s);

            }


        }

        public void ParsingTxtLine(string line)
        {
            line = line.Trim();

            char[] SplitChars = new char[] { (char)9, };

            String[] line_parts = line.Split(SplitChars);

            //if (line_parts.Length != 4 || line_parts[0].Length <= 0) return;
            //if (line_parts[0][0].Equals('#')) return;

            if (line_parts.Length < 2) return;

            string temp = line_parts[1].Trim();

            if (temp == String.Empty) return;

            string s_address;
            string s_value;

            if (temp.StartsWith("0x")) 
            {
                temp = temp.Substring(2);

                s_address = temp.Substring(0, 2);
                s_value = temp.Substring(2, 4);
            }
            else 
            {
                return;
            } 

            int address;
            int value;

            if (!int.TryParse(s_address, NumberStyles.HexNumber, null, out address)) return;
            if (!int.TryParse(s_value, NumberStyles.HexNumber, null, out value)) return;

            UpdateRegistersNoRequest(address, value);

            string s = String.Empty;
            for (int i = 0; i < line_parts.Length; i++)
            {
                //s += "-" + i.ToString() + "=" + line_parts[i] + "-";
                //s = temp + " ... " + s_address + " " + s_value;
            }

           
            //MessageBox.Show(line_parts.Length.ToString() + "..... " + s);
        }

        //-------------------------------------------------------------------------------------------------------------------
        //Data grid
        //-------------------------------------------------------------------------------------------------------------------
        public void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Registers_SettingData data = List_RegistersSetting[e.RowIndex];

            int address = data.p_address;
            int value = data.ParseValue(Registers_AddressValueSize);
            Registers_SettingData.eReadWrite readWrite = data._ReadWrite;

            if (value < 0) return;



            int index_write = DataGrid_RegistersSetting.Columns["button_ADCregisterWrite"].Index;
            int index_read = DataGrid_RegistersSetting.Columns["button_ADCregisterRead"].Index;

            

            //ToDo zjistit proc to nekdy vrací pri kliknuti 0 a 1 (ma to vracet 4 a 5), dela to po nacteni z nastaveni setting
            if (e.ColumnIndex == index_read) //read
            //if (e.ColumnIndex == 4 || e.ColumnIndex == 0) //read
            {
                
                if (readWrite == Registers_SettingData.eReadWrite.read_write || readWrite == Registers_SettingData.eReadWrite.read) 
                {
                    Send(Registers_ID_GET, address, value);
                }
                else 
                {
                    MessageBox.Show("Unable to read.", "Unable to read", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if (e.ColumnIndex == index_write)
            //else if (e.ColumnIndex == 5 || e.ColumnIndex == 1) //write
            {
                if (readWrite == Registers_SettingData.eReadWrite.read_write || readWrite == Registers_SettingData.eReadWrite.write)
                {
                    Send(Registers_ID_SET, address, value);
                }
                else
                {
                    MessageBox.Show("Unable to write.", "Unable to write", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool Grid_GetSelectData(out Registers_SettingData data) 
        {
            data = null;
            
            int selCount = DataGrid_RegistersSetting.SelectedRows.Count;
            if (selCount == 0) return false;

            int selIndex = DataGrid_RegistersSetting.SelectedRows[0].Index;
            if (selIndex < 0) return false;

            data = List_RegistersSetting[selIndex];

            return true;
        }

        //-------------------------------------------------------------------------------------------------------------------
        //Read Write function
        //-------------------------------------------------------------------------------------------------------------------
        public void ReadAll() 
        {
            foreach(Registers_SettingData data in List_RegistersSetting) 
            {
                int address = data.p_address;
                
                Registers_SettingData.eReadWrite readWrite = data._ReadWrite;

                if (readWrite == Registers_SettingData.eReadWrite.read_write || readWrite == Registers_SettingData.eReadWrite.read)
                {
                    Send(Registers_ID_GET, address, 0);
                }

            }
        }

        public void WriteAll() 
        {
            foreach (Registers_SettingData data in List_RegistersSetting)
            {
                int address = data.p_address;
                int value = data.ParseValue(Registers_AddressValueSize);
                Registers_SettingData.eReadWrite readWrite = data._ReadWrite;

                if (value < 0) continue;

                if (readWrite == Registers_SettingData.eReadWrite.read_write || readWrite == Registers_SettingData.eReadWrite.read)
                {
                    Send(Registers_ID_SET, address, value);
                }

            }
        }

        public void WriteAllReverse()
        {
            
            
            
            //foreach (Registers_SettingData data in List_RegistersSetting)
            for(int i = 0; i < List_RegistersSetting.Count;i++)
            {
                Registers_SettingData data = List_RegistersSetting[List_RegistersSetting.Count -1 - i];


                int address = data.p_address;
                int value = data.ParseValue(Registers_AddressValueSize);
                Registers_SettingData.eReadWrite readWrite = data._ReadWrite;

                if (value < 0) continue;

                if (readWrite == Registers_SettingData.eReadWrite.read_write || readWrite == Registers_SettingData.eReadWrite.read)
                {
                    Send(Registers_ID_SET, address, value);
                }

            }
        }

        //-------------------------------------------------------------------------------------------------------------------
        //Send function
        //-------------------------------------------------------------------------------------------------------------------
        public void SendRegister(int address) 
        {
            for (int i = 0; i < List_RegistersSetting.Count; i++)
            {
                Registers_SettingData data = List_RegistersSetting[i];

                if (address == data.p_address) 
                {
                    Registers_SettingData.eReadWrite readWrite = data._ReadWrite;

                    int value = data.ParseValue(Registers_AddressValueSize);

                    if (readWrite == Registers_SettingData.eReadWrite.read_write || readWrite == Registers_SettingData.eReadWrite.write)
                    {
                        Send(Registers_ID_SET, address, value);
                    }
                }
            }
        }

        public void SendRegister(int address, int value)
        {
            Send(Registers_ID_SET, address, value);
        }

        private void Send(Communication.eCommandCode CMD, int address, int value) 
        {
            
            
            byte[] data = new byte[3];
            
            if(Registers_AddressValueSize == eAddressValueSize.Address8_Value8) 
            {
                data[0] = 0;
                data[1] = (byte)address;
                data[2] = (byte)value;
            }
            else if (Registers_AddressValueSize == eAddressValueSize.Address16_Value8) 
            {
                data[0] = (byte) ((address >> 8) & 0x00FF);
                data[1] = (byte)  (address & 0x00FF);
                data[2] = (byte)   value;
            }
            else if (Registers_AddressValueSize == eAddressValueSize.Address8_Value16)
            {
                data[0] = (byte) address;
                data[1] = (byte) ((value >> 8) & 0x00FF);
                data[2] = (byte) (value & 0x00FF);
            }

            SendFunction(CMD, data[0], data[1], data[2]);
        }

        //-------------------------------------------------------------------------------------------------------------------
        //Read function
        //-------------------------------------------------------------------------------------------------------------------
        public void ReadRequestRegister(int address)
        {
            if (_ReadRequestMask == true) return;

            for (int i = 0; i < List_RegistersSetting.Count; i++)
            {
                Registers_SettingData data = List_RegistersSetting[i];

                if (address == data.p_address)
                {
                    Registers_SettingData.eReadWrite readWrite = data._ReadWrite;

                    if (readWrite == Registers_SettingData.eReadWrite.read_write || readWrite == Registers_SettingData.eReadWrite.read)
                    {
                        Send(Registers_ID_GET, address, 0x00);
                        _ReadRequest = true;
                        _ReadRequest_Address = address;
                        //nastavit timeout
                       
                    }
                }
            }
        }

        public bool StateReadRegister()
        {
            return !_ReadRequest;
        }

        //-------------------------------------------------------------------------------------------------------------------
        //Send with mask
        //-------------------------------------------------------------------------------------------------------------------
        public void SendMaskRegister_Request(int address, int value, int mask)
        {
            if (_ReadRequestMask == true) return;
            
            for (int i = 0; i < List_RegistersSetting.Count; i++)
            {
                Registers_SettingData data = List_RegistersSetting[i];

                if (address == data.p_address)
                {
                    Registers_SettingData.eReadWrite readWrite = data._ReadWrite;

                    if (readWrite == Registers_SettingData.eReadWrite.read_write || readWrite == Registers_SettingData.eReadWrite.read)
                    {
                        Send(Registers_ID_GET, address, 0x00);
                        _ReadRequestMask = true;
                        _ReadRequestMask_Address = address;
                        _ReadRequestMask_Value = value;
                        _ReadRequestMask_Mask = mask;
                        //nastavit timeout

                    }
                }
            }

        }

        public void SendMaskRegister_Request(int address, int mask)
        {
            if (_ReadRequestMask == true) return;

            for (int i = 0; i < List_RegistersSetting.Count; i++)
            {
                Registers_SettingData data = List_RegistersSetting[i];

                if (address == data.p_address)
                {
                    int value = data.ParseValue(Registers_AddressValueSize);

                    Registers_SettingData.eReadWrite readWrite = data._ReadWrite;

                    if (readWrite == Registers_SettingData.eReadWrite.read_write || readWrite == Registers_SettingData.eReadWrite.read || readWrite == Registers_SettingData.eReadWrite.write)
                    {
                        Send(Registers_ID_GET, address, 0x00);
                        _ReadRequestMask = true;
                        _ReadRequestMask_Address = address;
                        _ReadRequestMask_Value = value;
                        _ReadRequestMask_Mask = mask;
                        //nastavit timeout

                    }
                }
            }

        }

        private void MaskRegister_Send(int readValue) 
        {
            if (_ReadRequestMask == true)
            {
                _ReadRequestMask = false;

                int x = (readValue & ~_ReadRequestMask_Mask) | (_ReadRequestMask_Value & _ReadRequestMask_Mask);
                SendRegister(_ReadRequestMask_Address, x);

            }
        }

        public bool StateMaskRegister() 
        {
            return !_ReadRequestMask;
        }

        public void SendMaskRegisterTblVal(int address, int value, int mask)
        {

            for (int i = 0; i < List_RegistersSetting.Count; i++)
            {
                Registers_SettingData data = List_RegistersSetting[i];

                if (address == data.p_address)
                {
                    Registers_SettingData.eReadWrite readWrite = data._ReadWrite;

                    if (readWrite == Registers_SettingData.eReadWrite.read_write)
                    {
                        int x = (data.ParseValue() & ~mask) | (value & mask);

                        SendRegister(address, x);
                        MessageBox.Show(x.ToString("x"));
                    }
                }
            }

        }

        //-------------------------------------------------------------------------------------------------------------------
        //Update registers
        //-------------------------------------------------------------------------------------------------------------------
        public void UpdateRegistersNoRequest(int address, int value)
        {
            int value_cell = DataGrid_RegistersSetting.Columns["p_value"].Index;

            for (int i = 0; i < List_RegistersSetting.Count; i++)
            {
                if (address.Equals(List_RegistersSetting[i].p_address))
                {
                    List_RegistersSetting[i].p_value = value.ToString("X");
                    DataGrid_RegistersSetting.UpdateCellValue(value_cell, i);
                }
            }
        }

        public void UpdateRegisters(int address, int value) 
        {
            int value_cell = DataGrid_RegistersSetting.Columns["p_value"].Index;

            for (int i = 0; i < List_RegistersSetting.Count; i++)
            {
                if (address.Equals(List_RegistersSetting[i].p_address))
                {
                    List_RegistersSetting[i].p_value = value.ToString("X");
                    DataGrid_RegistersSetting.UpdateCellValue(value_cell, i);

                    if (_ReadRequestMask == true)
                    {
                        if(address.Equals(_ReadRequestMask_Address))
                        {
                            MaskRegister_Send(value);
                        }
                    }
                    
                    if(_ReadRequest == true) 
                    {
                        //if (address.Equals(_ReadRequest_Address))
                        {
                            //MessageBox.Show("Prijato");
                            _LastReadValue = value;
                            _ReadRequest = false;
                        }
                    }


                }
            }
        }

        public void UpdateRegisters(byte data_0, byte data_1, byte data_2)
        {
            //MessageBox.Show("Update");

            int address = -1;
            int value = -1;

            if (Registers_AddressValueSize == eAddressValueSize.Address8_Value8)
            {
                address = data_1;
                value = data_2;
            }
            else if (Registers_AddressValueSize == eAddressValueSize.Address16_Value8)
            {
                address = (data_0 << 8) + data_1;
                value = data_2;
            }
            else if (Registers_AddressValueSize == eAddressValueSize.Address8_Value16)
            {
                address = data_0;
                value = (data_1 << 8) + data_2;
            }

            if (address < 0 || value < 0) return;


            UpdateRegisters(address, value);
            /*
            int value_cell = DataGrid_RegistersSetting.Columns["p_value"].Index;

            for (int i = 0; i < List_RegistersSetting.Count; i++)
            {
                if (address.Equals(List_RegistersSetting[i].p_address))
                {
                   
                    List_RegistersSetting[i].p_value = data_2.ToString("X");
                    DataGrid_RegistersSetting.UpdateCellValue(value_cell, i);

                    //DataGrid_RegistersSetting.
                }
            }
            */

        }

        //-------------------------------------------------------------------------------------------------------------------
        //line operation
        //-------------------------------------------------------------------------------------------------------------------
        public int FindLineAddress(int address) 
        {

            for (int i = 0; i < List_RegistersSetting.Count; i++)
            {
                if (address.Equals(List_RegistersSetting[i].p_address))
                {
                    return i;
                }
            }

            return -1;
        }

        public void SelectLine(int line) 
        {
            DataGrid_RegistersSetting.Rows[line].Selected = true;
        }

        public bool FindAddressSelect(int address) 
        {
            int line = FindLineAddress(address);
            if (line < 0) 
            {
                
                return false;
            }
            
            SelectLine(line);
            return true; 
        }

        public int GetRegisterValue(int address) 
        {
            for (int i = 0; i < List_RegistersSetting.Count; i++)
            {
                Registers_SettingData data = List_RegistersSetting[i];

                if (address == data.p_address)
                {
                    Registers_SettingData.eReadWrite readWrite = data._ReadWrite;

                    int value = data.ParseValue(Registers_AddressValueSize);

                    if (readWrite == Registers_SettingData.eReadWrite.read_write || readWrite == Registers_SettingData.eReadWrite.read)
                    {
                        return value;
                    }
                }
            }

            return -1;
        }

    }
}
