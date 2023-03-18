using CommunityToolkit.Mvvm.ComponentModel;
using HappySLMS.Wpf.Models;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySLMS.Wpf.ViewModels.Pages
{
    public partial class DashboardViewModel : ViewModelBase
    {
        [ObservableProperty]
        List<DashboardItem> items;

        public ISeries[] EquipmentOnlineSeries { get; set; }
            = new ISeries[]
            {
                 new PieSeries<double>
                {
                    Name="在线设备" ,
                    Values = new double[] { 80 } ,
                    //DataLabelsPaint = new SolidColorPaint(SKColors.Black) {FontFamily= LiveChartsSkiaSharp.MatchChar('汉') },                    
                },
                new PieSeries<double>
                {
                    Name="离线设备",
                    Values = new double[] { 20 } ,
                    //DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.End,
                    //DataLabelsFormatter = point => $"离线设备",
                    //DataLabelsPaint = new SolidColorPaint(SKColors.Black) {FontFamily= LiveChartsSkiaSharp.MatchChar('汉') },                            
                },


            };


        public ISeries[] EquipmentAlarmSeries { get; set; }
        = new ISeries[]
        {
                new PieSeries<double>
                {
                    Name="正常",
                    Values = new double[] { 80 } ,
                    //DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.End,
                    //DataLabelsFormatter = point => $"离线设备",
                    //DataLabelsPaint = new SolidColorPaint(SKColors.Black) {FontFamily= LiveChartsSkiaSharp.MatchChar('汉') },                            
                },
                new PieSeries<double>
                {
                    Name="普通告警" ,
                    Values = new double[] { 10 } ,
                    //DataLabelsPaint = new SolidColorPaint(SKColors.Black) {FontFamily= LiveChartsSkiaSharp.MatchChar('汉') },                    
                },
                new PieSeries<double>
                {
                    Name="重要告警",
                    Values = new double[] { 5 } ,
                    //DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.End,
                    //DataLabelsFormatter = point => $"离线设备",
                    //DataLabelsPaint = new SolidColorPaint(SKColors.Black) {FontFamily= LiveChartsSkiaSharp.MatchChar('汉') },                            
                },
               new PieSeries<double>
                {
                    Name="紧急告警",
                    Values = new double[] { 3 } ,
                    //DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.End,
                    //DataLabelsFormatter = point => $"离线设备",
                    //DataLabelsPaint = new SolidColorPaint(SKColors.Black) {FontFamily= LiveChartsSkiaSharp.MatchChar('汉') },                            
                },


    };







        public DashboardViewModel()
        {
            InitData();
        }


        public void InitData()
        {
            Items = new List<DashboardItem>
            {
                new DashboardItem("所有设备", "Dashboard", 100.ToString()),
                new DashboardItem("在线", "Dashboard", 100.ToString()),
                new DashboardItem("告警设备", "Dashboard", 100.ToString()),
                new DashboardItem("用户", "Dashboard", 100.ToString()),
                new DashboardItem("气温", "Dashboard", "36C"),
                new DashboardItem("风速", "Dashboard", "3km/h"),
                new DashboardItem("PM2.5", "Dashboard", "60"),
                new DashboardItem("噪音", "Dashboard", "105db"),

            };


        }
    }
}
