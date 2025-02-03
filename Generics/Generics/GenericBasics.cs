//var decimals = new List<decimal>() { 1.1m, 0.5m, 22.5m, 12m };
//var ints = decimals.ConvertTo<decimal, int>();

//var floats = new List<float> { 1.4f, -100.01f };
//var longs = floats.ConvertTo<float, long>();

//var dates = new List<DateTime>() { DateTime.Now };
//var longs2 = dates.ConvertTo<DateTime, long>();

//Console.ReadKey();

//static class ListExtentions
//{
//    public static List<TTarget> ConvertTo<TSource, TTarget>(this List<TSource> decimals)
//    {
//        var result = new List<TTarget>();

//        foreach (var item in decimals)
//        {
//            TTarget itemAfterCasting = (TTarget)Convert.ChangeType(item, typeof(TTarget));
//            result.Add(itemAfterCasting);
//        }

//        return result;
//    }
//    public static void AddToFront<T>(this List<T> list, T item)
//    {
//        list.Insert(0, item);
//    }
//}