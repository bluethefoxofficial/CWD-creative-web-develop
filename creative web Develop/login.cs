using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_web_Develop
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void CxFlatSimpleButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://csoftware.cf/signup.php");
        }

        private void CxFlatSimpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THE API TOKEN IS CURRENTLY NOT CREATED THEREFOR THE SOFTWARE CANT COMMUNICATE WITH THE SERVER.");
        }
    }
}
