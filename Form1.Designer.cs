namespace CS_Barcode2ControlSample1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.manualEnterUserControl1 = new CS_Barcode2ControlSample1.ManualEnterUserControl();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(4, 218);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(72, 20);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonExit_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 135);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 244);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 24);
            this.statusBar1.Text = "statusBar1";
            // 
            // listBox2
            // 
            this.listBox2.Location = new System.Drawing.Point(207, 73);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(30, 50);
            this.listBox2.TabIndex = 2;
            this.listBox2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(4, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 58);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(82, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 58);
            this.label1.Text = "Готов к работе";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "Manual";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // manualEnterUserControl1
            // 
            this.manualEnterUserControl1.Location = new System.Drawing.Point(0, 0);
            this.manualEnterUserControl1.Name = "manualEnterUserControl1";
            this.manualEnterUserControl1.Size = new System.Drawing.Size(240, 143);
            this.manualEnterUserControl1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.manualEnterUserControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonExit);
            this.Name = "Form1";
            this.Text = "IventTIS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private ManualEnterUserControl manualEnterUserControl1;
    }
}

