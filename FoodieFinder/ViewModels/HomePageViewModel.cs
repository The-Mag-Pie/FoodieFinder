using CommunityToolkit.Mvvm.ComponentModel;
using FoodieFinder.Models;
using System.Collections.ObjectModel;

namespace FoodieFinder.ViewModels
{
    partial class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<HomePageRecipeModel> YourRecipes { get; } = new();
        public ObservableCollection<HomePageBucketProductModel> BucketList { get; } = new();

        [ObservableProperty]
        private string _welcome = "Welcome, <USERNAME_HERE>";

        [ObservableProperty]
        private ImageSource _userImage = ImageSource.FromFile("dotnet_bot.png");

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
                IsTickedOff = true
            });

            BucketList.Add(new HomePageBucketProductModel
            {
                ProductName = "Lemon",
                IsTickedOff = false
            });

            BucketList.Add(new HomePageBucketProductModel
            {
                ProductName = "Eggs 4pcs.",
                IsTickedOff = false
            });

            BucketList.Add(new HomePageBucketProductModel
            {
                ProductName = "Onion",
                IsTickedOff = false
            });
        }
    }
}
