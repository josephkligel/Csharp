using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CookieCookbook
{
	public class Recipes: IPrintable
	{
		public List<Recipe> All = new List<Recipe>();

		//public Recipes(FileFormat fileFormat)
		//{
		//	if(fileFormat == FileFormat.Json)
		//	{
		//		return Recipes.CreateResumesFromJson();
		//	}
		//}

		public void Print()
		{
			
			int recipeCounter = 1;
			foreach(Recipe recipe in All)
			{
				Console.WriteLine();
				Console.WriteLine($"***** {recipeCounter} *****");
				foreach (var ingredient in recipe.Ingredients)
				{
                    Console.WriteLine($"{ingredient.Name}. {ingredient.Instructions}");
				}
				
				recipeCounter++;
			}
		}
	}
}
