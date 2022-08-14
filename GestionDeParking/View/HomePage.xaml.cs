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
    //private async void MenuItem_Delete(object sender, EventArgs e)
    //{
    //    var car = ((MenuItem)sender).BindingContext as Car;
    //    var res = await DisplayAlert("warning", "Are you sure you want to delete this item", "Yes", "No");
    //    if (res)
    //    {
    //        var homePageViewModel = BindingContext as HomePageViewModel;
    //        homePageViewModel?.DeleteCar(car);

    //    }
    //    InitializeComponent();
    //}

    //private async void MenuItem_Modify(object sender, EventArgs e)
    //{
    //    var car = ((MenuItem)sender).BindingContext as Car;
    //    var homePageViewModel = BindingContext as HomePageViewModel;
    //    await homePageViewModel.GoToModification(car);
    //}
}