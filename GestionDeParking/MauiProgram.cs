using GestionDeParking.View;
using GestionDeParking.ViewModel;

namespace GestionDeParking;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		//Views
		builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<AddPage>();
        builder.Services.AddSingleton<SearchPage>();
        builder.Services.AddTransient<DetailsPage>();
        builder.Services.AddTransient<PopupPage>();

        //View Models
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<HomePageViewModel>();
        builder.Services.AddSingleton<AddPageViewModel>();
        builder.Services.AddSingleton<SearchPageViewModel>();
        builder.Services.AddTransient<DetailsPageViewModel>();
        


        return builder.Build();
	}
}
