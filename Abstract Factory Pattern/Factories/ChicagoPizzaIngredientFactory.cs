public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{


    public IDough CreateDough()
    {
        return new ThickCrustDough();
    }

    public ISauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public ICheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public List<IVeggies> CreateVeggies()
    {
        var veggies = new List<IVeggies>(){ new BlackOlives(),
            new Spinach(),
            new Eggplant() };
        return veggies;
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public IClams CreateClam()
    {
        return new FrozenClams();
    }
}