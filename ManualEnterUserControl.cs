using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CS_Barcode2ControlSample1
{
    public partial class ManualEnterUserControl : UserControl
    {
        public ManualEnterUserControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox.Text;
            if (str == "") return;
            Program.mainForm.HandleData(str);
            textBox.Text = "";
            this.Hide();
           
        }

    }
}
