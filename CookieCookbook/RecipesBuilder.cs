using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CookieCookbook
{
	public static class RecipesBuilder
	{
		public static Recipes CreateFromJson()
		{
			Recipes recipes = new Recipes();

			var jsonString = RecipeFileRepository.ReadFromJson();

			var jsonList = jsonString.Split(Environment.NewLine).ToList();

			foreach(var itemList in jsonList)
			{
				Recipe recipe = new Recipe();
				foreach(var item in itemList)
				{
					var idNumber = (int)item;
					recipe.AddIngredient(
						new Ingredients().All[idNumber - 1]
						);
				}

				recipes.All.Add(recipe);
			}

			return recipes;
		}

		public static Recipes CreateFromText()
		{

			Recipes recipes = new Recipes();

			var textLines = RecipeFileRepository.ReadFromText();
			foreach (var line in textLines)
			{
				var ingredientIdList = line.Split(",").ToList();
				var recipe = new Recipe();
				foreach (var item in ingredientIdList)
				{
					_ = int.TryParse(item, out int ingredientId);
					recipe.Ingredients.Add(
						new Ingredients().All[ingredientId - 1]
						);

				}
				recipes.All.Add(recipe);
			}

			return recipes;
		}
	}
}
