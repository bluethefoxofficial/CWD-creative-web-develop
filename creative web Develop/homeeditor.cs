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
                imageList2.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                FileInfo fi = new FileInfo(item);
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
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                using (StreamWriter file = File.CreateText(@"D:\path.txt"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, _data);
                }
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
