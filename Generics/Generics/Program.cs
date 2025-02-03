var people = new List<Person>()
{
    new Person(){Name = "Anna", YearOfBirth = 1815},
    new Person(){Name = "Bill", YearOfBirth = 2150}
};

var employees = new List<Employee>()
{
    new Employee(){Name = "John", YearOfBirth = 1980 },
    new Employee(){Name = "Anna", YearOfBirth = 1815 }
};

var validPeople = GetOnlyValid(people);

var validEmployees = GetOnlyValid(employees);

foreach (var employee in validEmployees)
{
    employee.GoToWork();
}

Console.ReadKey();

IEnumerable<TPerson> GetOnlyValid<TPerson>(IEnumerable<TPerson> persons)
    where TPerson : Person
{
    var result = new List<TPerson>();

    foreach (var person in persons)
    {
        if (person.YearOfBirth > 1900 &&
            person.YearOfBirth < DateTime.Now.Year)
        {
            result.Add(person);
        }
    }

    return result;
}

public class Person
{
    public string? Name { get; set; }
    public int YearOfBirth { get; set; }

}

public class Employee: Person
{
    public void GoToWork()
    {
        Console.WriteLine("Going to work");
    }
}