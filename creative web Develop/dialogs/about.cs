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
    public partial class about : Form
    {
        public bool drag = false;
        private Timer tmr;
        private int scrll { get; set; }
        private int limit = 40;
        public about()
        {
            InitializeComponent();
        }

 

       

        private void about_Load(object sender, EventArgs e)
        {
            ScrollLabel();
            timer1.Start();
        }
        private void ScrollLabel()
        {
            string strString = "       \n This is the people that made CWD                      \n[---developers---]   \nkessan robertson \nNexite \nT3K  \n[---beta testers---] \nSam \n [---CWD graphic designers---]    \n[the background and splash screen] \n Kessan Robertson \n [the icon] \n Nexite                                                ";

            scrll = scrll + 1;
            int iLmt = strString.Length - scrll;
            if (iLmt < limit)
            {
                scrll = 0;
            }
            string str = strString.Substring(scrll, limit);
            label1.Text = str;
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            new shhh().ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ScrollLabel();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
