using GestionDeParking.Model;
using GestionDeParking.View;
using GestionDeParking.Services;
using Microsoft.Toolkit.Mvvm.Input;
using Application = Microsoft.Maui.Controls.Application;
using System.Windows.Input;

namespace GestionDeParking.ViewModel
{
    public partial class HomePageViewModel : BaseViewModel
    {
        public HomePageViewModel()
        {   
            MessagingCenter.Subscribe<HomePageViewModel>(this, "refresh", (sender) =>
            {
                // Do something whenever the "refresh" message is received
                Refresh();
            });
            Refresh();
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
        public async Task DeleteCar(Car car)
        {
            await CarService.RemoveCar(car.Id);
            await Refresh(); 
        }
        [ICommand]
        public async void OpenPopup(Car car)
        {
            var result = await Application.Current.MainPage.DisplayActionSheet(null, "Cancel", null, "Delete", "Modify", "Details", "Change Disponibility");
            
            switch (result)
            {
                case "Delete":
                    var Delete = await Application.Current.MainPage.DisplayAlert("warning", "Are you sure you want to delete this item ?", "Yes", "No");
                    if (Delete)
                    {
                        await DeleteCar(car);
                        await Refresh();
                    }
                    break;

                case "Details":
                    await GoToDetails(car);
                    break;

                case "Modify":
                    await GoToModification(car);
                    break;
                case "Change Disponibility":
                    var Change_Dispo = await Application.Current.MainPage.DisplayAlert("warning", "Are you sure you want to change the disponibility State ?", "Yes", "No");
                    if (Change_Dispo)
                    {
                        await ChangeCarDispo(car);
                        await Refresh();

                    }
                    break;
                default:
                    break;

            }

        }

        [ICommand]
        public async Task ChangeCarDispo(Car car)
        {
            await CarService.ChangeDispo(car);
            await Refresh();
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
        [ICommand]
        async Task Refresh()
        {
            await RefreshList();

        }


        [ICommand]
        public async Task GoToAdd()
        {
            var car = new Car();    
            await Shell.Current.GoToAsync($"{nameof(AddPage)}", 
                new Dictionary<String, object>
                {
                    {"Car",car }
                });
        }


    }
}
