using GameDataParser.Models;
using GameDataParser.UserInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser
{
    public class App
    {
        public static void Run(ConsoleUserInteraction userInteraction, GamesRepository gamesRepository, ConsoleGamePrinter gamePrinter)
        {
            userInteraction.Prompt();
            gamesRepository.GetItems();
            gamePrinter.Print();
        }
    }
}
