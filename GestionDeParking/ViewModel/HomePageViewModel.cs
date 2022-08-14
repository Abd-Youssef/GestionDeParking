using Android.App;
using DevExpress.Data.XtraReports.Native;
using GestionDeParking.Model;
using GestionDeParking.View;
using Microsoft.FSharp.Linq.RuntimeHelpers;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application = Microsoft.Maui.Controls.Application;

namespace GestionDeParking.ViewModel
{
    public partial class HomePageViewModel : BaseViewModel
    {

        public HomePageViewModel()
        {
            NewCars = new ObservableCollection<Car>();
            NewCars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Dispo = true, Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            NewCars.Add(new Car { Marque = "SEAT"      , Name = "IBIZA"  , Dispo = false, Distance = 30000, Image = "ibiza.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            NewCars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Dispo = true, Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            NewCars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Dispo = true, Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            NewCars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Dispo = true, Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });

        }


        [ObservableProperty]
        public ObservableCollection<Car> newCars;
        Car selectedCar;
        public Car SelectedCar { get { return selectedCar; } set { selectedCar = value; } }
        
        [ICommand]
        public async Task GoToDetails(Car car)
        {
            if (car == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
                new Dictionary<String, object>
                {
                    {"Car",car }
                });
        }
        [ICommand]
        public async Task DeleteCar(Car car)
        {
            NewCars.Remove(car);
            OnPropertyChanged(nameof(NewCars));
        }
        [ICommand]
        public void AddCar(Car car)
        {            
            NewCars.Add(car);
            Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }

        [ICommand]
        public async void OpenPopup(Car car)
        {
            var result = await Application.Current.MainPage.DisplayActionSheet(null, "Cancel", null, "Delete", "Modify", "Details");
            
            switch (result)
            {
                case "Delete":
                    var Delete = await Application.Current.MainPage.DisplayAlert("warning", "Are you sure you want to delete this item", "Yes", "No");
                    if (Delete)
                    {
                        await DeleteCar(car);
                    }
                    break;

                case "Details":
                    await GoToDetails(car);
                    break;

                case "Modify":
                    await GoToModification(car);
                    break;
                default:
                    break;

            }

        }
        [ICommand]
        public async Task GoToModification(Car car)
        {
            if (car == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(ModificationPage)}", true,
                new Dictionary<String, object>
                {
                    {"Car",car }
                });
            
        }



        /*
        BestCars = new ObservableCollection<Car>();
        BestCars.Add(new Car { Name = "BMW", Distance = 30000, Image = "bmw.jpg" });

        RecommendedCars = new ObservableCollection<Car>();
        RecommendedCars.Add(new Car { Name = "Mercades", Distance = 30000, Image = "ibiza.jpg" });
        */



    }
}
