using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.IO.Compression;

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
        Process server = new Process();

        public phpprojecteditor()
        {
            InitializeComponent();
        }
        private void setLabelText(ToolStripStatusLabel label, string text)
        {
            try
            {
                
                label.Text = text;
          
            }
            catch
            {

            }
            
        }
        private void Phpprojecteditor_Load(object sender, EventArgs e)
        {

            splitContainer2.Panel2.Hide();

            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(folderlocation))
            {
                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                smallicons.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                largeicons.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));

                

                FileInfo fi = new FileInfo(item);
                projectfiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
                

            }
            try
            {
                richTextBox1.Text = System.IO.File.ReadAllText(folderlocation + "/index.php");
                currentfile = folderlocation + "/index.php";
            }
            catch
            {

                currentfile = folderlocation + "               NO FILE                ";
                MessageBox.Show("index.php is missing index.php is required create a new index.php file");
            }
            
          

            toolStripStatusLabel1.Text = "current file: " + currentfile;
            //MessageBox.Show(Environment.CurrentDirectory + Properties.Settings.Default.libdirectory + Properties.Settings.Default.phpexe);
            server.StartInfo.FileName = Environment.CurrentDirectory + Properties.Settings.Default.libdirectory + Properties.Settings.Default.phpexe;
            server.StartInfo.Arguments = "-S localhost:8000 \"" + currentfile + "\"";
            server.StartInfo.RedirectStandardInput = true;
            server.StartInfo.RedirectStandardOutput = true;
            server.StartInfo.CreateNoWindow = true;
            server.StartInfo.UseShellExecute = false;

            server.OutputDataReceived += Cmd_OutputDataReceived;
        }
        private void Cmd_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            SetText(e.Data);

        }
        delegate void StringArgReturningVoidDelegate(string text);
        private void SetText(string text)
        { // InvokeRequired required compares the thread ID of the
          // calling thread to the thread ID of the creating thread.
          // If these threads are different, it returns true.

            if (text != null)
            {


               

            }
        }
   

        private void OpenInCmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Process.Start(Environment.CurrentDirectory +  Properties.Settings.Default.libdirectory + Properties.Settings.Default.phpexe);
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("php server \n localhost:8000");
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                server.Start();
                server.BeginOutputReadLine();
            }
            catch
            {
                MessageBox.Show("php is already running.");
            }
            serverstat.BackColor = Color.Lime;
            
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Hide();
            serverstat.BackColor = Color.Red;
            server.Kill();
            timer1.Stop();
        }

    

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
                server.StandardInput.Flush();
            }
        }

 

        private void ListView1_DoubleClick(object sender, EventArgs e)
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
                        richTextBox1.Enabled = false;
                     
                        image_viewer iv = new image_viewer(currentfile);
                        richTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;

                        iv.ShowDialog();

                    }
                    else if (fi.Extension == ".gif")
                    {
                        richTextBox1.Enabled = false;
                      
                        image_viewer iv = new image_viewer(currentfile);
                        richTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        iv.ShowDialog();

                    }
                    else if (fi.Extension == ".png")
                    {
                        richTextBox1.Enabled = false;
                       
                        image_viewer iv = new image_viewer(currentfile);
                        richTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        iv.ShowDialog();

                    }
                    else if (fi.Extension == ".jpg")
                    {
                        richTextBox1.Enabled = false;
                      
                        image_viewer iv = new image_viewer(currentfile);
                        richTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        iv.ShowDialog();

                    }
                    else if (fi.Extension == ".css")
                    {
                        richTextBox1.Language = FastColoredTextBoxNS.Language.Custom;
                      
                        richTextBox1.Enabled = true;
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        richTextBox1.Text = System.IO.File.ReadAllText(projectFolder + "/" + listView1.Items[intselectedindex].Text);
                    }
                    else if (fi.Extension == ".js")
                    {
                        richTextBox1.Language = FastColoredTextBoxNS.Language.JS;
                      
                        richTextBox1.Enabled = true;
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        richTextBox1.Text = System.IO.File.ReadAllText(projectFolder + "/" + listView1.Items[intselectedindex].Text);
                    }
                    else if (fi.Extension == ".ico")
                    {
                        richTextBox1.Enabled = false;
                      
                        image_viewer iv = new image_viewer(currentfile);
                        richTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        iv.ShowDialog();

                    }

                    else if (fi.Extension == ".html")
                    {
                        richTextBox1.Language = FastColoredTextBoxNS.Language.HTML;

                        richTextBox1.Enabled = true;

                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        richTextBox1.Text = System.IO.File.ReadAllText(projectFolder + "/" + listView1.Items[intselectedindex].Text);
                    }
                    else if (fi.Extension == ".php")
                    {
                        richTextBox1.Language = FastColoredTextBoxNS.Language.PHP;

                        richTextBox1.Enabled = true;

                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        richTextBox1.Text = System.IO.File.ReadAllText(projectFolder + "/" + listView1.Items[intselectedindex].Text);
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

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void PHPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("new PHP file", "name of file", "", 10, 10);
            File.WriteAllText(projectFolder + "/" + x + ".php", "");
            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(projectFolder))
            {

                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));



                FileInfo fi = new FileInfo(item);
                projectfiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }
        }

        private void HTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("new html document", "name of file", "", 10, 10);
            if (x == "")
            {
                File.WriteAllText(projectFolder + "/" + x + ".html", " < !DOCTYPE html >\n < html >\n < head >\n </ head > \n </ html > ");
            }
            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(projectFolder))
            {

                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));



                FileInfo fi = new FileInfo(item);
                projectfiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageList1.Images.Clear();
            smallicons.Images.Clear();
            largeicons.Images.Clear();

            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(folderlocation))
            {
                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                smallicons.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                largeicons.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));



                FileInfo fi = new FileInfo(item);
                projectfiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);


            }
         
        }

        private void OpenAPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int intselectedindex = listView1.SelectedIndices[0];
                textpreview tp = new textpreview(projectFolder + "/" + listView1.Items[intselectedindex].Text);
                tp.Show();
            }
            catch
            {

            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(currentfile, richTextBox1.Text);
        }

        private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {

                File.WriteAllText(currentfile, richTextBox1.Text);


            }
            else
            {

            }
        }

        private void DebugToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (serverstat.BackColor == Color.Red)
            {
                MessageBox.Show("server is not running goto PHP > server > start");
            }
            else
            {
                File.WriteAllText(currentfile, richTextBox1.Text);
                dialogs.debugwindow dw = new dialogs.debugwindow();
                dw.location = "localhost:8000";
                dw.ShowDialog();
            }
        }

        private void RichTextBox1_Load(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Properties.Settings.Default.Textboxcolor;
            richTextBox1.IndentBackColor = Properties.Settings.Default.textbosidebarcolor;
            richTextBox1.ForeColor = Properties.Settings.Default.textboxforecolor;
            richTextBox1.LineNumberColor = Properties.Settings.Default.textbosidebarforecolor;
        }

        private void OpenInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(projectFolder);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to delete this file", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    int intselectedindex = listView1.SelectedIndices[0];

                    File.Delete(projectFolder + "/" + listView1.Items[intselectedindex].Text);
                    listView1.Items.Clear();
                    foreach (string item in Directory.GetFiles(projectFolder))
                    {

                        imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));



                        FileInfo fi = new FileInfo(item);
                        projectfiles.Add(fi.FullName);
                        listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
                    }
                }
                catch
                {
                    MessageBox.Show("please select a file you want to delete");
                }
            }
        }

        private void PHPToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("new PHP file", "name of file", "", 10, 10);
            File.WriteAllText(projectFolder + "/" + x + ".php", "");
            imageList1.Images.Clear();
            smallicons.Images.Clear();
            largeicons.Images.Clear();

            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(folderlocation))
            {
                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                smallicons.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                largeicons.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));



                FileInfo fi = new FileInfo(item);
                projectfiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);


            }
        }

        private void HTMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("new html document", "name of file", "", 10, 10);
            if (x == "")
            {
                File.WriteAllText(projectFolder + "/" + x + ".html", " < !DOCTYPE html >\n < html >\n < head >\n </ head > \n </ html > ");
            }
            imageList1.Images.Clear();
            smallicons.Images.Clear();
            largeicons.Images.Clear();

            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(folderlocation))
            {
                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                smallicons.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                largeicons.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));



                FileInfo fi = new FileInfo(item);
                projectfiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);


            }
        }

        private void LargeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void SmallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void ListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void DetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void SaveAsTemplateFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CWD template file |*.CWDTF |ZIP File|*.zip|ALPHA FILE |*.AF";
            if(sfd.ShowDialog() == DialogResult.OK)
            {

                ZipFile.CreateFromDirectory(projectFolder, sfd.FileName);
            }
            else
            {
               
            }
        }

        private void OpenTemplateFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!!WARNING!!!! \n THIS WILL OVERWRITE ANY FILES IN THE DIRECTORY");
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ofd.Filter = "CWD template file |*.CWDTF | ZIP File|*.zip | ALPHA FILE |*.AF";
                    Directory.CreateDirectory(projectFolder + "/temp_zip");
                    ZipFile.ExtractToDirectory(ofd.FileName, projectFolder + "/temp_zip");
                    System.IO.DirectoryInfo di = new DirectoryInfo("YourPath");

                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        if (dir.Name == "temp_zip") { }
                        else
                        {

                            dir.Delete(true);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void RichTextBox1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Properties.Settings.Default.Textboxcolor;
            richTextBox1.IndentBackColor = Properties.Settings.Default.textbosidebarcolor;
            richTextBox1.ForeColor = Properties.Settings.Default.textboxforecolor;
            richTextBox1.LineNumberColor = Properties.Settings.Default.textbosidebarforecolor;
        }
    }
}
