using Instructor_Cookiecookbook.Recipes.Ingredients;
using Instructor_CookieCookbook.Recipes;

namespace Instructor_Cookiecookbook
{
    public class RecipesRepository : IRecipesRepository
    {
        public List<Recipe> Read(string filePath)
        {
            return new List<Recipe>
            {
                new Recipe(new List<Ingredient>
                {
                    new WheatFlour(),
                    new Butter(),
                    new Sugar()
                }),
                new Recipe(
                    new List<Ingredient>
                    {
                        new CocoaPowder(),
                        new Butter(),
                        new Cinnamon(),
                    })
            };
        }
    }
}