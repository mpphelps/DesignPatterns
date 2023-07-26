class FruitHater
{
    public string Name { get; }
    public FruitHater(string name, FruitNotifier notifier)
    {
        Name = name;
        notifier.FruitAdded += OnFruitAdded;
    }

    private void OnFruitAdded(object sender, FruitAddedEventArgs e)
    {
        Console.WriteLine($"{Name}: Oh! I hate {e.FruitName}, it should be removed!");
    }
}