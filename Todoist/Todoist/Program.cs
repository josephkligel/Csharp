//// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

switch (userChoice)
{
    case "S":
    case "s":
        PrintSelectedOption("See all TODOs");
        break;
    case "A":
    case "a":
        PrintSelectedOption("Add a TODO");
        break;
    case "R":
    case "r":
        PrintSelectedOption("Remove a TODO");
        break;
    case "E":
    case "e":
        PrintSelectedOption("Exit");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}

void PrintSelectedOption(string userChoice)
{
    Console.WriteLine($"Selected choice: {userChoice}");
}

char ConvertPointsToGrade(int points)
{
    switch (points)
    {
        case 10:
        case 9:
            return 'A';
        case 8:
        case 7:
        case 6:
            return 'B';
        case 5:
        case 4:
        case 3:
            return 'C';
        case 2:
        case 1:
            return 'D';
        case 0:
            return 'E';
        default:
            return '!';
    }
}

Console.ReadKey();