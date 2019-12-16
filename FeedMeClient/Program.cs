using System;
using System.Windows.Forms;

namespace FeedMeClient
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Forms.MainMenu());
            Application.Run(new Forms.Authentication.LoginForm());
        }
    }
}
