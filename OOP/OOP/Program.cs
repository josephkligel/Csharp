//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new Mozzarella());
//pizza.AddIngredient(new TomatoSauce());

//Console.WriteLine(pizza.Describe());

//var ingredient = new Ingredient();
//ingredient.PublicField = 10;

//var cheddar = new Cheddar();
//cheddar.PublicField = 20;

//Console.WriteLine("Value in ingredient: " + ingredient.PublicField);
//Console.WriteLine("Value in cheddar: " + cheddar.PublicField);
//Console.WriteLine(cheddar.PublicMethod());
//Console.WriteLine(cheddar.ProtectedMethod());

//Console.WriteLine("Variable of type cheddar");
//Cheddar cheddar = new Cheddar();
//Console.WriteLine(cheddar.Name);

//Console.WriteLine("Variable of type ingredient");
//Ingredient ingredient = new Cheddar();
//Console.WriteLine(ingredient.Name);

//var ingredients = new List<Ingredient>
//{
//    new Cheddar(),
//    new Mozzarella(),
//    new TomatoSauce()
//};

//foreach(Ingredient ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}

//var cheddar = new Cheddar();

//Console.WriteLine(new TomatoSauce());
//Console.WriteLine(new List<int>());

//Console.WriteLine(123);
//Console.WriteLine(new DateTime(2023, 5, 6));
//Console.WriteLine("hello");

//Console.WriteLine(new Pizza());

//var ingredient = new Ingredient(1);

//var cheddar = new Cheddar(2, 12);

//Console.WriteLine(cheddar);

//Ingredient ingredient = new Cheddar(2, 12);
//Ingredient randomIngredient = GenerateRandomIngredient();
//Console.WriteLine("Random ingredient is " + randomIngredient);

//Console.WriteLine($"is object? {ingredient is object}");
//Console.WriteLine($"is ingredient? {ingredient is Ingredient}");
//Console.WriteLine($"is cheddar? {ingredient is Cheddar}");
//Console.WriteLine($"is mozzarella? {ingredient is Mozzarella}");
//Console.WriteLine($"is tomato sauce? {ingredient is TomatoSauce}");

//if (randomIngredient is Cheddar)
//{
//    Cheddar cheddar = (Cheddar)randomIngredient;
//    Console.WriteLine("cheddar object: " + cheddar);
//}
//Ingredient ingredient = GenerateRandomIngredient();
//Console.WriteLine($"Ingredient is {ingredient}");
//Cheddar cheddar = ingredient as Cheddar;

//if (cheddar != null)
//{
//    Console.WriteLine(cheddar.Name);
//}
//else
//{
//    Console.WriteLine("Conversion failed");
//}

//var cheddar = new Cheddar(2, 12);
//var tomatoSauce = new TomatoSauce(1);
//cheddar.Prepare();
//tomatoSauce.Prepare();

//var ingredients = new List<Ingredient>
//{
//    new Cheddar(2, 10),
//    new Mozzarella(2),
//    new TomatoSauce(1)
//};

//foreach (Ingredient ingredient in ingredients)
//{
//    ingredient.Prepare();
//}

//var pizza = RandomPizzaGenerator.Generate(3);

//using OOP.Extensions;

//var multiline = @"aaaa
//bbbb
//cccc
//dddd";

//Console.WriteLine("Count of lines is " + multiline.CountLines());
//Console.WriteLine("Count of lines is " + StringExtensions.CountLines(multiline));

//Console.WriteLine("Next after spring is " + Season.Spring.Next());

//Console.ReadKey();

//public static class RandomPizzaGenerator
//{
//    public static Pizza Generate(int howManyIngredients)
//    {
//        var pizza = new Pizza();
//        for (int i = 0; i < howManyIngredients; ++i)
//        {
//            var randomIngredient = GenerateRandomIngredient();
//            pizza.AddIngredient(randomIngredient);
//        }

//        return pizza;
//    }

//    private static Ingredient GenerateRandomIngredient()
//    {
//        var random = new Random();
//        var number = random.Next(1, 4);
//        if (number == 1) { return new Cheddar(2, 12); }
//        if (number == 2) { return new TomatoSauce(1); }
//        else return new Mozzarella(2);
//    }
//}

var bakeableDishes = new List<IBakeable>
{
    new Pizza(),
    new Panettone(),
};

foreach(var bakeableDish in bakeableDishes)
{
    Console.WriteLine(bakeableDish.GetInstructions());
}

public abstract class Dessert { }

public interface IBakeable
{
    public abstract string GetInstructions();
}

public class Panettone: Dessert, IBakeable
{
    public string GetInstructions() =>
        $"Bake at 180 degrees Celsius for 35 minutes";
}
public class Pizza: IBakeable
{
    public Ingredient ingredient;
    
    private List<Ingredient> _ingredients = new();

    public void AddIngredient(Ingredient ingredient) =>
        _ingredients.Add(ingredient);

	public string GetInstructions()
	{
        return "Bake at 250 degrees Celcius for 10 minutes";
	}

	public override string ToString() =>
        $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public abstract class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine(
            "Contructor from the Ingredient class"
            );
        PriceIfExtraTopping = priceIfExtraTopping;
    }

    public int PriceIfExtraTopping { get; }
    public override string ToString() => Name;
    public virtual string Name { get; } = "Some ingredient";

    public abstract void Prepare();

    public int PublicField;
    public string PublicMethod() =>
        "This method is PUBLIC in the Ingredient class";
    
    protected string ProtectedMethod() =>
        "This method is PROTECTED in the Ingredient class";

    private string PrivateMethod()
    {
        return "This method is PRIVATE in the Igredient class.";
    }

}

public abstract class Cheese : Ingredient
{
    public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }
}

public class Cheddar: Ingredient
{
    public Cheddar(int priceIfExtraTopping, int agedForMonths) 
        : base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonths;
        Console.WriteLine(
            "Contructor from the Cheddar class."
            );
    }
    public override string Name =>
        $"{base.Name}, more specifically, " +
        $"a Cheddar cheese aged for {AgedForMonths} months";
    public int AgedForMonths { get; }

    public override void Prepare()
    {
        Console.WriteLine("Grate and sprinkle on pizza");
    }

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
        //Console.WriteLine(PrivateMethod());
    }

    
}

public class TomatoSauce: Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Tomatoe sauce";
    public int TomatoesIn100Grams { get; }

    public sealed override void Prepare()
    {
        Console.WriteLine("Cook tomatoes with basil, garlic, and salt. " +
            "Spread on pizza.");
    }
}

public sealed class Mozzarella : Ingredient
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Mozarella";
    public bool IsLight { get; }

    public override void Prepare()
    {
        Console.WriteLine("Slice thinly and place on top of pizza.");
    }
}

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter,
}