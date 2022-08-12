using GestionDeParking.ViewModel;
using GestionDeParking.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace GestionDeParking.View;
public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }
    //void OpenPopup()
    //{
    //    Shell.Current.GoToAsync($"//{nameof(PopupPage)}");
    //}


    

    private async void Carliste_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        
            var SelectedCar = ((ListView)sender).SelectedItem as Car;
            var homePageViewModel = BindingContext as HomePageViewModel;
            var result = await DisplayActionSheet(null, "Cancel", null, "Delete", "Modify", "Details");
            if (result is "Delete")
            {
                var Delete = await DisplayAlert("warning", "Are you sure you want to delete this item", "Yes", "No");
                if (Delete is true)
                {
                //homePageViewModel?.RemoveCar.Execute(SelectedCar);
                homePageViewModel?.Delete(SelectedCar);
                }
                InitializeComponent();
            }
            else if (result is "Details")
            {
                await homePageViewModel.GoToDetails(SelectedCar);
            }
            else if (result is "Modify")
            {
                var Modification = await DisplayActionSheet(null, "Cancel", null, "Marque", "Name", "Engine", "Distance");
            switch (Modification)
            {
                case "Marque":
                    SelectedCar.Marque = await DisplayPromptAsync("Model", "Car's Model", initialValue: SelectedCar.Marque);
                    break;

                case "Name":
                    SelectedCar.Name = await DisplayPromptAsync("Name", "Car's Name", initialValue: SelectedCar.Name);
                    break;

                case "Engine":
                    SelectedCar.Engine = await DisplayPromptAsync("Engine", "Car's Engine details", initialValue: SelectedCar.Engine);
                    break;
                case "Distance":
                    SelectedCar.Distance = Int16.Parse(await DisplayPromptAsync("Distance", "Covered Distance",  keyboard:Keyboard.Numeric));
                    break;
                default:
                    break;  

            }
            InitializeComponent();

        }
        
    }

private async void MenuItem_Delete(object sender, EventArgs e)
    {
        var car= ((MenuItem)sender).BindingContext as Car; 
        var res= await DisplayAlert("warning", "Are you sure you want to delete this item", "Yes", "No");
        if (res)
        {   
            var homePageViewModel =BindingContext as HomePageViewModel;
            //homePageViewModel?.RemoveCar.Execute(car);
            homePageViewModel?.Delete(car);  
            
        }
        InitializeComponent();
    }

    private void MenuItem_Modify(object sender, EventArgs e)
    {
        var car = ((MenuItem)sender).BindingContext as Car;
        Shell.Current.GoToAsync($"//{nameof(AddPage)}");
    }
}