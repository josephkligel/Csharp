
internal readonly struct Point: IEquatable<Point>
{
    public int X { get; init; }
    public int Y { get; init; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool Equals(Point other)
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