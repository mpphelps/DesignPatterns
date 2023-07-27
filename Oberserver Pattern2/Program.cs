using System.Net.Mail;

public class Program
{
    public static void Main(string[] args)
    {
        IObservable subject = new Subject();
        IObserver observer1 = new ObserverA();
        IObserver observer2 = new ObserverB();
        subject.Attach(observer1);
        subject.Attach(observer2);
        subject.Notify();
        subject.Detach(observer1);
        subject.Detach(observer2);
    }
}