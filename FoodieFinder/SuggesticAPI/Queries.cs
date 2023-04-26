namespace FoodieFinder.SuggesticAPI
{
    public struct Queries
    {
        public const string SearchRecipesByNameQuery = @"
        {
            recipeSearch (
                query: {{searchQuery}}
            ) {
                edges {
                    node {
                        name
                        totalTimeInSeconds
                        parsedIngredientLines {
                            ingredient
                            quantity
                            unit
                        }
                        instructions
                    }
                }
            }
        }";

        public const string SearchRecipesByNameOrIngredientsQuery = @"
        {
            searchRecipeByNameOrIngredient (
                query: {{searchQuery}}
            ) {
                onPlan {
                    name
                    totalTimeInSeconds
                    parsedIngredientLines {
                        ingredient
                        quantity
                        unit
                    }
                    instructions
                }
                otherResults {
                    name
                    totalTimeInSeconds
                    parsedIngredientLines {
                        ingredient
                        quantity
                        unit
                    }
                    instructions
                }
            }
        }";

        public const string SearchRecipesByIngredientsQuery = @"
        {
            searchRecipesByIngredients (
                mustIngredients: {{ingredientsList}}
            ) {
                edges {
                    node {
                        name
                        totalTimeInSeconds
                        parsedIngredientLines {
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
