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

            if (Properties.Settings.Default.onethree == true)
            {

                //no
                Application.Exit();
                //no
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
