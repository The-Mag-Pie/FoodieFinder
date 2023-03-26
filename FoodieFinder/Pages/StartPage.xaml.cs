using FoodieFinder.Database;
using FoodieFinder.Popups;
using FoodieFinder.UserAccount;
using CommunityToolkit.Maui.Views;
using System.Diagnostics;

namespace FoodieFinder.Pages;

public partial class StartPage : ContentPage
{
    private AppDbContext _dbContext;
    private UserData _userData;
    //private LoadingPopup _loadingPopup;

    public StartPage(AppDbContext dbContext, UserData userData)
	{
		InitializeComponent();

        _dbContext = dbContext;
        _userData = userData;
        //_loadingPopup = new();
    }

    private void GoToRegisterPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegisterPage(_dbContext, _userData));
    }

    private void GoToSignInPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SignInPage(_dbContext, _userData));
    }

    private void GoToForgotPasswordPage(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ForgotPasswordPage(_dbContext, _userData));
    }

    private void ContinueAsGuest(object sender, TappedEventArgs e)
    {
        _userData.IsGuest = true;
        _userData.UserId = -1;
        _userData.UserName = "Guest";

        Application.Current.MainPage = new AppShell();
    }

    // Login
    //private void Button_Clicked(object sender, EventArgs e)
    //{
    //    ShowLoadingPopup();

    //    Task.Run(() =>
    //    {
    //        var username = "Wojciech@wp.pl";
    //        var password = "juzek2137";

    //        var login = new Login(_dbContext);

    //        if (login.CheckIfInDatabase(username, password))
    //        {
    //            var data = _dbContext.User.Where((u) => u.Email == username).Single(); // TODO: przerzucić do klasy Login

    //            _userData.IsGuest = false;
    //            _userData.UserId = data.Id;
    //            _userData.UserName = data.Email;

    //            StartHomePage();
    //        }
    //        else
    //        {
    //            DisplayAlert("Error", "Wrong user name or password", "OK");
    //        }

    //        //CloseLoadingPopup();
    //    });
    //}

    //private void ShowLoadingPopup() => this.ShowPopup(_loadingPopup);

    //private void CloseLoadingPopup() => _loadingPopup.Close();

    //private void StartHomePage()
    //{
    //    this.ShowPopup(_loadingPopup);

    //    Task.Run(() =>
    //    {
    //        var shell = new AppShell();
    //        shell.Appearing += (s, e) => CloseLoadingPopup();
    //        MainThread.BeginInvokeOnMainThread(() => Application.Current.MainPage = shell);
    //    });
    //}
}