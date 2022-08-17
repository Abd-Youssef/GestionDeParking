
using GestionDeParking.Model;
using GestionDeParking.Services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeParking.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        public BaseViewModel()
        {
            NewCars = new ObservableCollection<Car>();
        }
        
        [ObservableProperty]
        public ObservableCollection<Car> newCars;
        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private string _title;

        public async Task RefreshList()
        {
            IsBusy = true;
            await Task.Delay(1000);
            NewCars.Clear();
            var cars = await CarService.GetCar();
            if (cars != null)
            {
                foreach (var car in cars)
                {
                    NewCars.Add(car);
                }
            }
            IsBusy = false;

        }
    }
}
