using HandyControl.Tools.Extension;
using HappySLMS.Wpf.ViewModels;
using HappySLMS.Wpf.ViewModels.Pages;
using HappySLMS.Wpf.Views;
using HappySLMS.Wpf.Views.Pages;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace HappySLMS.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider ConfigureService()
        {
            var service = new ServiceCollection();


            service.AddTransient<MainWindow>();
            service.AddTransient<MainWindowViewModel>();

            service.AddTransient<LoginWindow>();
            service.AddTransient<LoginWindowViewModel>();



            service.AddTransient<Dashboard>();
            service.AddTransient<DashboardViewModel>();

            service.AddTransient<DataExport>();
            service.AddTransient<EquipmentManagement>();
            service.AddTransient<LogPage>();
            service.AddTransient<LogPageViewModel>();

            service.AddTransient<MonitorPage>();
            service.AddTransient<Settings>();
            service.AddTransient<UserManagement>();


            return service.BuildServiceProvider();

        }


        public static IServiceProvider Services;


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Services = ConfigureService();
            //MainWindow = Services.GetRequiredService<LoginWindow>();
            //MainWindow.Show();
            MainWindow = Services.GetRequiredService<LoginWindow>();

            MainWindow.Show();
        }
       
    }
}
