
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_web_Develop
{
    public partial class homeeditor : Form
    {
        List<string> listFiles = new List<string>();
        public homeeditor()
        {
            InitializeComponent();
        }
        public void DisplayFolder(string folderPath) //irrelevent
        {
            string[] files = System.IO.Directory.GetFiles(folderPath);

            for (int x = 0; x < files.Length; x++)
            {
                listView1.Items.Add(files[x]);
            }
        }
        private void homeeditor_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.darktheme == true)
            {
                BackColor = Color.Black;
                ForeColor = Color.White;
                tabPage1.BackColor = Color.Black;
                listView1.BackColor = Color.DarkGray;
                listView1.ForeColor = Color.White;
                listView2.BackColor = Color.DarkGray;
                listView2.ForeColor = Color.White;
                menuStrip1.BackColor = Color.Black;
                menuStrip1.ForeColor = Color.White;
                groupBox1.ForeColor = Color.White;
                groupBox2.ForeColor = Color.White;

            }
            groupBox1.Hide();
            groupBox2.Hide();
            if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents/" + "/creative web projects/"))
            {
                System.Diagnostics.Debug.WriteLine("directory exist "+ Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents/" + "/creative web projects/");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("directory does not exist " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents/" + "/creative web projects/");
                DirectoryInfo di = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents/" + "/creative web projects/");
               

            }
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox1.Show();

            listView1.Items.Clear();
            foreach (string item in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents/" + "/creative web projects/"))
            {
    
                FileInfo fi = new FileInfo(item);
                imageList2.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                listFiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList2.Images.Count - 1);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new settingsbox().ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int intselectedindex = listView1.SelectedIndices[0];
           // listView2.Items[intselectedindex].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
             
                int intselectedindex = listView2.SelectedIndices[0];
                System.IO.File.WriteAllText(Environment.GetFolderPath( Environment.SpecialFolder.UserProfile) + "/Documents" + "/creative web projects/" + textBox1.Text, "{'folder':'" + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents/" + "/creative web projects/" + textBox1.Text + "_files" + "','type':'" + listView2.Items[intselectedindex].Text + "'}");
                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents" + "/creative web projects/" + textBox1.Text + "_files");
                TabPage tp = new TabPage();
                Htmlprojecteditor hpe = new Htmlprojecteditor(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Documents" + "/creative web projects/" + textBox1.Text);
                tp.Controls.Add(hpe);
                hpe.Dock = DockStyle.Fill;
                tabControl1.TabPages.Add(tp);
            }
            else
            {
                MessageBox.Show("Please give your project a name.");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new about().ShowDialog();
        }
    }
}
