using FoodieFinder.ViewModels;
using FoodieFinder.Database;
using FoodieFinder.UserAccount;
using Auth0.OidcClient;

namespace FoodieFinder.Pages;

public partial class SignInPage : ContentPage
{
    private readonly SignInPageViewModel vm;
	public SignInPage(AppDbContext appDbContext, UserData userData)
    {
        InitializeComponent();
        vm = new(appDbContext, userData);
        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Shell.SetTabBarIsVisible(this, false);
    }

    private async void SignInGoogleClickedAsync(object sender, EventArgs e)
    {
        Auth0Client client = new Auth0Client(new Auth0ClientOptions
        {
            Domain = "",
            ClientId = ""
        });

        var loginResult = await client.LoginAsync();

        if (loginResult.IsError)
        {
            System.Diagnostics.Debugger.Break();
        }
    }
}