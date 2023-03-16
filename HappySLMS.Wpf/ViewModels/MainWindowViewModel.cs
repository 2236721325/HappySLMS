using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HappySLMS.Wpf.Models;
using HappySLMS.Wpf.Views.Pages;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Windows.Controls;

namespace HappySLMS.Wpf.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {

        [ObservableProperty]
        List<NavigationMenuItem> navItems;

        [ObservableProperty]
        NavigationMenuItem selectedItem;


        [RelayCommand]
        void SelectionChanged(Frame frame)
        {
            var page=App.Services.GetRequiredService(selectedItem.PageType);
            frame.Navigate(page);
        }

        public MainWindowViewModel()
        {
            InitData();
        }

        void InitData()
        {
            navItems = new List<NavigationMenuItem>
            {
                new NavigationMenuItem("仪表盘", typeof(Dashboard), "Dashboard"),
                new NavigationMenuItem("用户管理", typeof(UserManagement), "UserManagement"),
                new NavigationMenuItem("实时监控", typeof(MonitorPage), "Monitor"),
                new NavigationMenuItem("设备管理", typeof(EquipmentManagement), "EquipmentManagement"),
                new NavigationMenuItem("报表导出", typeof(DataExport), "DataExport"),
                new NavigationMenuItem("系统日志", typeof(LogPage), "Log"),
                new NavigationMenuItem("系统设置", typeof(Settings), "Settings")
            };

            SelectedItem = navItems[index: 0];


        }

    }

}
