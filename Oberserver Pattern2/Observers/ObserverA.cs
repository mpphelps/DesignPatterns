public class ObserverA : IObserver
{
    public void Update(IObservable subject)
    {
        Console.WriteLine($"ObserverA got an update from {subject}");
    }
}