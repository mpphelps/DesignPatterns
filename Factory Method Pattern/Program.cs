public class Program
{
    public static void Main(string[] args)
    {
        /*
         * The Factory Method Pattern: defines an interface
         * for creating an object, but lets subclasses decide which
         * class to instantiate.  Factory Method lets a class defer
         * instantiation to subclasses.
         */

        PizzaStore nyPizzaStore = new NYPizzaStore();
        nyPizzaStore.OrderPizza("Cheese");

        PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
        chicagoPizzaStore.OrderPizza("Pepperoni");

    }
}