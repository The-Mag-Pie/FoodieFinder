using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.SuggesticAPI;
using FoodieFinder.UserAccount;
using System.Collections.ObjectModel;

namespace FoodieFinder.ViewModels
{
    public partial class OnlineRecipePageViewModel : BaseViewModel
    {
        public ObservableCollection<OnlineRecipe> SavedOnlineItems { get; } = new();


        [ObservableProperty]
        private string _addIngredientName = string.Empty;

        private readonly IServiceProvider _serviceProvider;
        private readonly AppDbContext _dbContext;
        private readonly UserData _userData;

        public OnlineRecipePageViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _userData = _serviceProvider.GetRequiredService<UserData>();
            _dbContext = _serviceProvider.GetRequiredService<AppDbContext>();

            LoadSavedItems();
        }

        public void LoadSavedItems()
        {
            SavedOnlineItems.Clear();
            /*foreach (var item in _dbContext.Recipe.Where(u => u.UserId == _userData.UserId))
            {
                SavedOfflineItems.Add(item);
            }*/
            //List<OnlineRecipe> SRecipe = new List<OnlineRecipe> { };
            try
            {
                var log = new Login(_serviceProvider);
                foreach (var item in _dbContext.OnlineRecipe.Where(u => u.UserId == _userData.UserId))
                {
                    //SavedOfflineItems.Add(item);

                    //zapisywanie do nowego pliku danych z bazy
                    //SRecipe.Add(item);
                    SavedOnlineItems.Add(item);
                }           
            }
            catch
            {
                Application.Current.MainPage.DisplayAlert("Error", "Cannot connect to the server", "OK");
            }
        }

        [RelayCommand]
        private async Task SavedItemTapped(OnlineRecipe RecipeIt)
        {
            var apiClient = _serviceProvider.GetRequiredService<SuggesticApiClient>();

            await InvokeAsyncWithLoader(async () =>
            {
                var recipe = await apiClient.GetRecipeById(RecipeIt.RecipeApiId);

                if (recipe is null)
                {
                    await Application.Current.MainPage.DisplayAlert("Recipe error", "Online recipe not found", "OK");
                    return;
                }

                var navigationParameter = new Dictionary<string, object>
                {
                    { "Recipe", recipe }
                };
                await Shell.Current.GoToAsync("OnlineRecipeDetailsPage", navigationParameter);
            });
        }

        [RelayCommand]
        private void DeleteOnlineRecipe(OnlineRecipe RecipeIt)
        {
            //Application.Current.MainPage.DisplayAlert("Error", RecipeIt.Id.ToString()+" "+RecipeIt.Name, "OK");

            _dbContext.ChangeTracker.Clear();
            _dbContext.OnlineRecipe.Remove(RecipeIt);

            _dbContext.SaveChanges();

            LoadSavedItems();
        }
        
    }
}
