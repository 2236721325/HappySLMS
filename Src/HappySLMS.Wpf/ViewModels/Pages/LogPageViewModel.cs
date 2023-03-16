
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySLMS.Wpf.ViewModels.Pages
{
    public partial  class LogPageViewModel:ViewModelBase
    {
        public ISeries[] Series { get; set; }
             = new ISeries[]
             {
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
                    Fill = null
                }
             };
    }
}
