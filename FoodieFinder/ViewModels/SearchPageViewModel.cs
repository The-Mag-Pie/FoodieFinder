using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.LocalJsonDatabase;
using FoodieFinder.Models;
using FoodieFinder.UserAccount;
using System.Collections.ObjectModel;

namespace FoodieFinder.ViewModels
{
    partial class SearchPageViewModel : BaseViewModel
    {

        public ObservableCollection<OnlineRecipe> SearchedRecipes { get; } = new();
        public ObservableCollection<OnlineRecipe> RecentSearch { get; } = new();
        [ObservableProperty]
        private bool _isYourRecipesVisible = false;
        [ObservableProperty]
        private string searched;

        [ObservableProperty]
        private string _addIngredientName = string.Empty;

        private readonly IServiceProvider _serviceProvider;
        private readonly AppDbContext _dbContext;
        private readonly UserData _userData;

        public SearchPageViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            _userData = _serviceProvider.GetRequiredService<UserData>();
            OnlineRecipe item = new OnlineRecipe();
            item.Id = 1;
            item.RecipeName = "Testowa";
            item.UserId = 1;
            SearchedRecipes.Add(item);
            SearchedRecipes.Add(item);
            SearchedRecipes.Add(item);
            RecentSearch.Add(item);
            RecentSearch.Add(item);
            RecentSearch.Add(item);

        }
        private void SearchItemTapped(OnlineRecipe ORecipe)
        {
            //----------------------------------
        }
        private void RecentSearchTapped(OnlineRecipe RecentSearchRecipe)
        {
            //----------------------------------
        }
        private void DeleteRecentSearchTapped(OnlineRecipe RecentSearchRecipe)
        {
            //----------------------------------
        }
        private void Search(OnlineRecipe RecentSearchRecipe)
        {
            //----------------------------------
        }
        private void FiltersTapped()
        {
            //----------------------------------
        }



    }
}
