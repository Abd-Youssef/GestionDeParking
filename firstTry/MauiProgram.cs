using firstTry.View;
using firstTry.ViewModel;

namespace firstTry;

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
        builder.Services.AddSingleton<SearchPage>();
        builder.Services.AddTransient<DetailsPage>();

        //View Models
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<HomePageViewModel>();
        builder.Services.AddSingleton<SearchPageViewModel>();
        builder.Services.AddTransient<DetailsPageViewModel>();

        return builder.Build();
	}
}
