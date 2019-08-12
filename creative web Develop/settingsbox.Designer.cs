namespace creative_web_Develop
{
    partial class settingsbox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsbox));
            this.Applysettings = new CxFlatUI.Controls.CxFlatButton();
            this.groupBox1 = new CxFlatUI.CxFlatGroupBox();
            this.Status = new System.Windows.Forms.Label();
            this.groupBox2 = new CxFlatUI.CxFlatGroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TestFTPconnectionbtn = new CxFlatUI.Controls.CxFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new CxFlatUI.CxFlatTextBox();
            this.textBox2 = new CxFlatUI.CxFlatTextBox();
            this.textBox1 = new CxFlatUI.CxFlatTextBox();
            this.groupBox3 = new CxFlatUI.CxFlatGroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox4 = new CxFlatUI.CxFlatSwitch();
            this.checkBox2 = new CxFlatUI.CxFlatSwitch();
            this.checkBox3 = new CxFlatUI.CxFlatSwitch();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Applysettings
            // 
            this.Applysettings.ButtonType = CxFlatUI.ButtonType.Primary;
            this.Applysettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Applysettings.Location = new System.Drawing.Point(645, 478);
            this.Applysettings.Name = "Applysettings";
            this.Applysettings.Size = new System.Drawing.Size(102, 32);
            this.Applysettings.TabIndex = 0;
            this.Applysettings.Text = "Apply";
            this.Applysettings.TextColor = System.Drawing.Color.White;
            this.Applysettings.Click += new System.EventHandler(this.Applysettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TestFTPconnectionbtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(24, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.ShowText = false;
            this.groupBox1.Size = new System.Drawing.Size(375, 417);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP";
            this.groupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(61, 276);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(148, 28);
            this.Status.TabIndex = 2;
            this.Status.Text = "status: waiting...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(6, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.ShowText = false;
            this.groupBox2.Size = new System.Drawing.Size(33, 33);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 12);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TestFTPconnectionbtn
            // 
            this.TestFTPconnectionbtn.ButtonType = CxFlatUI.ButtonType.Primary;
            this.TestFTPconnectionbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TestFTPconnectionbtn.Location = new System.Drawing.Point(45, 232);
            this.TestFTPconnectionbtn.Name = "TestFTPconnectionbtn";
            this.TestFTPconnectionbtn.Size = new System.Drawing.Size(186, 33);
            this.TestFTPconnectionbtn.TabIndex = 0;
            this.TestFTPconnectionbtn.Text = "Test connection";
            this.TestFTPconnectionbtn.TextColor = System.Drawing.Color.White;
            this.TestFTPconnectionbtn.Click += new System.EventHandler(this.TestFTPconnectionbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host name";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox3.Hint = "";
            this.textBox3.Location = new System.Drawing.Point(102, 183);
            this.textBox3.MaxLength = 32767;
            this.textBox3.Multiline = false;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '\0';
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox3.SelectedText = "";
            this.textBox3.SelectionLength = 0;
            this.textBox3.SelectionStart = 0;
            this.textBox3.Size = new System.Drawing.Size(253, 43);
            this.textBox3.TabIndex = 4;
            this.textBox3.TabStop = false;
            this.textBox3.UseSystemPasswordChar = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox2.Hint = "";
            this.textBox2.Location = new System.Drawing.Point(102, 126);
            this.textBox2.MaxLength = 32767;
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '\0';
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox2.SelectedText = "";
            this.textBox2.SelectionLength = 0;
            this.textBox2.SelectionStart = 0;
            this.textBox2.Size = new System.Drawing.Size(253, 43);
            this.textBox2.TabIndex = 3;
            this.textBox2.TabStop = false;
            this.textBox2.UseSystemPasswordChar = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox1.Hint = "";
            this.textBox1.Location = new System.Drawing.Point(118, 64);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.Size = new System.Drawing.Size(237, 43);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.UseSystemPasswordChar = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.Location = new System.Drawing.Point(426, 51);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.ShowText = false;
            this.groupBox3.Size = new System.Drawing.Size(321, 417);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "general";
            this.groupBox3.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.Location = new System.Drawing.Point(55, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "High DPI support \r\n(Requires restarting when disabling)\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "splash screen";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(9, 139);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(40, 20);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "High DPI support \r\n(Requires restarting when disabling)";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 75);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(40, 20);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "splash screen";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(18, 486);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(40, 20);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "restart application on apply";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.Location = new System.Drawing.Point(65, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "restart application on apply";
            // 
            // settingsbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 525);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Applysettings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2160, 1158);
            this.MinimizeBox = false;
            this.Name = "settingsbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsbox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CxFlatUI.Controls.CxFlatButton Applysettings;
        private CxFlatUI.CxFlatGroupBox groupBox1;
        private System.Windows.Forms.Label Status;
        private CxFlatUI.CxFlatGroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CxFlatUI.Controls.CxFlatButton TestFTPconnectionbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CxFlatUI.CxFlatTextBox textBox3;
        private CxFlatUI.CxFlatTextBox textBox2;
        private CxFlatUI.CxFlatTextBox textBox1;
        private CxFlatUI.CxFlatGroupBox groupBox3;
        private CxFlatUI.CxFlatSwitch checkBox2;
        private CxFlatUI.CxFlatSwitch checkBox3;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CxFlatUI.CxFlatSwitch checkBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}