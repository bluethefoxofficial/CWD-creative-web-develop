using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace creative_web_Develop
{
    public partial class Htmlprojecteditor : UserControl
    {
        public string projectFolder;
        List<string> projectfiles = new List<string>();
            public Htmlprojecteditor(string v)
        {
            InitializeComponent();
        }

        private void Htmlprojecteditor_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //dark theme
            if(Properties.Settings.Default.darktheme == true)
            {
                richTextBox1.BackColor = Color.DarkSlateGray;
                richTextBox1.ForeColor = Color.White;
                menuStrip1.BackColor = Color.LightSlateGray;
                menuStrip1.ForeColor = Color.White;
            }
            //loads project files in the project explorer
            try
            {
                foreach (string item in Directory.GetFiles(Properties.Settings.Default.folder.ToString()))
                {
                    imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));

                    listView1.Items.Clear();

                    FileInfo fi = new FileInfo(item);
                    projectfiles.Add(fi.FullName);
                    listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
                }
                richTextBox1.Text = System.IO.File.ReadAllText(Properties.Settings.Default.folder + "");
            }
            catch
            {
                MessageBox.Show("Unable to load folder into project explorer");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void cMDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
