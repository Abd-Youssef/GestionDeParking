
using firstTry.ViewModel;

namespace firstTry.View;

public partial class LoginPage : ContentPage
{

	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;


	}


}

