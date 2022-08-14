using GestionDeParking.View;
using Microsoft.Maui.Controls;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeParking.Model;

using Microsoft.Toolkit.Mvvm.ComponentModel;


namespace GestionDeParking.ViewModel
{
    [QueryProperty(nameof(Car), "Car")]
        public partial class AddPageViewModel:BaseViewModel
    {

        [ObservableProperty]
            Car car;
            //[ICommand]
        //public void AddCar(Car car)
        //{
        //    var vm =  HomePageViewModel();
        //    vm.NewCars.Add(car);
        //    Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        //}

    }
}
