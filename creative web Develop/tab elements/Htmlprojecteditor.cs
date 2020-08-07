using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using CefSharp;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using CefSharp.WinForms;
using System.Net;
using System.IO.Compression;

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
            if (Properties.Settings.Default.highdpi == true)
            {
                Cef.EnableHighDPISupport();
            }
            else
            {

            }
        }
        private void ftpFileRead(string dir = null)
        {
            try
            {
                textBox1.Text = dir;
                listBox1.Items.Add("..");
                FtpWebRequest Request = (FtpWebRequest)WebRequest.Create("ftp://" + Properties.Settings.Default.host + "/" + dir);
                Request.Method = WebRequestMethods.Ftp.ListDirectory;
                Request.Credentials = new NetworkCredential(Properties.Settings.Default.username, Properties.Settings.Default.password);
                FtpWebResponse Response = (FtpWebResponse)Request.GetResponse();
                Stream ResponseStream = Response.GetResponseStream();
                StreamReader Reader = new StreamReader(ResponseStream);

                while (!Reader.EndOfStream)//Read file name   
                {
                    if (Reader.ReadLine() == "..")
                    {
                    }
                    else if (Reader.ReadLine() == ".")
                    {
                    }
                    else
                    {

                        listBox1.Items.Add(Reader.ReadLine().ToString());

                    }
                }
                Response.Close();
                ResponseStream.Close();
                Reader.Close();
            }
            catch
            {

            }
        }
        private void Htmlprojecteditor_Load(object sender, EventArgs e)
        {
            try
            {
                ftpFileRead();
            }
            catch
            {
                splitContainer3.Panel2.Hide();
            }



            richTextBox1.CaretColor = Color.Black;

            richTextBox1.AutoCompleteBrackets = true;
           
        
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("about:blank");
            splitContainer2.Panel2.Controls.Add(chromeBrowser);
            chromeBrowser.Show();
            listView1.Items.Clear();
       
            //loads project files in the project explorer
            try
            {
                listView1.Items.Clear();
                foreach (string item in Directory.GetFiles(projectFolder))
                {
                    imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                   smallicons.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                   largeicons.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));



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
    

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new settingsbox().ShowDialog();
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            File.WriteAllText(currentfile, richTextBox1.Text);
        }

        private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string x = Interaction.InputBox("new html document", "name of file", "", 10, 10);
            if (x == "")
            { }
            else { 
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
                    else if (fi.Extension == ".ico")
                    {
                        richTextBox1.Enabled = false;
                        debugToolStripMenuItem.Enabled = false;
                        image_viewer iv = new image_viewer(currentfile);
                        richTextBox1.Text = "please select a new file to open";
                        toolStripStatusLabel1.Text = "current file: " + currentfile;
                        iv.ShowDialog();

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
            if (Properties.Settings.Default.licenced == false)
            {
                MessageBox.Show("This feature is only usable by activated users.");
            }
            else
            {
                File.WriteAllText(currentfile, richTextBox1.Text);
                System.Diagnostics.Process.Start(currentfile);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("new css file", "name of file", "", 10, 10);
            if (x == "")
            { }
            else
            {
                File.WriteAllText(projectFolder + "/" + x + ".css", "");
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

        private void jsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("new javascript file", "name of file", "", 10, 10);
            if (x == "")
            { }
            else
            {
                File.WriteAllText(projectFolder + "/" + x + ".js", "");
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

        private void SplitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        progress_dialog uploadd = new progress_dialog();
 
        private void Button1_Click_1(object sender, EventArgs e)
        {
            progress_dialog pd = new progress_dialog();
            pd.Show();
            pd.Title = "Uploading files to selected directory of a FTP server";
            var ftp = new ftpserver(Properties.Settings.Default.username, Properties.Settings.Default.password, Properties.Settings.Default.host + "/" + listBox1.SelectedItem + "//", projectFolder, "//" + listBox1.SelectedItem + "//");
            ftp.UploadDirectory();

            
            pd.Close();

        }

       

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string si = listBox1.SelectedItem.ToString();
                listBox1.Items.Clear();
                ftpFileRead(si);
                
            }
            catch
            {

            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Clear();
                ftpFileRead(textBox1.Text);
            }
        }


        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void Copy(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)));

            foreach (var directory in Directory.GetDirectories(sourceDir))
                Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
        }
        private void ExportAsATemplateFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CWD template file |*.CWDTF |ZIP File|*.zip|ALPHA FILE |*.AF";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                ZipFile.CreateFromDirectory(projectFolder, sfd.FileName);
            }
            else
            {

            }
        }

        private void OpenInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(projectFolder);
        }

     

        private void Htmlprojecteditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.S)
            {
                Savingl.Visible = true;
                File.WriteAllText(currentfile, richTextBox1.Text);
                Savingl.Visible = false;
                
            }
        }

        private void MenuStrip1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.S)
            {
             
                File.WriteAllText(currentfile, richTextBox1.Text);
            

            }
        }

        private void DocumentMap1_MouseDown(object sender, MouseEventArgs e)
        {
         
        }

        private void DocumentMap1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.S)
            {
        
                File.WriteAllText(currentfile, richTextBox1.Text);
      

            }
        }

        private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.S)
            {
           
                File.WriteAllText(currentfile, richTextBox1.Text);
  

            }
        }

        private void RichTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
  
        }

        private void RichTextBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {

                File.WriteAllText(currentfile, richTextBox1.Text);


            }
            else
            {
               
            }
        }

        private void RichTextBox1_Load_1(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Properties.Settings.Default.Textboxcolor;
            richTextBox1.IndentBackColor = Properties.Settings.Default.textbosidebarcolor;
            richTextBox1.ForeColor = Properties.Settings.Default.textboxforecolor;
            richTextBox1.LineNumberColor = Properties.Settings.Default.textbosidebarforecolor;
            documentMap1.BackColor = Properties.Settings.Default.documentmapbackground;
            documentMap1.ForeColor = Properties.Settings.Default.documentmapfore;
        }

        private void ContextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void RefreshToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ftpFileRead(textBox1.Text);
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

        private void ListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void SmallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void LargeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void TileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formgen fg = new formgen();
            fg.ShowDialog();
            if(fg.generatedcode == "")
            {
                MessageBox.Show("No output");
            }
            else
            {
                richTextBox1.SelectedText += fg.generatedcode;
            }
        }

        private void RichTextBox1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Properties.Settings.Default.Textboxcolor;
            richTextBox1.IndentBackColor = Properties.Settings.Default.textbosidebarcolor;
            richTextBox1.ForeColor = Properties.Settings.Default.textboxforecolor;
            richTextBox1.LineNumberColor = Properties.Settings.Default.textbosidebarforecolor;
            documentMap1.BackColor = Properties.Settings.Default.documentmapbackground;
            documentMap1.ForeColor = Properties.Settings.Default.documentmapfore;
        }

        private void InsertCodeToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.licenced == false)
            {
                MessageBox.Show("This feature is only usable by activated users.");
                insertCodeToolStripMenuItem.HideDropDown();
                insertCodeToolStripMenuItem.Visible = false;
                htmlToolStripMenuItem.HideDropDown();
            }
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
