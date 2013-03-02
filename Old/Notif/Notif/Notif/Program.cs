using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Notif
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
            Application.Run(new Notification("Hard disk warning", "Sorry, Ocular cannot run because there is no space on your hard disk! Please free at least 50MB of space."));
        }
    }
}
