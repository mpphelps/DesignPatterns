public class VeggiePizza : Pizza
{
    IPizzaIngredientFactory ingredientFactory;


    public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        dough = ingredientFactory.CreateDough();
        sauce = ingredientFactory.CreateSauce();
        cheese = ingredientFactory.CreateCheese();
        veggies = ingredientFactory.CreateVeggies();
    }
}