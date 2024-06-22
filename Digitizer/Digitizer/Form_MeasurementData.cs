using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitizer_ver1
{
    public partial class Form_MeasurementData : Form
    {
        public Form_MeasurementData()
        {
            InitializeComponent();
            
        }

        public Control ReturnParent;
        public Control TableControl;
        public Button button_AnotherForm;

        private void Form_MeasurementData_FormClosed(object sender, FormClosedEventArgs e)
        {
            button_AnotherForm.Enabled = true;
            TableControl.Parent = ReturnParent;
        }
    }
}
