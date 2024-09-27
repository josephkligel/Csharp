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

var cheddar = new Cheddar();

Console.WriteLine(new TomatoSauce());
Console.WriteLine(new List<int>());

Console.WriteLine(123);
Console.WriteLine(new DateTime(2023, 5, 6));
Console.WriteLine("hello");

Console.WriteLine(new Pizza());

Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new();

    public void AddIngredient(Ingredient ingredient) =>
        _ingredients.Add(ingredient);

    public override string ToString() =>
        $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
    public override string ToString() => Name;
    public virtual string Name { get; } = "Some ingredient";

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

public class Cheese: Ingredient
{

}

public class ItalianFood
{

}

public class Cheddar : Cheese
{
    public override string Name => "Cheddar cheese";
    public int AgedForMonths { get; }

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
        //Console.WriteLine(PrivateMethod());
    }

    
}

public class TomatoSauce: Ingredient
{
    public override string Name => "Tomatoe sauce";
    public int TomatoesIn100Grams { get; }
}

public class Mozzarella : Cheese
{
    public override string Name => "Mozarella";
    public bool IsLight { get; }
}