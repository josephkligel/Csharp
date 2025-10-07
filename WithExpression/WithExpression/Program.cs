using System.Drawing;

var point = new Point(10, 20);
var pointMoved = point with { X = 30 };

Console.ReadKey();

struct Point
{
    public int X { get; init; }
    public int Y { get; init; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}