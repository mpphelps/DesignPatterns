using System.Text;

public abstract class Pizza
{
    public string Name { get; set; }

    protected IDough dough;
    protected ISauce sauce;
    protected List<IVeggies> veggies;
    protected ICheese cheese;
    protected IPepperoni pepperoni;
    protected IClams clam;

    public abstract void Prepare();

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

    public string ToString()
    {
        var result = new StringBuilder();
        result.Append("---- " + Name + " ----\n");
        if (dough != null)
        {
            result.Append(dough);
            result.Append("\n");
        }
        if (sauce != null)
        {
            result.Append(sauce);
            result.Append("\n");
        }
        if (cheese != null)
        {
            result.Append(cheese);
            result.Append("\n");
        }
        if (veggies != null)
        {
            for (int i = 0; i < veggies.Count; i++)
            {
                result.Append(veggies[i]);
                if (i < veggies.Count - 1)
                {
                    result.Append(", ");
                }
            }
            result.Append("\n");
        }
        if (clam != null)
        {
            result.Append(clam);
            result.Append("\n");
        }
        if (pepperoni != null)
        {
            result.Append(pepperoni);
            result.Append("\n");
        }
        return result.ToString();
    }
}