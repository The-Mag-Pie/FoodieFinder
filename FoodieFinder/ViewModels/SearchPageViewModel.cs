using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.Popups;
using FoodieFinder.SuggesticAPI;
using FoodieFinder.UserAccount;
using System.Collections.ObjectModel;
using Recipe = FoodieFinder.SuggesticAPI.Models.Recipe;

namespace FoodieFinder.ViewModels
{
    partial class SearchPageViewModel : BaseViewModel
    {
        private static string _buildAlertMessage(Recipe recipe)
        {
            var message = string.Empty;

            if (recipe.PreparationTime is not null)
                message = $"Preparation time: {recipe.PreparationTime / 60} minutes";
            else
                message = "Preparation time: not specified";

            var ingredientsStrings = recipe.Ingredients.Select(r =>
            {
                var str = string.Empty;
                if (r.Quantity is not null)
                {
                    str = r.Quantity + " ";
                    if (r.Unit is not null)
                        str += r.Unit + " of ";
                }
                str += r.IngredientName;
                return str;
            });

            if (ingredientsStrings.Count() > 0)
                message += "\n\nIngredients:\n" + string.Join("\n", ingredientsStrings);

            if (recipe.Instructions.Count > 0)
                message += "\n\nPreparation:\n" + string.Join("\n", recipe.Instructions);

            return message;
        }

        //public ObservableCollection<string> RecentSearches { get; } = new();
        public ObservableCollection<Recipe> FoundRecipes { get; } = new();

        [ObservableProperty]
        private string _searchQuery;

        private readonly IServiceProvider _serviceProvider;
        private readonly SuggesticApiClient _apiClient;
        private readonly AppDbContext _dbContext;
        private readonly UserData _userData;

        public SearchPageViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _apiClient = serviceProvider.GetRequiredService<SuggesticApiClient>();
            _dbContext = serviceProvider.GetRequiredService<AppDbContext>();
            _userData = serviceProvider.GetRequiredService<UserData>();
        }

        [RelayCommand]
        private void FiltersTapped()
        {
            //----------------------------------
        }

        [RelayCommand]
        private async Task Search()
        {
            if (SearchQuery is null || SearchQuery.Length == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Recipe name is empty", "OK");
                return;
            }

            await InvokeAsyncWithLoader(async () =>
            {
                var foundRecipes = await _apiClient.SearchRecipesByNameAsync(SearchQuery);

                FoundRecipes.Clear();
                foreach (var recipe in foundRecipes)
                {
                    FoundRecipes.Add(recipe);
                }
            });
        }

        [RelayCommand]
        private async Task SearchByIngredients()
        {
            var popup = new SelectIngredientsPopup(_serviceProvider);
            var selectedIngredients = await Application.Current.MainPage.ShowPopupAsync(popup) as List<string>;

            SearchQuery = string.Empty;

            if (selectedIngredients == null) return;

            await InvokeAsyncWithLoader(async () =>
            {
                var foundRecipes = await _apiClient.SearchRecipesByIngredientsAsync(selectedIngredients);

                FoundRecipes.Clear();
                foreach (var recipe in foundRecipes)
                {
                    FoundRecipes.Add(recipe);
                }
            });
        }
        [RelayCommand]
        private async Task SurpriseMeSearch()
        {
            List <string> item1 = new List<string>();
            foreach (var item in _dbContext.StoreRoom.Where(u => u.User_UserId == _userData.UserId))
            {
                item1.Add(item.ProductName);
            }
            for (int i = item1.Count; i>2; i--)
            {
                Random rnd = new Random();
                item1.Remove(item1[rnd.Next(0, item1.Count)]);
            }
            var selectedIngredients = item1;

            SearchQuery = string.Empty;

            if (selectedIngredients == null) return;

            await InvokeAsyncWithLoader(async () =>
            {
                var foundRecipes = await _apiClient.SearchRecipesByIngredientsAsync(selectedIngredients);

                FoundRecipes.Clear();
                foreach (var recipe in foundRecipes)
                {
                    FoundRecipes.Add(recipe);
                }
            });
        }

        [RelayCommand]
        private async Task SearchItemTapped(Recipe recipe)
        {
            var message = _buildAlertMessage(recipe);
            var result = await Application.Current.MainPage.DisplayAlert(recipe.Name, message, "Save recipe", "Cancel");

            if (result) SaveRecipe(recipe);
        }

        private void SaveRecipe(Recipe recipe)
        {
            var onlineRecipe = new OnlineRecipe()
            {
                RecipeApiId = recipe.ID,
                RecipeName = recipe.Name,
                UserId = _userData.UserId
            };

            _dbContext.OnlineRecipe.Add(onlineRecipe);

            if (_dbContext.SaveChanges() > 0)
                //Application.Current.MainPage.DisplaySnackbar("Recipe has been saved.");
                Toast.Make("Recipe has been saved.", CommunityToolkit.Maui.Core.ToastDuration.Long).Show();
        }

        //private void RecentSearchTapped(string searchQuery)
        //{
        //    //----------------------------------
        //}
        //private void DeleteRecentSearchTapped(string searchQuery)
        //{
        //    //----------------------------------
        //}
    }
}
