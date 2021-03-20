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
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            //Program.mainForm.Show();
           
            this.Close();
        }

        private void Check_Click(object sender, EventArgs e)
        {

        }
    }
}