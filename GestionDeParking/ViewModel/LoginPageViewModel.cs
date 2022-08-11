
using GestionDeParking.View;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeParking.ViewModel
{
    public partial class LoginPageViewModel :BaseViewModel
    {

        [ICommand]
        void Login()
        {
            Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
        //[ICommand]
        //void OpenPopup()
        //{
        //    Shell.Current.GoToAsync($"//{nameof(PopupPage)}");
        //}
    }
    
}
