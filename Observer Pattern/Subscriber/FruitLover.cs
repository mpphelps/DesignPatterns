class FruitLover
{
    public string Name { get; }

    public FruitLover(string name, FruitNotifier notifier)
    {
        Name = name;
        notifier.FruitAdded += OnFruitAdded;
        notifier.FruitRemoved += OnFruitRemoved;
    }

    private void OnFruitAdded(object sender, FruitAddedEventArgs e)
    {
        Console.WriteLine($"{Name}: Oh! I love {e.FruitName}!");
    }

    private void OnFruitRemoved(string fruitName)
    {
        Console.WriteLine($"{Name}: Oh! I'm sad {fruitName} got removed!");
    }
}