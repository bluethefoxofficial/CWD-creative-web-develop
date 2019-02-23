using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_web_Develop
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
       
            if (Properties.Settings.Default.splashscreen == true)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new homeeditor());
            }
           
        }
    }
}
