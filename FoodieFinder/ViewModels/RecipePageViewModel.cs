using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.Models;
using FoodieFinder.Pages;
using FoodieFinder.Popups;
using FoodieFinder.UserAccount;
using Microsoft.Extensions.Configuration;
using System.Collections.ObjectModel;

namespace FoodieFinder.ViewModels
{
    partial class RecipePageViewModel : BaseViewModel
    {

        public ObservableCollection<IngredientModel> Ingredients { get; } = new(); 

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(UserFirstLetter))]
        private string _welcomeUser;
        public string UserFirstLetter => WelcomeUser.First().ToString().ToUpper();
        private readonly IServiceProvider _serviceProvider;

        public RecipePageViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            var userData = _serviceProvider.GetRequiredService<UserData>();

            var username = userData.UserName;
            var atIdx = username.LastIndexOf('@');
            if (atIdx > -1)
            {
                WelcomeUser = username[..atIdx];
            }
            else
            {
                WelcomeUser = username;
            }

            Ingredients.Add(new()
            {
                IngredientName = "Avocado",
                Quantity = 3,
                Unit = "pcs",
                IsChecked = true
                
            });
            Ingredients.Add(new()
            {
                IngredientName = "Lime",
                Quantity = 1,
                Unit = "pcs",
                IsChecked = false

            });
            Ingredients.Add(new()
            {
                IngredientName = "Salt",
                Quantity = 1,
                Unit = "tbs",
                IsChecked = true

            });
            Ingredients.Add(new()
            {
                IngredientName = "Cilantro",
                Quantity = 3,
                Unit = "tbs",
                IsChecked = false

            });
            Ingredients.Add(new()
            {
                IngredientName = "Plum tomatoes",
                Quantity = 2,
                Unit = "pcs",
                IsChecked = false

            });
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
                Uri = $"https://{domainName}/{shareRecipeEndpoint.Replace("{{recipeId}}", 5.ToString())}" // TODO: recipe id
            });
        }

        private async Task NotificationPopupSet()
        {
            var popup = new SetNotificationPopup();
            var result = (SetTimer)await Application.Current.MainPage.ShowPopupAsync(popup);
            // zmienna z czasem znajduje się pod result.SetTime

        }
    }

}
