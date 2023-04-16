using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Views;
using FoodieFinder.Database;
using FoodieFinder.LocalJsonDatabase;
using FoodieFinder.Models;
using FoodieFinder.Popups;
using FoodieFinder.UserAccount;
using System.Collections.ObjectModel;
using FoodieFinder.Pages;
using Microsoft.Extensions.Configuration;

namespace FoodieFinder.ViewModels
{
    partial class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<HomePageRecipeModel> YourRecipes { get; } = new();
        public ObservableCollection<BucketListItem> BucketList { get; } = new();

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(UserFirstLetter))]
        private string _welcomeUser;

        public string UserFirstLetter => WelcomeUser.First().ToString().ToUpper();

        [ObservableProperty]
        private bool _isYourRecipesVisible = false;

        [ObservableProperty]
        private string _addIngredientName = string.Empty;

        //[ObservableProperty]
        //private ImageSource _userImage = ImageSource.FromFile("mclovitch.png");

        private readonly IServiceProvider _serviceProvider;

        public HomePageViewModel(IServiceProvider serviceProvider)
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

            IsYourRecipesVisible = !userData.IsGuest;

            //for (int i = 1; i <= 5; i++)
            //{
            //    _dbContext.Recipe.Add(new()
            //    {
            //        Name = $"recipe {i}",
            //        Description = $"recipe {i} description",
            //        Preparation = $"recipe {i} preparation",
            //        UserId = 0
            //    });
            //}

            //_dbContext.SaveChanges();

            foreach (var recipe in dbContext.Recipe.Where((r) => r.UserId == userData.UserId))
            {
                YourRecipes.Add(new()
                {
                    RecipeName = recipe.Name,
                    //Image = ImageSource.FromFile("pesto_pasta.png")
                    Image = ImageSource.FromFile("guacamole.png")
                    //Image = ImageSource.FromFile("thai_soup.png")
                });
            }

            foreach (var bucketItem in BucketListDb.GetItems())
            {
                BucketList.Add(bucketItem);
            }
        }

        [RelayCommand]
        private void RecipeTapped(HomePageRecipeModel recipe)
        {
            Shell.Current.GoToAsync("//HomePage3");
        }

        [RelayCommand]
        public void SaveBucketList()
        {
            Task.Run(() => BucketListDb.SaveItems(BucketList.ToList()));
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
        private void BucketProductTapped(BucketListItem model)
        {
            model.IsChecked = !model.IsChecked;
            SaveBucketList();
        }

        [RelayCommand]
        private void AddBucketListItem()
        {
            if (AddIngredientName.Length == 0)
            {
                Application.Current.MainPage.DisplayAlert("Error", "Ingredient name is empty!", "OK");
                return;
            }

            BucketList.Add(new()
            {
                IsChecked = false,
                ProductName = AddIngredientName
            });

            SaveBucketList();

            AddIngredientName = string.Empty;
        }

        [RelayCommand]
        private void RemoveBucketListItem(BucketListItem item)
        {
            BucketList.Remove(item);
            SaveBucketList();
        }
        private async Task NotificationPopupSet()
        {
            var popup = new SetNotificationPopup();
            var result = (SetTimer)await Application.Current.MainPage.ShowPopupAsync(popup);
            // zmienna z czasem znajduje się pod result.SetTime

        }
    }
}
