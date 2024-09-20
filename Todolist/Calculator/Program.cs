// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");

Console.Write("Input the first number: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.Write("Input the second number: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);

Console.WriteLine("What would you like to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

string selectedOption = Console.ReadLine();

int result;

switch(selectedOption)
{
    case "A":
    case "a":
        result = number1 + number2;
        PrintFinalEquation(number1, number2, result, "+");
        break;
    case "S": 
    case "s":
        result = number1 - number2;
        PrintFinalEquation(number1, number2, result, "-"); 
        break;
    case "M":
    case "m":
        result = number1 * number2;
        PrintFinalEquation(number1, number2, result, "*");
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}

void PrintFinalEquation(
    int number1, int number2, int result, string @operator)
{
    Console.WriteLine("{0} {1} {2} = {3}", number1, @operator, number2, result);
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();