//var countryToCurrencyMapping = new Dictionary<string, string>()
//{
//	["USA"] = "USD",
//	["India"] = "INR",
//	["Spain"] = "EUR"
//};
////countryToCurrencyMapping.Add("USA", "USD");
////countryToCurrencyMapping.Add("India", "INR");
////countryToCurrencyMapping.Add("Spain", "EUR");

//if (countryToCurrencyMapping.ContainsKey("Spain"))
//{
//	Console.WriteLine($"Currency in Spain is {countryToCurrencyMapping["Spain"]}");
//}

//countryToCurrencyMapping["Poland"] = "PLN";

//foreach(var countryCurrencyPair in countryToCurrencyMapping)
//{
//	Console.WriteLine(
//		$"Country: {countryCurrencyPair.Key}, " +
//		$"currency: {countryCurrencyPair.Value}"
//		);
//}
//{
//	Console.WriteLine();
//}

//Console.ReadKey();

var employees = new List<Employee>
{
    new Employee("Jake Smith", "Space Navigation", 25000),
    new Employee("Anna Blake", "Space Navigation", 29000),
    new Employee("Barbara Oak", "Xenobiology", 21500),
    new Employee("Damien Parker", "Xenobiology", 22000),
    new Employee("Nisha Patel", "Machanics", 21000),
    new Employee("Gustavo Sanchez", "Machanics", 20000)
};

var result = CalculateAverageSalaryPerDepartment(employees);

Console.ReadKey();

Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(
    IEnumerable<Employee> employees
    )
{
    var employeesPerDepartments = new Dictionary<string, List<Employee>>();

    foreach (var employee in employees)
    {
        if(!employeesPerDepartments.ContainsKey(employee.Department))
            employeesPerDepartments[employee.Department] = new List<Employee>();

        employeesPerDepartments[employee.Department].Add(employee);
    }

    var result = new Dictionary<string, decimal>();

    foreach (var employeesPerDepartment in employeesPerDepartments)
    {
        decimal sumOfSalaries = 0;

        foreach (var employee in employeesPerDepartment.Value)
        {
            sumOfSalaries += employee.MonthlySalary;
        }

        var average = sumOfSalaries / employeesPerDepartment.Value.Count;

        result[employeesPerDepartment.Key] = average;
    }

    return result;
}

public class Employee
{
    public Employee(string name, string department, int monthlySalary)
    {
        Name = name;
        Department = department;
        MonthlySalary = monthlySalary;
    }

    public string Name { get; }
    public string Department { get; }
    public int MonthlySalary { get; }
}