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
        public enum eAnotherSequenceActions : byte
        {
            non,
            start,
            stop,
            state,


            stop_all
        };


        private BindingList<MultipleConfigurationFileSequencer_Data> List_MultipleConfigFiles = new BindingList<MultipleConfigurationFileSequencer_Data>();

        public DataGridView MultipleConfigFiles;
        public DataGridView dataGridView_ConfigFile;
        public BindingList<SystemSetting_RegistersFileData> List_ReigistersFile;
        public Reset_Control rst;
        public GPIO_Control gpio;

        public MultipleConfigurationFileSequencer_Data ActualSelected;

        public ListBox listBox_MainLog;

        public void Init() 
        {
            List_MultipleConfigFiles.Clear();


            MultipleConfigFiles.DataSource = List_MultipleConfigFiles;

            for (int i = 0; i < MultipleConfigFiles.Columns.Count; i++)
            {
                MultipleConfigFiles.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            MultipleConfigFiles.Update();
        }

        public static void Move<T>(BindingList<T> list, int oldIndex, int newIndex)
        {
            var item = list[oldIndex];

            list.RemoveAt(oldIndex);

            //if (newIndex > oldIndex) newIndex--;
            // the actual index could have shifted due to the removal

            list.Insert(newIndex, item);
        }

        public void MoveConfigItemUp()
        {
            int selCount = MultipleConfigFiles.SelectedRows.Count;
            if (selCount == 0)
            {
                return;
            }

            int selIndex = MultipleConfigFiles.SelectedRows[0].Index;
            if (selIndex < 0) return;

            if (selIndex == 0) return;

            Move(List_MultipleConfigFiles, selIndex, selIndex - 1);
            MultipleConfigFiles.Rows[selIndex - 1].Selected = true;
        }

        public void MoveConfigItemDown()
        {
            int selCount = MultipleConfigFiles.SelectedRows.Count;
            if (selCount == 0)
            {
                return;
            }

            int selIndex = MultipleConfigFiles.SelectedRows[0].Index;
            if (selIndex < 0) return;

            if (selIndex >= List_MultipleConfigFiles.Count - 1) return;

            Move(List_MultipleConfigFiles, selIndex, selIndex + 1);
            MultipleConfigFiles.Rows[selIndex + 1].Selected = true;
        }

        private MultipleConfigurationFileSequencer_Data InitConfig() 
        {
            MultipleConfigurationFileSequencer_Data data = new MultipleConfigurationFileSequencer_Data();
            data._ConfigSequencer.listBox_MainLog = listBox_MainLog;
            data._ConfigSequencer.List_ReigistersFile = List_ReigistersFile;
            data._ConfigSequencer.rst = rst;
            data._ConfigSequencer.gpio = gpio;
            data._ConfigSequencer._dataGridView_ConfigFile = dataGridView_ConfigFile;
            data._ConfigSequencer._MultiConfig_data = data;
            data._ConfigSequencer.StateSetFunction = StateSet;
            data._ConfigSequencer.AnotherSequenceAction = AnotherSequenceAction;

            return data;
        }

        public void AddConfig() 
        {
            MultipleConfigurationFileSequencer_Data data = InitConfig();
            List_MultipleConfigFiles.Add(data);

            //MultipleConfigFiles.Update();

            for (int i = 0; i < MultipleConfigFiles.Rows.Count; i++) 
            {
                MultipleConfigFiles.Rows[i].Selected = false;
            }
            MultipleConfigFiles.Rows[MultipleConfigFiles.Rows.Count - 1].Selected = true;
        }

        public void AssignFile()
        {
            
            int selCount = MultipleConfigFiles.SelectedRows.Count;
            if (selCount == 0) return;

            int selIndex = MultipleConfigFiles.SelectedRows[0].Index;
            if (selIndex < 0) return;



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


            List_MultipleConfigFiles[selIndex]._Patch = fname;
            List_MultipleConfigFiles[selIndex].p_Name = OnlyName;
            List_MultipleConfigFiles[selIndex]._ConfigSequencer.OpenRegistersFileAsString(fname);

            List_MultipleConfigFiles[selIndex].SetState(MultipleConfigurationFileSequencer_Data.eStates.Idle);

            MultipleConfigFiles.Refresh();

        }

        public void OpenFromSetting(string name, string file)
        {
            if (name == string.Empty) return;

            MultipleConfigurationFileSequencer_Data data = InitConfig();

            //pokud neni prirazen file, ale vytvori se v tabulce nepreirazeny
            if (file != string.Empty) 
            {
                data.p_Name = name;
                data._Patch = file;
                data.SetState(MultipleConfigurationFileSequencer_Data.eStates.Idle);
            }

            List_MultipleConfigFiles.Add(data);
            MultipleConfigFiles.Refresh();

            data._ConfigSequencer.OpenRegistersFileAsString(file);

        }

        public void ReloadFile() 
        {
            int selCount = MultipleConfigFiles.SelectedRows.Count;
            if (selCount == 0) return;

            int selIndex = MultipleConfigFiles.SelectedRows[0].Index;
            if (selIndex < 0) return;

            String fname = String.Empty;
            //String OnlyName = String.Empty;

            fname = List_MultipleConfigFiles[selIndex]._Patch;
            //List_MultipleConfigFiles[selIndex].p_Name = OnlyName;
            if (fname == String.Empty) return;

            List_MultipleConfigFiles[selIndex]._ConfigSequencer.OpenRegistersFileAsString(fname);
            List_MultipleConfigFiles[selIndex].SetState(MultipleConfigurationFileSequencer_Data.eStates.Idle);
            MultipleConfigFiles.Refresh();

        }

        public int GetCountOfConfigFiles() 
        {
            return List_MultipleConfigFiles.Count;
        }

        public string GetStringForSettingSave(int lineConfig) 
        {
            if (lineConfig < 0 || lineConfig > List_MultipleConfigFiles.Count - 1) return string.Empty;
            
            MultipleConfigurationFileSequencer_Data data = List_MultipleConfigFiles[lineConfig];

            string s = data.p_Name + ";" + data._Patch;

            return s;
        }



        public void RemoveFile() 
        {
            int selCount = MultipleConfigFiles.SelectedRows.Count;
            if (selCount == 0) return;

            int selIndex = MultipleConfigFiles.SelectedRows[0].Index;
            if (selIndex < 0) return;

            //List_MultipleConfigFiles[selIndex].
            List_MultipleConfigFiles.Remove(List_MultipleConfigFiles[selIndex]);


            if(List_MultipleConfigFiles.Count == 0) 
            {
                dataGridView_ConfigFile.DataSource = null;
                dataGridView_ConfigFile.Refresh();
            }
        }

        public void SelectedChanged() 
        {
            foreach(MultipleConfigurationFileSequencer_Data x in List_MultipleConfigFiles) 
            {
                x._ConfigSequencer.ClrDataGrid();
            }

            int selCount = MultipleConfigFiles.SelectedRows.Count;
            if (selCount == 0) 
            {
                dataGridView_ConfigFile.DataSource = null;
                dataGridView_ConfigFile.Refresh();
                return;
            } 

            int selIndex = MultipleConfigFiles.SelectedRows[0].Index;
            if (selIndex < 0) return;


            //int selIndex = comboBox_ConfigFiles.SelectedIndex;
            //if (selIndex < 0) return;

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

        public void StateSet(MultipleConfigurationFileSequencer_Data.eStates state, MultipleConfigurationFileSequencer_Data MultiConfig_data) 
        {
            MultiConfig_data.SetState(state);
            MultipleConfigFiles.Refresh();
        }

        /*
        public int AnotherSequenceAction(string action, string Value) 
        {



            if (action.Equals("START"))
            {

                foreach (MultipleConfigurationFileSequencer_Data x in List_MultipleConfigFiles) 
                {

                    if (x.p_Name.Equals(Value)) 
                    {
                        x._ConfigSequencer.ConfigSequenceStart();
                    }

                }

                return 0;
            }
            else if (action.Equals("STOP"))
            {
              
                foreach (MultipleConfigurationFileSequencer_Data x in List_MultipleConfigFiles)
                {
                    if (x.p_Name.Equals(Value))
                    {
                        x._ConfigSequencer.ConfigSequenceStop();
                    }
                }

                return 0;
            }
            else if (action.Equals("STATE")) 
            {
                foreach (MultipleConfigurationFileSequencer_Data x in List_MultipleConfigFiles)
                {
                    if (x.p_Name.Equals(Value))
                    {
                        return (int)x.GetState();
                    }
                }

                return -1;
            }

            return 0;
        }
        */


        public void SequenceStart(string name) 
        {
            foreach (MultipleConfigurationFileSequencer_Data x in List_MultipleConfigFiles)
            {

                if (x.p_Name.Equals(name))
                {
                    x._ConfigSequencer.ConfigSequenceStart();
                }

            }
        }

        public int AnotherSequenceAction(eAnotherSequenceActions action, string Value)
        {

            int return_value = 0;

            switch (action) 
            {
                case eAnotherSequenceActions.start:
                    foreach (MultipleConfigurationFileSequencer_Data x in List_MultipleConfigFiles)
                    {

                        if (x.p_Name.Equals(Value))
                        {
                            x._ConfigSequencer.ConfigSequenceStart();
                            return_value = 1;
                        }

                    }

                    return return_value;

                    break;

                case eAnotherSequenceActions.stop:
                    foreach (MultipleConfigurationFileSequencer_Data x in List_MultipleConfigFiles)
                    {
                        if (x.p_Name.Equals(Value))
                        {
                            x._ConfigSequencer.ConfigSequenceStop();
                            return_value = 1;
                        }
                    }

                    return return_value;

                    break;

                case eAnotherSequenceActions.state:
                    foreach (MultipleConfigurationFileSequencer_Data x in List_MultipleConfigFiles)
                    {
                        if (x.p_Name.Equals(Value))
                        {
                            return (int)x.GetState();
                        }
                    }

                    return -1;

                    break;

                case eAnotherSequenceActions.stop_all:
                    foreach (MultipleConfigurationFileSequencer_Data x in List_MultipleConfigFiles)
                    {
                        x._ConfigSequencer.ConfigSequenceStop();
                    }

                    return 1;


                default:
                    break;
            }



            return  -1;
        }



    }
}
