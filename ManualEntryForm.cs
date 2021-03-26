using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS_Barcode2ControlSample1
{
    public partial class ManualEntryForm : Form
    {
        public ManualEntryForm()
        {
            InitializeComponent();
            textBoxCode.Focus();
        }


        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            //Program.mainForm.Show();
           
            this.Hide();
        }

        private void Check_Click(object sender, EventArgs e)
        {

            string str = textBoxCode.Text;
            if (str == "") return;
            Program.mainForm.HandleData(str);
            textBoxCode.Text = "";
            this.Hide();
        }

        private void buttonNumberClick(object sender, EventArgs e)
        {
            textBoxCode.Text += ((Button)sender).Text;
           // textBoxCode.Focus();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text.Length >= 2) textBoxCode.Text = (textBoxCode.Text).Substring(0, textBoxCode.Text.Length - 1);
            else if (textBoxCode.Text.Length == 1) textBoxCode.Text = "";
        }
    }
}