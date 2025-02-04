var numbers = new List<int>() { 5, 1, 7, 2 };
numbers.Sort();

var words = new List<string>() { "ddd", "aaa", "ccc", "bbb" };
words.Sort();

var people = new List<Person>
{
	new Person { Name = "John", YearOfBirth = 1980 },
	new Person { Name = "Anna", YearOfBirth = 1915 },
	new Person { Name = "Bill", YearOfBirth = 2011 }
};

people.Sort();


Console.ReadKey();

public class Person: IComparable<Person>
{
	public string Name { get; set; }
	public int YearOfBirth { get; set; }

	public int CompareTo(Person other)
	{
		if (YearOfBirth < other.YearOfBirth)
		{
			return 1;
		}
		else if (YearOfBirth > other.YearOfBirth)
		{
			return -1;
		}
		else
		{
			return 0;
		}
	}
}
