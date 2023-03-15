using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

        public HomePageViewModel()
        {
            YourRecipes.Add(new HomePageRecipeModel
            {
                RecipeName = "Pesto Pasta",
                Image = ImageSource.FromFile("pesto_pasta.png")
            });

            YourRecipes.Add(new HomePageRecipeModel
            {
                RecipeName = "Thai soup",
                Image = ImageSource.FromFile("thai_soup.png")
            });

            YourRecipes.Add(new HomePageRecipeModel
            {
                RecipeName = "Guacamole",
                Image = ImageSource.FromFile("guacamole.png")
            });

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
