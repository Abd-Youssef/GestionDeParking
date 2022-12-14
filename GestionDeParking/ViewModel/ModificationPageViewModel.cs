using GestionDeParking.Model;
using GestionDeParking.Services;
using GestionDeParking.View;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeParking.ViewModel
{
    [QueryProperty(nameof(Car), "Car")]
    public partial class ModificationPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        Car car;

        [ICommand]
        public async void Modify()
        {
            await CarService.ModifyCar(car);
            await Shell.Current.GoToAsync("..");
            IsBusy = true;
            //await RefreshList();
        }
    }
}
