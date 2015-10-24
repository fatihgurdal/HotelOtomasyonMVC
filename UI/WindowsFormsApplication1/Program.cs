using System;
using System.Windows.Forms;
using ProjectTemplate.Application.Bootstrappers;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Dependency' ler Register ediliyor
            Bootstrapper.Instance
           .Bootstrap(new DependencyBootstrapper());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
