using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_web_Develop
{
    public partial class image_viewer : Form
    {
        string ip;
        public image_viewer(string imagepath)
        {
            InitializeComponent();
            ip = imagepath;
        }

        private void image_viewer_Load(object sender, EventArgs e)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(ip);
            Height = img.Height;
            Width = img.Width;
            pictureBox1.ImageLocation = ip;
            Text = this.Size.Width + "x" + this.Size.Height;
            timeBeginPeriod(timerAccuracy);
            
        }

        private void image_viewer_SizeChanged(object sender, EventArgs e)
        {
            Text = this.Size.Width + "x" + this.Size.Height;
        }
        // Pinvoke:
        private const int timerAccuracy = 1;
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        private static extern int timeBeginPeriod(int msec);
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        public static extern int timeEndPeriod(int msec);

        private void image_viewer_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void image_viewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            timeEndPeriod(timerAccuracy);
            
        }

        private void image_viewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            timeEndPeriod(timerAccuracy);
        }
    }

}
