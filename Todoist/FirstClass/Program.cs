// See https://aka.ms/new-console-template for more information

var rectangle1 = new Rectangle(5, 10);
var rectangle2 = new Rectangle(50, 100);

Console.WriteLine("Count of Rectangle objects is " + Rectangle.CountOfInstances);

Console.WriteLine(Rectangle.DescribeGenerally());
Console.WriteLine(Rectangle.NumberOfSides);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.GetHeight());
Console.WriteLine("Area is " + rectangle1.CalculateArea());
Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());

Console.WriteLine($"1 + 2 is {Calculator.Add(1,2)}");
Console.WriteLine($"1 - 2 is {Calculator.Subtract(1,2)}");
Console.WriteLine($"1 * 2 is {Calculator.Multiply(1,2)}");

Console.ReadKey();

static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}

class Rectangle
{

    public static int CountOfInstances { get; private set; }
    private static DateTime _firstUsed;
    // private static DateTime _firstUsed = DateTime.Now;

    static Rectangle()
    {
        _firstUsed = DateTime.Now;
    }
    
    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));
        ++CountOfInstances;
    }
    
    public int Width { get; }

    private int _height;
    public int GetHeight() => _height;

    public int SetHeight(int value)
    {
        if(value > 0)
        {
            _height = value;
        }

        return _height;
    }

    private int GetLengthOrDefault(int length, string name)
    {
        const int defaultValueIfNonPositive = 1;

        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a postivive number.");
            return defaultValueIfNonPositive;
        }
        return length;

    }
    public int CalculateCircumference() => 2 * Width + 2 * _height;

    public int CalculateArea() => Width * _height;

    public string Description => $"A rectangle with width {Width} "
        + $"and height {_height}";

    public static string DescribeGenerally() =>
        $"A plane figure with four straight sides and four right angles.";

    public const int NumberOfSides = 4;
}
