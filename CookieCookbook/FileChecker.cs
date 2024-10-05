namespace CookieCookbook
{
	public static class FileChecker
	{
		public static bool IsRecipesFile()
		{
			if(File.Exists(RecipeFileRepository.jsonFilename) || File.Exists(RecipeFileRepository.textFilename))
			{
				return true;
			}
			return false;
		}
	}
}