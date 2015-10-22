using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerPartient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            //AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);
            Application.Run(new FormBanner());
        }

        private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            
            Console.WriteLine("Close 1");
            Application.ExitThread();
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            Console.WriteLine("Close 2");
            Application.Exit();
        }
    }
}
