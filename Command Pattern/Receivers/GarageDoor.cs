public class GarageDoor
{
    private bool _open;
    private string _desc;
    public GarageDoor(string desc)
    {
        _open = false;
        _desc = desc;
    }
    internal void Open()
    {
        Console.WriteLine($"{_desc} door was opened.");
        _open = true;
    }

    internal void Close()
    {
        Console.WriteLine($"{_desc} door was closed.");
        _open = false;
    }
}
