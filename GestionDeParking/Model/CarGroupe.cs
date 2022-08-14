using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeParking.Model
{
    public class CarGroupe : ObservableCollection<Car> 
    {
        public Boolean Dispo { get; set; }  
        public CarGroupe(bool dispo, ObservableCollection<Car> cars) :base(cars)
        {
            this.Dispo = dispo;
        }
    }
}
