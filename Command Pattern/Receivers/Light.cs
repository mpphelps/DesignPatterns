public class Light
{
    private bool _on;
    private string _desc;
    public Light(string desc)
    {
        _on = false;
        _desc = desc;
    }
    internal void On()
    {
        Console.WriteLine($"{_desc} light was turned on.");
        _on = true;
    }

    internal void Off()
    {
        Console.WriteLine($"{_desc} light was turned off.");
        _on = false;
    }
}
