using GestionDeParking.Model;
using GestionDeParking.View;
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
    public partial class HomePageViewModel :BaseViewModel
    {
        public ObservableCollection<Car> NewCars { get; set; }
        public ObservableCollection<Car> BestCars { get; set; }
        public ObservableCollection<Car> RecommendedCars { get; set; }
        public HomePageViewModel()
        {
            NewCars = new ObservableCollection<Car>();
            NewCars.Add(new Car { Marque= "VOLKSWAGEN" , Name = " GOLF 8", Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            NewCars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            NewCars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            NewCars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            NewCars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
        }
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
        void OpenPopup()
        {
            Shell.Current.GoToAsync($"//{nameof(PopupPage)}");
        }
        HomePage res;
        /*
        BestCars = new ObservableCollection<Car>();
        BestCars.Add(new Car { Name = "BMW", Distance = 30000, Image = "bmw.jpg" });
        BestCars.Add(new Car { Name = "BMW", Distance = 30000, Image = "bmw.jpg" });
        BestCars.Add(new Car { Name = "BMW", Distance = 30000, Image = "bmw.jpg" });
        BestCars.Add(new Car { Name = "BMW", Distance = 30000, Image = "bmw.jpg" });
        BestCars.Add(new Car { Name = "BMW", Distance = 30000, Image = "bmw.jpg" });
        BestCars.Add(new Car { Name = "BMW", Distance = 30000, Image = "bmw.jpg" });

        RecommendedCars = new ObservableCollection<Car>();
        RecommendedCars.Add(new Car { Name = "Mercades", Distance = 30000, Image = "ibiza.jpg" });
        RecommendedCars.Add(new Car { Name = "Mercades", Distance = 30000, Image = "ibiza.jpg" });
        RecommendedCars.Add(new Car { Name = "Mercades", Distance = 30000, Image = "ibiza.jpg" });
        RecommendedCars.Add(new Car { Name = "Mercades", Distance = 30000, Image = "ibiza.jpg" });
        RecommendedCars.Add(new Car { Name = "Mercades", Distance = 30000, Image = "ibiza.jpg" });
        RecommendedCars.Add(new Car { Name = "Mercades", Distance = 30000, Image = "ibiza.jpg" });
        */



    }
}
