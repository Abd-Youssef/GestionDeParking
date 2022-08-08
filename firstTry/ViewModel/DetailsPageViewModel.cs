using firstTry.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace firstTry.ViewModel
{
    [QueryProperty(nameof(Car), "Car")]
    public partial class DetailsPageViewModel : BaseViewModel
    {
        
        [ObservableProperty]
        Car car;
        }
}
