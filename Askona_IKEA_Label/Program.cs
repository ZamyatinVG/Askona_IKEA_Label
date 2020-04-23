using System;
using System.Windows.Forms;
using System.Threading;

namespace Askona_IKEA_Label
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _ = new Mutex(true, "Askona IKEA Label", out bool tryCreateNewApp);
            if (tryCreateNewApp)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
                return;
            }
        }
    }
}