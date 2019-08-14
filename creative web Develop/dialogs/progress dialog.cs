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
    public partial class progress_dialog : Form
    {
        private const string V = "Value of progress bar";

        public progress_dialog()
        {
            InitializeComponent();
        }
        [Description("Title of the Dialog"), Category("Data")]
        public string Title
        {
            get { return Text; }
            set { Text = value; }
        }

        [Description(V), Category("Data")]
        public int progress
        {
        
            set { progressBar1.Value = value; }
        }
        private void Progress_dialog_Load(object sender, EventArgs e)
        {

        }

        private void CxFlatProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
