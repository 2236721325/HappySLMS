using CommunityToolkit.Mvvm.ComponentModel;
using HappySLMS.Wpf.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Documents;

namespace HappySLMS.Wpf.ViewModels.Pages
{
    public partial class EquipmentManagementViewModel : ViewModelBase
    {

        [ObservableProperty]
        List<EquipmentInfo> dataList;

        public EquipmentManagementViewModel()
        {
            DataList = new List<EquipmentInfo>();
            for (int i = 0; i < 100; i++)
            {
                DataList.Add(new EquipmentInfo()
                {
                    Id = Guid.NewGuid(),
                    Name = i.ToString() + ".设备",
                    State = "在线"
                });
            }
            
          
        }
    }
}
