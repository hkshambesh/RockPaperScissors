using System;
using System.Windows.Forms;
using Ninject;
using Rps.Infrastructure.IoC;

namespace Rps.Ui
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(DependencyResolver.Kernel.Get<MainMenu>());
        }
    }
}