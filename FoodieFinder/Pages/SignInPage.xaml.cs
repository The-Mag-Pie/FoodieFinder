using FoodieFinder.ViewModels;
using FoodieFinder.Database;
using FoodieFinder.UserAccount;
//using Auth0.OidcClient;
using FoodieFinder.Auth0;
using UserData = FoodieFinder.UserAccount.UserData;

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
        var auth0client = _serviceProvider.GetRequiredService<Auth0Client>();
        var userData = _serviceProvider.GetRequiredService<UserData>();
        var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
        var loginResult = await auth0client.LoginAsync();

        if (loginResult.IsError)
        {
            await DisplayAlert("Login error", loginResult.ErrorDescription, "OK");
            return;
        }

        await DisplayAlert("Login success", loginResult.User.Identity.Name, "OK");
        string email = loginResult.User.Claims.ToList().FirstOrDefault(c => c.Type == "email")?.Value;
        string password = "auth0";

        var logoutResult = await auth0client.LogoutAsync();
        if (logoutResult.IsError)
        {
            await DisplayAlert("Error", logoutResult.ErrorDescription, "OK");
            return;
        }

        Register reg = new Register(_serviceProvider);
        Login log = new Login(_serviceProvider);

        if (!reg.CheckIfInDatabase(email))
        {
            reg.AddToDatabase(email, password);
        }
        if (log.CreateSession(email))
        {
            var dbUserData = dbContext.User.Where(u => u.Email == email).First();
            userData.IsGuest = false;
            userData.UserId = dbUserData.Id;
            userData.UserName = email;

            Application.Current.MainPage = new AppShellUser();

        }
        else
        {
            await DisplayAlert("Error", "Session not created", "Ok");
            return;
        }

        //var auth0config = _serviceProvider.GetRequiredService<IConfiguration>()
        //    .GetSection("Auth0Config")
        //    .Get<Auth0Config>();

        //if (auth0config == null) return;

        //Auth0Client client = new Auth0Client(new Auth0ClientOptions
        //{
        //    Domain = auth0config.Domain,
        //    ClientId = auth0config.ClientId
        //});

        //var loginResult = await client.LoginAsync();

        //if (loginResult.IsError)
        //{
        //    System.Diagnostics.Debugger.Break();
        //}
    }
}