public class Fan
{
    private int _speed;
    private string _desc;
    public static readonly int HIGH = 3;
    public static readonly int MEDIUM = 2;
    public static readonly int LOW = 1;
    public static readonly int OFF = 0;


    public Fan(string desc)
    {
        _speed = OFF;
        _desc = desc;

    }
    public void High()
    {
        Console.WriteLine($"{_desc} fan speed set to high.");
        _speed = HIGH;
    }
    public void Medium()
    {
        Console.WriteLine($"{_desc} fan speed set to medium.");
        _speed = MEDIUM;
    }
    public void Low()
    {
        Console.WriteLine($"{_desc} fan speed set to low.");
        _speed = LOW;
    }
    public void Off()
    {
        Console.WriteLine($"{_desc} fan turned off.");
        _speed = OFF;
    }
    public int GetSpeed()
    {
        return _speed;
    }
}
