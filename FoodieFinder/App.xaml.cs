using FoodieFinder.Pages;

namespace FoodieFinder;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        Current.UserAppTheme = AppTheme.Light;

        MainPage = new StartPage();
	}
}
