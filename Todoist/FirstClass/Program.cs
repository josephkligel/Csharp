// See https://aka.ms/new-console-template for more information

var rectangle1 = new Rectangle(5, 10);
var calculator = new ShapesMeasurementCalculator();

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.Height);
Console.WriteLine("Area is " + calculator.CalculateArea(rectangle1));
Console.WriteLine("Circumference is " + calculator.CalculateCircumference(rectangle1));

Console.ReadKey();

class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

   
}

class ShapesMeasurementCalculator
{
    public int CalculateCircumference(Rectangle rectangle)
    {
        return 2 * rectangle.Width + 2 * rectangle.Height;
    }

    public int CalculateArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}