using GestionDeParking.Model;
using GestionDeParking.Services;
using GestionDeParking.View;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace GestionDeParking.ViewModel
{
    [QueryProperty(nameof(Car), "Car")]
    public partial class DetailsPageViewModel : BaseViewModel
    {
        
        [ObservableProperty]
        Car car;

        [ICommand]
        public async Task ChangeCarDispo(Car car)
        {
            await CarService.ChangeDispo(car);
        }

    }
    

}
