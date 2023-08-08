public class Program
{
    public static void Main(string[] args)
    {
        /*
         * The adapter pattern converts the interace of a class
         * into another interface the clients expect.  Adapter lets
         * classes work together that couldn't otherwise because of
         * incompatibile interfaces.
         */
        var duck = new MallardDuck();
        var turkey = new WildTurkey();
        var turkeyAdapter = new TurkeyAdapter(turkey);
        Console.WriteLine("The turkey says: ");
        turkey.Gobble();
        turkey.Fly();

        Console.WriteLine("\nThe duck says: ");
        duck.Quack();
        duck.Fly();

        Console.WriteLine("\nThe turkey adapter says: ");
        turkeyAdapter.Quack();
        turkeyAdapter.Fly();
    }
}
