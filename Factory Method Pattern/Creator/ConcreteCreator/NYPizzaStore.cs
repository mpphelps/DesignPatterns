public class NYPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        if (type == "Cheese")
        {
            return new NYStyleCheesePizza();
        }
        else if (type == "Pepperoni")
        {
            return new NYStylePepperoniPizza();
        }
        else return null;
    }
}