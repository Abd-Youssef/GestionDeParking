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
    public partial class AddPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        Car car;

        [ICommand]
        public async void AddCar()
        {
            await CarService.AddNewCar(car);
            await Shell.Current.GoToAsync("..");
            //await RefreshList();
        }
    }
}
