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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            lblversion.Text = ProductVersion;
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

          
               
            this.WindowState = FormWindowState.Minimized;
           
            this.Hide();

            timer1.Start();
            var Maineditor = new homeeditor();
            Maineditor.Closed += (s, args) => this.Close();
            Maineditor.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {    
                timer1.Stop();

            this.Hide();
       

        }
    }
}
