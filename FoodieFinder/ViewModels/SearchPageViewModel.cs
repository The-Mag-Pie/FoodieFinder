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
        public ObservableCollection<Recipe> FoundRecipes { get; } = new();

        [ObservableProperty]
        private string _searchQuery;

        private readonly IServiceProvider _serviceProvider;
        private readonly SuggesticApiClient _apiClient;
        private readonly AppDbContext _dbContext;
        private readonly UserData _userData;
        private Filters FiltersSetup = new();

        public SearchPageViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _apiClient = serviceProvider.GetRequiredService<SuggesticApiClient>();
            _dbContext = serviceProvider.GetRequiredService<AppDbContext>();
            _userData = serviceProvider.GetRequiredService<UserData>();
            LoadRecentSearches();
        }


        [RelayCommand]
        private async Task FiltersTapped()
        {
            var popup = new FiltersPopup(FiltersSetup);
            var result = (Filters)await Application.Current.MainPage.ShowPopupAsync(popup);
            try
            {
                FiltersSetup = result;
                CheckFilters();
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
                var foundRecipes = await _apiClient.SearchRecipesByNameAsync(SearchQuery);

                FoundRecipes.Clear();
                foreach (var recipe in foundRecipes)
                {
                    FoundRecipes.Add(recipe);
                }
                CheckFilters();
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
            CheckFilters();
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
            CheckFilters();
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

            var items = RecentSearchesDb.GetItems();

            if (items.Count > 3)
            {
                items.Remove(items.First());
                RecentSearchesDb.SaveItems(items);
            }

            items.Reverse();
            foreach (var item in items)
            {
                RecentSearches.Add(item);
            }
        }
        private void AddStringToRecent(string searchRecent)
        {
            RecentSearchesDb.AddItem(searchRecent);
            LoadRecentSearches();
        }

        [RelayCommand]
        private void DeleteRecentSearch(string recent)
        {
            RecentSearchesDb.RemoveItem(recent);
            LoadRecentSearches();
        }
        private void CheckFilters()
        {

            if (FiltersSetup.NoMeat)
            {
                CheckIfMeat();
            }
            if (FiltersSetup.MaxIngredients > 0)
            {
                CheckMaxIngredients(FiltersSetup.MaxIngredients);
            }
            if (FiltersSetup.MaxPreparationTime > 0)
            {
                CheckMaxPrepTime(FiltersSetup.MaxPreparationTime);
            }
        }
        private void CheckIfMeat()
        {
            foreach (Recipe item in FoundRecipes.ToList())
            {
                if (checkifmeat2(item))
                {
                    FoundRecipes.Remove(item);
                }
            }  
        }
        private bool checkifmeat2(Recipe item)
        {
            string x = "";
            for (int i = 0; i <= item.Ingredients.Count(); i++)
            {
                foreach (string MeatListItem in meats)
                {
                    if (item.Ingredients[i].IngredientName.ToLower() == MeatListItem.ToLower())
                    {
                        return true;
                    }
                }        
            }
            return false;
        }
        private void CheckMaxIngredients(int IntIngredients)
        {
            foreach (Recipe item in FoundRecipes.ToList())
            {
                int i = item.Ingredients.Count();

                if (IntIngredients < i) { FoundRecipes.Remove(item); }
            }
        }
        private void CheckMaxPrepTime(int PrepTime)
        {
            foreach (Recipe item in FoundRecipes.ToList())
            {
                int? i = item.PreparationTime;

                if (i >= PrepTime) { FoundRecipes.Remove(item); }
            }
        }

        private static List<string> meats = new List<string>()
        {
            "Beef",
            "Pork",
            "Chicken",
            "Lamb",
            "Turkey",
            "Veal",
            "Venison",
            "Bison",
            "Duck",
            "Goose",
            "Quail",
            "Rabbit",
            "Kangaroo",
            "Ostrich",
            "Alligator",
            "Pheasant",
            "Boar",
            "Salmon",
            "Tuna",
            "Cod",
            "Haddock",
            "Trout",
            "Mackerel",
            "Sardine",
            "Halibut",
            "Swordfish",
            "Bass",
            "Snapper",
            "Anchovy",
            "Catfish",
            "Crab",
            "Lobster",
            "Shrimp",
            "Crayfish",
            "Mussels",
            "Clams",
            "Oysters",
            "Scallops",
            "Octopus",
            "Squid",
            "Escargot",
            "Frog legs",
            "Sweetbreads",
            "Tripe",
            "Kidneys",
            "Liver",
            "Heart",
            "Tongue",
            "Brains",
            "Cheeks",
            "Feet",
            "Tail",
            "Chorizo",
            "Pepperoni",
            "Bacon",
            "Ham",
            "Sausage",
            "Hot dog",
            "Salami",
            "Pastrami",
            "Prosciutto",
            "Corned beef",
            "Pate",
            "Ground beef",
            "Ground pork",
            "Ground chicken",
            "Ground lamb",
            "Ground turkey",
            "Ground veal",
            "Beef jerky",
            "Pork rinds",
            "Lamb chops",
            "Pork chops",
            "Chicken breast",
            "Chicken wings",
            "Chicken thighs",
            "Chicken drumsticks",
            "Chicken nuggets",
            "Chicken tenders",
            "Turkey breast",
            "Turkey legs",
            "Turkey bacon",
            "Duck breast",
            "Goose liver",
            "Quail eggs",
            "Rabbit stew",
            "Lobster bisque",
            "Crab cakes",
            "Shrimp cocktail",
            "Clam chowder",
            "Oyster stew",
            "Mussels marinara",
            "Calamari rings",
            "Frog legs provencal",
            "Escargot bourguignon",
            "Beef Wellington",
            "Lamb kebabs",
            "Chicken curry",
            "Turkey meatballs",
            "Duck confit",
            "Pork belly",
            "Bacon-wrapped scallops",
            "Ham and cheese sandwich",
            "Salami and provolone panini",
            "Pepperoni pizza",
            "Sausage and peppers",
            "Hot dog with sauerkraut",
            "Pastrami on rye",
            "Prosciutto-wrapped melon",
            "Corned beef hash",
            "Liver and onions",
            "Beef tongue tacos",
            "Grilled lamb chops",
            "Pork spare ribs",
            "Chicken kabobs",
            "Buffalo wings",
            "Turkey chili",
            "Duck a l'orange",
            "Gooseberry pie",
            "Rabbit pie",
            "Shrimp scampi",
            "Crab bisque",
            "Lobster roll",
            "Clam bake",
            "Oysters Rockefeller",
            "Scallops wrapped in bacon",
            "Octopus salad",
            "Squid ink pasta",
            "Frog legs sautéed",
            "Sweetbreads with mushrooms",
            "Tripe stew",
            "Kidney pie",
            "Liver pâté",
            "Heart skewers",
            "Tongue sandwich",
            "Brains and eggs",
            "Cheek tacos",
            "Chicken feet soup",
            "Oxtail stew",
            "Chorizo burrito",
            "Pepperoni calzone",
            "Bacon-wrapped filet mignon",
            "Ham and pineapple pizza",
            "Sausage gravy and biscuits",
            "Hot dog with chili and cheese",
            "Salami sandwich with mustard",
            "Pastrami Reuben",
            "Prosciutto-wrapped asparagus",
            "Corned beef and cabbage",
            "Beef stir-fry",
            "Pork fried rice",
            "Chicken noodle soup",
            "Turkey club sandwich",
            "Duck à l'orange",
            "Goose roast",
            "Quail stuffed with mushrooms",
            "Rabbit ragu",
            "Kangaroo steak",
            "Ostrich burger",
            "Alligator tail",
            "Bison burger",
            "Pheasant casserole"
        };
    }
}
