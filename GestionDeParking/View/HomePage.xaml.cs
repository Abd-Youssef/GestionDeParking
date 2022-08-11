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


    //public async void DisplayActionSheet(object obj, EventArgs eventArgs)
    //{
    //    var result =  await DisplayActionSheet(null, "Cancel", null, "Delete", "Modify", "Details");
    //    if (result is "Delete")
    //    {
    //        var Delete=await DisplayAlert("warning", "Are you sure you want to delete this item","Yes", "No");
    //        if (Delete is true)
    //        {
    //            //delete item
    //        }  
    //    }
    //    else if (result is "Details")
    //    {

    //        HomePageViewModel viewModel = new HomePageViewModel();
    //        await viewModel.GoToDetails(car);
    //        // open details page

    //        //Car car;
    //        //await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
    //        //    new Dictionary<String, object>
    //        //    {
    //        //        {"Car",car }
    //        //    });
    //    }
    //    else if (result is "Modify")
    //    {
    //        //open modification page
    //    }
    //}

    //private async void Carliste_ItemTapped(object sender, SelectedItemChangedEventArgs e)
    //{
    //    var car = ((ListView)sender).SelectedItem as Car;
    //    var result = await DisplayActionSheet(null, "Cancel", null, "Delete", "Modify", "Details");
    //    if (result is "Delete")
    //    {
    //        var Delete = await DisplayAlert("warning", "Are you sure you want to delete this item", "Yes", "No");
    //        if (Delete is true)
    //        {
    //            delete item
    //        }
    //    }
    //    else if (result is "Details")
    //    {

    //        HomePageViewModel viewModel = new HomePageViewModel();
    //        await viewModel.GoToDetails(car);
    //        open details page

    //       Car car;
    //        await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
    //            new Dictionary<String, object>
    //            {
    //                {"Car",car }
    //            });
    //    }
    //    else if (result is "Modify")
    //    {
    //        open modification page
    //    }
    //}

    private async void Carliste_ItemTapped_1(object sender, ItemTappedEventArgs e)
    {
        
            var car = ((ListView)sender).SelectedItem as Car;
            var result = await DisplayActionSheet(null, "Cancel", null, "Delete", "Modify", "Details");
            if (result is "Delete")
            {
                var Delete = await DisplayAlert("warning", "Are you sure you want to delete this item", "Yes", "No");
                if (Delete is true)
                {
                    //delete item
                }
            }
            else if (result is "Details")
            {

                HomePageViewModel viewModel = new HomePageViewModel();
                await viewModel.GoToDetails(car);
                // open details page

                //Car car;
                //await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
                //    new Dictionary<String, object>
                //    {
                //        {"Car",car }
                //    });
            }
            else if (result is "Modify")
            {
                //open modification page
            }
        
    }
}