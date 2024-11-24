using Instructor_Cookiecookbook.Recipes.Ingredients;
using Instructor_CookieCookbook.Recipes;

namespace Instructor_Cookiecookbook.App
{
    public interface IRecipesUserInteraction
    {
        void ShowMessage(string message);
        void Exit();
        void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
        void PromptToCreateRecipe();
        IEnumerable<Ingredient> ReadIngredientsFromUser();
    }
}