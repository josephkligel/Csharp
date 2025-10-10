var point1 = new Point(2, 3);
var point2 = new Point(4, 5);
var sum = point1 + point2;

class Point: IEquatable<Point> {     
    public int X { get; }
    public int Y { get; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    public static bool operator ==(Point p1, Point p2)
    {
        return p1.Equals(p2);
    }
    
    public static bool operator !=(Point p1, Point p2)
    {
        return !p1.Equals(p2);
    }

    public bool Equals(Point? other)
    {
        return other is Point point 
            && X == other.X 
            && Y == other.Y;
    }
}