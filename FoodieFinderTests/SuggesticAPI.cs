using FoodieFinder.SuggesticAPI;
using Microsoft.Extensions.Configuration;

namespace FoodieFinderTests
{
    public class SuggesticAPI
    {
        [Fact]
        public void TestSearchRecipesByName()
        {
            using var apiClient = GetApiClient();

            var name = "pancakes";

            var result = apiClient.SearchRecipesByNameAsync(name).Result;

            //System.Diagnostics.Debugger.Launch();

            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void TestSearchRecipesByNameOrIngredients()
        {
            using var apiClient = GetApiClient();

            var name = "Avocado lemon";

            var result = apiClient.SearchRecipesByNameOrIngredientsAsync(name).Result;

            //System.Diagnostics.Debugger.Launch();

            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void TestSearchRecipesByIngredients()
        {
            using var apiClient = GetApiClient();

            var ingredients = new List<string> { "egg", "broccoli" };

            var result = apiClient.SearchRecipesByIngredientsAsync(ingredients).Result;

            //System.Diagnostics.Debugger.Launch();

            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        private static SuggesticApiClient GetApiClient()
        {
            var config = InitConfiguration();
            var apiKey = config.GetRequiredSection("SuggesticAPI")["ApiKey"];
            return new SuggesticApiClient(apiKey);
        }

        private static IConfiguration InitConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}