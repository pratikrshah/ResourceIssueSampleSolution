using FIBRE_Reporting.ViewModels;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FIBRE_Reporting
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
 	        base.OnStartup(e);

            //Step 1 - One Time - Creating an instance of the container
            UnityContainer unity = new UnityContainer();

            //Step 2 - REgistering your MainWindowViewModel
            unity.RegisterType<MainWindowViewModel, MainWindowViewModel>();

            //Step 3 - Creating an Instance of the MainWindowViewModel
            MainWindowViewModel mwvm = unity.Resolve<MainWindowViewModel>();

            MainWindow mw = new MainWindow { DataContext = mwvm };

            mw.Show();
        }
    }
}
