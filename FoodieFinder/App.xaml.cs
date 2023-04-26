using FoodieFinder.Database;
using FoodieFinder.Pages;
using FoodieFinder.UserAccount;

namespace FoodieFinder;

public partial class App : Application
{
	public static int? SharedRecipeID { get; set; } = null;

	public App(IServiceProvider serviceProvider)
	{
		InitializeComponent();

        Current.UserAppTheme = AppTheme.Light;

		var dbContext = serviceProvider.GetRequiredService<AppDbContext>();
		var userData = serviceProvider.GetRequiredService<UserData>();

        var log = new Login(serviceProvider);
		if (log.CheckIfSession())
		{
			userData.IsGuest = false;
			userData.UserId = log.GetUserIdSession();
			userData.UserName = log.GetUserNameSession();
            MainPage = new AppShellUser();
        }
		else
		{
			MainPage = new StartNavigationPage(serviceProvider);
		}
	}
}
