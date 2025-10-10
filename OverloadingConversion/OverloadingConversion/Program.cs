var tuple = Tuple.Create(1, 2);
Point point = (Point)tuple;

Console.ReadKey();

readonly struct Point
{
    public int X { get; init; }
    public int Y { get; init; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    //public static Point operator +(Point p1, Point p2)
    //{
    //    return new Point(p1.X + p2.X, p1.Y + p2.Y);
    //}

    //public static bool operator ==(Point p1, Point p2)
    //{
    //    return p1.Equals(p2);
    //}

    //public static bool operator !=(Point p1, Point p2)
    //{
    //    return !p1.Equals(p2);
    //}

    //public bool Equals(Point? other)
    //{
    //    return other is Point point
    //        && X == other.X
    //        && Y == other.Y;
    //}

    //public static implicit operator Point(Tuple<int, int> tuple)
    //{
    //    return new Point(tuple.Item1, tuple.Item2);
    //}

    public static explicit operator Point(Tuple<int, int> tuple)
    {
        return new Point(tuple.Item1, tuple.Item2);
    }
}