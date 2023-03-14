using CommunityToolkit.Maui;
using GearInsight.Models;
using GearInsight.Services;
using GearInsight.ViewModels;
using Microsoft.Extensions.Logging;

namespace GearInsight;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
            .UseMauiCommunityToolkitMediaElement()
            .UseMauiCommunityToolkit()
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


		// Designpattern Singleton
		builder.Services.AddSingleton<Character>();
		
		builder.Services.AddSingleton<Mongo>();
		// builder.Services.AddSingleton<CharacterPageViewModel>();
		builder.Services.AddSingleton<MainPage>();



//#if DEBUG
//		builder.Logging.AddDebug();
//#endif

		return builder.Build();
	}
}
