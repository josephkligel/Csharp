// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[Remove] a TODO");
Console.WriteLine("[E]xit");

// reads line from console and assigns it to variable
var userChoice = Console.ReadLine();
bool isLong = IsLong(userChoice);

bool IsLong(string input)
{
    return input.Length > 10;
}

var result = Add(10, 5);
Console.WriteLine("10 + 5 = " + result);

//if(userChoice == "S")
//{
//    PrintSelectedOption("See all TODOs");
//}
//else if (userChoice == "A")
//{
//    PrintSelectedOption("Add a TODO");
//}
//else if (userChoice == "R")
//{
//    PrintSelectedOption("Remove a TODO");
//}
//else if (userChoice == "E")
//{
//    PrintSelectedOption("Exit");
//}

//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine("Selected option: " + selectedOption);
//}

int Add(int a, int b)
{
    return a + b;
}

Console.ReadKey();