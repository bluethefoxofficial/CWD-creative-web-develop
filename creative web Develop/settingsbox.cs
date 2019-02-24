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

        private void settingsbox_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.darktheme == true)
            {
                checkBox1.BackColor = Color.Transparent;
                checkBox2.BackColor = Color.Transparent;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
                groupBox1.BackColor = Color.Black;
                groupBox2.BackColor = Color.Black;
                groupBox3.BackColor = Color.Black;
                groupBox1.ForeColor = Color.White;
                groupBox2.ForeColor = Color.White;
                groupBox3.ForeColor = Color.White;
                BackColor = Color.Black;
                ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
            }
            textBox1.Text = Properties.Settings.Default.host;
            textBox2.Text = Properties.Settings.Default.username;
            textBox3.Text = Properties.Settings.Default.password;
            numericUpDown1.Value = Properties.Settings.Default.port;
            if(Properties.Settings.Default.splashscreen == true)
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
            if (Properties.Settings.Default.darktheme == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            
        }
        private void Form1_HelpButtonClicked(Object sender, CancelEventArgs e)

        {

            MessageBox.Show("CDW Help", "Beta versions of CDW dont have help in them.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TestFTPconnectionbtn_Click(object sender, EventArgs e)
        {
            Status.Text = "status: Connecting";
            pictureBox1.BackColor = Color.Orange;
            try
            {
                FtpWebRequest requestDir = (FtpWebRequest)FtpWebRequest.Create("ftp://" + textBox1.Text + ":" + numericUpDown1.Value);
                requestDir.Credentials = new NetworkCredential(textBox2.Text, textBox3.Text);

                try
                {
                    WebResponse response = requestDir.GetResponse();
                    Status.Text = "connection successfull";
                    pictureBox1.BackColor = Color.Green;
                }
                catch (Exception)
                {
                    Status.Text = "connection unsuccessfull";
                    pictureBox1.BackColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("connection was unsuccessfull because you didnt place any details relating to either Credentials or hostname");
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
            Properties.Settings.Default.port = numericUpDown1.Value;
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.darktheme = true;
            }
            else
            {
                Properties.Settings.Default.darktheme = false;
            }
            if (checkBox2.Checked == true)
            {
                Properties.Settings.Default.splashscreen = true;
            }
            else
            {
                Properties.Settings.Default.splashscreen = false;
            }
            if(checkBox3.Checked == true)
            {
                Application.Restart();
            }
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            this.Close();
        }
    }
}
