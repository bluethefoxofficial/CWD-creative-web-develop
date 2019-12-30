using CefSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_web_Develop
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public Form1()
        {
            try
            {
                InitializeComponent();
            }
            catch(Exception e)
            {
                pictureBoxDoubleBuffer1.Visible = true;
                cxFlatAlertBox1.Visible = true;
                cxFlatAlertBox1.Text = e.Message;
                Console.WriteLine(e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                lblversion.Text = ProductVersion;
            }catch(Exception exec)
            {
                pictureBoxDoubleBuffer1.Visible = true;
                cxFlatAlertBox1.Visible = true;
                cxFlatAlertBox1.Text = exec.Message;
            }
            try
            {
                string[] files = Directory.GetFiles(Environment.CurrentDirectory + "/plugins/", "*.*", SearchOption.AllDirectories);
                string[] unwantedExtensions = { "dll", "DLL" };
                StringCollection col = new StringCollection();
                foreach (string file in files)
                {
                    string ext = Path.GetExtension(file);
                    if (!unwantedExtensions.Contains<string>(ext))
                    {
                        Assembly assembly = Assembly.LoadFrom(file);
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (Properties.Settings.Default.highdpi == true)
            {
                try
                {
                    Cef.EnableHighDPISupport();

                }
                catch(Exception exe)
                {
                    pictureBoxDoubleBuffer1.Visible = true;
                    cxFlatAlertBox1.Visible = true;
                    cxFlatAlertBox1.Text = exe.Message;
                    Console.WriteLine(exe.Message);
                }
            }

            this.Hide();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Show();



            timer1.Start();
           

       

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            var Maineditor = new homeeditor();
            this.Hide();
            Maineditor.Closed += (s, args) => this.Close();
            Maineditor.Show();

            timer1.Stop();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
