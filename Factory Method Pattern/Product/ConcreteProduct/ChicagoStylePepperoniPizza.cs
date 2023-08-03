public class ChicagoStylePepperoniPizza : Pizza
{

    public ChicagoStylePepperoniPizza()
    {
        _name = "Chicago Style Pepperoni Pizza";
        _dough = "Extra Thick Crust Dough";
        _sauce = "Plum Tomato Sauce";

        _toppings.Add("Shredded Mozzarella Cheese");
        _toppings.Add("Black Olives");
        _toppings.Add("Spinach");
        _toppings.Add("Eggplant");
        _toppings.Add("Sliced Pepperoni");
    }

    public new void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}