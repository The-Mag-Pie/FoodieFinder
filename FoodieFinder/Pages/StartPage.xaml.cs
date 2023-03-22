using FoodieFinder.Database;
using FoodieFinder.UserAccount;

namespace FoodieFinder.Pages;

public partial class StartPage : ContentPage
{
    private AppDbContext _dbContext;
    private UserData _userData;

	public StartPage(AppDbContext dbContext, UserData userData)
	{
		InitializeComponent();

        _dbContext = dbContext;
        _userData = userData;
	}

    // Continue as guest
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        _userData.IsGuest = true;
        _userData.UserId = -1;
        _userData.UserName = "Guest";

		Application.Current.MainPage = new AppShell();
    }

    // Login
    private void Button_Clicked(object sender, EventArgs e)
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

            Application.Current.MainPage = new AppShell();
        }
        else
        {
            DisplayAlert("Error", "Wrong user name or password", "OK");
        }
    }

    // Register
    private void Button_Clicked_1(object sender, EventArgs e)
    {
        new Register(_dbContext).AddToDatabase("Wojciech@wp.pl", "juzek2137");
    }
}