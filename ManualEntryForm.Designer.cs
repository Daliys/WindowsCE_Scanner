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
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(403, 478);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(72, 54);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Close";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.textBox1.Location = new System.Drawing.Point(40, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 57);
            this.textBox1.TabIndex = 3;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(116, 141);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(218, 51);
            this.Check.TabIndex = 4;
            this.Check.Text = "Check It";
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // ManualEntryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(478, 535);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonExit);
            this.Menu = this.mainMenu1;
            this.Name = "ManualEntryForm";
            this.Text = "IventTIS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Check;
    }
}