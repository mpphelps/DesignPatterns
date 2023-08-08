public class TheaterLights
{
    public void On()
    {
        Console.WriteLine("Theater light turned on");
    }
    public void Off()
    {
        Console.WriteLine("Theater light turned off");
    }
    public void Dim(int dimness)
    {
        Console.WriteLine($"Theater light dimmed to {dimness}");
    }
}
