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

        public delegate void efunction(int CMD_ID, int address, int value);
        public efunction SendFunction;

        eAddressValueSize Registers_AddressValueSize;
        private int Registers_ID_GET;
        private int Registers_ID_SET;

        public Registers_Setting(DataGridView Registers_GridView, efunction SendForFunction, eAddressValueSize Sizes , int ID_GET, int ID_SET)
        {
            DataGrid_RegistersSetting = Registers_GridView;
            SendFunction = SendForFunction;
            Registers_AddressValueSize = Sizes;
            Registers_ID_GET = ID_GET;
            Registers_ID_SET = ID_SET;
        }


        public Registers_Setting(eAddressValueSize Sizes, int ID_GET, int ID_SET)
        {
            
            Registers_AddressValueSize = Sizes;
            Registers_ID_GET = ID_GET;
            Registers_ID_SET = ID_SET;
        }

        public void OpenRegistersFile()
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
                    return;
                }

                if (String.IsNullOrEmpty(fname))
                {
                    return;
                }

                List_RegistersSetting.Clear();

                String[] lines = File.ReadAllLines(fname, Encoding.GetEncoding("Windows-1250"));

                foreach (String s in lines)
                {
                    Registers_SettingData data = new Registers_SettingData(s);
                    List_RegistersSetting.Add(data);
                }



                DataGrid_RegistersSetting.DataSource = List_RegistersSetting;

                if (DataGrid_RegistersSetting.Columns.Count >= 5)
                {
                    return;
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
                DataGrid_RegistersSetting.Columns[3].DefaultCellStyle.Format = "X";

                


            }
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

        public void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int address = List_RegistersSetting[e.RowIndex].p_address;
            string strValue = List_RegistersSetting[e.RowIndex].p_value;
            int value = 0;

            if (!int.TryParse(strValue, NumberStyles.HexNumber, null, out value)) 
            {
                MessageBox.Show("Wrong value when parsing cell text. \nText: " + strValue, "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (e.ColumnIndex == 4)
            {

                //MessageBox.Show("Read:  " + address);
                SendFunction(Registers_ID_GET, address, value);
                //Send_Command(ID_GET, address, "1");
            }
            else if (e.ColumnIndex == 5)
            {

                //MessageBox.Show("Write:  " + address + " " + value);
                SendFunction(Registers_ID_SET, address, value);
                //Send_Command(ID_SET, address, value);
            }
        }

        public void UpdateRegisters(int address, int value) 
        {
            for (int i = 0; i < List_RegistersSetting.Count; i++)
            {
                if (address.Equals(List_RegistersSetting[i].p_address))
                {
                    List_RegistersSetting[i].p_value = value.ToString("X");
                    DataGrid_RegistersSetting.UpdateCellValue(2, i);
                }
            }
        }

        public void UpdateRegisters(byte data_0, byte data_1, byte data_2)
        {
            int address = (data_0 << 8) + data_1;

            for (int i = 0; i < List_RegistersSetting.Count; i++)
            {
                if (address.Equals(List_RegistersSetting[i].p_address))
                {
                    List_RegistersSetting[i].p_value = data_2.ToString("X");
                    DataGrid_RegistersSetting.UpdateCellValue(3, i);
                }
            }

        }

    }
}
