using GameDataParser.Data;
using GameDataParser.Models;

public class ConsoleGamePrinter : IGamePrinter
{
    public GamesRepository gamesRepository;

    public ConsoleGamePrinter(GamesRepository gamesRepository)
    {
        this.gamesRepository = gamesRepository;
    }
    public void Print()
    {
        if (gamesRepository.Games.Any())
        {
            Console.WriteLine("Loaded games are:");
            foreach (var game in gamesRepository.Games)
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