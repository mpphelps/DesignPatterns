public class ClamPizza : Pizza
{
    IPizzaIngredientFactory ingredientFactory;


    public ClamPizza(IPizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        dough = ingredientFactory.CreateDough();
        sauce = ingredientFactory.CreateSauce();
        cheese = ingredientFactory.CreateCheese();
        clam = ingredientFactory.CreateClam();
    }
}