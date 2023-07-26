public class FruitAddedEventArgs : EventArgs
{
    public string FruitName { get; }

    public FruitAddedEventArgs(string fruitName)
    {
        FruitName = fruitName;
    }
}