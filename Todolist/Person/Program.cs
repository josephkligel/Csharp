// See https://aka.ms/new-console-template for more information

var person = new Person
{
    Name = "Adam",
    YearOfBirth = 1981,
};

Console.ReadKey();

class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; init; }

    //public Person(string name, int yearOfBirth)
    //{
    //    Name = name;
    //    YearOfBirth = yearOfBirth;
    //}
}
