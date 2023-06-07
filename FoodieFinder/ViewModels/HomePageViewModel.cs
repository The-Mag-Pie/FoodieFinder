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
        public ObservableCollection<Recipe> YourRecipes { get; } = new();
        public ObservableCollection<BucketListItem> BucketList { get; } = new();

        [ObservableProperty]
        private bool _isYourRecipesVisible = false;

        [ObservableProperty]
        private string _addIngredientName = string.Empty;

        private readonly IServiceProvider _serviceProvider;
        private readonly AppDbContext _dbContext;
        private readonly UserData _userData;

        public HomePageViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            _dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            _userData = _serviceProvider.GetRequiredService<UserData>();

            IsYourRecipesVisible = !_userData.IsGuest;
        }

        public void OnAppearing()
        {
            LoadRecipes();
            LoadBucketList();
        }

        private void LoadRecipes()
        {
            YourRecipes.Clear();
            foreach (var recipe in _dbContext.Recipe.Where((r) => r.UserId == _userData.UserId))
            {
                YourRecipes.Add(new()
                {
                    Id = recipe.Id,
                    Name = recipe.Name,
                    Description = recipe.Description,
                    Preparation = recipe.Preparation,
                });
            }
        }

        private void LoadBucketList()
        {
            BucketList.Clear();
            foreach (var bucketItem in BucketListDb.GetItems())
            {
                BucketList.Add(bucketItem);
            }
        }

        [RelayCommand]
        private void RecipeTapped(Recipe recipe)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "Recipe", recipe }
            };
            Shell.Current.GoToAsync($"RecipePage", navigationParameter);
        }

        [RelayCommand]
        public void SaveBucketList()
        {
            Task.Run(() => BucketListDb.SaveItems(BucketList.ToList()));
        }

        [RelayCommand]
        private void BucketProductTapped(BucketListItem model)
        {
            model.IsChecked = !model.IsChecked;
            SaveBucketList();
        }

        [RelayCommand]
        private async Task AddBucketListItem()
        {
            if (AddIngredientName.Length == 0)
            {
                Application.Current.MainPage.DisplayAlert("Error", "Ingredient name is empty!", "OK");
                return;
            }

            // Check if item is already in the list
            var matchedItems = BucketListDb.GetItems().Where(i => i.ProductName.Contains(AddIngredientName) || AddIngredientName.Contains(i.ProductName));
            if (matchedItems.Count() > 0)
            {
                var message = "There are already similar products on the list:\n\n";

                foreach (var item in matchedItems)
                {
                    message += $"{item.ProductName}\n";
                }

                message += "\nDo you want to add the product anyway?";

                var response = await Application.Current.MainPage.DisplayAlert("Duplicated product", message, "Yes", "No");
                if (response == false) return;
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
    }
}
