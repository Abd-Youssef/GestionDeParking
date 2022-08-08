using firstTry.ViewModel;
using firstTry.Model;
namespace firstTry.View;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }
    
    
}