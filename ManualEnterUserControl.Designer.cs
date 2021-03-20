namespace CS_Barcode2ControlSample1
{
    partial class ManualEnterUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "проверить";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.textBox.Location = new System.Drawing.Point(0, 30);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(240, 30);
            this.textBox.TabIndex = 4;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ManualEnterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button1);
            this.Name = "ManualEnterUserControl";
            this.Size = new System.Drawing.Size(240, 143);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox;

    }
}
