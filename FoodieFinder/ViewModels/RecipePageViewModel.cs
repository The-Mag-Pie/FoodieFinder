using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.ObjectModel;
using FoodieFinder.UserAccount;
using FoodieFinder.LocalJsonDatabase;

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
            var matchedIngredient = StorageItems.Where(i => IsStringSimilar(i.ProductName, ingredient.Name)).FirstOrDefault();
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

        [RelayCommand]
        private void GenerateBucketList()
        {
            List<BucketListItem> BucketList = BucketListDb.GetItems();

            foreach (var ingredient in Ingredients)
            {
                if (ingredient.IsChecked)
                {
                    continue;
                }

                if(!BucketList.Where(x => IsStringSimilar(ingredient.IngredientName, x.ProductName)).Any())
                { 
                    BucketListItem item = new BucketListItem();
                    item.ProductName = ingredient.IngredientName;
                    item.IsChecked = false;
                    BucketList.Add(item);
                    BucketListDb.SaveItems(BucketList);
                    Application.Current.MainPage.DisplayAlert("Success", "Missing ingredients have been added to the bucket list", "Ok");
                }

            }


        }
    }
}
