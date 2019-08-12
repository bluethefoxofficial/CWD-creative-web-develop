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
    public partial class shhh : Form
    {
        public shhh()
        {
            InitializeComponent();
        }

        private void shhh_Load(object sender, EventArgs e)
        {
            BackgroundImage = Bitmap.FromHicon(SystemIcons.Shield.Handle);
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            BackgroundImage = Bitmap.FromHicon(SystemIcons.Exclamation.Handle);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            BackgroundImage = Bitmap.FromHicon(SystemIcons.Error.Handle);
        }
    }
}
