namespace CS_Barcode2ControlSample1
{
    partial class ManualEntryForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(308, 474);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(144, 54);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.White;
            this.textBoxCode.Font = new System.Drawing.Font("Tahoma", 11.5F, System.Drawing.FontStyle.Regular);
            this.textBoxCode.Location = new System.Drawing.Point(3, 28);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(472, 57);
            this.textBoxCode.TabIndex = 3;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(60, 105);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(357, 51);
            this.Check.TabIndex = 4;
            this.Check.Text = "Проверить билет";
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.button1.Location = new System.Drawing.Point(60, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.button2.Location = new System.Drawing.Point(181, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "2";
            this.button2.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.button3.Location = new System.Drawing.Point(302, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 60);
            this.button3.TabIndex = 7;
            this.button3.Text = "3";
            this.button3.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.button6.Location = new System.Drawing.Point(302, 253);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 60);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.button5.Location = new System.Drawing.Point(181, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 60);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.button4.Location = new System.Drawing.Point(60, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 60);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.button9.Location = new System.Drawing.Point(302, 319);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(115, 60);
            this.button9.TabIndex = 13;
            this.button9.Text = "9";
            this.button9.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.button8.Location = new System.Drawing.Point(181, 319);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 60);
            this.button8.TabIndex = 12;
            this.button8.Text = "8";
            this.button8.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.button7.Location = new System.Drawing.Point(60, 319);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 60);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.buttonEnter.Location = new System.Drawing.Point(302, 385);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(115, 60);
            this.buttonEnter.TabIndex = 16;
            this.buttonEnter.Text = "OK";
            this.buttonEnter.Click += new System.EventHandler(this.Check_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.button0.Location = new System.Drawing.Point(181, 385);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(115, 60);
            this.button0.TabIndex = 15;
            this.button0.Text = "0";
            this.button0.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular);
            this.buttonBackspace.Location = new System.Drawing.Point(60, 385);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(115, 60);
            this.buttonBackspace.TabIndex = 14;
            this.buttonBackspace.Text = "←";
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(22, 478);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(143, 50);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // ManualEntryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(478, 535);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.buttonBack);
            this.Menu = this.mainMenu1;
            this.Name = "ManualEntryForm";
            this.Text = "IventTIS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonClear;
    }
}