using firstTry.View;

namespace firstTry;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		
		Routing.RegisterRoute(nameof(HomePage),typeof(HomePage));
        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
    }
}
