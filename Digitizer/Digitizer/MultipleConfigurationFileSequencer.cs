using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class MultipleConfigurationFileSequencer
    {
        private BindingList<MultipleConfigurationFileSequencer_Data> List_MultipleConfigFiles = new BindingList<MultipleConfigurationFileSequencer_Data>();


        public ComboBox comboBox_ConfigFiles;
        public DataGridView dataGridView_ConfigFile;
        public BindingList<SystemSetting_RegistersFileData> List_ReigistersFile;
        public Reset_Control rst;
        public GPIO_Control gpio;

        public MultipleConfigurationFileSequencer_Data ActualSelected;

        public void AddConfig() 
        {
            MultipleConfigurationFileSequencer_Data data = new MultipleConfigurationFileSequencer_Data();
            data._ConfigSequencer.List_ReigistersFile = List_ReigistersFile;
            data._ConfigSequencer.rst = rst;
            data._ConfigSequencer.gpio = gpio;
            data._ConfigSequencer._dataGridView_ConfigFile = dataGridView_ConfigFile;
            List_MultipleConfigFiles.Add(data);

            UpdateBox();

        }

        public void AssignFile()
        {
            String fname = String.Empty;
            String OnlyName = String.Empty;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Soubory dat (*.csv)|*.csv|Vsechny|*.*";

                if (DialogResult.OK == ofd.ShowDialog())
                {
                    fname = ofd.FileName;
                    OnlyName = ofd.SafeFileName;
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

            int selIndex = comboBox_ConfigFiles.SelectedIndex;
            if (selIndex < 0) return;

            List_MultipleConfigFiles[selIndex]._Patch = fname;
            List_MultipleConfigFiles[selIndex].p_Name = OnlyName;
            List_MultipleConfigFiles[selIndex]._ConfigSequencer.OpenRegistersFileAsString(fname);


            UpdateBox();
        }

        public void comboBoxSelectedChanged() 
        {
            foreach(MultipleConfigurationFileSequencer_Data x in List_MultipleConfigFiles) 
            {
                x._ConfigSequencer.ClrDataGrid();
            }

            int selIndex = comboBox_ConfigFiles.SelectedIndex;
            if (selIndex < 0) return;

            ActualSelected = List_MultipleConfigFiles[selIndex];
            ActualSelected._ConfigSequencer.SetDataGrid();
        }

        public void ConfigSequenceStart() 
        {
            ActualSelected._ConfigSequencer.ConfigSequenceStart();
        }

        public void ConfigSequenceStop()
        {
            ActualSelected._ConfigSequencer.ConfigSequenceStop();
        }


        private void UpdateBox() 
        {
            comboBox_ConfigFiles.Items.Clear();


            foreach (MultipleConfigurationFileSequencer_Data data in List_MultipleConfigFiles)
            {
                comboBox_ConfigFiles.Items.Add(data.p_Name);
            }

            comboBox_ConfigFiles.SelectedIndex = comboBox_ConfigFiles.Items.Count - 1;

        }

    }
}
