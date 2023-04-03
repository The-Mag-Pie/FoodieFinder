using FoodieFinder.ViewModels;
using FoodieFinder.Database;
using FoodieFinder.UserAccount;
using Auth0.OidcClient;
using Microsoft.Extensions.Configuration;
using FoodieFinder.Models;

namespace FoodieFinder.Pages;

public partial class SignInPage : ContentPage
{
    private readonly SignInPageViewModel _vm;
    private readonly IServiceProvider _serviceProvider;

	public SignInPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _vm = new(serviceProvider);
        BindingContext = _vm;

        _serviceProvider = serviceProvider;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Shell.SetTabBarIsVisible(this, false);
    }

    private async void SignInGoogleClickedAsync(object sender, EventArgs e)
    {
        var auth0config = _serviceProvider.GetRequiredService<IConfiguration>()
            .GetSection("Auth0Config")
            .Get<Auth0Config>();

        if (auth0config == null) return;

        Auth0Client client = new Auth0Client(new Auth0ClientOptions
        {
            Domain = auth0config.Domain,
            ClientId = auth0config.ClientId
        });

        var loginResult = await client.LoginAsync();

        if (loginResult.IsError)
        {
            System.Diagnostics.Debugger.Break();
        }
    }
}