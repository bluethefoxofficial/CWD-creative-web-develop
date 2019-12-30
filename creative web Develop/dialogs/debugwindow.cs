using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_web_Develop.dialogs
{
   
 
    public partial class debugwindow : Form
    {
     
        
        public string urlfordebugging;
        public string location
        {
            get { return urlfordebugging; }
            set { urlfordebugging = value; }
        }
        public debugwindow()
        {
            InitializeComponent();

        }
        ChromiumWebBrowser chromeBrowser = new ChromiumWebBrowser("localhost:8000");
        private void Debugwindow_Load(object sender, EventArgs e)
        {
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.Show();
            chromeBrowser.BringToFront();
            chromeBrowser.Load("about:blank");
            chromeBrowser.Load("localhost:8000");
        }
    

        private void Debugwindow_KeyDown(object sender, KeyEventArgs e)
        {
          if(e.KeyCode == Keys.F5)
            {
                chromeBrowser.Load("about:blank");
                chromeBrowser.Load("localhost:8000");
            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

            chromeBrowser.Load("about:blank");
            chromeBrowser.Load("localhost:8000");
            
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void RefreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("about:blank");
            chromeBrowser.Load("localhost:8000");
        }
    }
}
