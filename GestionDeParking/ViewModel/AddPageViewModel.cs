using GestionDeParking.View;
using Microsoft.Maui.Controls;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeParking.Model;

namespace GestionDeParking.ViewModel
{
    public partial class AddPageViewModel:BaseViewModel
    {
        [ICommand]
        public void AddCar(Car car)
        {
            var vm = new HomePageViewModel();
            vm.NewCars.Add(car);
            Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }

    }
}
