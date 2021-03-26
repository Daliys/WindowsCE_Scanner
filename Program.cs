using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS_Barcode2ControlSample1
{
    static class Program
    {
        public static Form1 mainForm;
        public static ManualEntryForm manualEntryForm;
        [MTAThread]
        static void Main()
        {
            mainForm = new Form1();
            //mainForm.DoScale();
            manualEntryForm = new ManualEntryForm();
            Application.Run(mainForm);

        }
    }
}