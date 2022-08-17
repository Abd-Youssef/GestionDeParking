using GestionDeParking.Model;
using GestionDeParking.Services;

namespace GestionDeParking;

public partial class App : Application
{
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		 
	}
}
