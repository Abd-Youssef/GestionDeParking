using GestionDeParking.ViewModel;
using GestionDeParking.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace GestionDeParking.View;
public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }

    private void All_Clicked(object sender, EventArgs e)
    {
        var homePageViewModel = BindingContext as HomePageViewModel;
        
        Carliste.ItemsSource = homePageViewModel.NewCars;
        btn1.BackgroundColor = Color.FromRgb(13, 23, 42);
        btn1.TextColor= Color.FromRgb(255, 255, 255);   

        btn2.BackgroundColor = Color.FromRgb(255, 255, 255);
        btn2.TextColor = Color.FromRgb(0, 0, 0);
    }

    private void Car_Clicked(object sender, EventArgs e)
    {
        var homePageViewModel = BindingContext as HomePageViewModel;
         
        Carliste.ItemsSource = homePageViewModel.NewCars.Where(x=>x.Dispo);

        btn1.BackgroundColor = Color.FromRgb(255, 255, 255);
        btn1.TextColor = Color.FromRgb(0, 0, 0);

        btn2.BackgroundColor = Color.FromRgb(13, 23, 42);
        btn2.TextColor = Color.FromRgb(255, 255, 255);
    }
    





    //private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    var searchTerm = e.NewTextValue;
    //    var homePageViewModel = BindingContext as HomePageViewModel;
    //    if (string.IsNullOrWhiteSpace(searchTerm))
    //    {
    //        searchTerm = string.Empty;
    //    }
    //    searchTerm = searchTerm.ToLowerInvariant();
    //    var filtredItems= homePageViewModel.NewCars.car.Name.Where(value =>
    //      value.ToLowerInvariant().Contains(searchTerm) ).ToList();
    //}






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