using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ocular
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (global::Ocular.Properties.Settings.Default.DontShowStartupWindow)
            {
                Application.Run(new Working());
            }
            else
            {
                Application.Run(new Startup());
            }
        }
    }
}
