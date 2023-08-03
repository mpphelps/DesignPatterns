public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza()
    {
        _name = "Chicago Style Deep Dish Cheese Pizza";
        _dough = "Extra Thick Crust Dough";
        _sauce = "Plum Tomato Sauce";
        _toppings.Add("Shredded Mozzarella Cheese");
    }

    public new void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}