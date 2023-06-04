using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.Models;
using FoodieFinder.LocalJsonDatabase;
using FoodieFinder.Popups;
using FoodieFinder.SuggesticAPI;
using FoodieFinder.UserAccount;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Runtime.ExceptionServices;
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

        public ObservableCollection<string> RecentSearches { get; } = new();
        public ObservableCollection<Recipe> FoundRecipesFiltered { get; } = new();

        [ObservableProperty]
        private string _searchQuery;

        private readonly IServiceProvider _serviceProvider;
        private readonly SuggesticApiClient _apiClient;
        private readonly AppDbContext _dbContext;
        private readonly UserData _userData;

        private Filters FiltersSetup = new();
        private List<Recipe> FoundRecipes = new();

        public SearchPageViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _apiClient = serviceProvider.GetRequiredService<SuggesticApiClient>();
            _dbContext = serviceProvider.GetRequiredService<AppDbContext>();
            _userData = serviceProvider.GetRequiredService<UserData>();
            LoadRecentSearches();
        }

        private void FilterFoundRecipesAndShow()
        {
            var foundRecipes = FoundRecipes as IEnumerable<Recipe>;

            var noMeat = FiltersSetup.NoMeat;
            var maxIngredients = FiltersSetup.MaxIngredients;
            var maxPreparationTime = FiltersSetup.MaxPreparationTime;

            if (noMeat)
            {
                foundRecipes = foundRecipes.Where(r => r.Ingredients.All(i => Meats.Any(m => i.IngredientName.ToLower().Contains(m)) == false));
            }
            if (maxIngredients > 0)
            {
                foundRecipes = foundRecipes.Where(r => r.Ingredients.Count <= maxIngredients);
            }
            if (maxPreparationTime > 0)
            {
                foundRecipes = foundRecipes.Where(r => (r.PreparationTime / 60) <= maxPreparationTime);
            }

            FoundRecipesFiltered.Clear();
            foreach (var recipe in  foundRecipes)
            {
                FoundRecipesFiltered.Add(recipe);
            }
        }

        [RelayCommand]
        private async Task FiltersTapped()
        {
            var popup = new FiltersPopup(FiltersSetup);
            var result = (Filters)await Application.Current.MainPage.ShowPopupAsync(popup);
            try
            {
                FiltersSetup = result;
                //await SearchWithFilters();
                FilterFoundRecipesAndShow();
            }catch(Exception ex) { }
        }

        [RelayCommand]
        private async Task Search()
        {
            if (SearchQuery is null || SearchQuery.Length == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Recipe name is empty", "OK");
                return;
            }
            //kod na recent searches
            AddStringToRecent(SearchQuery);
            await InvokeAsyncWithLoader(async () =>
            {
                FoundRecipes = await _apiClient.SearchRecipesByNameAsync(SearchQuery);
            });
            FilterFoundRecipesAndShow();
        }
        //private async Task SearchWithFilters()
        //{
        //    if (SearchQuery is null || SearchQuery.Length == 0)
        //    {
        //        await Application.Current.MainPage.DisplayAlert("Error", "Recipe name is empty", "OK");
        //        return;
        //    }
        //    await InvokeAsyncWithLoader(async () =>
        //    {
        //        var foundRecipes = await _apiClient.SearchRecipesByNameAsync(SearchQuery);

        //        FoundRecipes.Clear();
        //        foreach (var recipe in foundRecipes)
        //        {
        //            FoundRecipes.Add(recipe);
        //        }

        //    });
        //    FilterFoundRecipesAndShow();
        //}

        [RelayCommand]
        private async Task SearchByIngredients()
        {
            var popup = new SelectIngredientsPopup(_serviceProvider);
            var selectedIngredients = await Application.Current.MainPage.ShowPopupAsync(popup) as List<string>;

            SearchQuery = string.Empty;

            if (selectedIngredients == null) return;

            await InvokeAsyncWithLoader(async () =>
            {
                FoundRecipes = await _apiClient.SearchRecipesByIngredientsAsync(selectedIngredients);
            });
            FilterFoundRecipesAndShow();
        }
        [RelayCommand]
        private async Task SurpriseMeSearch()
        {
            List <string> item1 = new List<string>();
            foreach (var item in _dbContext.StoreRoom.Where(u => u.User_UserId == _userData.UserId))
            {
                if (FiltersSetup.NoMeat && Meats.Any(m => item.ProductName.ToLower().Contains(m)))
                    continue;
                else
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
                FoundRecipes = await _apiClient.SearchRecipesByIngredientsAsync(selectedIngredients);
            });
            FilterFoundRecipesAndShow();
        }

        [RelayCommand]
        private async Task SearchItemTapped(Recipe recipe)
        {
            var message = _buildAlertMessage(recipe);
            var result = await Application.Current.MainPage.DisplayAlert(recipe.Name, message, "Save recipe", "Cancel");

            if (result)
            {
                if (_userData.IsGuest)
                {
                    await Application.Current.MainPage.DisplayAlert("Recipe error", "You have to be logged in to save the recipe.", "OK");
                }
                else
                {
                    SaveRecipe(recipe);
                }
            }
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

        [RelayCommand]
        private void RecentSearchTapped(string searchRecent)
        {
            DeleteRecentSearch(searchRecent);
            SearchQuery = searchRecent;
            Search();

        }
        private void LoadRecentSearches()
        {
            RecentSearches.Clear();

            var items = RecentSearchesDb.GetItems(_userData.UserId);

            if (items.Count > 3)
            {
                items.Remove(items.First());
                RecentSearchesDb.SaveItems(items, _userData.UserId);
            }

            items.Reverse();
            foreach (var item in items)
            {
                RecentSearches.Add(item);
            }
        }
        private void AddStringToRecent(string searchRecent)
        {
            RecentSearchesDb.AddItem(searchRecent, _userData.UserId);
            LoadRecentSearches();
        }

        [RelayCommand]
        private void DeleteRecentSearch(string recent)
        {
            RecentSearchesDb.RemoveItem(recent, _userData.UserId);
            LoadRecentSearches();
        }
        //private void CheckFilters()
        //{

        //    if (FiltersSetup.NoMeat)
        //    {
        //        CheckIfMeat();
        //    }
        //    if (FiltersSetup.MaxIngredients > 0)
        //    {
        //        CheckMaxIngredients(FiltersSetup.MaxIngredients);
        //    }
        //    if (FiltersSetup.MaxPreparationTime > 0)
        //    {
        //        CheckMaxPrepTime(FiltersSetup.MaxPreparationTime);
        //    }
        //}
        //private void CheckIfMeat()
        //{
        //    foreach (Recipe item in FoundRecipes.ToList())
        //    {
        //        if (checkifmeat2(item))
        //        {
        //            FoundRecipes.Remove(item);
        //        }
        //    }  
        //}
        //private bool checkifmeat2(Recipe item)
        //{
        //    for (int i = 0; i <= item.Ingredients.Count(); i++)
        //    {
        //        if (meats.Any(meats => item.Ingredients[i].IngredientName.ToLower().Contains(meats, StringComparison.OrdinalIgnoreCase)))
        //        {
        //            return true;
        //        }     
        //    }
        //    return false;
        //}
        //private void CheckMaxIngredients(int IntIngredients)
        //{
        //    foreach (Recipe item in FoundRecipes.ToList())
        //    {
        //        int i = item.Ingredients.Count();

        //        if (IntIngredients < i) { 
        //            FoundRecipes.Remove(item); }
        //    }
        //}
        //private void CheckMaxPrepTime(int PrepTime)
        //{
        //    foreach (Recipe item in FoundRecipes.ToList())
        //    {
        //        int? i = item.PreparationTime;

        //        if (i >= PrepTime*60) { 
        //            FoundRecipes.Remove(item); }
        //    }
        //}

        private static List<string> Meats = new List<string>()
        {
            "beef",
            "pork",
            "chicken",
            "lamb",
            "turkey",
            "veal",
            "venison",
            "bison",
            "duck",
            "goose",
            "quail",
            "rabbit",
            "kangaroo",
            "ostrich",
            "alligator",
            "pheasant",
            "boar",
            "salmon",
            "tuna",
            "cod",
            "haddock",
            "trout",
            "mackerel",
            "sardine",
            "halibut",
            "swordfish",
            "bass",
            "snapper",
            "anchovy",
            "catfish",
            "crab",
            "lobster",
            "shrimp",
            "crayfish",
            "mussels",
            "clams",
            "oysters",
            "scallops",
            "octopus",
            "squid",
            "escargot",
            "frog",
            "sweetbreads",
            "tripe",
            "kidneys",
            "liver",
            "heart",
            "tongue",
            "brains",
            "cheeks",
            "feet",
            "tail",
            "chorizo",
            "pepperoni",
            "bacon",
            "ham",
            "sausage",
            "salami",
            "pastrami",
            "prosciutto",
            "pate",
        };
    }
}
