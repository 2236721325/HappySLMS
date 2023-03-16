using CommunityToolkit.Mvvm.Input;
using HappySLMS.Wpf.Views;
using Microsoft.Extensions.DependencyInjection;

namespace HappySLMS.Wpf.ViewModels
{
    public partial class LoginWindowViewModel : ViewModelBase
    {


        [RelayCommand]
        void Login()
        {

            var lastWindow = App.Current.MainWindow;
            var nextWindow=App.Services.GetRequiredService<MainWindow>();
            nextWindow.Show();
            lastWindow.Close();
            App.Current.MainWindow = nextWindow;

            
            
        }
    
    }

}
