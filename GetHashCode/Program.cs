var dictionary = new Dictionary<Person, int>();
var martin = new Person(6, "Martin");
dictionary[martin] = 5;

Console.ReadKey();

readonly struct Point: IEquatable<Point>
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Person
{
    public int Id { get; init; }
    public string Name { get; init; }

    public Person(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override bool Equals(object? obj)
    {
        return obj is Person person &&
            Id == person.Id;
    }
}