using FoodieFinder.Database;
using FoodieFinder.Pages;
using FoodieFinder.UserAccount;
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

#if DEBUG
        builder.Logging.AddDebug();
#endif

		// Add appsettings.json configuration
		var a = Assembly.GetExecutingAssembly();
		using var stream = a.GetManifestResourceStream("FoodieFinder.appsettings.json");

		var config = new ConfigurationBuilder()
			.AddJsonStream(stream)
			.Build();

		builder.Configuration.AddConfiguration(config);

		// Add DbContext service
		var connectionString = config.GetConnectionString("MariaDbConnectionString");
		builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

		// Add pages to services (dependency injection)
		builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<StartPage>();

		// Add other services
		builder.Services.AddSingleton<UserData>();

        return builder.Build();
	}
}
