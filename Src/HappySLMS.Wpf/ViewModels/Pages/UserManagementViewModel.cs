using CommunityToolkit.Mvvm.ComponentModel;
using HappySLMS.Wpf.Models;
using System;
using System.Collections.Generic;

namespace HappySLMS.Wpf.ViewModels.Pages
{
    public partial class UserManagementViewModel : ViewModelBase
    {

        [ObservableProperty]
        List<UserInfo> dataList;

        public UserManagementViewModel()
        {
            DataList = new List<UserInfo>();
            for (int i = 0; i < 15; i++)
            {
                DataList.Add(new UserInfo()
                {
                    Id = Guid.NewGuid(),
                    Name = i.ToString() + ".用户",
                    Email="2236721324@qq.com",
                    Phone="18376482944322",
                    LoginFailedCount=0,
                    Role="管理员"
                });
            }


        }
    }
}
