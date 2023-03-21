using FoodieFinder.Database;
using FoodieFinder.UserAccount;

namespace FoodieFinder.Pages;

public partial class StartPage : ContentPage
{
    private AppDbContext _dbContext;

	public StartPage(AppDbContext dbContext)
	{
		InitializeComponent();

        _dbContext = dbContext;
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		Application.Current.MainPage = new AppShell();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        new Register(_dbContext).AddToDatabase("Wojciech@wp.pl", "juzek2137");
    }
}