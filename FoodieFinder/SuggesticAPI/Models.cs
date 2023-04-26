using System.Text.Json.Serialization;

namespace FoodieFinder.SuggesticAPI.Models
{
    public class SearchRecipesByIngredientsResponse
    {
        public RequestType SearchRecipesByIngredients { get; set; }
    }

    public class RequestType
    {
        public List<Edge> Edges { get; set; }
    }

    public class Edge
    {
        public Recipe Node { get; set; }
    }

    public class Recipe
    {
        public string Name { get; set; }
        [JsonPropertyName("parsedIngredientLines")]
        public List<IngredientLine> Ingredients { get; set; }
        public List<string> Instructions { get; set; }
    }

    public class IngredientLine
    {
        [JsonPropertyName("ingredient")]
        public string IngredientName { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
    }
}
