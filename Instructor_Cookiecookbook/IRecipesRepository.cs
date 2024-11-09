using Instructor_CookieCookbook.Recipes;

namespace Instructor_Cookiecookbook
{
    public interface IRecipesRepository
    {
        List<Recipe> Read(string filePath);
    }
}