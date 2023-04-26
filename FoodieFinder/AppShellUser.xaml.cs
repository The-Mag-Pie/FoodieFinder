namespace FoodieFinder;

public partial class AppShellUser : Shell
{
	public AppShellUser()
	{
		InitializeComponent();

		Loaded += async (s, e) =>
		{
            await DisplayAlert("Intent", $"SharedRecipeID: {App.SharedRecipeID}", "OK");
            App.SharedRecipeID = null;
   //         if (App.SharedRecipeID != null)
			//{
			//	await DisplayAlert("Intent", $"SharedRecipeID: {App.SharedRecipeID}", "OK");
			//	App.SharedRecipeID = null;
			//}
		};
	}
}
