using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_web_Develop.tab_elements
{
    public partial class phpprojecteditor : UserControl
    {
        List<string> projectfiles = new List<string>();
        public string projectFolder;
        public string currentfile;

        [Description("This is to direct this element to where the project is located."), Category("Data")]
        public string folderlocation
        {
            get { return projectFolder; }
            set { projectFolder = value; }
        }
        public string currentfileprop
        {
            get { return currentfile; }
            set { currentfile = value; }
        }


        public phpprojecteditor()
        {
            InitializeComponent();
        }

        private void Phpprojecteditor_Load(object sender, EventArgs e)
        {

        }
    }
}
