using GestionDeParking.Model;
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
        void OpenPopup()
        {
            Shell.Current.GoToAsync($"//{nameof(PopupPage)}");
        }
    }

}
