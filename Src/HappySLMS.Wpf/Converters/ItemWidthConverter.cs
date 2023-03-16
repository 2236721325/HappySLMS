using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HappySLMS.Wpf.Converters
{
    public class ItemWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double actualWidth)
            {
                int itemPerRow = 4;
                // 计算每行显示的子项数量
                if (parameter != null)
                {
                    if(int.TryParse(parameter as string, out int perRow))
                    {
                        itemPerRow = perRow;
                    }
                }
                
                double spacing = 32;
                double totalSpacing = spacing * (itemPerRow - 1);
                double availableWidth = actualWidth - totalSpacing;
                double itemWidth = availableWidth / itemPerRow;

                return itemWidth;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
