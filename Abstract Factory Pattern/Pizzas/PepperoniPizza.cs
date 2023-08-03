public class PepperoniPizza : Pizza
{
    IPizzaIngredientFactory ingredientFactory;


    public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
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
        pepperoni = ingredientFactory.CreatePepperoni();
    }
}