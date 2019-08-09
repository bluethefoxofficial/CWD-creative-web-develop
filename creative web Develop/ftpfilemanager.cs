using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_web_Develop
{
    public partial class ftpfilemanager : Form
    {
        public ftpfilemanager()
        {
            InitializeComponent();
        }
        private void ftpFileRead(string dir = null)
        {
            FtpWebRequest Request = (FtpWebRequest)WebRequest.Create("ftp://"+ Properties.Settings.Default.host + "/" + dir);
            Request.Method = WebRequestMethods.Ftp.ListDirectory;
            Request.Credentials = new NetworkCredential(Properties.Settings.Default.username, Properties.Settings.Default.password);
            FtpWebResponse Response = (FtpWebResponse)Request.GetResponse();
            Stream ResponseStream = Response.GetResponseStream();
            StreamReader Reader = new StreamReader(ResponseStream);

            while (!Reader.EndOfStream)//Read file name   
            {
                ListBox1.Items.Add(Reader.ReadLine().ToString());
            }
            Response.Close();
            ResponseStream.Close();
            Reader.Close();
        }
        private void Ftpfilemanager_Load(object sender, EventArgs e)
        {
            ftpFileRead();
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string si = ListBox1.SelectedItem.ToString();
                ListBox1.Items.Clear();
                ftpFileRead(si);
            }
            catch
            {

            }
        }
    }
}
