using System.IO.Enumeration;
using System.Text.Json;
using System.Threading.Channels;
using System.Xml.Linq;
using GameDataParser;

var filename = "";
bool isFileValid = false;
var fileContents = "";
do
{
    Console.WriteLine("Enter the name of the file you want to read: ");

    try
    {
        filename = Console.ReadLine();
        isFileValid = true;
        fileContents = File.ReadAllText(filename);
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine("File name cannot be null.");
    }
	catch (FileNotFoundException ex)
	{
		Console.WriteLine("File not found.");
	}
	catch (ArgumentException ex)
	{
        Console.WriteLine("File name cannot be empty.");
    }
    
} while (!isFileValid);

List<Game> games = JsonSerializer.Deserialize<List<Game>>(fileContents);

Console.WriteLine("Loaded games are: ");

foreach(var game in games)
{
    Console.WriteLine(game);
}

Console.ReadKey();