using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using ApiRecipe = FoodieFinder.SuggesticAPI.Models.Recipe;
using FoodieFinder.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.ObjectModel;
using FoodieFinder.UserAccount;
using FoodieFinder.SuggesticAPI.Models;

namespace FoodieFinder.ViewModels
{
    partial class OnlineRecipeDetailsPageViewModel : BaseViewModel
    {
        public ObservableCollection<ApiIngredientModel> Ingredients { get; } = new();

        [ObservableProperty]
        private ApiRecipe _tappedRecipe;

        private readonly List<StorageItem> StorageItems = new();

        private readonly IServiceProvider _serviceProvider;

        public OnlineRecipeDetailsPageViewModel(IServiceProvider serviceProvider, ApiRecipe recipe)
        {
            _serviceProvider = serviceProvider;
            TappedRecipe = recipe;

            var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            var userData = _serviceProvider.GetRequiredService <UserData>();

            StorageItems.Clear();
            foreach (var item in dbContext.StoreRoom.Where(u => u.User_UserId == userData.UserId))
            {
                StorageItems.Add(item);
            }

            foreach (var ingredient in recipe.Ingredients)
            {
                Ingredients.Add(new()
                {
                    IngredientName = ingredient.IngredientName,
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
                Uri = $"https://{domainName}/{shareRecipeEndpoint.Replace("{{recipeId}}", TappedRecipe.ID)}"
            });
        }

        [RelayCommand]
        private void Back()
        {
            Shell.Current.SendBackButtonPressed();
        }

        private bool IsIngredientInStorage(IngredientLine ingredient)
        {
            var matchedIngredient = StorageItems.Where(i => IsStringSimilar(i.ProductName, ingredient.IngredientName)).FirstOrDefault();

            if(matchedIngredient != null)
                return true;
            else
                return false;
        }

        private static bool IsStringSimilar(string word, string input)
        {
            word = word.ToLower();
            input = input.ToLower();
            if (word == input)
            {
                return true;
            }

            if (Math.Abs(word.Length - input.Length) > 1)
            {
                return false;
            }

            string shorter = word.Length < input.Length ? word : input;
            string longer = word.Length < input.Length ? input : word;

            bool foundMismatch = false;
            int shorterIndex = 0;
            int longerIndex = 0;

            while (shorterIndex < shorter.Length && longerIndex < longer.Length)
            {
                if (shorter[shorterIndex] != longer[longerIndex])
                {
                    if (foundMismatch)
                    {
                        return false;
                    }
                    foundMismatch = true;

                    if (shorter.Length == longer.Length)
                    {
                        shorterIndex++;
                    }
                }
                else
                {
                    shorterIndex++;
                }
                longerIndex++;
            }

            return true;
        }
    }
}
