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
using Microsoft.VisualBasic;

namespace creative_web_Develop
{
    public partial class Htmlprojecteditor : UserControl
    {
        public string projectFolder;
        public string currentfile;

        List<string> projectfiles = new List<string>();
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
        public Htmlprojecteditor()
        {
            InitializeComponent();
        }

        private void Htmlprojecteditor_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //dark theme
            if (Properties.Settings.Default.darktheme == true)
            {
                BackColor = Color.Black;
                groupBox1.BackColor = Color.Black;
                groupBox1.ForeColor = Color.White;
                richTextBox1.BackColor = Color.DarkSlateGray;
                richTextBox1.ForeColor = Color.White;
                menuStrip1.BackColor = Color.LightSlateGray;
                menuStrip1.ForeColor = Color.White;
            }
            //loads project files in the project explorer
            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(projectFolder))
            {
                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));

               

                FileInfo fi = new FileInfo(item);
                projectfiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }
            richTextBox1.Text = System.IO.File.ReadAllText(projectFolder + "/index.html");
            currentfile = projectFolder + "/index.html";
            toolStripStatusLabel1.Text = "current file: " + currentfile;
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

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new settingsbox().ShowDialog();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            File.WriteAllText(currentfile, richTextBox1.Text);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string x = Interaction.InputBox("new html document", "name of file", "nothing", 10, 10);
                File.WriteAllText(projectFolder + "/" + x + ".html", " < !DOCTYPE html >\n < html >\n < head >\n </ head > \n </ html > ");
            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(projectFolder))
                {
                
                    imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));

             

                    FileInfo fi = new FileInfo(item);
                    projectfiles.Add(fi.FullName);
                    listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
                }
          
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(projectFolder))
            {

                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));

         

                FileInfo fi = new FileInfo(item);
                projectfiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int intselectedindex = listView1.SelectedIndices[0];
            if (MessageBox.Show("are you sure you want to close the current file and open a new file new file: " + listView1.Items[intselectedindex].Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                richTextBox1.Text = System.IO.File.ReadAllText(projectFolder + "/" + listView1.Items[intselectedindex].Text);
                currentfile = projectFolder + "/" +  listView1.Items[intselectedindex].Text;
                toolStripStatusLabel1.Text = "current file: " + currentfile;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
    }
}
