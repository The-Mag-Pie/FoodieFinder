using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.SuggesticAPI;
using FoodieFinder.SuggesticAPI.Models;
using System.Collections.ObjectModel;

namespace FoodieFinder.ViewModels
{
    partial class SearchPageViewModel : BaseViewModel
    {
        //public ObservableCollection<string> RecentSearches { get; } = new();
        public ObservableCollection<Recipe> FoundRecipes { get; } = new();

        [ObservableProperty]
        private string _searchQuery;

        private readonly SuggesticApiClient _apiClient;

        public SearchPageViewModel(SuggesticApiClient apiClient)
        {
            _apiClient = apiClient;
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
        private void SearchItemTapped(Recipe recipe)
        {
            Application.Current.MainPage.DisplayAlert(
                recipe.Name,
                $"Preparation time: {recipe.PreparationTime / 60} minutes\n\nIngredients:\n{string.Join("\n", recipe.Ingredients.Select(r => r.Quantity + " " + r.Unit + " of " + r.IngredientName))}",
                "OK");
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
