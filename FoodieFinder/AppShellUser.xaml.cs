namespace FoodieFinder;

public partial class AppShellUser : Shell
{
	public AppShellUser()
	{
		InitializeComponent();

		Loaded += async (s, e) => await OnSharedRecipeIntentReceived();
		App.SharedRecipeIntentReceived += async () => await OnSharedRecipeIntentReceived();
	}

	private async Task OnSharedRecipeIntentReceived()
	{
		if (App.SharedRecipeID != null)
		{
            await DisplayAlert("Intent", $"SharedRecipeID: {App.SharedRecipeID}", "OK");
			App.SharedRecipeID = null;
        }
	}
}
