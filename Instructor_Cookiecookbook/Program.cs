using Instructor_Cookiecookbook;
using Instructor_CookieCookbook.Recipes;

var cookiesRecipesApp = new CookiesRecipeApp(
    new RecipesRepository(),
    new RecipesConsoleUserInteraction(
        new IngredientsRegister()));
cookiesRecipesApp.Run("recipes.txt");

class CookiesRecipeApp
{
	private readonly RecipesRepository _recipesRepository;
	private readonly IRecipesUserInteraction _recipesUserInteraction;

    public CookiesRecipeApp(
        RecipesRepository recipesRepository,
        RecipesConsoleUserInteraction recipesUserInteraction
        )
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }
    public void Run(string filePath)
	{
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        _recipesUserInteraction.PromptToCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        if (ingredients.Count() > 0)
        {
            var recipe = new Recipe(ingredients);
            allRecipes.Add(recipe);
            //_recipesRepository.Write(filePath, allRecipes);

            _recipesUserInteraction.ShowMessage("Recipe added:");
            _recipesUserInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipesUserInteraction.ShowMessage(
                "No ingredients have been selected. " +
                "Recipe will not be saved.");
        }

        _recipesUserInteraction.Exit();
	}
}

