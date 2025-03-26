using CarRentWinForms;
using System;
using System.Windows.Forms;

namespace CarRent
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enables visual styles for the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += (sender, e) => MessageBox.Show(e.Exception.Message);


            // Starts the application with the LoginForm
            Application.Run(new LoginForm());
        }
    }
}
