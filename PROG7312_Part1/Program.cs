using System;
using System.Windows.Forms;

namespace PROG7312_Part1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CallNumbersForm());
        }
    }
}
//---------------------------------------------EndOfFile---------------------------------------------//