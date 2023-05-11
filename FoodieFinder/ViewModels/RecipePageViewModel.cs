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

        private readonly IServiceProvider _serviceProvider;

        public RecipePageViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();

            Ingredients.Add(new()
            {
                IngredientName = "Avocado",
                Quantity = 3,
                Unit = "pcs",
                IsChecked = true
                
            });
            Ingredients.Add(new()
            {
                IngredientName = "Lime",
                Quantity = 1,
                Unit = "pcs",
                IsChecked = false

            });
            Ingredients.Add(new()
            {
                IngredientName = "Salt",
                Quantity = 1,
                Unit = "tbs",
                IsChecked = true

            });
            Ingredients.Add(new()
            {
                IngredientName = "Cilantro",
                Quantity = 3,
                Unit = "tbs",
                IsChecked = false

            });
            Ingredients.Add(new()
            {
                IngredientName = "Plum tomatoes",
                Quantity = 2,
                Unit = "pcs",
                IsChecked = false

            });
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
    }
}
