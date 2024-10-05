using System.Text.Json;
using System.Text.Json.Serialization;

namespace CookieCookbook
{
	public static class RecipeFileRepository
	{
		public static string jsonFilename = "C:\\Users\\c0021\\OneDrive\\Documents\\GitHub\\Csharp\\CookieCookbook\\bin\\Debug\\net8.0\\recipes.json";
		public static string textFilename = "C:\\Users\\c0021\\OneDrive\\Documents\\GitHub\\Csharp\\CookieCookbook\\bin\\Debug\\net8.0\\recipes.txt";

		public static string ReadFromJson()
		{
			var jsonString = File.ReadAllText(jsonFilename);
			return jsonString;
		}

		public static string[] ReadFromText()
		{
			var textLines = File.ReadAllLines(textFilename);
			return textLines;
		}

		public static void WriteToJson(Recipe recipe)
		{
			var ingredientIds = new List<int>();

			foreach(var ingredient in recipe.Ingredients)
			{
				ingredientIds.Add(ingredient.ID);
			}

			var jsonString = Environment.NewLine + JsonSerializer.Serialize(ingredientIds);
			File.AppendAllText(jsonFilename, jsonString);

		}

		public static void WriteToText(Recipe recipe)
		{
			var ingredientIds = new List<int>();
			foreach(var ingredient in recipe.Ingredients)
			{
				ingredientIds.Add(ingredient.ID);
			}
			var ingredientIdsString = Environment.NewLine + string.Join(",", ingredientIds);

			File.AppendAllText(textFilename, ingredientIdsString);
		}
	}
}