using FoodieFinder.SuggesticAPI;
using Microsoft.Extensions.Configuration;

namespace FoodieFinderTests
{
    public class SuggesticAPI
    {
        [Fact]
        public void TestSearchRecipesByIngredients()
        {
            var config = InitConfiguration();
            var apiKey = config.GetRequiredSection("SuggesticAPI")["ApiKey"];
            using var apiClient = new SuggesticApiClient(apiKey);

            var ingredients = new List<string> { "broccoli", "eggs" };

            var result = apiClient.SearchRecipesByIngredients(ingredients).Result;

            System.Diagnostics.Debugger.Launch();

            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        private static IConfiguration InitConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}