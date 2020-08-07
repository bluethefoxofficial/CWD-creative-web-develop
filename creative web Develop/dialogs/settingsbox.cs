using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_web_Develop
{
    public partial class settingsbox : Form
    {
        public settingsbox()
        {
            InitializeComponent();
        }
        private bool isValidConnection(string url, string user, string password)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(user, password);
                request.GetResponse();
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        private void settingsbox_Load(object sender, EventArgs e)
        {
            if(Debugger.IsAttached == true)
            {
                cxFlatButton5.Show();
            }
            else
            {
                cxFlatButton5.Hide();
            }
            if (Properties.Settings.Default.licenced == false)
            {
                groupBox1.Hide();
                groupBox4.Hide();
            }
            else
            {
                tabPage6.Hide();
                groupBox3.Hide();
                groupBox1.Show();
            }
            pictureBox2.BackColor = Properties.Settings.Default.Textboxcolor;
            label10.BackColor = Properties.Settings.Default.Textboxcolor;
            label11.BackColor = Properties.Settings.Default.documentmapbackground;
            pictureBox3.BackColor = Properties.Settings.Default.textbosidebarcolor;
            pictureBox4.BackColor = Properties.Settings.Default.documentmapbackground;
            label9.BackColor = Properties.Settings.Default.textbosidebarcolor;
            label10.ForeColor = Properties.Settings.Default.textboxforecolor;
            label11.ForeColor = Properties.Settings.Default.documentmapfore;
            textBox1.Text = Properties.Settings.Default.host;
            textBox2.Text = Properties.Settings.Default.username;
            phpcmd.Text = Properties.Settings.Default.phpexe;
            libdir.Text = Properties.Settings.Default.libdirectory;
            textBox3.Text = Properties.Settings.Default.password;

            if (Properties.Settings.Default.splashscreen == true)
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
            if (Properties.Settings.Default.highdpi == true)
            {
                checkBox4.Checked = true;
            }
            else
            {
                checkBox4.Checked = false;
            }
            if (Properties.Settings.Default.darktheme == true)
            {
              
            }
            else
            {
               
            }

            
        }
        private void Form1_HelpButtonClicked(Object sender, CancelEventArgs e)

        {

            MessageBox.Show("CDW Help", "Beta versions of CDW dont have help in them.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TestFTPconnectionbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Uri uri = new Uri("ftp://" + textBox1.Text);
                Status.Text = "status: Connecting";
                pictureBox1.BackColor = Color.Orange;
                timer1.Start();
                FtpWebRequest requestDir = (FtpWebRequest)FtpWebRequest.Create(uri);
                requestDir.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                requestDir.Credentials = new NetworkCredential(textBox2.Text, textBox3.Text);
                try
                {
                    timer1.Stop();
                    WebResponse response = requestDir.GetResponse();
                    Status.Text = "status: Connection successfull";
                    pictureBox1.BackColor = Color.Green;
                    MessageBox.Show("connection established");


                }
                catch (WebException ex)
                {
                    timer1.Stop();

                    Status.Text = "status: Connection error";
                    pictureBox1.BackColor = Color.Red;
                    MessageBox.Show("connection error: " + ex.Message);
                }
            }
            catch
            {
                MessageBox.Show("check host input");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void Applysettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.host = textBox1.Text;
            Properties.Settings.Default.libdirectory = libdir.Text;
            Properties.Settings.Default.phpexe = phpcmd.Text;
            Properties.Settings.Default.username = textBox2.Text;
            Properties.Settings.Default.password = textBox3.Text;


            //themeing engine code (csoftware 2019 30th december)

            Properties.Settings.Default.Textboxcolor = pictureBox2.BackColor;
           Properties.Settings.Default.textbosidebarcolor = pictureBox3.BackColor;
           Properties.Settings.Default.documentmapbackground = pictureBox4.BackColor;
           Properties.Settings.Default.textbosidebarcolor = label9.BackColor;
            Properties.Settings.Default.textboxforecolor = label10.ForeColor;
            Properties.Settings.Default.documentmapfore = label11.ForeColor;

            if (checkBox2.Checked == true)
            {
                Properties.Settings.Default.splashscreen = true;
            }
            else
            {
                Properties.Settings.Default.splashscreen = false;
            }
            if (checkBox4.Checked == true)
            {
                Properties.Settings.Default.highdpi = true;
            }
            else
            {
                Properties.Settings.Default.highdpi = false;
            }
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            if (checkBox3.Checked == true)
            {
                Application.Restart();
            }  
           
            if (Properties.Settings.Default.highdpi == true)
            {
                Cef.EnableHighDPISupport();
            }
            else
            {
                
            }
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.BackColor == Color.Orange)
            {
                pictureBox1.BackColor = Color.DarkOrange;
            }
            else
            {
                pictureBox1.BackColor = Color.Orange;
            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new ftpfilemanager().Show();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.php.net/downloads.php");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Help \n this helps debug php when your running a php project. \n the %filename% is used for when you want to use the current file, \n is required for debugging to work properly.");
        }

        private void CxFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("this will reset cwd by resetting all settings \n are you sure you wanna do this?", "FINAL WARNING!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Application.Restart();
            }
        }

        private void CxFlatRoundButton1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You are about to enable console mode in console mode GUI interfaces dont work. type disableconsole to disable console mode") == DialogResult.OK)
            {

            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
        }
        
        private void CxFlatButton1_Click_1(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory);
        }

        private void CxFlatButton5_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.BackColor = colorDialog1.Color;
                label11.BackColor = colorDialog1.Color;
            }
        }

        private void CxFlatButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackColor = colorDialog1.Color;
                label10.BackColor = colorDialog1.Color;
            }
        }

        private void CxFlatButton3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.BackColor = colorDialog1.Color;
                label9.BackColor = colorDialog1.Color;
            }
        }

        private void CxFlatButton4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
              
                label9.ForeColor = colorDialog1.Color;
            }
        }

        private void CxFlatButton6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                label11.ForeColor = colorDialog1.Color;
            }
        }

        private void CxFlatButton7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                label10.ForeColor = colorDialog1.Color;
            }
        }

        private void CxFlatButton8_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.activationkeys.Contains(cxFlatTextBox1.Text))
            {
                Properties.Settings.Default.licenced = true;
                Properties.Settings.Default.Save();
                MessageBox.Show("Activated. Restarting");
                Application.Restart();
            }
           
        }

        private void CxFlatButton9_Click(object sender, EventArgs e)
        {
           new dialogs.terminal().ShowDialog();
        }

        private void CxFlatButton10_Click(object sender, EventArgs e)
        {


            Properties.Settings.Default.Textboxcolor = Color.FromArgb(64, 64, 64);
            Properties.Settings.Default.textbosidebarcolor = Color.White;
            Properties.Settings.Default.documentmapbackground = Color.Black;
            Properties.Settings.Default.textbosidebarcolor = Color.FromArgb(64,64,64);
            Properties.Settings.Default.textboxforecolor = Color.White;
            Properties.Settings.Default.documentmapfore = Color.White;
            Properties.Settings.Default.Save();
            MessageBox.Show("Restored to default settings for themes.");
            this.Close();
        }
    }
}
