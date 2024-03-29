﻿using CommunityToolkit.Maui;
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
	private static IServiceProvider _serviceProvider;
	public static IServiceProvider ServiceProvider => _serviceProvider;

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

		// Configure custom handlers
		builder.ConfigureMauiHandlers(handlers =>
		{
#if ANDROID
			handlers.AddHandler<CollectionView, FoodieFinder.Platforms.Android.CustomHandlers.CollectionViewCustomHandler>();
#endif
		});

		// Routes
		Routing.RegisterRoute(nameof(AddSavedRecipePage), typeof(AddSavedRecipePage));
        Routing.RegisterRoute(nameof(ModifySavedRecipePage), typeof(ModifySavedRecipePage));
        Routing.RegisterRoute(nameof(RecipePage), typeof(RecipePage));
		Routing.RegisterRoute(nameof(OnlineRecipePage), typeof(OnlineRecipePage));
		Routing.RegisterRoute(nameof(OnlineRecipeDetailsPage), typeof(OnlineRecipeDetailsPage));
		Routing.RegisterRoute(nameof(SavedRecipePage), typeof(SavedRecipePage));
		Routing.RegisterRoute(nameof(UserAccountPage), typeof(UserAccountPage));

        // Add appsettings.json configuration
        var a = Assembly.GetExecutingAssembly();
		using var stream = a.GetManifestResourceStream("FoodieFinder.appsettings.json");

		var config = new ConfigurationBuilder()
			.AddJsonStream(stream)
			.Build();

		builder.Configuration.AddConfiguration(config);

		// Add DbContext service
		var connectionString = config.GetConnectionString("MariaDbConnectionString");
		builder.Services.AddDbContext<AppDbContext>(
			options => options.UseMySql(
				connectionString,
				ServerVersion.Create(
					new Version(10,5,19),
					Pomelo.EntityFrameworkCore.MySql.Infrastructure.ServerType.MariaDb
				)
			)
		);

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

		// Add shell to services
		builder.Services.AddTransient<AppShellUser>();

        // Add pages to services
        builder.Services.AddTransient<HomePage>();
		builder.Services.AddTransient<StoragePage>();
        builder.Services.AddTransient<StartPage>();
        builder.Services.AddTransient<RecipePage>();
        builder.Services.AddTransient<UserAccountPage>();
        builder.Services.AddTransient<SavedRecipePage>();
        builder.Services.AddTransient<AddSavedRecipePage>();
        builder.Services.AddTransient<ModifySavedRecipePage>();
        builder.Services.AddTransient<OnlineRecipePage>();
        builder.Services.AddTransient<OnlineRecipeDetailsPage>();
        builder.Services.AddTransient<SavedRecipePage>();
        builder.Services.AddTransient<SearchPage>();

        // Add other services
        builder.Services.AddSingleton<UserData>();
        builder.Services.AddSingleton<HttpClient>();

		var app = builder.Build();

		_serviceProvider = app.Services;

		return app;
	}
}
