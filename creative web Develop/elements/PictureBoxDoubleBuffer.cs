using System.Windows.Forms;

namespace creative_web_Develop
{
    public class PictureBoxDoubleBuffer : PictureBox
    {
        public bool DoubleBuffered
        {
            get { return base.DoubleBuffered; }
            set { base.DoubleBuffered = value; }
        }



        public PictureBoxDoubleBuffer()
        {
            base.DoubleBuffered = true;
        }
    }
}