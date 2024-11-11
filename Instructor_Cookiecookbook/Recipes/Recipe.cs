﻿using Instructor_Cookiecookbook.Recipes.Ingredients;

namespace Instructor_CookieCookbook.Recipes
{
    public class Recipe
    {
        public IEnumerable<Ingredient> Ingredients { get; }


        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            var steps = new List<string>();
            foreach(var ingredient in Ingredients)
            {
                steps.Add($"{ingredient.Name}. {ingredient.PreperationInstructions}");
            }

            return string.Join( Environment.NewLine, steps );
        }
    }

}