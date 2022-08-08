using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstTry.View;
using firstTry.Model;
using DevExpress.Data.XtraReports.Native;
using Microsoft.Toolkit.Mvvm.Input;

namespace firstTry.ViewModel
{



    public partial class SearchPageViewModel : BaseViewModel
    {
        public ObservableCollection<Car> Cars { get; set; }

        public SearchPageViewModel()
        {
            Cars = new ObservableCollection<Car>();
            Cars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            Cars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            Cars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            Cars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            Cars.Add(new Car { Marque = "VOLKSWAGEN", Name = " GOLF 8", Distance = 100000, Image = "golf8.jpg", Engine = "NOMBRE DE CYLINDRES\t4\r\nENERGIE\tEssence\r\nPUISSANCE FISCALE\t8 CV\r\nPUISSANCE (CH.DIN)\t150 CH\r\nCOUPLE\t250 nm 1400 tr/min\r\nCYLINDRÉE\t1395 CM³" });
            
        }
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
