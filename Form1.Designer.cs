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
            this.answerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ColorAnswerPanel = new System.Windows.Forms.Panel();
            this.ColorAnswerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Gray;
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.buttonExit.Location = new System.Drawing.Point(440, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 40);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonExit_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 110);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 511);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(478, 24);
            this.statusBar1.Text = "statusBar1";
            // 
            // listBox2
            // 
            this.listBox2.Location = new System.Drawing.Point(445, 149);
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
            this.pictureBox1.Location = new System.Drawing.Point(13, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 58);
            this.pictureBox1.Visible = false;
            // 
            // answerLabel
            // 
            this.answerLabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.answerLabel.ForeColor = System.Drawing.Color.White;
            this.answerLabel.Location = new System.Drawing.Point(27, 171);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(412, 139);
            this.answerLabel.Text = "Готов к работе";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.answerLabel.ParentChanged += new System.EventHandler(this.answerLabel_ParentChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ручной ввод";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColorAnswerPanel
            // 
            this.ColorAnswerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.ColorAnswerPanel.Controls.Add(this.listBox1);
            this.ColorAnswerPanel.Controls.Add(this.answerLabel);
            this.ColorAnswerPanel.Controls.Add(this.buttonExit);
            this.ColorAnswerPanel.Controls.Add(this.button1);
            this.ColorAnswerPanel.Controls.Add(this.pictureBox1);
            this.ColorAnswerPanel.Location = new System.Drawing.Point(0, 0);
            this.ColorAnswerPanel.Name = "ColorAnswerPanel";
            this.ColorAnswerPanel.Size = new System.Drawing.Size(480, 505);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(478, 535);
            this.Controls.Add(this.ColorAnswerPanel);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.statusBar1);
            this.Name = "Form1";
            this.Text = "IventTIS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ColorAnswerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ColorAnswerPanel;
    }
}

