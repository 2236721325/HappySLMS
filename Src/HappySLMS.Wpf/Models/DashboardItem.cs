using System.Windows.Media;

namespace HappySLMS.Wpf.Models
{
    public class DashboardItem
    {
        public string Name { get; set; }
        private string iconKey;
        public string Value { get; set; }
        public Geometry PathData
        {
            get
            {
                return (Geometry)App.Current.FindResource(iconKey);
            }
        }

        public DashboardItem(string name, string icon_key, string value)
        {
            Name = name;
            iconKey = icon_key;
            Value = value;
        }
    }
}
