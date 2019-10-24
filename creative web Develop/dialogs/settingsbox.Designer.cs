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
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.libdir = new CxFlatUI.CxFlatTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.phpcmd = new CxFlatUI.CxFlatTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox4 = new CxFlatUI.CxFlatSwitch();
            this.checkBox2 = new CxFlatUI.CxFlatSwitch();
            this.checkBox3 = new CxFlatUI.CxFlatSwitch();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new CxFlatUI.CxFlatGroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new CxFlatUI.CxFlatTextBox();
            this.TestFTPconnectionbtn = new CxFlatUI.Controls.CxFlatButton();
            this.textBox2 = new CxFlatUI.CxFlatTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new CxFlatUI.CxFlatTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Applysettings
            // 
            this.Applysettings.ButtonType = CxFlatUI.ButtonType.Primary;
            this.Applysettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Applysettings.Location = new System.Drawing.Point(746, 589);
            this.Applysettings.Name = "Applysettings";
            this.Applysettings.Size = new System.Drawing.Size(102, 32);
            this.Applysettings.TabIndex = 0;
            this.Applysettings.Text = "Apply";
            this.Applysettings.TextColor = System.Drawing.Color.White;
            this.Applysettings.Click += new System.EventHandler(this.Applysettings_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(566, 161);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(16, 18);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // libdir
            // 
            this.libdir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.libdir.Hint = "";
            this.libdir.Location = new System.Drawing.Point(283, 247);
            this.libdir.MaxLength = 32767;
            this.libdir.Multiline = false;
            this.libdir.Name = "libdir";
            this.libdir.PasswordChar = '\0';
            this.libdir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.libdir.SelectedText = "";
            this.libdir.SelectionLength = 0;
            this.libdir.SelectionStart = 0;
            this.libdir.Size = new System.Drawing.Size(306, 43);
            this.libdir.TabIndex = 10;
            this.libdir.TabStop = false;
            this.libdir.Text = "lib";
            this.libdir.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "LIB directory";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(156, 207);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 18);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "download PHP";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "PHP CMD";
            // 
            // phpcmd
            // 
            this.phpcmd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.phpcmd.Hint = "";
            this.phpcmd.Location = new System.Drawing.Point(259, 158);
            this.phpcmd.MaxLength = 32767;
            this.phpcmd.Multiline = false;
            this.phpcmd.Name = "phpcmd";
            this.phpcmd.PasswordChar = '\0';
            this.phpcmd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phpcmd.SelectedText = "";
            this.phpcmd.SelectionLength = 0;
            this.phpcmd.SelectionStart = 0;
            this.phpcmd.Size = new System.Drawing.Size(301, 43);
            this.phpcmd.TabIndex = 7;
            this.phpcmd.TabStop = false;
            this.phpcmd.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.Location = new System.Drawing.Point(71, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "High DPI support \r\n(Requires restarting when disabling)\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "splash screen";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(25, 122);
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
            this.checkBox2.Location = new System.Drawing.Point(25, 58);
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
            this.checkBox3.Location = new System.Drawing.Point(14, 602);
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
            this.label6.Location = new System.Drawing.Point(57, 602);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "restart application on apply";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(21, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 522);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General settings";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Status);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.TestFTPconnectionbtn);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FTP settings";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(195, 224);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(113, 18);
            this.Status.TabIndex = 2;
            this.Status.Text = "status: waiting...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(140, 180);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox1.Hint = "";
            this.textBox1.Location = new System.Drawing.Point(252, 12);
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
            // TestFTPconnectionbtn
            // 
            this.TestFTPconnectionbtn.ButtonType = CxFlatUI.ButtonType.Primary;
            this.TestFTPconnectionbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TestFTPconnectionbtn.Location = new System.Drawing.Point(179, 180);
            this.TestFTPconnectionbtn.Name = "TestFTPconnectionbtn";
            this.TestFTPconnectionbtn.Size = new System.Drawing.Size(186, 33);
            this.TestFTPconnectionbtn.TabIndex = 0;
            this.TestFTPconnectionbtn.Text = "Test connection";
            this.TestFTPconnectionbtn.TextColor = System.Drawing.Color.White;
            this.TestFTPconnectionbtn.Click += new System.EventHandler(this.TestFTPconnectionbtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox2.Hint = "";
            this.textBox2.Location = new System.Drawing.Point(236, 74);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox3.Hint = "";
            this.textBox3.Location = new System.Drawing.Point(236, 131);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.phpcmd);
            this.tabPage4.Controls.Add(this.linkLabel2);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.libdir);
            this.tabPage4.Controls.Add(this.linkLabel1);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(803, 491);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "LIB Settings";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Lib Settings";
            // 
            // settingsbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 633);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox3);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CxFlatUI.Controls.CxFlatButton Applysettings;
        private CxFlatUI.CxFlatSwitch checkBox2;
        private CxFlatUI.CxFlatSwitch checkBox3;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CxFlatUI.CxFlatSwitch checkBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private CxFlatUI.CxFlatTextBox phpcmd;
        private CxFlatUI.CxFlatTextBox libdir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label1;
        private CxFlatUI.CxFlatGroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CxFlatUI.CxFlatTextBox textBox1;
        private CxFlatUI.Controls.CxFlatButton TestFTPconnectionbtn;
        private CxFlatUI.CxFlatTextBox textBox2;
        private System.Windows.Forms.Label label3;
        private CxFlatUI.CxFlatTextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
    }
}