using GestionDeParking.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace GestionDeParking.ViewModel
{
    [QueryProperty(nameof(Car), "Car")]
    public partial class DetailsPageViewModel : BaseViewModel
    {
        
        [ObservableProperty]
        Car car;
        }
}
