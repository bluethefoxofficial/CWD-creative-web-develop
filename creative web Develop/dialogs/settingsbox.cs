using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                return false;
            }
            return true;
        }
        private void settingsbox_Load(object sender, EventArgs e)
        {
          
            textBox1.Text = Properties.Settings.Default.host;
            textBox2.Text = Properties.Settings.Default.username;
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
                    MessageBox.Show("connection error");
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
            Properties.Settings.Default.username = textBox2.Text;
            Properties.Settings.Default.password = textBox3.Text;
        
         
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
            if (checkBox3.Checked == true)
            {
                Application.Restart();
            }  
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
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
    }
}
