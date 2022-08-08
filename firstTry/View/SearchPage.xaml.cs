namespace firstTry.View;
using firstTry.ViewModel;
using firstTry.Model;

public partial class SearchPage : ContentPage
{
	public SearchPage(SearchPageViewModel searchPage)
	{
		InitializeComponent( );
		this.BindingContext = searchPage;
		
	}
}