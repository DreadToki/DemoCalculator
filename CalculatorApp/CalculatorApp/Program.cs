using CalculatorApp.Presenter;
using CalculatorApp.Views;
using System;
using System.Windows.Forms;

namespace CalculatorApp
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
            var view = new MainForm();
            new Calculator(view, new Models.Buffer());
            Application.Run(view);
        }
    }
}
