//var people = new List<Person>()
//{
//    new Person(){Name = "Anna", YearOfBirth = 1815},
//    new Person(){Name = "Bill", YearOfBirth = 2150}
//};

//var employees = new List<Employee>()
//{
//    new Employee(){Name = "John", YearOfBirth = 1980 },
//    new Employee(){Name = "Anna", YearOfBirth = 1815 }
//};

//var validPeople = GetOnlyValid(people);

//var validEmployees = GetOnlyValid(employees);

//foreach (var employee in validEmployees)
//{
//    employee.GoToWork();
//}

//Console.ReadKey();

//IEnumerable<TPerson> GetOnlyValid<TPerson>(IEnumerable<TPerson> persons)
//    where TPerson : Person
//{
//    var result = new List<TPerson>();

//    foreach (var person in persons)
//    {
//        if (person.YearOfBirth > 1900 &&
//            person.YearOfBirth < DateTime.Now.Year)
//        {
//            result.Add(person);
//        }
//    }

//    return result;
//}

//public class Person
//{
//    public string? Name { get; set; }
//    public int YearOfBirth { get; set; }

//}

//public class Employee: Person
//{
//    public void GoToWork()
//    {
//        Console.WriteLine("Going to work");
//    }
//}
// ----------------------------------------
//var john = new Person { Name = "John", YearOfBirth = 1980 };
//var anna = new Person { Name = "Anna", YearOfBirth = 1915 };

//PrintInOrder(10, 5);

//PrintInOrder("fff", "ddd");

//PrintInOrder(john, anna);

//Console.ReadKey();

//void PrintInOrder<T>(T first, T second) where T: IComparable<T>
//{
//	if (first.CompareTo(second) > 0)
//	{
//        Console.WriteLine($"{second} {first}");
//	}
//	else
//	{
//		Console.WriteLine($"{first} {second}");
//	}
//}

//public class Person : IComparable<Person>
//{
//	public string Name { get; init; }
//	public int YearOfBirth { get; init; }

//    public override string ToString()
//    {
//		return $"{Name} born in {YearOfBirth}";
//    }

//    public int CompareTo(Person other)
//	{
//		if (YearOfBirth < other.YearOfBirth)
//		{
//			return 1;
//		}
//		else if (YearOfBirth > other.YearOfBirth)
//		{
//			return -1;
//		}
//		else
//		{
//			return 0;
//		}
//	}
//}
// ------------------------------------------
//using System.Numerics;

//Console.WriteLine("Square of 2 is: " + Calculator.Square(2));
//Console.WriteLine("Square of 4m is: " + Calculator.Square(4m));
//Console.WriteLine("Square of 6d is: " + Calculator.Square(6d));

//Console.ReadKey();

//public static class Calculator
//{
//	public static T Square<T>(T input) where T: INumber<T> => input * input;
//}

// ------------------------------------------

Console.ReadKey();

void SomeMethod<TPet, TOwner>(TPet pet, TOwner owner) 
	where TPet: Pet, IComparable<TPet>
	where TOwner: new()
{

}

public class Pet { }

public class PetOwner { }
