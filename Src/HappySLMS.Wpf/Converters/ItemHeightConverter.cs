using System;
using System.Globalization;
using System.Windows.Data;

namespace HappySLMS.Wpf.Converters
{
    public class ItemHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double actualHeight)
            {
                // 计算每行显示的子项数量
                int itemPerRow = 4;
                double spacing = 32;
                double totalSpacing = spacing * (itemPerRow - 1);
                double availableHeight = actualHeight - totalSpacing;
                double itemHeight = availableHeight / itemPerRow;

                return itemHeight;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
