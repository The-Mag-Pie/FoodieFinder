using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.UserAccount;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace FoodieFinder.ViewModels
{
    public partial class SavedRecipePageViewModel : BaseViewModel
    {
        public ObservableCollection<Recipe> SavedOfflineItems { get; } = new();
        private static readonly string FullPath = Path.Combine(FileSystem.Current.AppDataDirectory, "SavedItems.json");

        [ObservableProperty]
        private string _addIngredientName = string.Empty;

        private readonly IServiceProvider _serviceProvider;
        private readonly AppDbContext _dbContext;
        private readonly UserData _userData;

        public SavedRecipePageViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _userData = _serviceProvider.GetRequiredService<UserData>();
            _dbContext = _serviceProvider.GetRequiredService<AppDbContext>();

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
        private void AddSavedItem()
        {
            Shell.Current.GoToAsync("AddSavedRecipePage"); //Przejœcie do AddSavedRecipe
            LoadSavedItems();
        }

        [RelayCommand]
        private async Task SavedItemTapped(Recipe RecipeIt)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "Recipe", RecipeIt }
            };
            Shell.Current.GoToAsync($"RecipePage", navigationParameter);
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
    }
}
