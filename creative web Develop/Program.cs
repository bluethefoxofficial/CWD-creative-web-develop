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
        public static void Main()
        {
            try
            {
                string[] passedargs = Environment.GetCommandLineArgs();

                if (passedargs.Contains("/a") || passedargs.Contains("/A")) { Console.WriteLine("[CWD] Activated."); Properties.Settings.Default.licenced = true; Properties.Settings.Default.Save(); }
                Application.EnableVisualStyles();
                try
                {
                    Application.SetCompatibleTextRenderingDefault(false);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Application.Exit();
                }

                Application.Run(new Form1());

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } 
     }
    }

