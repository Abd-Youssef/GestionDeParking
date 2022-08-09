
using GestionDeParking.ViewModel;

namespace GestionDeParking.View;

public partial class LoginPage : ContentPage
{

	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;


	}


}

