using CommunityToolkit.Maui;
using FoodieFinder.Auth0;
using FoodieFinder.Database;
using FoodieFinder.Models;
using FoodieFinder.Pages;
using FoodieFinder.SuggesticAPI;
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
            })
			.UseMauiCommunityToolkit();

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

		// Add Auth0 client
		var auth0config = config.GetRequiredSection("Auth0Config").Get<Auth0Config>();
		builder.Services.AddSingleton(new Auth0Client(new()
		{
			Domain = auth0config.Domain,
			ClientId = auth0config.ClientId,
			Scope = "openid profile email",
			RedirectUri = "myapp://callback"
		}));

		// Add Suggestic API client
		var apiKey = config.GetRequiredSection("SuggesticAPI")["ApiKey"];
		builder.Services.AddSingleton(new SuggesticApiClient(apiKey));

        // Add pages to services (dependency injection)
        builder.Services.AddTransient<HomePage>();
		builder.Services.AddTransient<StoragePage>();
        builder.Services.AddTransient<StartPage>();
        builder.Services.AddTransient<RecipePage>();
        builder.Services.AddTransient<UserAccountPage>();
        builder.Services.AddTransient<SavedRecipePage>();
        builder.Services.AddTransient<AddSavedRecipePage>();

        // Add other services
        builder.Services.AddSingleton<UserData>();
        builder.Services.AddSingleton<HttpClient>();

        return builder.Build();
	}
}
