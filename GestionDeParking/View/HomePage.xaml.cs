using GestionDeParking.ViewModel;
using GestionDeParking.Model;
namespace GestionDeParking.View;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
    }
    
    
}