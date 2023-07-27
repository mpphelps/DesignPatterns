public class ObserverB : IObserver
{
    public void Update(IObservable subject)
    {
        Console.WriteLine($"ObserverB got an update from {subject}");
    }
}