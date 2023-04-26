namespace FoodieFinder.SuggesticAPI
{
    public struct Queries
    {
        public const string SearchRecipesByIngredientsQuery = @"
        {
            searchRecipesByIngredients (
                mustIngredients: {{ingredientsList}}
            ) {
                edges {
                    node {
                        name
                        parsedIngredientLines (
                            preferredUnitSystem: METRIC
                        ) {
                            ingredient
                            quantity
                            unit
                        }
                        instructions
                    }
                }
            }
        }";
    }
}
