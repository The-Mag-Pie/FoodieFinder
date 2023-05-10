using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Views;
using FoodieFinder.Database;
using FoodieFinder.Models;
using FoodieFinder.Popups;
using FoodieFinder.UserAccount;
using System.Collections.ObjectModel;
using FoodieFinder.Pages;
using FoodieFinder.Notification;

namespace FoodieFinder.ViewModels
{
    public partial class ModifySavedRecipePageViewModel : BaseViewModel
    {
        public Recipe SavedOfflineItems { get; } = new();
        public ObservableCollection<Ingredient> IngredientItems { get; } = new();
        private List<Ingredient> IngredientList = new List<Ingredient>();

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(UserFirstLetter))]
        private string _welcomeUser;
        public string UserFirstLetter => WelcomeUser.First().ToString().ToUpper();

        [ObservableProperty]
        public Recipe modifiedRecipe;

        [ObservableProperty]
        private string _addIngredientName = string.Empty;

        private readonly IServiceProvider _serviceProvider;
        private readonly AppDbContext _dbContext;
        private readonly UserAccount.UserData _userData;
        private IEnumerable<Recipe> currentRecipe;


        public ModifySavedRecipePageViewModel(IServiceProvider serviceProvider, Recipe recipe)
        {
            _serviceProvider = serviceProvider;
            _userData = _serviceProvider.GetRequiredService<UserAccount.UserData>();
            _dbContext = _serviceProvider.GetRequiredService<AppDbContext>();

            var username = _userData.UserName;
            var atIdx = username.LastIndexOf('@');
            if (atIdx > -1)
            {
                WelcomeUser = username[..atIdx];
            }
            else
            {
                WelcomeUser = username;
            }
           
            ModifiedRecipe = recipe;

            foreach (var item in _dbContext.Ingredient.Where(u => u.RecipeId == ModifiedRecipe.Id))
            {
                IngredientList.Add(item);
            }
            LoadIngredientItems();

            currentRecipe = (IEnumerable<Recipe>)_dbContext.Recipe.Where(u => u.Id == ModifiedRecipe.Id);
        }

        [RelayCommand]
        private async Task UserOptionsTapped()
        {
            var popup = new UserOptionsPopup();
            var result = (string)await Application.Current.MainPage.ShowPopupAsync(popup);

            switch (result)
            {
                case "logout":
                    var log = new Login(_serviceProvider);
                    log.DestroySession();
                    Application.Current.MainPage = new StartNavigationPage(_serviceProvider);
                    break;
                case "notification":
                    NotificationPopupSet();

                    break;
                default: break;

            }
        }
        [RelayCommand]
        private void ModifySavedItem()
        {
            if (ModifiedRecipe.Name != String.Empty && ModifiedRecipe.Description != String.Empty &&
                ModifiedRecipe.Preparation != String.Empty && IngredientList.Count > 0)
            {
                currentRecipe.First().Name = ModifiedRecipe.Name;
                currentRecipe.First().Description = ModifiedRecipe.Description;
                currentRecipe.First().Preparation = ModifiedRecipe.Preparation;

                foreach (var ingredient in _dbContext.Ingredient.Where(u => u.RecipeId == ModifiedRecipe.Id))
                {
                    _dbContext.Ingredient.Remove(ingredient);
                }

                _dbContext.SaveChanges();

                foreach (var ingredient in IngredientItems)
                {
                    ingredient.Id = 0;
                    ingredient.RecipeId = ModifiedRecipe.Id;
                    _dbContext.Ingredient.Add(ingredient);
                }

                _dbContext.SaveChanges();

                Back(); //PRZEJŚCIE DO SavedRecipePage
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "You must enter all the data, to add the recipe!", "OK");
            }
        }
        [RelayCommand]
        private async Task AddIgredientItem()
        {
            var popup = new AddSavedRecipePopup();
            var result = await Application.Current.MainPage.ShowPopupAsync(popup) as Ingredient;
            if (result.Name != String.Empty && result.Quantity > 0 && result.Unit != String.Empty)
            {
                IngredientList.Add(result);
                LoadIngredientItems();
            }
        }
        [RelayCommand]
        private void DeleteIgredientItem(Ingredient IngredientIt)
        {
            IngredientList.Remove(IngredientIt);
            LoadIngredientItems();
        }
        private void LoadIngredientItems()
        {
            IngredientItems.Clear();

            foreach (var item in IngredientList)
            {
                IngredientItems.Add(item);
            }
        }
        [RelayCommand]
        private void Back()
        {
            Shell.Current.SendBackButtonPressed();
        }
        private async Task NotificationPopupSet()
        {
            var popup = new SetNotificationPopup();
            var result = (SetTimer)await Application.Current.MainPage.ShowPopupAsync(popup);
            // zmienna z czasem znajduje się pod result.SetTime
            var not = new AndroidNotification();
            if (!not.CreateNotification(result.Hour, result.Minutes, result.Seconds))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Notification has not been established!", "OK");
            }


        }

    }
}
