using System.Text.Json.Serialization;

namespace FoodieFinder.SuggesticAPI.Models
{

    public class SearchRecipesByNameResponse
    {
        public RequestType RecipeSearch { get; set; }
    }

    public class SearchRecipesByNameOrIngredientsResponse
    {
        public RequestTypeOnPlanOtherResults SearchRecipeByNameOrIngredient { get; set; }
    }

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

    public class RequestTypeOnPlanOtherResults
    {
        public List<Recipe> OnPlan { get; set; }
        public List<Recipe> OtherResults { get; set; }
    }

    public class RecipeByIdResult
    {
        public Recipe Recipe { get; set; }
    }

    public class Recipe
    {
        public string ID { get; set; }
        public string Name { get; set; }
        [JsonPropertyName("totalTimeInSeconds")]
        public int? PreparationTime { get; set; }
        [JsonPropertyName("parsedIngredientLines")]
        public List<IngredientLine> Ingredients { get; set; }
        public List<string> Instructions { get; set; }
    }

    public class IngredientLine
    {
        [JsonPropertyName("ingredient")]
        public string IngredientName { get; set; }
        public string Quantity { get; set; }
        public string Unit { get; set; }
    }
}
