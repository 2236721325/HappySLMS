using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace handynnde
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        ServiceProvider serviceProvider { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            this.InitializeComponent();
            var service = new ServiceCollection();

            ConfigurationService(service);

            serviceProvider = service.BuildServiceProvider();

            var mainView = serviceProvider.GetRequiredService<MainWindow>();
            mainView.Show();

            base.OnStartup(e);
        }

        private void ConfigurationService(ServiceCollection service)
        {
            //注入
            service.AddTransient(typeof(MainWindow));
        }

    }
}
