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
using GestionDeParking.Services;

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
        [ICommand]
        public async void AddCar(Car car)
        {
            //NewCars.Add(car);
            //OnPropertyChanged(nameof(NewCars));
            //Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            await CarService.AddNewCar(car.Name, car.Marque);
            //await Refresh();
        }
    }
}
