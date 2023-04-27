using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using FoodieFinder.Database;
using FoodieFinder.Popups;
using FoodieFinder.UserAccount;

namespace FoodieFinder;

public partial class AppShellUser : Shell
{
	private readonly IServiceProvider _serviceProvider;

	public AppShellUser(IServiceProvider serviceProvider)
	{
		InitializeComponent();

		_serviceProvider = serviceProvider;

		Loaded += async (s, e) => await OnSharedRecipeIntentReceived();
		App.SharedRecipeIntentReceived += async () => await OnSharedRecipeIntentReceived();
	}

	private async Task OnSharedRecipeIntentReceived()
	{
		var recipeID = App.SharedRecipeID;
		if (recipeID != null)
		{
			var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            
            Recipe recipe;
			try
			{
                recipe = dbContext.Recipe.Where(r => r.Id == recipeID).Single();
            }
			catch
			{
				await DisplayAlert("Shared recipe error", "Shared recipe not found.", "OK");
                App.SharedRecipeID = null;
				return;
            }

            var userData = _serviceProvider.GetRequiredService<UserData>();
			if (recipe.UserId == userData.UserId)
			{
                await DisplayAlert("Shared recipe error", "You can't save your own recipe.", "OK");
                App.SharedRecipeID = null;
				return;
            }

            var popup = new SaveSharedRecipePopup(recipe.Name);
			var result = await this.ShowPopupAsync(popup);

			if (result is true)
			{
				
				dbContext.Recipe.Add(new Recipe()
				{
					Name = recipe.Name,
					Description = recipe.Description,
					Preparation = recipe.Preparation,
					UserId = userData.UserId
				});
				dbContext.SaveChanges();
                await Toast.Make("Recipe saved", ToastDuration.Long).Show();
            }

			App.SharedRecipeID = null;
        }
	}
}
