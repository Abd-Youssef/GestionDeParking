using GestionDeParking.Model;
using GestionDeParking.ViewModel;

namespace GestionDeParking.View;

public partial class ModificationPage : ContentPage
{
	public ModificationPage(ModificationPageViewModel modificationPageViewModel)
	{
		InitializeComponent();
        BindingContext = modificationPageViewModel;
    }
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
    
}