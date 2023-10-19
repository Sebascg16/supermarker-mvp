using Supermarket__mvp._Repositories;
using Supermarket__mvp.Models;
using Supermarket__mvp.Presenters;
using Supermarket__mvp.Properties;
using Supermarket__mvp.Views;

namespace Supermarket__mvp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}