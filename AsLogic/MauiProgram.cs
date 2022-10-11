using AsLogic.ViewModels;
using AsLogic.Views;

namespace AsLogic;

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
		builder.Services.AddSingleton<Principal>();
        builder.Services.AddSingleton<PrincipalViewModel>();
        builder.Services.AddSingleton<Site1>();
        builder.Services.AddSingleton<Site1ViewModel>();
        builder.Services.AddSingleton<Site2>();
        builder.Services.AddSingleton<Site2ViewModel>();
        builder.Services.AddSingleton<Site3>();
        builder.Services.AddSingleton<Site3ViewModel>();
        return builder.Build();
	}
}
