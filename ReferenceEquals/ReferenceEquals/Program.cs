var john = new Person("John", 1);
var sameJohn = john;

Console.WriteLine($"Are references equal? {object.ReferenceEquals(john, sameJohn)}");
Console.WriteLine(object.ReferenceEquals(null, null));

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
}

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }
}