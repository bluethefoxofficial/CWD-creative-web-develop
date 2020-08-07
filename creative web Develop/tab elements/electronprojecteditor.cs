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
using System.Diagnostics;

namespace creative_web_Develop.tab_elements
{
    public partial class electronprojecteditor : UserControl
    {
        private const MessageBoxButtons oK = MessageBoxButtons.OK;
        public string projectFolder;
        public string currentfile;
        Process p = new Process();

        public electronprojecteditor()
        {
            InitializeComponent();

        }

        private void electronprojecteditor_Load(object sender, EventArgs e)
        {
        

            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(projectFolder))
            {
                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                smallicons.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                largeicons.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));



                FileInfo fi = new FileInfo(item);
              //  projectfiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);


            }
            try
            {
                fastColoredTextBox1.Text = System.IO.File.ReadAllText(projectFolder + "/index.js");
                currentfile = projectFolder + "/index.js";
            }
            catch
            {

                currentfile = projectFolder + "               NO FILE                ";
                MessageBox.Show("index.js is missing");
            }
            toolStripStatusLabel1.Text = currentfile;


            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.WorkingDirectory = projectFolder;
            p.OutputDataReceived += Cmd_OutputDataReceived;
            p.Start();
            p.BeginOutputReadLine();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {
            fastColoredTextBox1.BackColor = Properties.Settings.Default.Textboxcolor;
            fastColoredTextBox1.IndentBackColor = Properties.Settings.Default.textbosidebarcolor;
            fastColoredTextBox1.ForeColor = Properties.Settings.Default.textboxforecolor;
            fastColoredTextBox1.LineNumberColor = Properties.Settings.Default.textbosidebarforecolor;
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
   
        private void startDebigToolStripMenuItem_Click(object sender, EventArgs e)
        {

            p.StandardInput.WriteLine(@"cd "  +  projectFolder +  "\\");
            p.StandardInput.WriteLine(@"npm test");
            p.StandardInput.Flush();
            
        }
        private void Cmd_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            SetText(e.Data);
        }
        delegate void StringArgReturningVoidDelegate(string text);
        private void SetText(string text)
        { 

            if (text != null)
            {


                if (listBox1.InvokeRequired)
                {
                    StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    listBox1.Items.Add(text);
                    listBox1.TopIndex = listBox1.Items.Count - 1;

                }

            }
        }
        private void cxFlatTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (cxFlatTextBox1.Text.StartsWith("exit"))
                {
                    MessageBox.Show("No");
                    return;
                }
                p.StandardInput.WriteLine(cxFlatTextBox1.Text);
                cxFlatTextBox1.Text = "";
                if (cxFlatTextBox1.Text.StartsWith("clear")) { 

                    
                    listBox1.Items.Clear();
                    return;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
                

            }
        }

        private void cxFlatTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int intselectedindex = listView1.SelectedIndices[0];
                if (MessageBox.Show("are you sure you want to close the current file and open a new file new file: " + listView1.Items[intselectedindex].Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    currentfile = projectFolder + "/" + listView1.Items[intselectedindex].Text;
                    FileInfo fi = new FileInfo(currentfile);
                    if (fi.Extension == ".jpg")
                    {
                        fastColoredTextBox1.Enabled = false;
                        debugToolStripMenuItem.Enabled = false;
                        image_viewer iv = new image_viewer(currentfile);
                        fastColoredTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;

                        iv.ShowDialog();

                    }
                    else if (fi.Extension == ".gif")
                    {
                        fastColoredTextBox1.Enabled = false;
                        debugToolStripMenuItem.Enabled = false;
                        image_viewer iv = new image_viewer(currentfile);
                        fastColoredTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        iv.ShowDialog();

                    }
                    else if (fi.Extension == ".png")
                    {
                        fastColoredTextBox1.Enabled = false;
                        debugToolStripMenuItem.Enabled = false;
                        image_viewer iv = new image_viewer(currentfile);
                        fastColoredTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        iv.ShowDialog();

                    }
                    else if (fi.Extension == ".jpg")
                    {
                        fastColoredTextBox1.Enabled = false;
                        debugToolStripMenuItem.Enabled = false;
                        image_viewer iv = new image_viewer(currentfile);
                        fastColoredTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        iv.ShowDialog();

                    }
                    else if (fi.Extension == ".css")
                    {
                        fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom;
                        debugToolStripMenuItem.Enabled = false;
                        fastColoredTextBox1.Enabled = true;
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        fastColoredTextBox1.Text = System.IO.File.ReadAllText(projectFolder + "/" + listView1.Items[intselectedindex].Text);
                    }
                    else if (fi.Extension == ".js")
                    {
                        fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS;
                        debugToolStripMenuItem.Enabled = false;
                        fastColoredTextBox1.Enabled = true;
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        fastColoredTextBox1.Text = System.IO.File.ReadAllText(projectFolder + "/" + listView1.Items[intselectedindex].Text);
                    }
                    else if (fi.Extension == ".ico")
                    {
                        fastColoredTextBox1.Enabled = false;
                        debugToolStripMenuItem.Enabled = false;
                        image_viewer iv = new image_viewer(currentfile);
                        fastColoredTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        iv.ShowDialog();

                    }

                    else if (fi.Extension == ".html")
                    {
                        fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
                        debugToolStripMenuItem.Enabled = true;
                        fastColoredTextBox1.Enabled = true;

                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        fastColoredTextBox1.Text = System.IO.File.ReadAllText(projectFolder + "/" + listView1.Items[intselectedindex].Text);
                    }
                    else if (fi.Extension == ".json")
                    {
                        fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom;
                        debugToolStripMenuItem.Enabled = true;
                        fastColoredTextBox1.Enabled = true;

                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        fastColoredTextBox1.Text = System.IO.File.ReadAllText(projectFolder + "/" + listView1.Items[intselectedindex].Text);
                    }
                    else
                    {
                        MessageBox.Show("sorry cant open that type of file");
                    }
                }
            }
            catch
            {
                MessageBox.Show("please select a file");
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(currentfile, cxFlatTextBox1.Text);
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.StandardInput.WriteLine(@"npm compilewin");
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.StandardInput.WriteLine(@"npm compile");
        }

        private void macToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.StandardInput.WriteLine(@"npm compilemac");
        }

        private void linuxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.StandardInput.WriteLine(@"npm compilelinux");
        }
    }
}
