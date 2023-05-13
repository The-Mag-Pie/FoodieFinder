using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.ObjectModel;

namespace FoodieFinder.ViewModels
{
    partial class RecipePageViewModel : BaseViewModel
    {
        public ObservableCollection<IngredientModel> Ingredients { get; } = new();
        [ObservableProperty]
        public Recipe tappedRecipe;
        private readonly IServiceProvider _serviceProvider;

        public RecipePageViewModel(IServiceProvider serviceProvider, Recipe recipe)
        {
            _serviceProvider = serviceProvider;
            tappedRecipe = recipe;

            var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            Random xd = new Random();

            foreach (var ingredient in dbContext.Ingredient.Where(i => i.RecipeId == recipe.Id))
            {
                Ingredients.Add(new()
                {
                    IngredientName = ingredient.Name,
                    Unit = ingredient.Unit,
                    Quantity = ingredient.Quantity,
                    IsChecked = Convert.ToBoolean(xd.Next(0, 2))
                });
            }
        }

        [RelayCommand]
        private async Task ShareButtonClicked()
        {
            var config = _serviceProvider.GetRequiredService<IConfiguration>();
            var configSection = config.GetRequiredSection("FoodieFinder");

            var domainName = configSection["DomainName"];
            var shareRecipeEndpoint = configSection["ShareRecipeEndpoint"];
            if (domainName == null || shareRecipeEndpoint == null) return;

            await Share.Default.RequestAsync(new ShareTextRequest()
            {
                Title = "Share recipe",
                Text = "Check out my recipe!",
                Uri = $"https://{domainName}/{shareRecipeEndpoint.Replace("{{recipeId}}", 5.ToString())}" // TODO: recipe id
            });
        }

        [RelayCommand]
        private void Back()
        {
            Shell.Current.SendBackButtonPressed();
        }
    }
}
