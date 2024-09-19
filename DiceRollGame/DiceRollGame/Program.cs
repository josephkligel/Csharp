// See https://aka.ms/new-console-template for more information
// Dice rolled. Guess what number it shows in 3 tries
// Enter a number:
// Check for valid number
// You Win! or You Lose :(

using DiceRollGame;

int numberOfTries = 3;

Dice dice = new();
Guess guess = new();
GuessValidator guessValidator = new();
Game game = new();


Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries");
while(numberOfTries > 0)
{
    Console.Write("Enter a number: ");
    string guessString = Console.ReadLine();
    if(guessValidator.IsValid(guessString))
    {
        guess.Number = Convert.ToInt32(guessString);
        if(game.DidIWin(dice._number, guess.Number))
        {
            Console.WriteLine("You win!");
            System.Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Wrong number.");
        }
    }
    numberOfTries--;
}

Console.WriteLine("You lose :(");