// See https://aka.ms/new-console-template for more information

var rectangle1 = new Rectangle(5, 10);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.GetHeight());
Console.WriteLine("Area is " + rectangle1.CalculateArea());
Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());

Console.ReadKey();

class Rectangle
{
    
    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));
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
}
