﻿using CommunityToolkit.Mvvm.Messaging;
using HappySLMS.Wpf.Messages;
using HappySLMS.Wpf.Utility;
using HappySLMS.Wpf.ViewModels;
using HappySLMS.Wpf.Views.Pages;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace HappySLMS.Wpf.Views
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : HandyControl.Controls.Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.Services.GetRequiredService<MainWindowViewModel>();
            this.KeyDown += (s, e) => WeakReferenceMessenger.Default.Send(new KeyDownMessage(e));


           
        }
    }
}
