using System.Globalization;

var numbers = new List<int> { 10, 12, -100, 55, 17, 22 };

Console.WriteLine(@"
Even
Odd
Positive");

var userInput = Console.ReadLine();

var filteringStrategy = new FilteringStrategySelector().Select(userInput);
List<int> result = new NumberFilter().FilterBy(filteringStrategy, numbers);


Print(result);

Console.ReadKey();

void Print(IEnumerable<int> numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}

public class FilteringStrategySelector
{
    private readonly Dictionary<string, Func<int, bool>> _filteringStrategies = new()
    {
        ["Even"] = number => number % 2 == 0,
        ["Odd"] = number => number % 1 == 0,
        ["Postive"] = number => number > 0,
    };
    public Func<int, bool> Select(string filteringType)
    {
        if (!_filteringStrategies.ContainsKey(filteringType))
        {
            throw new NotSupportedException(
                    $"{filteringType} is not supported.");
        }
        else
        {
            return _filteringStrategies[filteringType];
        }
    }
}

public class NumberFilter
{
    
    public List<int> FilterBy(Func<int, bool> predicate, List<int> numbers)
    {
        var result = new List<int>();

        foreach (var number in numbers)
        {
            if (predicate(number))
            {
                result.Add(number);
            }
        }

        return result;
    }

}
