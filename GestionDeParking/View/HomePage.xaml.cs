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
        
            var car = ((ListView)sender).SelectedItem as Car;
            var result = await DisplayActionSheet(null, "Cancel", null, "Delete", "Modify", "Details");
            if (result is "Delete")
            {
                var Delete = await DisplayAlert("warning", "Are you sure you want to delete this item", "Yes", "No");
                if (Delete is true)
                {
                    var homePageViewModel = BindingContext as HomePageViewModel;
                    //homePageViewModel?.RemoveCar.Execute(car);
                    homePageViewModel?.Delete(car);
                }
                InitializeComponent();
            }
            else if (result is "Details")
            {
                HomePageViewModel viewModel = new HomePageViewModel();
                await viewModel.GoToDetails(car);
            }
            else if (result is "Modify")
            {
                await Shell.Current.GoToAsync($"//{nameof(AddPage)}");
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