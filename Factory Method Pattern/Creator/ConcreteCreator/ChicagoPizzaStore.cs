public class ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        if (type == "Cheese")
        {
            return new ChicagoStyleCheesePizza();
        }
        else if (type == "Pepperoni")
        {
            return new ChicagoStylePepperoniPizza();
        }
        else return null;
    }
}