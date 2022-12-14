using GestionDeParking.View;

namespace GestionDeParking;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		
		Routing.RegisterRoute(nameof(HomePage),typeof(HomePage));
        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
        Routing.RegisterRoute(nameof(ModificationPage), typeof(ModificationPage));

        Routing.RegisterRoute(nameof(AddPage), typeof(AddPage));
    }
}
