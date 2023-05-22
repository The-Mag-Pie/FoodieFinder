namespace FoodieFinder.SuggesticAPI
{
    public struct Queries
    {
        private const string RecipeObjectFields = @"
        id
        name
        totalTimeInSeconds
        parsedIngredientLines {
            ingredient
            quantity
            unit
        }
        instructions";

        public static string SearchRecipesByNameQuery = @"
        {
            recipeSearch (
                query: {{searchQuery}},
                hasInstructions: true
            ) {
                edges {
                    node {
                        {{recipeObjectFields}}
                    }
                }
            }
        }".Replace("{{recipeObjectFields}}", RecipeObjectFields);

        public static string SearchRecipesByNameOrIngredientsQuery = @"
        {
            searchRecipeByNameOrIngredient (
                query: {{searchQuery}}
            ) {
                onPlan {
                    {{recipeObjectFields}}
                }
                otherResults {
                    {{recipeObjectFields}}
                }
            }
        }".Replace("{{recipeObjectFields}}", RecipeObjectFields);

        public static string SearchRecipesByIngredientsQuery = @"
        {
            searchRecipesByIngredients (
                mustIngredients: {{ingredientsList}}
            ) {
                edges {
                    node {
                        {{recipeObjectFields}}
                    }
                }
            }
        }".Replace("{{recipeObjectFields}}", RecipeObjectFields);

        public static string GetRecipeById = @"
        {
            recipe(
                id: {{recipeId}}
            ) {
                {{recipeObjectFields}}
            }
        }".Replace("{{recipeObjectFields}}", RecipeObjectFields);
    }
}
