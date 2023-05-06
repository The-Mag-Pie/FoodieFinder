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
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace FoodieFinder.ViewModels
{
    public partial class SavedRecipePageViewModel : BaseViewModel
    {
        public ObservableCollection<Recipe> SavedOfflineItems { get; } = new();
        private static readonly string FullPath = Path.Combine(FileSystem.Current.AppDataDirectory, "SavedItems.json");

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(UserFirstLetter))]
        private string _welcomeUser;
        public string UserFirstLetter => WelcomeUser.First().ToString().ToUpper();

        [ObservableProperty]
        private string _addIngredientName = string.Empty;

        private readonly IServiceProvider _serviceProvider;
        private readonly AppDbContext _dbContext;
        private readonly UserAccount.UserData _userData;

        public SavedRecipePageViewModel(IServiceProvider serviceProvider)
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

            LoadSavedItems();
        }

        public void LoadSavedItems()
        {
            SavedOfflineItems.Clear();
            /*foreach (var item in _dbContext.Recipe.Where(u => u.UserId == _userData.UserId))
            {
                SavedOfflineItems.Add(item);
            }*/
            List<Recipe> SRecipe = new List<Recipe> { };
            try
            {
                var log = new Login(_serviceProvider);
                foreach (var item in _dbContext.Recipe.Where(u => u.UserId == _userData.UserId))
                {
                    //SavedOfflineItems.Add(item);

                    //zapisywanie do nowego pliku danych z bazy
                    SRecipe.Add(item);
                }
                string jsonString = JsonConvert.SerializeObject(SRecipe);
                File.WriteAllText(FullPath, jsonString);
                
            }
            catch
            {
                Application.Current.MainPage.DisplayAlert("Error", "Cannot connect to the server", "OK");
            }
            // odczytywanie z tego pliku do aplikacji
            try
            {
                string FileContent = File.ReadAllText(FullPath);
                SRecipe = JsonConvert.DeserializeObject<List<Recipe>>(FileContent);
                foreach (Recipe item in SRecipe)
                {
                    SavedOfflineItems.Add(item);
                }
            }
            catch
            {
                Application.Current.MainPage.DisplayAlert("Error", "nr2", "OK");
            }
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
        private void AddSavedItem()
        {
            Shell.Current.GoToAsync("AddSavedRecipePage"); //Przejœcie do AddSavedRecipe
            LoadSavedItems();
        }

        [RelayCommand]
        private async Task SavedItemTapped(Recipe RecipeIt)
        {
            Application.Current.MainPage.DisplayAlert("Error", RecipeIt.Preparation, "OK");
            /*var popup = new StorageItemPopup(RecipeIt);
            var result = (string)await Application.Current.MainPage.ShowPopupAsync(popup);

            switch (result)
            {

                default: break;
            }*/
        }
        [RelayCommand]
        private void DeleteSavedRecipe(Recipe RecipeIt)
        {
            //Application.Current.MainPage.DisplayAlert("Error", RecipeIt.Id.ToString()+" "+RecipeIt.Name, "OK");
            
            foreach (var item in _dbContext.Ingredient.Where(u => u.RecipeId == RecipeIt.Id))
            {
                _dbContext.Ingredient.Remove(item);
            }

            _dbContext.ChangeTracker.Clear();
            _dbContext.Recipe.Remove(RecipeIt);

            _dbContext.SaveChanges();

            LoadSavedItems();
        }
        [RelayCommand]
        private void ModifySavedRecipe(Recipe RecipeIt)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "Recipe", RecipeIt }
            };
            Shell.Current.GoToAsync($"ModifySavedRecipePage", navigationParameter);
            LoadSavedItems();
        }
        private async Task NotificationPopupSet()
        {
            var popup = new SetNotificationPopup();
            var result = (SetTimer)await Application.Current.MainPage.ShowPopupAsync(popup);
            // zmienna z czasem znajduje siê pod result.SetTime
            var not = new AndroidNotification();
            if (!not.CreateNotification(result.Hour, result.Minutes, result.Seconds))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Notification has not been established!", "OK");
            }


        }

    }
}
