namespace GestionDeParking.View;
using GestionDeParking.ViewModel;
using GestionDeParking.Model;

public partial class SearchPage : ContentPage
{
	public SearchPage(SearchPageViewModel searchPage)
	{
		InitializeComponent( );
		this.BindingContext = searchPage;
		
	}


}