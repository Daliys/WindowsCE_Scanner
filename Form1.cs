//--------------------------------------------------------------------
// FILENAME: Form1.cs
//
// Copyright © 2011 Motorola Solutions, Inc. All rights reserved.
//
// DESCRIPTION:
//
// NOTES:
//
// 
//--------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Symbol.Barcode2;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Linq;
using System.Media;
using WMPLib;



namespace CS_Barcode2ControlSample1
{


    public partial class Form1 : Form
    {
        private readonly ScanAPI _myScanApi = new ScanAPI();
        private bool _isBarcodeInitiated;
        private int _fix = 0;
        private Barcode2.OnScanHandler _myScanNotifyHandler;

        private Color wrongAnswerColor = Color.FromArgb(173, 0, 0);
        private Color rightAnswerColor = Color.FromArgb(0, 173, 0);
        private Color neutralAnswerColor = Color.FromArgb(143, 143, 143 );

        //private int port = 80;
        //private string server = "192.168.31.236";
        //TcpClient client = new TcpClient();
        NetThread connNet = new NetThread();
        
        Thread myThread = new Thread(new ThreadStart(Count));
         // запускаем поток
                        

        private static bool bPortrait = true;   // The default dispaly orientation 
        // has been set to Portrait.

        private bool bSkipMaxLen = false;    // The restriction on the maximum 
        // physical length is considered by default.

        private bool bInitialScale = true;   // The flag to track whether the 
        // scaling logic is applied for
        // the first time (from scatch) or not.
        // Based on that, the (outer) width/height values
        // of the form will be set or not.
        // Initially set to true.

        private int resWidthReference = 240;   // The (cached) width of the form. 
        // INITIALLY HAS TO BE SET TO THE WIDTH OF THE FORM AT DESIGN TIME (IN PIXELS).
        // This setting is also obtained from the platform only on
        // Windows CE devices before running the application on the device, as a verification.
        // For PocketPC (& Windows Mobile) devices, the failure to set this properly may result in the distortion of GUI/viewability.

        private int resHeightReference = 268;  // The (cached) height of the form.
        // INITIALLY HAS TO BE SET TO THE HEIGHT OF THE FORM AT DESIGN TIME (IN PIXELS).
        // This setting is also obtained from the platform only on
        // Windows CE devices before running the application on the device, as a verification.
        // For PocketPC (& Windows Mobile) devices, the failure to set this properly may result in the distortion of GUI/viewability.

        private const double maxLength = 5.5;  // The maximum physical width/height of the sample (in inches).
        // The actual value on the device may slightly deviate from this
        // since the calculations based on the (received) DPI & resolution values 
        // would provide only an approximation, so not 100% accurate.

        
        public static void Count()
        {   
            //TcpClient client1 = new TcpClient();
            //IPAddress ipa = IPAddress.Parse("192.168.31.236");
            //client1.Connect(ipa, 34567);
            

        }

        public Form1()
        {
            //int con = 0;
            InitializeComponent();
            this.listBox1.Focus();
            //manualEnterUserControl1.Hide();


            /*Thread firstThread = new Thread(new ThreadStart(connNet.connect));
            firstThread.Start();
            listBox2.Items.Add(connNet.mess);*/
            connNet.response = "12345";
            Thread sendThread = new Thread(new ThreadStart(connNet.sendCode));
            sendThread.Start();

            
            /*try
            {
                client1.Connect(ipa, 34567);
                listBox1.Items.Add("Коннект");
            }
            catch
            {
                listBox1.Items.Add("Не коннект");
                con = 1;
            }
            finally
            {
                if (con==0)
                {
                    string response1 = "connected";
                    Byte[] data1 = Encoding.UTF8.GetBytes(response1);
                    if (client1 != null)
                    {
                        NetworkStream stream1 = client1.GetStream();
                        if (stream1 != null)
                        {
                            stream1.Write(data1, 0, data1.Length);
                            stream1.Close();
                        }
                        listBox1.Items.Add("Соединено");

                        client1.Close();

                    }
                }
            }*/
        }

        public void SendRequest()
        {


        }

        /// <summary>
        /// This function does the (initial) scaling of the form
        /// by re-setting the related parameters (if required) &
        /// then calling the Scale(...) internally. 
        /// </summary>
        /// 
        public void DoScale()
        {
            if (Screen.PrimaryScreen.Bounds.Width > Screen.PrimaryScreen.Bounds.Height)
            {
                bPortrait = false; // If the display orientation is not portrait (so it's landscape), set the flag to false.
            }

            if (this.WindowState == FormWindowState.Maximized)    // If the form is maximized by default.
            {
                this.bSkipMaxLen = true; // we need to skip the max. length restriction
            }

            if ((Symbol.Win32.PlatformType.IndexOf("WinCE") != -1) || (Symbol.Win32.PlatformType.IndexOf("WindowsCE") != -1) || (Symbol.Win32.PlatformType.IndexOf("Windows CE") != -1)) // Only on Windows CE devices
            {
                this.resWidthReference = this.Width;   // The width of the form at design time (in pixels) is obtained from the platorm.
                this.resHeightReference = this.Height; // The height of the form at design time (in pixels) is obtained from the platform.
            }

            Scale(this); // Initial scaling of the GUI
        }

        /// <summary>
        /// This function scales the given Form & its child controls in order to
        /// make them completely viewable, based on the screen width & height.
        /// </summary>
        private static void Scale(Form1 frm)
        {
            int PSWAW = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;    // The width of the working area (in pixels).
            int PSWAH = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;   // The height of the working area (in pixels).

            // The entire screen has been taken in to account below 
            // in order to decide the half (S)VGA settings etc.
            if (!((Screen.PrimaryScreen.Bounds.Width <= (1.5) * (Screen.PrimaryScreen.Bounds.Height))
            && (Screen.PrimaryScreen.Bounds.Height <= (1.5) * (Screen.PrimaryScreen.Bounds.Width))))
            {
                if ((Screen.PrimaryScreen.Bounds.Width) > (Screen.PrimaryScreen.Bounds.Height))
                {
                    PSWAW = (int)((1.33) * PSWAH);  // If the width/height ratio goes beyond 1.5,
                    // the (longer) effective width is made shorter.
                }

            }

            System.Drawing.Graphics graphics = frm.CreateGraphics();

            float dpiX = graphics.DpiX; // Get the horizontal DPI value.

            if (frm.bInitialScale == true) // If an initial scale (from scratch)
            {
                if (Symbol.Win32.PlatformType.IndexOf("PocketPC") != -1) // If the platform is either Pocket PC or Windows Mobile
                {
                    frm.Width = PSWAW;  // Set the form width. However this setting
                    // would be the ultimate one for Pocket PC (& Windows Mobile)devices.
                    // Just for the sake of consistency, it's explicitely specified here.
                }
                else
                {
                    frm.Width = (int)((frm.Width) * (PSWAW)) / (frm.resWidthReference); // Set the form width for others (Windows CE devices).

                }
            }
            if ((frm.Width <= maxLength * dpiX) || frm.bSkipMaxLen == true) // The calculation of the width & left values for each control
            // without taking the maximum length restriction into consideration.
            {
                foreach (System.Windows.Forms.Control cntrl in frm.Controls)
                {
                    cntrl.Width = ((cntrl.Width) * (frm.Width)) / (frm.resWidthReference);
                    cntrl.Left = ((cntrl.Left) * (frm.Width)) / (frm.resWidthReference);

                    if (cntrl is System.Windows.Forms.TabControl)
                    {
                        foreach (System.Windows.Forms.TabPage tabPg in cntrl.Controls)
                        {
                            foreach (System.Windows.Forms.Control cntrl2 in tabPg.Controls)
                            {
                                cntrl2.Width = (((cntrl2.Width) * (frm.Width)) / (frm.resWidthReference));
                                cntrl2.Left = (((cntrl2.Left) * (frm.Width)) / (frm.resWidthReference));
                            }
                        }
                    }
                }

            }
            else
            {   // The calculation of the width & left values for each control
                // with the maximum length restriction taken into consideration.
                foreach (System.Windows.Forms.Control cntrl in frm.Controls)
                {
                    cntrl.Width = (int)(((cntrl.Width) * (PSWAW) * (maxLength * dpiX)) / (frm.resWidthReference * (frm.Width)));
                    cntrl.Left = (int)(((cntrl.Left) * (PSWAW) * (maxLength * dpiX)) / (frm.resWidthReference * (frm.Width)));

                    if (cntrl is System.Windows.Forms.TabControl)
                    {
                        foreach (System.Windows.Forms.TabPage tabPg in cntrl.Controls)
                        {
                            foreach (System.Windows.Forms.Control cntrl2 in tabPg.Controls)
                            {
                                cntrl2.Width = (int)(((cntrl2.Width) * (PSWAW) * (maxLength * dpiX)) / (frm.resWidthReference * (frm.Width)));
                                cntrl2.Left = (int)(((cntrl2.Left) * (PSWAW) * (maxLength * dpiX)) / (frm.resWidthReference * (frm.Width)));
                            }
                        }
                    }
                }

                frm.Width = (int)((frm.Width) * (maxLength * dpiX)) / (frm.Width);

            }

            frm.resWidthReference = frm.Width; // Set the reference width to the new value.


            // A similar calculation is performed below for the height & top values for each control ...

            if (!((Screen.PrimaryScreen.Bounds.Width <= (1.5) * (Screen.PrimaryScreen.Bounds.Height))
            && (Screen.PrimaryScreen.Bounds.Height <= (1.5) * (Screen.PrimaryScreen.Bounds.Width))))
            {
                if ((Screen.PrimaryScreen.Bounds.Height) > (Screen.PrimaryScreen.Bounds.Width))
                {
                    PSWAH = (int)((1.33) * PSWAW);
                }

            }

            float dpiY = graphics.DpiY;

            if (frm.bInitialScale == true)
            {
                if (Symbol.Win32.PlatformType.IndexOf("PocketPC") != -1)
                {
                    frm.Height = PSWAH;
                }
                else
                {
                    frm.Height = (int)((frm.Height) * (PSWAH)) / (frm.resHeightReference);

                }
            }

            if ((frm.Height <= maxLength * dpiY) || frm.bSkipMaxLen == true)
            {
                foreach (System.Windows.Forms.Control cntrl in frm.Controls)
                {

                    cntrl.Height = ((cntrl.Height) * (frm.Height)) / (frm.resHeightReference);
                    cntrl.Top = ((cntrl.Top) * (frm.Height)) / (frm.resHeightReference);


                    if (cntrl is System.Windows.Forms.TabControl)
                    {
                        foreach (System.Windows.Forms.TabPage tabPg in cntrl.Controls)
                        {
                            foreach (System.Windows.Forms.Control cntrl2 in tabPg.Controls)
                            {
                                cntrl2.Height = ((cntrl2.Height) * (frm.Height)) / (frm.resHeightReference);
                                cntrl2.Top = ((cntrl2.Top) * (frm.Height)) / (frm.resHeightReference);
                            }
                        }
                    }

                }

            }
            else
            {
                foreach (System.Windows.Forms.Control cntrl in frm.Controls)
                {

                    cntrl.Height = (int)(((cntrl.Height) * (PSWAH) * (maxLength * dpiY)) / (frm.resHeightReference * (frm.Height)));
                    cntrl.Top = (int)(((cntrl.Top) * (PSWAH) * (maxLength * dpiY)) / (frm.resHeightReference * (frm.Height)));


                    if (cntrl is System.Windows.Forms.TabControl)
                    {
                        foreach (System.Windows.Forms.TabPage tabPg in cntrl.Controls)
                        {
                            foreach (System.Windows.Forms.Control cntrl2 in tabPg.Controls)
                            {
                                cntrl2.Height = (int)(((cntrl2.Height) * (PSWAH) * (maxLength * dpiY)) / (frm.resHeightReference * (frm.Height)));
                                cntrl2.Top = (int)(((cntrl2.Top) * (PSWAH) * (maxLength * dpiY)) / (frm.resHeightReference * (frm.Height)));
                            }
                        }
                    }

                }

                frm.Height = (int)((frm.Height) * (maxLength * dpiY)) / (frm.Height);

            }

            frm.resHeightReference = frm.Height;

            if (frm.bInitialScale == true)
            {
                frm.bInitialScale = false; // If this was the initial scaling (from scratch), it's now complete.
            }
            if (frm.bSkipMaxLen == true)
            {
                frm.bSkipMaxLen = false; // No need to consider the maximum length restriction now.
            }


        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            // You must disable the scanner before exiting the application in 
            // order to release all the resources.
            this.Close();
        }
        private void buttonExit_KeyDown(object sender, KeyEventArgs e)
        {
            // Checks if the key pressed was an enter button (character code 13)
            if (e.KeyValue == (char)13)
                buttonExit_Click(this, e);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            this.listBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add MainMenu if Pocket PC
            if (Symbol.Win32.PlatformType.IndexOf("PocketPC") != -1)
            {
                this.Menu = this.mainMenu1;
            }
            try
            {
                _isBarcodeInitiated = _myScanApi.InitBarcode();
                if (!(_isBarcodeInitiated))
                {
                    Application.Exit();
                }
                else
                {
                    _myScanNotifyHandler = myScanAPI_ScanNotify;
                    _myScanApi.AttachScanNotify(_myScanNotifyHandler);
                    _myScanApi.StartScan(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Bitmap MyImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap("\\Release\\OK.png");
            pictureBox1.Image = (Image)MyImage;
        }

        private void myScanAPI_ScanNotify(ScanDataCollection scanDataCollection)
        {
            _fix = _fix + 1;
            _myScanApi.StopScan();
            ScanData scanData = scanDataCollection.GetFirst;
            switch (scanData.Result)
            {
                case Results.SUCCESS:
                    HandleData(scanData.Text);
                    if (_fix == 1)
                    {
                        _myScanApi.Barcode2.ScanBufferClear();
                    }
                    else
                    {
                        _fix = 0;
                    }
                    break;
                case Results.E_SCN_READTIMEOUT:
                    break;
                case Results.CANCELED:
                    break;
                case Results.E_SCN_DEVICEFAILURE:
                    break;
                default:
                    if (scanData.Result == Results.E_SCN_READINCOMPATIBLE)
                    {
                        Close();
                    }
                    break;
            }
            _myScanApi.StartScan(false);
        }


        public void HandleData(string scanData)
        {
            while (listBox1.Items.Count >= 3)
            {
                listBox1.Items.RemoveAt(0);
            }
            listBox1.Items.Add(scanData);
            //listBox1.Items[listBox1.Items.Count - 1];
                

            if (Program.manualEntryForm.Visible)
            {
                Program.manualEntryForm.Hide();
                Program.mainForm.Show();
            }
                        

            connNet.response = scanData;
            Thread sendThread = new Thread(new ThreadStart(connNet.sendCode));
            sendThread.Start();
            answerLabel.Text = "Идет проверка билета";
            ColorAnswerPanel.BackColor = neutralAnswerColor;
            


            listBox2.Items.Clear();
            listBox2.Items.Add("Ожидание...");
            //Bitmap MyImage;
            try
            {
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //MyImage = new Bitmap("\\Release\\wait.png");
               // pictureBox1.Image = (Image)MyImage;
            }
            catch
            {
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (bInitialScale == true)
            {
                return; // Return if the initial scaling (from scratch)is not complete.
            }

            if (Screen.PrimaryScreen.Bounds.Width > Screen.PrimaryScreen.Bounds.Height) // If landscape orientation
            {
                if (bPortrait != false) // If an orientation change has occured to landscape
                {
                    bPortrait = false; // Set the orientation flag accordingly.
                    bInitialScale = true; // An initial scaling is required due to orientation change.
                    Scale(this); // Scale the GUI.
                }
                else
                {   // No orientation change has occured
                    bSkipMaxLen = true; // Initial scaling is now complete, so skipping the max. length restriction is now possible.
                    Scale(this); // Scale the GUI.
                }
            }
            else
            {
                // Similarly for the portrait orientation...
                if (bPortrait != true)
                {
                    bPortrait = true;
                    bInitialScale = true;
                    Scale(this);
                }
                else
                {
                    bSkipMaxLen = true;
                    Scale(this);
                }
            }
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (connNet.update == true)
            {
                SoundPlayer sp;
                string path = "\\Release\\yes.wav";
                sp = new SoundPlayer(path);
                Bitmap MyImage;
                try
                {
                    if (connNet.response5 == "204")
                    {
                        path = "\\Release\\yes.wav";
                        sp = new SoundPlayer(path);
                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        //MyImage = new Bitmap("\\Release\\OK.png");
                        //pictureBox1.Image = (Image)MyImage;
                        answerLabel.Text = "Доступ разрешен";
                        ColorAnswerPanel.BackColor = rightAnswerColor;
                    }
                    else
                    {
                        path = "\\Release\\no.wav";
                        sp = new SoundPlayer(path);
                        if (connNet.response5 == "404")
                        {
                            //MyImage = new Bitmap("\\Release\\not correct.jpg");
                            //pictureBox1.Image = (Image)MyImage;
                            answerLabel.Text = "Неизвестный билет";
                            ColorAnswerPanel.BackColor = wrongAnswerColor;
                        }
                        if (connNet.response5 == "403")
                        {
                           // MyImage = new Bitmap("\\Release\\Zapret.png");
                          //  pictureBox1.Image = (Image)MyImage;
                            answerLabel.Text = "Билет уже погашен";
                            ColorAnswerPanel.BackColor = wrongAnswerColor;
                        }
                        if (connNet.response5 == "303")
                        {
                            //MyImage = new Bitmap("\\Release\\servererror.png");
                            //pictureBox1.Image = (Image)MyImage;
                            answerLabel.Text = "Потеря связи с сервером";
                            ColorAnswerPanel.BackColor = wrongAnswerColor;
                        }
                    }
                    if (connNet.response != "12345")
                    {
                        sp.Play();
                    }
                    else
                    {
                        answerLabel.Text = "Готов к работе";
                        ColorAnswerPanel.BackColor = neutralAnswerColor;
                       /* try
                        {
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            MyImage = new Bitmap("\\Release\\OK.png");
                            pictureBox1.Image = (Image)MyImage;
                        }
                        catch
                        {
                        }*/
                    }
                }
                catch { }
                listBox2.Items.Clear();
                statusBar1.Text = connNet.mess + " |  ответ сервера: " + connNet.response5;
                connNet.update = false;
            }
            else if (connNet.mess == "Ошибка") statusBar1.Text = "Проверьте соединение с интернетом";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (manualEnterUserControl1.Visible) manualEnterUserControl1.Hide();
            //else manualEnterUserControl1.Show();

            Program.manualEntryForm.Show();

            //ManualEntryForm manualForm = new ManualEntryForm();
            //UserControl uc = new UserControl();
            //uc.Show();
            //manualForm.Show();
            //manualForm.Closing += delegate { this.Show(); };
            //this.Hide();
           
        }

        private void answerLabel_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}