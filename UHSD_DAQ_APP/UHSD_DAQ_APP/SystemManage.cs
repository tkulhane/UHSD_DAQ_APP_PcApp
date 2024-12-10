using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    class SystemManage
    {


        public GroupBox groupBox_ManageActions;

        public delegate void efunction_SequenceStart(string name);
        public efunction_SequenceStart SequenceStart;



        public BindingList<SystemManage_ActionsData> List_Actions = new BindingList<SystemManage_ActionsData>();



        public void InitActions() 
        {

            OpenActionsFile("Actions.txt");


            for (int i = 0; i< List_Actions.Count; i++) 
            {
                List_Actions[i]._actionNumber = i;
            }


            for (int i = 0; i < List_Actions.Count; i++)
            {
                int x = (List_Actions.Count - 1) - i;
                AddInitButton(List_Actions[x]._userText, List_Actions[x]._actionNumber);
                
            }


        }

        public void AddInitButton(string text, int num) 
        {
            Button btn = new Button();
            btn.Dock = DockStyle.Top;
            btn.Text = text;
            btn.Tag = num;

            Size size = btn.Size;
            size.Height = 50;
            btn.Size = size;

            btn.Click += ActionButtons_Click;

            groupBox_ManageActions.Controls.Add(btn);

            Padding padding = btn.Padding;
            padding.Top = 15;
            padding.Left = 5;
            padding.Right = 5;
            groupBox_ManageActions.Padding = padding;


        }

        private void ActionButtons_Click(object sender, EventArgs e)
        {
            int btnTag = (int)(sender as Button).Tag;

            foreach (SystemManage_ActionsData x in List_Actions)
            {
                if (x._actionNumber.Equals(btnTag)) 
                {
                    SequenceStart(x._configFileName);
                }
            }

            
        }

        public string OpenActionsFile(string fname)
        {


            if (String.IsNullOrEmpty(fname)) return fname;

            List_Actions.Clear();

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
                SystemManage_ActionsData data = new SystemManage_ActionsData(s, 0);
                /*
                if (data.dataOk == false)
                {
                    MessageBox.Show("Wrong value when parsing register file." + "\n" + fname + "......" + s, "Wrong Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                */
                List_Actions.Add(data); 
            }


            //DataGrid_RegistersSetting.DataSource = List_RegistersSetting;
            //DataGrid_RegistersSetting.Show();

            return fname;

        }



    }
}
