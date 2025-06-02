using System;
using System.Windows.Forms;

namespace WebScrapper
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

            // Admin mode
            Application.Run(new MainForm(true));

            // User mode
            //Application.Run(new MainForm());
        }
    }
}
