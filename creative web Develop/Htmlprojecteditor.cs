using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using CefSharp;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using CefSharp.WinForms;

namespace creative_web_Develop
{
    public partial class Htmlprojecteditor : UserControl
    {
        private const MessageBoxButtons oK = MessageBoxButtons.OK;
        public string projectFolder;
        public string currentfile;
        public ChromiumWebBrowser chromeBrowser;
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
            richTextBox1.AutoCompleteBrackets = true;
           
        
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("about:blank");
            splitContainer2.Panel2.Controls.Add(chromeBrowser);
            chromeBrowser.Show();
            listView1.Items.Clear();
            //dark theme
            if (Properties.Settings.Default.darktheme == true)
            {
                BackColor = Color.Black;
                groupBox1.BackColor = Color.Black;
                groupBox1.ForeColor = Color.White;
                richTextBox1.BackColor = Color.Black;
                richTextBox1.ForeColor = Color.White;
                menuStrip1.BackColor = Color.LightSlateGray;
                menuStrip1.ForeColor = Color.White;
                chromeBrowser.BackColor = Color.Black;
                chromeBrowser.ForeColor = Color.Black; 
                listView1.BackColor = Color.Black;
                listView1.ForeColor = Color.White;
                splitContainer1.BackColor = Color.Black;
                splitContainer2.BackColor = Color.Black;

            }
            //loads project files in the project explorer
            try
            {
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
            catch
            {
                MessageBox.Show("ERROR", "no project detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
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

            string x = Interaction.InputBox("new html document", "name of file", "", 10, 10);
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
                        debugToolStripMenuItem.Enabled = false;
                        image_viewer iv = new image_viewer(currentfile);
                        richTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;

                        iv.ShowDialog();

                    }
                    else if (fi.Extension == ".gif")
                    {
                        richTextBox1.Enabled = false;
                        debugToolStripMenuItem.Enabled = false;
                        image_viewer iv = new image_viewer(currentfile);
                        richTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        iv.ShowDialog();

                    }
                    else if (fi.Extension == ".png")
                    {
                        richTextBox1.Enabled = false;
                        debugToolStripMenuItem.Enabled = false;
                        image_viewer iv = new image_viewer(currentfile);
                        richTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        iv.ShowDialog();

                    }
                    else if (fi.Extension == ".jpg")
                    {
                        richTextBox1.Enabled = false;
                        debugToolStripMenuItem.Enabled = false;
                        image_viewer iv = new image_viewer(currentfile);
                        richTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        iv.ShowDialog();

                    }
                    else if (fi.Extension == ".css")
                    {
                        richTextBox1.Language = FastColoredTextBoxNS.Language.Custom;
                        debugToolStripMenuItem.Enabled = false;
                        richTextBox1.Enabled = true;
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        richTextBox1.Text = System.IO.File.ReadAllText(projectFolder + "/" + listView1.Items[intselectedindex].Text);
                    }
                    else if (fi.Extension == ".js")
                    {
                        richTextBox1.Language = FastColoredTextBoxNS.Language.JS;
                        debugToolStripMenuItem.Enabled = false;
                        richTextBox1.Enabled = true;
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        richTextBox1.Text = System.IO.File.ReadAllText(projectFolder + "/" + listView1.Items[intselectedindex].Text);
                    }

                    else if(fi.Extension == ".html")
                    {
                        richTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
                        debugToolStripMenuItem.Enabled = true;
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

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(currentfile, richTextBox1.Text);
            chromeBrowser.ShowDevTools();
            chromeBrowser.Load(currentfile);
        }

        private void startWithoutDevToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(currentfile, richTextBox1.Text);
            chromeBrowser.Load(currentfile);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
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
      

        private void richTextBox1_Load(object sender, EventArgs e)
        {
           
        }
        
        private void documentmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (documentMap1.Visible == false)
            {
                documentMap1.Visible = true;
            }
            else
            {
                documentMap1.Visible = false;
            }
        }

        private void htmlToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<html>\n\n</html>";
            
        }

        private void headToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "  <head>\n \n </head>";
        }

        private void bodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "  <body>\n    \n</body>";
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<p></p>";
        }

        private void imgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<img src=''></img>";
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<form>\n\n</form>";
        }

        private void brToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<br/>";
        }

        private void scriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<script>\n\n</script>";
        }

        private void divToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<div>\n</div>";
        }

        private void startWithinBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(currentfile, richTextBox1.Text);
            System.Diagnostics.Process.Start(currentfile);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("new css file", "name of file", "", 10, 10);
            File.WriteAllText(projectFolder + "/" + x + ".css", "");
            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(projectFolder))
            {

                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));



                FileInfo fi = new FileInfo(item);
                projectfiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }
        }

        private void jsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("new javascript file", "name of file", "", 10, 10);
            File.WriteAllText(projectFolder + "/" + x + ".js", "");
            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(projectFolder))
            {

                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));



                FileInfo fi = new FileInfo(item);
                projectfiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
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
        }

        private void documentMap1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Control && e.KeyCode == Keys.S)
            {
                File.WriteAllText(currentfile, richTextBox1.Text);
            }
            else
            {
                
            }
            
        }

        private void insertCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bootstrap4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>\n<script src='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js' integrity='sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM' crossorigin='anonymous'></script>";
        }

        private void w3cssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += " <link rel='stylesheet' href='https://www.w3schools.com/w3css/4/w3.css'> ";
        }

        private void jqueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<script src='https://code.jquery.com/jquery-3.3.1.slim.min.js' integrity='sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo' crossorigin='anonymous'></script>";
        }

        private void popperjsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<script src='https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js' integrity='sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1' crossorigin='anonymous'></script>";
        }

        private void submitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<input type='submit' name='' value=''/>";

        }

        private void textareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<textarea name=''></textarea>";
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<input type='email' name='' value=''/>";
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<input type='password' name='' value=''/>";
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<input type='text' name='' value=''/>";
        }

        private void buttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += "<button class=''>Button</button>";
        }

        private void RefreshToolStripMenuItem1_Click(object sender, EventArgs e)
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
    }
}
