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

        var log = new Login(dbContext);
		if (log.CheckIfSession())
		{
			userData.IsGuest = false;
			userData.UserId = log.GetUserIdSession();
			userData.UserName = log.GetUserNameSession();
            MainPage = new AppShell();
        }
		else
		{
			MainPage = new StartNavigationPage(dbContext, userData);
		}
	}
}
