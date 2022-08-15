using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeParking.View;
using GestionDeParking.Model;
using DevExpress.Data.XtraReports.Native;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace GestionDeParking.ViewModel
{



    public partial class SearchPageViewModel : BaseViewModel
    {

        public SearchPageViewModel()
        {
            NewCars = new ObservableCollection<Car>();
            NewCars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Dispo = true, Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            NewCars.Add(new Car { Marque = "SEAT", Name = "IBIZA", Dispo = false, Distance = 30000, Image = "ibiza.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            NewCars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Dispo = true, Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            NewCars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Dispo = true, Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            NewCars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Dispo = true, Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });



            LastCars = new ObservableCollection<Car>();
            LastCars.Add(new Car { Marque = "SEAT", Name = "IBIZA", Dispo = false, Distance = 30000, Image = "ibiza.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            LastCars.Add(new Car { Marque = "SEAT", Name = "IBIZA", Dispo = false, Distance = 30000, Image = "ibiza.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            LastCars.Add(new Car { Marque = "SEAT", Name = "IBIZA", Dispo = false, Distance = 30000, Image = "ibiza.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
        }


        [ObservableProperty]
        public ObservableCollection<Car> newCars;
        [ObservableProperty]
        public ObservableCollection<Car> lastCars;
        [ICommand]
        async Task GoToDetailsPage(Car car)
        {
            if (car == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
                new Dictionary<String, object>
                {
                    {"Car",car }
                });
        }
        

    }
}
