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
            
            timer1.Start();
            lblversion.Text = ProductVersion;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += 1;
            if(Opacity == 100)
            {
                timer1.Stop();
                Application.Run(new homeeditor());
                this.Close();
            }
        }
    }
}
