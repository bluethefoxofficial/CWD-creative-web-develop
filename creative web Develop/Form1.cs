using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            if (Properties.Settings.Default.splashscreen == true)
            {
             
            }
            else
            {
                timer1.Stop();
                this.Hide();
                var Maineditor = new homeeditor();
                Maineditor.Closed += (s, args) => this.Close();
                Maineditor.Show();
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {    
                timer1.Stop();

            this.Hide();
            var Maineditor = new homeeditor();
            Maineditor.Closed += (s, args) => this.Close();
            Maineditor.Show();

        }
    }
}
