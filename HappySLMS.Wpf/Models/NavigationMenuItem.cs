using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HappySLMS.Wpf.Models
{
    public class NavigationMenuItem
    {
        public string Name { get; set; }
        public Type PageType { get; set; }
        private string iconKey;
        public Geometry PathData 
        {
            get
            {
                return (Geometry)App.Current.FindResource(iconKey);
            }
        }
        
        public NavigationMenuItem(string name, Type pageType, string icon_key)
        {
            Name = name;
            PageType = pageType;
            iconKey=icon_key;
        }
        
    }
}
