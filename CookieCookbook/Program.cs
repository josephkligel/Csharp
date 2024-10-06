using CookieCookbook;

// Creates flag to whether program has ended
var continueProgram = true;
// Creates a recipe variable to hold ingredients
var recipe = new Recipe();
// Decides on a file format for the Recipes file
const FileFormat fileFormat = FileFormat.Json;
// Creates the developer-decided class containing displayable ingredients
var ingredients = new Ingredients();

// Checks if file recipes.txt or recipes.json exists
if (FileChecker.IsRecipesFile())
{
	Console.WriteLine("Printing existing recipes.");
	// Creates new Recipes object to hold all recipes from Recipes file
	Recipes recipes;
	if(fileFormat == FileFormat.Json)
	{
		recipes = RecipesBuilder.CreateFromJson();
	}
	else
	{
		recipes = RecipesBuilder.CreateFromText();
	}	
	// Prints all recipes
	recipes.Print();
}

Console.WriteLine();
Console.WriteLine("Create a new cookie recipe! Available Ingredients are:");
ingredients.Print();

// Runs program while recipe has ingredients and continueProgram var is true

do
{
	Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");

	if (int.TryParse(Console.ReadLine(), out int ingredientId))
	{
		if (ingredientId >= 1 && ingredientId <= 8)
		{
			recipe.AddIngredient(ingredients.All[ingredientId - 1]);
		}
	}
	else
	{
		continueProgram = false;
	}
} while (recipe.Ingredients.Count >= 1 && continueProgram);

if(recipe.Ingredients.Count < 1)
{
	Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
}
else
{
    Console.WriteLine("Recipe added:");
	foreach (var ingredient in recipe.Ingredients) ingredient.PrintNameAndInstructions();
    Console.WriteLine("Storing recipes in a text file.");
	if (fileFormat == FileFormat.Json)
	{
		RecipeFileRepository.WriteToJson(recipe);
	}
	else
	{
		RecipeFileRepository.WriteToText(recipe);
	}
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();
