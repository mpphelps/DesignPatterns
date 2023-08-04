public class Program
{
    public static void Main(string[] args)
    {
        /*
         * The singleton pattern restricts the initialization of a class to
         * ensure that only one instance of the class can be created.
         */
        var singleton1 = NaiveSingleton.GetInstance();
        var singleton2 = NaiveSingleton.GetInstance();
        singleton1.Name = "#1";
        singleton2.Name = "#2";
        Console.WriteLine(singleton1.Name);
        Console.WriteLine(singleton2.Name);

        var process1 = new Thread(() =>
        {
            var singleton = ThreadSafeSingleton.GetInstance("Thread 1 initialized singleton");
            Console.WriteLine(singleton.Name);
        });
        var process2 = new Thread(() =>
        {
            var singleton = ThreadSafeSingleton.GetInstance("Thread 2 initialized singleton");
            Console.WriteLine(singleton.Name);
        });
        process1.Start();
        process2.Start();
        process1.Join();
        process2.Join();
    }
}