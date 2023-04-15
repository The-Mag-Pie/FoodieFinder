using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.Models;
using FoodieFinder.Pages;
using FoodieFinder.Popups;
using FoodieFinder.UserAccount;
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

                default: break;
            }
        }
    }

}
