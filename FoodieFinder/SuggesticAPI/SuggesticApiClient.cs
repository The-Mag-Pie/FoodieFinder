using FoodieFinder.SuggesticAPI.Models;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;
using System.Text.Json;

namespace FoodieFinder.SuggesticAPI
{
    public class SuggesticApiClient : IDisposable
    {
        private readonly GraphQLHttpClient _client;

        public SuggesticApiClient(string apiKey)
        {
            _client = new("https://production.suggestic.com/graphql", new SystemTextJsonSerializer());
            _client.HttpClient.DefaultRequestHeaders.Add("Authorization", $"Token {apiKey}");
        }

        public void Dispose()
        {
            _client.Dispose();
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Search for recipes with given name
        /// </summary>
        /// <param name="name">Recipe name</param>
        /// <returns>A list of found recipes or empty list if no recipes found</returns>
        public async Task<List<Recipe>> SearchRecipesByNameAsync(string name)
        {
            var query = Queries.SearchRecipesByNameQuery;
            var nameJson = JsonSerializer.Serialize(name);
            query = query.Replace("{{searchQuery}}", nameJson);
            var response = await _sendQueryAsync<SearchRecipesByNameResponse>(query);
            return response.RecipeSearch.Edges
                .Select(e => e.Node)
                .Where(r => r.Ingredients.Count > 0 && r.Instructions.Count > 0)
                .ToList();
        }

        /// <summary>
        /// Search for recipes with given name or ingredients
        /// </summary>
        /// <param name="searchQuery">Recipe or ingredient(s) name(s)</param>
        /// <returns>A list of found recipes or empty list if no recipes found</returns>
        public async Task<List<Recipe>> SearchRecipesByNameOrIngredientsAsync(string searchQuery)
        {
            var query = Queries.SearchRecipesByNameOrIngredientsQuery;
            var searchQueryJson = JsonSerializer.Serialize(searchQuery);
            query = query.Replace("{{searchQuery}}", searchQueryJson);
            var response = await _sendQueryAsync<SearchRecipesByNameOrIngredientsResponse>(query);

            var onPlan = response.SearchRecipeByNameOrIngredient.OnPlan;
            var otherResults = response.SearchRecipeByNameOrIngredient.OtherResults;

            return onPlan.Concat(otherResults)
                .Where(r => r.Ingredients.Count > 0 && r.Instructions.Count > 0)
                .ToList();
        }

        /// <summary>
        /// Search for recipes containing the given ingredients
        /// </summary>
        /// <param name="ingredients">A list of ingredients</param>
        /// <returns>A list of found recipes or empty list if no recipes found</returns>
        public async Task<List<Recipe>> SearchRecipesByIngredientsAsync(List<string> ingredients)
        {
            var query = Queries.SearchRecipesByIngredientsQuery;
            var ingredientsJson = JsonSerializer.Serialize(ingredients);
            query = query.Replace("{{ingredientsList}}", ingredientsJson);
            var response = await _sendQueryAsync<SearchRecipesByIngredientsResponse>(query);
            return response.SearchRecipesByIngredients.Edges
                .Select(e => e.Node)
                .Where(r => r.Ingredients.Count > 0 && r.Instructions.Count > 0)
                .ToList();
        }

        /// <summary>
        /// Get recipe data with the given ID
        /// </summary>
        /// <param name="recipeId">An ID of the recipe</param>
        /// <returns>A recipe with the given ID</returns>
        public async Task<Recipe> GetRecipeById(string recipeId)
        {
            var query = Queries.GetRecipeById;
            var recipeIdJson = JsonSerializer.Serialize(recipeId);
            query = query.Replace("{{recipeId}}", recipeIdJson);
            var response = await _sendQueryAsync<RecipeByIdResult>(query);
            return response.Recipe;
        }

        private async Task<T> _sendQueryAsync<T>(string query)
        {
            var request = new GraphQLRequest(query);
            return (await _client.SendQueryAsync<T>(request)).Data;
        }
    }
}
