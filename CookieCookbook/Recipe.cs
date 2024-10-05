namespace CookieCookbook
{
	public class Recipe: IPrintable
	{
		public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();	

		public void AddIngredient(Ingredient ingredient)
		{
			Ingredients.Add(ingredient);
		}

		public void Print()
		{
            foreach(var ingredient in Ingredients)
			{
				ingredient.Print();
			}
		}


	}
}
