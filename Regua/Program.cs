using System;
using System.Windows.Forms;

namespace Regua
{
    internal static class Program
    {
        static Regua f = new Regua();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            f.TopMost = true;
            f.Show();
            f.FormBorderStyle = FormBorderStyle.None;
            Application.Run(f);
        }
    }
}
