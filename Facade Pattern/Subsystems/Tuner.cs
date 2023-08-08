public class Tuner
{
    private Amplifier _amplifer;
    public void On()
    {
        Console.WriteLine("Tuner turned on");
    }
    public void Off()
    {
        Console.WriteLine("Tuner turned off");
    }
    public void SetAM()
    {
        Console.WriteLine("Tuner set to AM");
    }
    public void SetFM()
    {
        Console.WriteLine("Tuner set to FM");
    }
    public void SetFrequency(float frequency)
    {
        Console.WriteLine($"Tuner frequency set to {frequency}");
    }
}
