using FoodieFinder.Database;
using FoodieFinder.Pages;
using FoodieFinder.UserAccount;

namespace FoodieFinder;

public partial class App : Application
{
	public App(AppDbContext dbContext, UserData userData)
	{
		InitializeComponent();

        Current.UserAppTheme = AppTheme.Light;

        MainPage = new StartPage(dbContext, userData);
	}
}
