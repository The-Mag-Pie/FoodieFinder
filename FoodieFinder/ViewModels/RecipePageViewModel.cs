using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.ObjectModel;
using FoodieFinder.UserAccount;

namespace FoodieFinder.ViewModels
{
    partial class RecipePageViewModel : BaseViewModel
    {
        public ObservableCollection<IngredientModel> Ingredients { get; } = new();
        [ObservableProperty]
        private Recipe tappedRecipe;
        private static List<StorageItem> StorageItems = new();
        private readonly IServiceProvider _serviceProvider;

        public RecipePageViewModel(IServiceProvider serviceProvider, Recipe recipe)
        {
            _serviceProvider = serviceProvider;
            tappedRecipe = recipe;

            var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            var userData = _serviceProvider.GetRequiredService <UserData>();

            StorageItems.Clear();
            foreach (var item in dbContext.StoreRoom.Where(u => u.User_UserId == userData.UserId))
            {
                StorageItems.Add(item);
            }

            foreach (var ingredient in dbContext.Ingredient.Where(i => i.RecipeId == recipe.Id))
            {
                Ingredients.Add(new()
                {
                    IngredientName = ingredient.Name,
                    Unit = ingredient.Unit,
                    Quantity = ingredient.Quantity,
                    IsChecked = IsIngredientInStorage(ingredient)
                });
            }
        }

        [RelayCommand]
        private async Task ShareButtonClicked()
        {
            var config = _serviceProvider.GetRequiredService<IConfiguration>();
            var configSection = config.GetRequiredSection("FoodieFinder");

            var domainName = configSection["DomainName"];
            var shareRecipeEndpoint = configSection["ShareRecipeEndpoint"];
            if (domainName == null || shareRecipeEndpoint == null) return;

            await Share.Default.RequestAsync(new ShareTextRequest()
            {
                Title = "Share recipe",
                Text = "Check out my recipe!",
                Uri = $"https://{domainName}/{shareRecipeEndpoint.Replace("{{recipeId}}", TappedRecipe.Id.ToString())}"
            });
        }

        [RelayCommand]
        private void Back()
        {
            Shell.Current.SendBackButtonPressed();
        }

        private static bool IsIngredientInStorage(Ingredient ingredient)
        {
            var matchedIngredient = StorageItems.Where(i => String.Equals(i.ProductName, ingredient.Name, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            if(matchedIngredient != null)
            {
                if(matchedIngredient.Unit == ingredient.Unit)
                {
                    return matchedIngredient.Quantity >= ingredient.Quantity;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
