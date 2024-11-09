using Instructor_CookieCookbook.Recipes;

namespace Instructor_Cookiecookbook
{
    internal interface IRecipesUserInteraction
    {
        void ShowMessage(string message);
        void Exit();
        void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    }
}