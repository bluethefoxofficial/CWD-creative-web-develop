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
  
        public about()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Purple;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Azure;
        }

       

        private void label5_Click(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Blue;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Blue;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //label7.ForeColor = Color.Purple;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Red;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //label6.ForeColor = Color.Aqua;
        }

        private void label3_Click(object sender, EventArgs e)
        {
     
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void about_Load(object sender, EventArgs e)
        {
            
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
    }
}
