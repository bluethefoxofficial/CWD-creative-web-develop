namespace creative_web_Develop
{
    partial class login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cxFlatSimpleButton1 = new CxFlatUI.CxFlatSimpleButton();
            this.cxFlatTextBox1 = new CxFlatUI.CxFlatTextBox();
            this.SuspendLayout();
            // 
            // cxFlatSimpleButton1
            // 
            this.cxFlatSimpleButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatSimpleButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatSimpleButton1.Location = new System.Drawing.Point(491, 289);
            this.cxFlatSimpleButton1.Name = "cxFlatSimpleButton1";
            this.cxFlatSimpleButton1.Size = new System.Drawing.Size(113, 40);
            this.cxFlatSimpleButton1.TabIndex = 5;
            this.cxFlatSimpleButton1.Text = "login";
            this.cxFlatSimpleButton1.TextColor = System.Drawing.Color.White;
            this.cxFlatSimpleButton1.Click += new System.EventHandler(this.CxFlatSimpleButton1_Click);
            // 
            // cxFlatTextBox1
            // 
            this.cxFlatTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatTextBox1.Hint = "";
            this.cxFlatTextBox1.Location = new System.Drawing.Point(38, 135);
            this.cxFlatTextBox1.MaxLength = 32767;
            this.cxFlatTextBox1.Multiline = false;
            this.cxFlatTextBox1.Name = "cxFlatTextBox1";
            this.cxFlatTextBox1.PasswordChar = '\0';
            this.cxFlatTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cxFlatTextBox1.SelectedText = "";
            this.cxFlatTextBox1.SelectionLength = 0;
            this.cxFlatTextBox1.SelectionStart = 0;
            this.cxFlatTextBox1.Size = new System.Drawing.Size(548, 43);
            this.cxFlatTextBox1.TabIndex = 6;
            this.cxFlatTextBox1.TabStop = false;
            this.cxFlatTextBox1.Text = "Token";
            this.cxFlatTextBox1.UseSystemPasswordChar = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 341);
            this.Controls.Add(this.cxFlatTextBox1);
            this.Controls.Add(this.cxFlatSimpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.ResumeLayout(false);

        }

        #endregion
        private CxFlatUI.CxFlatSimpleButton cxFlatSimpleButton1;
        private CxFlatUI.CxFlatTextBox cxFlatTextBox1;
    }
}