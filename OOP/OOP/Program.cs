//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new Mozzarella());
//pizza.AddIngredient(new TomatoSauce());

//Console.WriteLine(pizza.Describe());

var ingredient = new Ingredient();
ingredient.PublicField = 10;

var cheddar = new Cheddar();
cheddar.PublicField = 20;

Console.WriteLine("Value in ingredient: " + ingredient.PublicField);
Console.WriteLine("Value in cheddar: " + cheddar.PublicField);
//Console.WriteLine(cheddar.PublicMethod());
//Console.WriteLine(cheddar.ProtectedMethod());

Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new();

    public void AddIngredient(Ingredient ingredient) =>
        _ingredients.Add(ingredient);

    public string Describe() =>
        $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
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

public class Cheddar : Ingredient
{
    public string Name => "Cheddar cheese";
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
    public string Name => "Tomatoe sauce";
    public int TomatoesIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public string Name => "Mozarella";
    public bool IsLight { get; }
}