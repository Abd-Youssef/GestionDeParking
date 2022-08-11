
using GestionDeParking.ViewModel;

namespace GestionDeParking.View;

public partial class LoginPage : ContentPage
{

	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;

        
    }
	//public async void DisplayAlert(object obj, EventArgs eventArgs)
	//{
	//	await DisplayAlert("warning", "This alert Demo", "Ok");
	//}
}

