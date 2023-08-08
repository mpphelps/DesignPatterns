public class Stereo
{
    private bool _on;
    private int _volume;
    private string _desc;
    public Stereo(string desc)
    {
        _on = false;
        _volume = 0;
        _desc = desc;
    }
    internal void On()
    {
        Console.WriteLine($"{_desc} stereo was turned on.");
        _on = true;
    }

    internal void Off()
    {
        Console.WriteLine($"{_desc} stereo was turned off.");
        _on = false;
    }

    internal void SetCD()
    {
        if (_on)
            Console.WriteLine("Playing the CD.");
    }

    internal void SetVolume(int volume)
    {
        _volume = volume;
        Console.WriteLine($"Stero volume set to {_volume}.");
        
    }
}
