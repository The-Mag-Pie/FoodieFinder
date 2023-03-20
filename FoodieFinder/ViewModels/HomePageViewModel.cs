using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.Models;
using System.Collections.ObjectModel;

namespace FoodieFinder.ViewModels
{
    partial class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<HomePageRecipeModel> YourRecipes { get; } = new();
        public ObservableCollection<HomePageBucketProductModel> BucketList { get; } = new();

        [ObservableProperty]
        private string _welcome = "Welcome, user";

        [ObservableProperty]
        private ImageSource _userImage = ImageSource.FromFile("mclovitch.png");

        private AppDbContext _dbContext;

        public HomePageViewModel(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;

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

            foreach (var recipe in _dbContext.Recipe)
            {
                YourRecipes.Add(new()
                {
                    RecipeName = recipe.Name,
                    //Image = ImageSource.FromFile("pesto_pasta.png")
                    Image = ImageSource.FromFile("guacamole.png")
                    //Image = ImageSource.FromFile("thai_soup.png")
                });
            }

            BucketList.Add(new HomePageBucketProductModel
            {
                ProductName = "Milk",
                IsChecked = true
            });

            BucketList.Add(new HomePageBucketProductModel
            {
                ProductName = "Lemon",
                IsChecked = false
            });

            BucketList.Add(new HomePageBucketProductModel
            {
                ProductName = "Eggs 4pcs.",
                IsChecked = false
            });

            BucketList.Add(new HomePageBucketProductModel
            {
                ProductName = "Onion",
                IsChecked = false
            });
        }

        [RelayCommand]
        private void BucketProductTapped(HomePageBucketProductModel model)
        {
            model.IsChecked = !model.IsChecked;
        }
    }
}
