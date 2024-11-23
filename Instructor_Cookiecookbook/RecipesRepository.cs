using Instructor_Cookiecookbook.Recipes.Ingredients;
using Instructor_CookieCookbook.Recipes;

namespace Instructor_Cookiecookbook
{
    public class RecipesRepository : IRecipesRepository
    {
        private readonly IStringsRepository _stringRepository;
        private readonly IIngredientsRegister _ingredientsRegister;
        private string Seperator = ",";

		public RecipesRepository(
            IStringsRepository stringRepository, 
            IIngredientsRegister ingredientsRegister)
		{
			_stringRepository = stringRepository;
			_ingredientsRegister = ingredientsRegister;
		}
		public List<Recipe> Read(string filePath)
        {
            List<string> recipesFromFile = _stringRepository.Read(filePath);
            var recipes = new List<Recipe>();
            foreach(var recipeFromFile in recipesFromFile)
            {
                var recipe = RecipeFromString(recipeFromFile);
                recipes.Add(recipe);
            }
            return recipes;
        }

        public Recipe RecipeFromString(string recipeFromFile)
        {
            var textualIds = recipeFromFile.Split(Seperator);
            var ingredients = new List<Ingredient>();

            foreach(var textualId in textualIds)
            {
                var id = int.Parse(textualId);
                var ingredient = _ingredientsRegister.GetById(id);
                ingredients.Add(ingredient);
            }

            return new Recipe(ingredients);
        }

		public void Write(string filePath, List<Recipe> allRecipes)
		{
            var recipesAsStrings = new List<string>();
            foreach (var recipe in allRecipes)
            {
                var allIds = new List<int>();
                foreach(var ingredient in recipe.Ingredients)
                {
                    allIds.Add(ingredient.Id);
                }
                recipesAsStrings.Add(string.Join(Seperator, allIds));
            }
            File.WriteAllText(filePath, string.Join(Environment.NewLine, recipesAsStrings));
		}
	}
}