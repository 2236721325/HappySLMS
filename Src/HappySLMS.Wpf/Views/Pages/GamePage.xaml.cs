using HappySLMS.Wpf.ViewModels;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HappySLMS.Wpf.Views.Pages
{
    /// <summary>
    /// GamePage.xaml 的交互逻辑
    /// </summary>
    public partial class GamePage : Page
    {
        public GamePage()
        {
            InitializeComponent();
            DataContext = App.Services.GetRequiredService<GamePageViewModel>();
            //this.Loaded += (s, e) =>
            //{
            //    DoubleAnimation label1Animation = new DoubleAnimation
            //    {
            //        From = -50,
            //        To = 200,
            //        Duration = new Duration(System.TimeSpan.FromSeconds(2))
            //    };
            //    DoubleAnimation label2Animation = new DoubleAnimation
            //    {
            //        From = -50,
            //        To = 200,
            //        Duration = new Duration(System.TimeSpan.FromSeconds(2))
            //    };
            //    DoubleAnimation label3Animation = new DoubleAnimation
            //    {
            //        From = -50,
            //        To = 200,
            //        Duration = new Duration(System.TimeSpan.FromSeconds(2))
            //    };

            //    Storyboard.SetTarget(label1Animation, label1);
            //    Storyboard.SetTargetProperty(label1Animation, new PropertyPath(Canvas.TopProperty));

            //    Storyboard.SetTarget(label2Animation, label2);
            //    Storyboard.SetTargetProperty(label2Animation, new PropertyPath(Canvas.TopProperty));

            //    Storyboard.SetTarget(label3Animation, label3);
            //    Storyboard.SetTargetProperty(label3Animation, new PropertyPath(Canvas.TopProperty));

            //    Storyboard storyboard = new Storyboard();
            //    storyboard.Children.Add(label1Animation);
            //    storyboard.Children.Add(label2Animation);
            //    storyboard.Children.Add(label3Animation);
            //    storyboard.Begin(this);
            //};
        }
    }
}
