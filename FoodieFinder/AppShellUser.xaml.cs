using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using FoodieFinder.Database;
using FoodieFinder.Popups;
using FoodieFinder.SuggesticAPI;
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
		if (recipeID is not null)
            await HandleSharedRecipe(recipeID);

        var onlineRecipeID = App.SharedOnlineRecipeID;
        if (onlineRecipeID is not null)
            await HandleSharedOnlineRecipe(onlineRecipeID);
    }

	private async Task HandleSharedRecipe(int? recipeID)
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

    private async Task HandleSharedOnlineRecipe(string recipeID)
    {
        var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
        var apiClient = _serviceProvider.GetRequiredService<SuggesticApiClient>();
        var userData = _serviceProvider.GetRequiredService<UserData>();

        var onlineRecipe = await apiClient.GetRecipeById(recipeID);

        if (onlineRecipe is null)
        {
            await DisplayAlert("Shared recipe error", "Shared recipe not found.", "OK");
            App.SharedOnlineRecipeID = null;
            return;
        }

        var isOnlineRecipeSavedByUser = dbContext.OnlineRecipe
            .Where(r => r.UserId == userData.UserId)
            .Any(r => r.RecipeApiId == recipeID);

        if (isOnlineRecipeSavedByUser)
        {
            await DisplayAlert("Shared recipe error", "This recipe has been previously saved by you.", "OK");
            App.SharedOnlineRecipeID = null;
            return;
        }

        var popup = new SaveSharedRecipePopup(onlineRecipe.Name);
        var result = await this.ShowPopupAsync(popup);

        if (result is true)
        {
            dbContext.OnlineRecipe.Add(new()
            {
                RecipeApiId = recipeID,
                RecipeName = onlineRecipe.Name,
                UserId = userData.UserId
            });

            dbContext.SaveChanges();
            await Toast.Make("Recipe saved", ToastDuration.Long).Show();
        }

        App.SharedOnlineRecipeID = null;
    }
}
