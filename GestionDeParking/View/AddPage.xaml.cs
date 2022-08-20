using GestionDeParking.Model;
using GestionDeParking.ViewModel;
using Microsoft.Maui.Controls;

namespace GestionDeParking.View;

public partial class AddPage : ContentPage
{
	public AddPage(AddPageViewModel addPageViewModel)
	{
        InitializeComponent();
        BindingContext = addPageViewModel;
    }
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

    
}