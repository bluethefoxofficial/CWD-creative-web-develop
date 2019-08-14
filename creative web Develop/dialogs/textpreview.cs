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
    public partial class textpreview : Form
    {
        public string fto;
        public textpreview(string filepathfortext)
        {
            InitializeComponent();
            fastColoredTextBox1.Text = System.IO.File.ReadAllText(filepathfortext);
            fto = System.IO.File.ReadAllText(filepathfortext);
        }

        private void HtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
            fastColoredTextBox1.Text = fto;
        }

        private void CssToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void JsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS;
            fastColoredTextBox1.Text = fto;
        }

        private void PlaintextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom;
            fastColoredTextBox1.Text = fto;
        }

        private void Textpreview_Load(object sender, EventArgs e)
        {

        }

        private void FastColoredTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FastColoredTextBox1_KeyPressed(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FastColoredTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
