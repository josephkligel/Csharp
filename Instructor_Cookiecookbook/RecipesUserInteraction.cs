using Instructor_Cookiecookbook;
using Instructor_CookieCookbook.Recipes;

public class RecipesUserInteraction: IRecipesUserInteraction
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }
    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if(allRecipes.Count() > 0)
        {
            Console.WriteLine("Existing recipes are: " + Environment.NewLine);

            int counter = 0;
            foreach(var recipes in allRecipes)
            {
                Console.WriteLine($"*****{++counter}*****");
                Console.WriteLine(recipes);
                Console.WriteLine();
            }
        }
    }
}