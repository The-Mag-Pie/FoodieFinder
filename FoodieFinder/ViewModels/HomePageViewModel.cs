using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.LocalJsonDatabase;
using FoodieFinder.Models;
using FoodieFinder.UserAccount;
using System.Collections.ObjectModel;

namespace FoodieFinder.ViewModels
{
    partial class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<HomePageRecipeModel> YourRecipes { get; } = new();
        public ObservableCollection<BucketListItem> BucketList { get; } = new();

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(UserFirstLetter))]
        private string _welcomeUser;

        public string UserFirstLetter => WelcomeUser.First().ToString();

        //[ObservableProperty]
        //private ImageSource _userImage = ImageSource.FromFile("mclovitch.png");

        private readonly AppDbContext _dbContext;
        private readonly UserData _userData;

        public HomePageViewModel(AppDbContext appDbContext, UserData userData)
        {
            _dbContext = appDbContext;
            _userData = userData;

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

            foreach (var recipe in _dbContext.Recipe.Where((r) => r.UserId == _userData.UserId))
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

        public void OnDisappearing()
        {
            Task.Run(() => BucketListDb.SaveItems(BucketList.ToList()));
        }

        [RelayCommand]
        private void BucketProductTapped(BucketListItem model)
        {
            model.IsChecked = !model.IsChecked;
        }

        [RelayCommand]
        private void AddBucketListItems()
        {
            BucketList.Add(new()
            {
                IsChecked = true,
                ProductName = "Milk"
            });

            BucketList.Add(new()
            {
                IsChecked = false,
                ProductName = "Lemon"
            });

            BucketList.Add(new()
            {
                IsChecked = false,
                ProductName = "Eggs 4pcs."
            });

            BucketList.Add(new()
            {
                IsChecked = false,
                ProductName = "Onion"
            });
        }
    }
}
