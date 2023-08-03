public abstract class Pizza
{
    protected string _name;
    protected string _dough;
    protected string _sauce;
    protected List<string> _toppings = new List<string>();
    public void Prepare()
    {
        Console.WriteLine($"Preparing {_name}");
        Console.WriteLine($"Tossing dough...");
        Console.WriteLine($"Adding sauce...");
        Console.WriteLine($"Adding toppings:...");
        foreach (var topping in _toppings)
        {
            Console.WriteLine($" {topping}");
        }
    }

    public void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }
}