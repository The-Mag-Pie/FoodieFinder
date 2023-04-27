namespace FoodieFinder;

public partial class AppShellGuest : Shell
{
	public AppShellGuest()
	{
		InitializeComponent();

        Loaded += async (s, e) => await OnSharedRecipeIntentReceived();
        App.SharedRecipeIntentReceived += async () => await OnSharedRecipeIntentReceived();
    }

    private async Task OnSharedRecipeIntentReceived()
    {
        if (App.SharedRecipeID != null)
        {
            await DisplayAlert("Shared recipe", $"You must be logged in if you want to save the recipe", "OK");
            App.SharedRecipeID = null;
        }
    }
}
