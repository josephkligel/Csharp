public class ConsoleUserInteractor : IUserInteractor
{
	public string ReadValidFilePath()
	{
		bool isFilePathValid = false;
		string fileName = default;

		do
		{
			Console.WriteLine("Enter the name of the file you want to read:");

			fileName = Console.ReadLine();

			if (fileName is null)
			{
				Console.WriteLine("File cannot be null");
			}
			else if (fileName == string.Empty)
			{
				Console.WriteLine("File name cannot be empty.");
			}
			else if (!File.Exists(fileName))
			{
				Console.WriteLine("File not found");
			}
			else
			{
				isFilePathValid = true;
			}
		} while (!isFilePathValid);
		return fileName;
	}

	public void PrintMessage(string message)
	{
		Console.WriteLine(message);
	}

	public void PrintError(string message)
	{
		var originalColor = Console.ForegroundColor;

		Console.ForegroundColor = ConsoleColor.Red;

		Console.WriteLine(message);

		Console.ForegroundColor = originalColor;
	}
}
