public class ThreadSafeSingleton
{
    private static ThreadSafeSingleton _instance;
    private static readonly object _lock = new();
    private string _name;
    public string Name => _name;

    private ThreadSafeSingleton()
    {

    }

    public static ThreadSafeSingleton GetInstance(string name)
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingleton();
                    _instance._name = name;
                }
            }
        }
        return _instance;
    }

}