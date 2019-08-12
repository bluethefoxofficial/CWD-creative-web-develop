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
    public partial class newhtml : Form
    {
        public newhtml()
        {
            InitializeComponent();
        }

        private void newhtml_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.darktheme == true)
            {
                BackColor = Color.Black;
                ForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
