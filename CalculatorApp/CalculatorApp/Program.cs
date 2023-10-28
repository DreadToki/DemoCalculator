using CalculatorApp.Models;
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
        static int Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var model = new CalculatorModel();
            var view = new MainForm();
            var presenter = new CalculatorPresenter(view, model);
            Application.Run(view);

            return 0;
        }
    }
}
