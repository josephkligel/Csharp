// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[Remove] a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();
Console.WriteLine("User input: " + userChoice);
userChoice = "ABC";

var result = "abc" + "def" + "ghi";

Console.ReadKey();
