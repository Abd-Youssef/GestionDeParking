
using firstTry.View;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTry.ViewModel
{
    public partial class LoginPageViewModel :BaseViewModel
    {

        [ICommand]
        void Login()
        {
            Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
    }
}
