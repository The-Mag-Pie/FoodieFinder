using FoodieFinder.SuggesticAPI.Models;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;

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

        public async Task<List<Recipe>> SearchRecipesByIngredients(List<string> ingredients)
        {
            var query = Queries.SearchRecipesByIngredientsQuery;
            var response = await _sendQueryAsync<SearchRecipesByIngredientsResponse>(query);
            return response.SearchRecipesByIngredients.Edges.Select(e => e.Node).ToList();
        }

        private async Task<T> _sendQueryAsync<T>(string query)
        {
            var request = new GraphQLRequest(query);
            return (await _client.SendQueryAsync<T>(request)).Data;
        }
    }
}
