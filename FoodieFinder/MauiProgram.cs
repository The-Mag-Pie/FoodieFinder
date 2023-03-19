using FoodieFinder.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace FoodieFinder;

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


        var a = Assembly.GetExecutingAssembly();
        using var stream = a.GetManifestResourceStream("FoodieFinder.appsettings.json");

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddJsonStream(stream)
            .Build();


        builder.Configuration.AddConfiguration(configuration);

        using (var context = new IngredientContext(configuration))
        {
            context.Database.Migrate();
        }

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
