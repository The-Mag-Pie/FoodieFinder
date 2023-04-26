namespace FoodieFinder.SuggesticAPI
{
    public struct Queries
    {
        public const string SearchRecipesByIngredientsQuery = @"
        {
            searchRecipesByIngredients (
                mustIngredients: [""broccoli"", ""eggs""]
            ) {
                edges {
                    node {
                        name
                        ingredients {
                            name
                        }
                        instructions
                    }
                }
            }
        }";
    }
}
