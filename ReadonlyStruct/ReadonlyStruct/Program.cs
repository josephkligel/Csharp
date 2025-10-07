readonly struct Point
{
    private readonly int _z;
    public int X { get; init; }
    public int Y { get; init; }

    public Point(int y, int x)
    {
        Y = y;
        X = x;
    }

    public override string ToString() => $"X: {X}, Y: {Y}";
}