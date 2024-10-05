using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookbook
{
	public class Ingredients: IPrintable
	{
		public List<Ingredient> All = new List<Ingredient>();

        public Ingredients()
        {
            All = new List<Ingredient>
            {
                new Ingredient(1, "Wheat flour", "Sieve. Add to other ingredients."),
                new Ingredient(2, "Coconut flour", "Sieve. Add to other ingredients."),
                new Ingredient(3, "Butter", "Melt on low heat. Add to other ingredients."),
                new Ingredient(4, "Chocolate", "Melt in a water bath. Add to other ingredients."),
                new Ingredient(5, "Sugar", "Add to other ingredients."),
                new Ingredient(6, "Cardamomr", "Take half a teaspoon. Add to other ingredients."),
                new Ingredient(7, "Cinnamon", "Take half a teaspoon. Add to other ingredients."),
                new Ingredient(8, "Cocoa powder", "Add to other ingredients."),
			};
        }

        public void Print()
        {
            foreach(var ingredient in All)
            {
                ingredient.Print();
            }
        }
    }
}
