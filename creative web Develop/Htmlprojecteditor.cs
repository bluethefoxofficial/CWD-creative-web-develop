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
        List<string> projectfiles = new List<string>();
            public Htmlprojecteditor()
        {
            InitializeComponent();
        }

        private void Htmlprojecteditor_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(string item in Directory.GetFiles(Properties.Settings.Default.folder))
            {
                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));

                listView1.Items.Clear();

                    FileInfo fi = new FileInfo(item);
                    projectfiles.Add(fi.FullName);
                    listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);   
            }
            richTextBox1.Text = System.IO.File.ReadAllText(Properties.Settings.Default.folder + "");
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
    }
}
