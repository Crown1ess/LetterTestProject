using Letters.ViewModels;
using Letters.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Letters
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainWindow mainWindow;
        private MainWindowViewModel mainWindowViewModel;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            mainWindowViewModel = new MainWindowViewModel();
            mainWindow = new MainWindow()
            {
                DataContext = mainWindowViewModel
            };
            mainWindow.Show();
        }
    }
}
