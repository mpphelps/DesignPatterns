class FruitNotifier
{
    public event EventHandler<FruitAddedEventArgs> FruitAdded;
    public event Action<string> FruitRemoved;

    public void AddFruit(string fruitName)
    {
        OnFruitAdded(new FruitAddedEventArgs(fruitName));
    }

    public void RemoveFruit(string fruitName)
    {
        OnFruitRemoved(fruitName);
    }

    protected virtual void OnFruitAdded(FruitAddedEventArgs e)
    {
        FruitAdded?.Invoke(this, e);
    }

    protected virtual void OnFruitRemoved(string name)
    {
        FruitRemoved.Invoke(name);
    }
}