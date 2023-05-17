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
                        id
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
                    id
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
                    id
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
                        id
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
