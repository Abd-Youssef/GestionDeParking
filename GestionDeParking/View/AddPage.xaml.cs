using GestionDeParking.Model;
using GestionDeParking.ViewModel;
using Microsoft.Maui.Controls;

namespace GestionDeParking.View;

public partial class AddPage : ContentPage
{
	public AddPage()
	{
		InitializeComponent();
	}
    //   protected override async void OnAppearing()
    //   {
    //       base.OnAppearing();
    //       collectionView.ItemsSource = await App.Database.GetPeopleAsync();
    //   }

    //async void OnButtonClicked(object sender, EventArgs e)
    //{
    //	if (!string.IsNullOrWhiteSpace(marque.Text))
    //	{
    //		await App.Database.SavePersonAsync(new Car
    //		{
    //			Marque = marque.Text,
    //		});

    //		marque.Text = string.Empty;

    //		collectionView.ItemsSource = await App.Database.GetPeopleAsync();
    //	}
    //}
    public async void OnButtonClicked(object sender, EventArgs e)
    {
        
            var car =new Car
            {
                Marque = marque.Text,
                Name   = name.Text,
                Engine = engine.Text,
                Image = "bmw.jpg"
            };
        //var vm = BindingContext as AddPageViewModel;
        var vm = new AddPageViewModel();
        vm.AddCar(car); 
    }
}