using FoodieFinder.Database;
using FoodieFinder.Popups;
using FoodieFinder.UserAccount;
using CommunityToolkit.Maui.Views;

namespace FoodieFinder.Pages;

public partial class StartPage : ContentPage
{
    private AppDbContext _dbContext;
    private UserData _userData;
    private LoadingPopup _loadingPopup;

	public StartPage(AppDbContext dbContext, UserData userData)
	{
		InitializeComponent();

        _dbContext = dbContext;
        _userData = userData;
        _loadingPopup = new();
	}

    // Continue as guest
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        _userData.IsGuest = true;
        _userData.UserId = -1;
        _userData.UserName = "Guest";

        StartHomePage();
    }

    // Login
    private void Button_Clicked(object sender, EventArgs e)
    {
        ShowLoadingPopup();

        Task.Run(() =>
        {
            var username = "Wojciech@wp.pl";
            var password = "juzek2137";

            var login = new Login(_dbContext);

            if (login.CheckIfInDatabase(username, password))
            {
                var data = _dbContext.User.Where((u) => u.Email == username).Single(); // TODO: przerzucić do klasy Login

                _userData.IsGuest = false;
                _userData.UserId = data.Id;
                _userData.UserName = data.Email;

                StartHomePage();
            }
            else
            {
                DisplayAlert("Error", "Wrong user name or password", "OK");
            }

            //CloseLoadingPopup();
        });
    }

    // Register
    private void Button_Clicked_1(object sender, EventArgs e)
    {
        new Register(_dbContext).AddToDatabase("Wojciech@wp.pl", "juzek2137");
    }

    private void ShowLoadingPopup() => this.ShowPopup(_loadingPopup);

    private void CloseLoadingPopup() => _loadingPopup.Close();

    private void StartHomePage()
    {
        this.ShowPopup(_loadingPopup);

        Task.Run(() =>
        {
            var shell = new AppShell();
            shell.Appearing += (s, e) => CloseLoadingPopup();
            MainThread.BeginInvokeOnMainThread(() => Application.Current.MainPage = shell);
        });
    }
}