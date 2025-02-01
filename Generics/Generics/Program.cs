var decimals = new List<decimal>() { 1.1m, 0.5m, 22.5m, 12m};
var ints = decimals.ConvertTo();

Console.ReadKey();

static class ListExtentions
{
    public static List<TTarget> ConvertTo<TSource, TTarget>(this List<TSource> decimals)
    {
        var result = new List<TTarget>();

        foreach(var item in decimals)
        {
            result.Add((typeof(TTarget))item);
        }

        return result;
    }
    public static void AddToFront<T>(this List<T> list, T item)
    {
        list.Insert(0, item);
    }
}
