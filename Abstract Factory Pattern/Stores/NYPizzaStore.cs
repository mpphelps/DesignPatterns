public class NYPizzaStore : PizzaStore
{


    protected override Pizza CreatePizza(string item)
    {
        Pizza pizza = null;
        IPizzaIngredientFactory ingredientFactory =
            new NYPizzaIngredientFactory();

        if (item == "cheese")
        {

            pizza = new CheesePizza(ingredientFactory);
            pizza.Name = "New York Style Cheese Pizza";

        }
        else if (item == "veggie")
        {

            pizza = new VeggiePizza(ingredientFactory);
            pizza.Name = "New York Style Veggie Pizza";

        }
        else if (item == "clam")
        {

            pizza = new ClamPizza(ingredientFactory);
            pizza.Name = "New York Style Clam Pizza";

        }
        else if (item == "pepperoni")
        {

            pizza = new PepperoniPizza(ingredientFactory);
            pizza.Name = "New York Style Pepperoni Pizza";

        }
        return pizza;
    }
}