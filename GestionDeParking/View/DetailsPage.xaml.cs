namespace GestionDeParking.View;
using GestionDeParking.ViewModel;


public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsPageViewModel detailsPageView)
	{
		InitializeComponent();
		BindingContext=detailsPageView;
	}
	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}
}