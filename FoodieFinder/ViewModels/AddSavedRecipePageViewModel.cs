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
using IdentityModel.OidcClient;

namespace FoodieFinder.ViewModels
{
    public partial class AddSavedRecipePageViewModel : BaseViewModel
    {
        public Recipe SavedOfflineItems { get; } = new();
        public ObservableCollection<Ingredient> IngredientItems { get; } = new();
        private List<Ingredient> IngredientList= new List<Ingredient>();

        [ObservableProperty]
        private string name;
        [ObservableProperty]
        private string description;
        [ObservableProperty]
        private string preparation;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(UserFirstLetter))]
        private string _welcomeUser;
        public string UserFirstLetter => WelcomeUser.First().ToString().ToUpper();

        [ObservableProperty]
        private string _addIngredientName = string.Empty;

        private readonly IServiceProvider _serviceProvider;
        private readonly AppDbContext _dbContext;
        private readonly UserAccount.UserData _userData;


        public AddSavedRecipePageViewModel(IServiceProvider serviceProvider)
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

            SavedOfflineItems = new Recipe();

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
            SavedOfflineItems.Name = Name;
            SavedOfflineItems.Description = Description;
            SavedOfflineItems.Preparation = Preparation;
            var userData = _serviceProvider.GetRequiredService<UserAccount.UserData>();
            SavedOfflineItems.UserId = userData.UserId;
            _dbContext.Recipe.Add(SavedOfflineItems);
            _dbContext.SaveChanges();
            int id_recipe = 0;
            foreach (var item2 in _dbContext.Recipe.Where(u => u.Preparation == Preparation))
            {
                id_recipe = item2.Id;
            }
            foreach (var item in IngredientList)
            {
                item.RecipeId = id_recipe;
                _dbContext.Ingredient.Add(item);
                _dbContext.SaveChanges();

            }

            //PRZEJ�CIE DO SavedRecipePage

        }
        [RelayCommand]
        private async Task AddIgredientItem()
        {
            var popup = new AddSavedRecipePopup();
            var result = await Application.Current.MainPage.ShowPopupAsync(popup) as Ingredient;
            IngredientList.Add(result);
            LoadIngredientItems();
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

            //PRZEJ�CIE DO SavedRecipePage
        }
        private async Task NotificationPopupSet()
        {
            var popup = new SetNotificationPopup();
            var result = (SetTimer)await Application.Current.MainPage.ShowPopupAsync(popup);
            // zmienna z czasem znajduje si� pod result.SetTime
            var not = new AndroidNotification();
            if (!not.CreateNotification(result.Hour, result.Minutes, result.Seconds))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Notification has not been established!", "OK");
            }


        }

    }
}
