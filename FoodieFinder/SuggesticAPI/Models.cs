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
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Instructions { get; set; }
    }

    public class Ingredient
    {
        public string Name { get; set; }
    }
}
