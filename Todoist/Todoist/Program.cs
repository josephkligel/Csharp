// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[Remove] a TODO");
Console.WriteLine("[E]xit");

// reads line from console and assigns it to variable
string userChoice = Console.ReadLine();


Console.WriteLine("User input: " + userChoice);

bool isUserInputAbc = userChoice == "ABC";
bool isUserInputNotAbc1 = userChoice != "ABC";
bool isUserInputNotAbc2 = !(userChoice == "ABC");

Console.ReadKey();
