using System.Text.Json;
using System.Text.Json.Nodes;


var app = new GameDataParserApp();
var logger = new Logger("log.txt");

try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine("Sorry! The application has experienced an unexpected error and will have to be closed.");
    logger.Log(ex);
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

public class GameDataParserApp
{
    
    public void Run()
    {
        bool isFileRead = false;
        string fileContents = default;
        string fileName = default;

        do
        {

            try
            {
                Console.WriteLine("Enter the name of the file you want to read:");

                fileName = Console.ReadLine();

                fileContents = File.ReadAllText(fileName);

                isFileRead = true;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("File cannot be null");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("File name cannot be empty.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found");
            }
        } while (!isFileRead);

        var videoGames = new List<VideoGame>();

        try
        {
            videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
        }
        catch (JsonException ex)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"JSON in the {fileName} was not in a valid format.");
            Console.WriteLine("JSON body:");
            Console.WriteLine(File.ReadAllText(fileName));
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.ForegroundColor = originalColor;

            throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
        }

        if (videoGames.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Loaded games are:");
            foreach (var game in videoGames)
            {
                Console.WriteLine(game);
            }
        }
        else
        {
            Console.WriteLine("No games are present in the input file.");
        }

    }
}

public class VideoGame
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public float Rating { get; set; }

    public override string ToString()
    {
        return $"{Title}, released in {ReleaseYear}, rating: {Rating}";
    }
}
