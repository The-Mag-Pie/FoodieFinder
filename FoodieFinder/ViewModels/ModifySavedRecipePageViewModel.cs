using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Views;
using FoodieFinder.Database;
using FoodieFinder.Popups;
using System.Collections.ObjectModel;

namespace FoodieFinder.ViewModels
{
    public partial class ModifySavedRecipePageViewModel : BaseViewModel
    {
        public Recipe SavedOfflineItems { get; } = new();
        public ObservableCollection<Ingredient> IngredientItems { get; } = new();
        private List<Ingredient> IngredientList = new List<Ingredient>();

        [ObservableProperty]
        public Recipe modifiedRecipe;

        [ObservableProperty]
        private string _addIngredientName = string.Empty;

        private readonly IServiceProvider _serviceProvider;
        private readonly AppDbContext _dbContext;
        private IEnumerable<Recipe> currentRecipe;

        public ModifySavedRecipePageViewModel(IServiceProvider serviceProvider, Recipe recipe)
        {
            _serviceProvider = serviceProvider;
            _dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
           
            ModifiedRecipe = recipe;

            foreach (var item in _dbContext.Ingredient.Where(u => u.RecipeId == ModifiedRecipe.Id))
            {
                IngredientList.Add(item);
            }
            LoadIngredientItems();

            currentRecipe = _dbContext.Recipe.Where(u => u.Id == ModifiedRecipe.Id);
        }

        [RelayCommand]
        private void ModifySavedItem()
        {
            if (ModifiedRecipe.Name != String.Empty && ModifiedRecipe.Description != String.Empty &&
                ModifiedRecipe.Preparation != String.Empty && IngredientList.Count > 0)
            {
                currentRecipe.First().Name = ModifiedRecipe.Name;
                currentRecipe.First().Description = ModifiedRecipe.Description;
                currentRecipe.First().Preparation = ModifiedRecipe.Preparation;

                foreach (var ingredient in _dbContext.Ingredient.Where(u => u.RecipeId == ModifiedRecipe.Id))
                {
                    _dbContext.Ingredient.Remove(ingredient);
                }

                _dbContext.SaveChanges();

                foreach (var ingredient in IngredientItems)
                {
                    ingredient.Id = 0;
                    ingredient.RecipeId = ModifiedRecipe.Id;
                    _dbContext.Ingredient.Add(ingredient);
                }

                _dbContext.SaveChanges();

                Back(); //PRZEJŚCIE DO SavedRecipePage
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "You must enter all the data, to add the recipe!", "OK");
            }
        }
        [RelayCommand]
        private async Task AddIgredientItem()
        {
            var popup = new AddSavedRecipePopup();
            var result = await Application.Current.MainPage.ShowPopupAsync(popup) as Ingredient;
            if (result.Name != String.Empty && result.Quantity > 0 && result.Unit != String.Empty)
            {
                IngredientList.Add(result);
                LoadIngredientItems();
            }
        }
        [RelayCommand]
        private void DeleteIgredientItem(Ingredient IngredientIt)
        {
            IngredientList.Remove(IngredientIt);
            LoadIngredientItems();
        }
        private void LoadIngredientItems()
        {
            IngredientItems.Clear();

            foreach (var item in IngredientList)
            {
                IngredientItems.Add(item);
            }
        }
        [RelayCommand]
        private void Back()
        {
            Shell.Current.SendBackButtonPressed();
        }
    }
}
