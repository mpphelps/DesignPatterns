public class ChicagoPizzaStore : PizzaStore
{


    protected override Pizza CreatePizza(string item)
    {
        Pizza pizza = null;
        IPizzaIngredientFactory ingredientFactory =
            new ChicagoPizzaIngredientFactory();

        if (item == "cheese")
        {

            pizza = new CheesePizza(ingredientFactory);
            pizza.Name = "Chicago Style Cheese Pizza";

        }
        else if (item == "veggie")
        {

            pizza = new VeggiePizza(ingredientFactory);
            pizza.Name = "Chicago Style Veggie Pizza";

        }
        else if (item == "clam")
        {

            pizza = new ClamPizza(ingredientFactory);
            pizza.Name = "Chicago Style Clam Pizza";

        }
        else if (item == "pepperoni")
        {

            pizza = new PepperoniPizza(ingredientFactory);
            pizza.Name = "Chicago Style Pepperoni Pizza";

        }
        return pizza;
    }
}