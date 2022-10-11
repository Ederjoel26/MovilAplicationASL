using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsLogic.ViewModels
{
    public partial class PrincipalViewModel: ObservableObject
    {
        [RelayCommand]
        public async void RedireccionarSite1()
        {
            await Shell.Current.GoToAsync("PaginaSite1");
        }

        [RelayCommand]
        public async void RedireccionarSite2()
        {
            await Shell.Current.GoToAsync("PaginaSite2");
        }

        [RelayCommand]
        public async void RedireccionarSite3()
        {
            await Shell.Current.GoToAsync("PaginaSite3");
        }
    }
}
