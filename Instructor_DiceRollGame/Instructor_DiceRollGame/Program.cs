

Console.ReadKey();

class Dice
{
    private Random _random;

    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll()
    {
        return _random.Next(1, 7);
    }
}