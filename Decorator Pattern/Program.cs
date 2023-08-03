using System.Net;public class Program
{
    public static void Main(string[] args)
    {
        Beverage beverage = new Espresso();
        Console.WriteLine($"{beverage.GetDescription()} &{beverage.cost()}");
        Beverage beverage2 = new HouseBlendCoffee();
        //beverage2 = new Soy(beverage2);
        beverage2 = new Mocha(beverage2);
        //beverage2 = new Whip(beverage2);
        Console.WriteLine($"{beverage2.GetDescription()} &{beverage2.cost()}");
    }
}

public abstract class Beverage
{
    protected string description = "Unknown Beverage";

    public string GetDescription()
    {
        return description;
    }

    public abstract double cost();
}

public abstract class CondimentDecorator : Beverage
{
    protected Beverage beverage;
    public abstract string GetDescription();
}

public class Espresso : Beverage
{
    public Espresso()
    {
        description = "Espresso";
    }
    public override double cost()
    {
        return 1.99;
    }
}

public class HouseBlendCoffee : Beverage
{
    public HouseBlendCoffee()
    {
        description = "House Blend Coffee";
    }
    public override double cost()
    {
        return 0.89;
    }
}

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage)
    {
        this.beverage = beverage;
    }
    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Mocha";
    }

    public override double cost()
    {
        return beverage.cost() + .20;
    }
}

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage)
    {
        this.beverage = beverage;
    }
    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Soy";
    }

    public override double cost()
    {
        return beverage.cost() + .35;
    }
}

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage)
    {
        this.beverage = beverage;
    }
    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Whip";
    }

    public override double cost()
    {
        return beverage.cost() + .45;
    }
}