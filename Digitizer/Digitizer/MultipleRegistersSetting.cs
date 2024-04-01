using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class MultipleRegistersSetting
    {

        public BindingList<RegistersSetting> List_RegistersSetting = new BindingList<RegistersSetting>();

        //public delegate void efunction_Send(Communication.eCommandCode CMD_ID, byte data_0, byte data_1, byte data_2);
        public RegistersSetting.efunction_Send SendFunction;

        public SystemSetting sysSetting;

        public TabControl tabControl_RegistersSetting;
        public TextBox textBox_RegAddress;
        public TextBox textBox_RegValue;
        public Label label_RegRW;
        public Label label_RegDescription;
        public GroupBox groupBox_RegBits;
        public RadioButton radioButton_RegAddrHEX;
        public RadioButton radioButton_RegAddrDEC;
        public RadioButton radioButton_RegValHEX;
        public RadioButton radioButton_RegValDEC;


        public RegistersSetting CreateRegister(string description, RegistersSetting.eAddressValueSize Sizes, Communication.eCommandCode ID_GET, Communication.eCommandCode ID_SET) 
        {
            RegistersSetting RS;

            RS = new RegistersSetting(description, tabControl_RegistersSetting, Sizes, ID_GET, ID_SET);
            RS.SendFunction = SendFunction;

            RS.GridCellContentClickFunction = Grids_CellClick;
            RS.GridSelectedChangedFunction = Grids_SelectedChanged;

            List_RegistersSetting.Add(RS);
            sysSetting.CreateRegistersInList(RS);

            return RS;
        }


        public void AddRegistersSetting(RegistersSetting rg) 
        {
            List_RegistersSetting.Add(rg);

        }


        public RegistersSetting GetRegister(string description) 
        {

            foreach(RegistersSetting RS in List_RegistersSetting) 
            {
                if (description.Equals(RS.p_description)) 
                {
                    return RS;
                }
            }

            return null;
        }

        public RegistersSetting GetRegister(Communication.eCommandCode ID_GET)
        {
            foreach (RegistersSetting RS in List_RegistersSetting)
            {
                if (ID_GET.Equals(RS.p_ID_GET))
                {
                    return RS;
                }
            }

            return null;
        }


        public void LoadFromFile(string desc) 
        {
            foreach (RegistersSetting RS in List_RegistersSetting)
            {
                if (desc.Equals(RS.p_description)) 
                {
                    string FileName = RS.OpenRegistersFile();
                    sysSetting.AddFileRegistersInList(RS, FileName);
                }

            }
        }


        public void SaveToFile(string desc) 
        {
            foreach (RegistersSetting RS in List_RegistersSetting)
            {
                if (desc.Equals(RS.p_description))
                {
                    RS.SaveRegistersFileAsString(sysSetting.GetFileStringForRegisters(RS));
                }

            }
        }

        public void SaveAs(string desc) 
        {
            foreach (RegistersSetting RS in List_RegistersSetting)
            {
                if (desc.Equals(RS.p_description))
                {
                    RS.SaveRegistersFile();
                }

            }
        }



        public void Grids_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;
            string description = tabControl_RegistersSetting.TabPages[selected].Text;

            Grids_CellClick(description, sender, e);
        }

        public void Grids_SelectedChanged(object sender, EventArgs e) 
        {
            int selected = tabControl_RegistersSetting.SelectedIndex;
            string description = tabControl_RegistersSetting.TabPages[selected].Text;

            Grids_SelectedChanged(description, sender, e);
        }



        public void Grids_CellClick(string desc, object sender, DataGridViewCellEventArgs e)
        {
            foreach (RegistersSetting RS in List_RegistersSetting)
            {
                if (desc.Equals(RS.p_description))
                {
                    RS.DataGridView_CellContentClick(sender, e);
                }

            }
        }

        public void Grids_SelectedChanged(string desc, object sender, EventArgs e)
        {
            RegistersSetting SelectedRegisters = null;

            foreach (RegistersSetting RS in List_RegistersSetting)
            {
                if (desc.Equals(RS.p_description))
                {
                    SelectedRegisters = RS;
                }

            }



            if (SelectedRegisters == null) //nebyl vybran zadny registers
            {
                SetRegistersInfoElements(false, null, 0);
                return;
            }

            RegistersSetting_Data data = null;
            if (SelectedRegisters.Grid_GetSelectData(out data))
            {
                // radek je vybran
                int valSize = SelectedRegisters.GetValueSize();
                SetRegistersInfoElements(true, data, valSize);
            }
            else
            {
                //radek neni vybran
                SetRegistersInfoElements(false, null, 0);
            }

        }


        public void RegReadAll(string desc)
        {
            foreach (RegistersSetting RS in List_RegistersSetting)
            {
                if (desc.Equals(RS.p_description))
                {
                    RS.ReadAll();
                }

            }
        }

        public void RegWriteAll(string desc)
        {
            foreach (RegistersSetting RS in List_RegistersSetting)
            {
                if (desc.Equals(RS.p_description))
                {
                    RS.WriteAll();
                }

            }
        }

        public void UpdateFromExtFile(string desc) 
        {
            foreach (RegistersSetting RS in List_RegistersSetting)
            {
                if (desc.Equals(RS.p_description))
                {
                    //TODO
                    //RS.UpdateFromPyFile();
                    //RS.UpdateFromTxtFile();
                }

            }
        }




        public void RegBitSet_CheckedChanged(object sender, EventArgs e)
        {
            int value = 0;

            foreach (CheckBox ch in groupBox_RegBits.Controls)
            {
                int chTag = int.Parse((string)ch.Tag);

                if (ch.Checked && ch.Enabled)
                {
                    value |= 1 << chTag;
                }
            }

            textBox_RegValue.Text = value.ToString("X");
        }

        public void RegAddress_TextChanged(object sender, EventArgs e)
        {

        }




        public void RegValue_TextChanged(string desc, object sender, EventArgs e)
        {

            RegistersSetting SelectedRegisters = null;

            foreach (RegistersSetting RS in List_RegistersSetting)
            {
                if (desc.Equals(RS.p_description))
                {
                    SelectedRegisters = RS;
                }

            }


            if (SelectedRegisters == null) //nebyl vybran zadny registers
            {
                SetRegistersInfoElements(false, null, 0);
                return;
            }

            int address;
            int value = 0;

            RegistersSetting_Data data = null;
            if (SelectedRegisters.Grid_GetSelectData(out data))
            {
                // radek je vybran
                address = data.p_address;
            }
            else
            {
                //radek neni vybran
                return;
            }


            //zobrazeni hodnoty
            if (radioButton_RegValHEX.Checked) //parsovat jako hex
            {
                if (!int.TryParse(textBox_RegValue.Text, NumberStyles.HexNumber, null, out value)) return;
            }
            else if (radioButton_RegValDEC.Checked) //parsovat jako dec
            {
                if (!int.TryParse(textBox_RegValue.Text, out value)) return;
            }



            SelectedRegisters.UpdateRegistersNoRequest(address, value);

        }

        public void RegAddrFind_Click(string desc, object sender, EventArgs e)
        {

            RegistersSetting SelectedRegisters = null;


            foreach (RegistersSetting RS in List_RegistersSetting)
            {
                if (desc.Equals(RS.p_description))
                {
                    SelectedRegisters = RS;
                }

            }



            if (SelectedRegisters == null) //nebyl vybran zadny registers
            {
                return;
            }

            int address = 0;
            bool parseResult = false;

            //parsovani
            if (radioButton_RegAddrHEX.Checked)
            {
                parseResult = int.TryParse(textBox_RegAddress.Text, NumberStyles.HexNumber, null, out address);
            }
            else if (radioButton_RegAddrDEC.Checked)
            {
                parseResult = int.TryParse(textBox_RegAddress.Text, out address);
            }

            if (!parseResult)
            {
                MessageBox.Show("Wrong value when parsing text. \nText: " + textBox_RegAddress.Text, "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!SelectedRegisters.FindAddressSelect(address))
            {
                MessageBox.Show("Address not found. \nAddress: " + address.ToString("X"), "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        



        private void SetRegistersInfoElements(bool set, RegistersSetting_Data data, int ValueSize)
        {
            if (set == false || data == null)
            {
                textBox_RegAddress.Text = String.Empty;
                textBox_RegValue.Text = String.Empty;
                label_RegRW.Text = String.Empty;
                label_RegDescription.Text = String.Empty;

                foreach (CheckBox ch in groupBox_RegBits.Controls)
                {
                    ch.Checked = false;
                    ch.Enabled = false;
                }
                return;
            }

            //zobrazeni adresy
            if (radioButton_RegAddrHEX.Checked)
            {
                textBox_RegAddress.Text = data.p_address.ToString("X"); //zobrazit jako hex
            }
            else if (radioButton_RegAddrDEC.Checked)
            {
                textBox_RegAddress.Text = data.p_address.ToString(); //zobrazit jako dec
            }

            //zobrazeni hodnoty
            if (radioButton_RegValHEX.Checked)
            {
                textBox_RegValue.Text = data.p_value; //zobrazit jako hex
            }
            else if (radioButton_RegValDEC.Checked)
            {
                textBox_RegValue.Text = data.ParseValue().ToString(); //zobrazit jako dec
            }



            label_RegRW.Text = data.p__StrReadWrite;
            label_RegDescription.Text = data.p_description;

            if (data._ReadWrite == RegistersSetting_Data.eReadWrite.read_write || data._ReadWrite == RegistersSetting_Data.eReadWrite.write)
            {
                textBox_RegValue.Enabled = true;
            }
            else
            {
                textBox_RegValue.Enabled = false;
            }

            int value = data.ParseValue();

            foreach (CheckBox ch in groupBox_RegBits.Controls)
            {
                int chTag = int.Parse((string)ch.Tag);

                if (chTag < ValueSize)
                {
                    if (data._ReadWrite == RegistersSetting_Data.eReadWrite.read_write || data._ReadWrite == RegistersSetting_Data.eReadWrite.write)
                    {
                        ch.Enabled = true;
                    }
                    else
                    {
                        ch.Enabled = false;
                    }

                    if (((value & (1 << chTag)) >> chTag) == 1)
                    {
                        ch.Checked = true;
                    }
                    else
                    {
                        ch.Checked = false;
                    }

                }
                else
                {
                    ch.Checked = false;
                    ch.Enabled = false;
                }


            }
        }




    }
}
