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
            //Must be instantiated after we set compatible text rendering default
            documentForm = new Ocular.Document.frmDocument();
            Application.Run(mainForm = new frmMain());
        }

        //So we can access contents from other classes without having to instantiate new objects everytime
        public static frmMain mainForm;
        public static Ocular.Document.frmDocument documentForm;
    }
}
