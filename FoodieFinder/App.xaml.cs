using FoodieFinder.Database;
using FoodieFinder.Pages;
using FoodieFinder.UserAccount;

namespace FoodieFinder;

public partial class App : Application
{
	public static int? SharedRecipeID { get; set; } = null;
    public static string SharedOnlineRecipeID { get; set; } = null;
    public static event Action SharedRecipeIntentReceived;
	public static void OnSharedRecipeIntentReceived() => SharedRecipeIntentReceived?.Invoke();
	public static void ClearSharedRecipeIntentReceived()
	{
		if (SharedRecipeIntentReceived == null) return;

		foreach (var d in SharedRecipeIntentReceived.GetInvocationList())
		{
			SharedRecipeIntentReceived -= (Action)d;
		}
	}

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
            MainPage = new AppShellUser(serviceProvider);
        }
		else
		{
			MainPage = new StartNavigationPage(serviceProvider);
		}
	}
}
