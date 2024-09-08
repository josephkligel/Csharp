// See https://aka.ms/new-console-template for more information

var rectangle1 = new Rectangle(5, 10);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.Height);
Console.WriteLine("Area is " + rectangle1.CalculateArea());
Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());

Console.ReadKey();

class Rectangle
{
    const int NumberOfSides = 4;
    public readonly int Width;
    public readonly int Height;

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        Height = GetLengthOrDefault(height, nameof(Height));
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
    public int CalculateCircumference() => 2 * Width + 2 * Height;

    public int CalculateArea() => Width * Height;
}
