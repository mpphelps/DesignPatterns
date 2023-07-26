// See https://aka.ms/new-console-template for more information
public class Program
{
    static void Main()
    {
        FruitNotifier notifier = new FruitNotifier();
        FruitLover alice = new FruitLover("Alice", notifier);
        FruitHater bob = new FruitHater("Bob", notifier);
        FruitLover charlie = new FruitLover("Charlie", notifier);

        notifier.AddFruit("Apple");
        notifier.RemoveFruit("Apple");
        notifier.AddFruit("Banana");
        notifier.AddFruit("Cherry");
    }
}