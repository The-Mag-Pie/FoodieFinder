using FoodieFinder.UserAccount;

namespace FoodieFinder.Pages;

public partial class StartPage : ContentPage
{
    private readonly IServiceProvider _serviceProvider;

    public StartPage(IServiceProvider serviceProvider)
	{
		InitializeComponent();

        _serviceProvider = serviceProvider;

        App.ClearSharedRecipeIntentReceived();
    }

    private void GoToRegisterPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegisterPage(_serviceProvider));
    }

    private void GoToSignInPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SignInPage(_serviceProvider));
    }

    private void GoToForgotPasswordPage(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ForgotPasswordPage(_serviceProvider));
    }

    private void ContinueAsGuest(object sender, TappedEventArgs e)
    {
        var userData = _serviceProvider.GetRequiredService<UserData>();

        userData.IsGuest = true;
        userData.UserId = -1;
        userData.UserName = "Guest";

        Application.Current.MainPage = new AppShellGuest();
    }
}