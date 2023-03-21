using FoodieFinder.Database;
using FoodieFinder.Pages;

namespace FoodieFinder;

public partial class App : Application
{
	public App(AppDbContext dbContext)
	{
		InitializeComponent();

        Current.UserAppTheme = AppTheme.Light;

        MainPage = new StartPage(dbContext);
	}
}
