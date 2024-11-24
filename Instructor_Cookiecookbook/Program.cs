using Instructor_Cookiecookbook;
using Instructor_CookieCookbook.Recipes;

const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository = Format == FileFormat.Json ?
    new StringsJsonRepository() :
    new StringsTextualRepository();

const string FileName = "recipes";
var fileMetadata = new FileMetaData(FileName, Format);

var ingredientsRegister = new IngredientsRegister();

var cookiesRecipesApp = new CookiesRecipeApp(
    new RecipesRepository(
        new StringsJsonRepository(),
        ingredientsRegister),
    new RecipesConsoleUserInteraction(
        ingredientsRegister));
cookiesRecipesApp.Run("recipes.json");

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
            _recipesRepository.Write(filePath, allRecipes);

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

public class FileMetaData
{
    public string Name { get; }
    public FileFormat Format { get; }

	public FileMetaData(string name, FileFormat format)
	{
		Name = name;
		Format = format;
	}

    public string ToPath() => $"{Name}.{Format.AsFileExtention()}";

}

public enum FileFormat
{
    Json,
    Txt
}

public static class FileFormatExtensions
{
	public static string AsFileExtention(this FileFormat fileFormat) =>
		fileFormat == FileFormat.Json ? "json" : "txt";
}

