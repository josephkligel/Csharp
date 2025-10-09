var point1 = new Point(1, 5);
var point2 = new Point(1, 5);

Console.WriteLine("point1 == point2" + (point1 == point2));

Console.WriteLine("1 == 1" + (1 == 1s));

internal readonly struct Point: IEquatable<Point>
{
    public int X { get; init; }
    public int Y { get; init; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool Equals([AllowNull] Point other)
    {
        return X == other.X &&
            Y == other.Y;
    }

    public override bool Equals(object? obj)
    {
        return obj is Point point &&
            Equals(point);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString() => $"X: {X}, Y: {Y}";

    //public override bool Equals(object? obj)
    //{
    //    return obj is Point other &&
    //        X == other.X &&
    //        Y == other.Y;
    //}
}
