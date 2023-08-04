public class NaiveSingleton
{
    private static NaiveSingleton _instance;
    public string Name { get; set; }
    private NaiveSingleton()
    {
        
    }

    public static NaiveSingleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new NaiveSingleton();
        }
        return _instance;
    }

}