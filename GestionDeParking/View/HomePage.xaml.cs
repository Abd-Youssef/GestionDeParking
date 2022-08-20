using GestionDeParking.ViewModel;
using GestionDeParking.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace GestionDeParking.View;
public partial class HomePage : ContentPage
{
    private bool DispoIsActive = false;   
	public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }

    private void AllCars(object sender, EventArgs e)
    {
        var homePageViewModel = BindingContext as HomePageViewModel;
        DispoIsActive = false;
        searchbar.Text = "";

        Carliste.ItemsSource = homePageViewModel.NewCars;
        btn1.BackgroundColor = Color.FromRgb(13, 23, 42);
        btn1.TextColor= Color.FromRgb(255, 255, 255);   

        btn2.BackgroundColor = Color.FromRgb(255, 255, 255);
        btn2.TextColor = Color.FromRgb(0, 0, 0);
    }

    private void AvailableCars(object sender, EventArgs e)
    {
        var homePageViewModel = BindingContext as HomePageViewModel;
        DispoIsActive = true;
        searchbar.Text = "";

        Carliste.ItemsSource = homePageViewModel.NewCars.Where(x=>x.Dispo);

        btn1.BackgroundColor = Color.FromRgb(255, 255, 255);
        btn1.TextColor = Color.FromRgb(0, 0, 0);

        btn2.BackgroundColor = Color.FromRgb(13, 23, 42);
        btn2.TextColor = Color.FromRgb(255, 255, 255);
    }



    private void SearchBar(object sender, TextChangedEventArgs e)
    {

        var homePageViewModel = BindingContext as HomePageViewModel;
        var searchTerm = e.NewTextValue;

        if (string.IsNullOrWhiteSpace(searchTerm))
        {
            Carliste.ItemsSource = homePageViewModel.NewCars;
        }
        else
        {

            searchTerm = searchTerm.ToLowerInvariant();
            Carliste.ItemsSource = homePageViewModel.NewCars.Where(i => i.Name.ToLowerInvariant().Contains(searchTerm)).Where(i => i.Dispo == DispoIsActive); 
        }


    }

}