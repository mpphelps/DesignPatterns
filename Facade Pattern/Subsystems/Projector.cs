public class Projector
{
    private StreamingPlayer _player;
    public void On()
    {
        Console.WriteLine("Projector turned on");
    }
    public void Off()
    {
        Console.WriteLine("Projector turned off");
    }
    public void TvMode()
    {
        Console.WriteLine("Projector set to TV mode");
    }
    public void WideScreenMode()
    {
        Console.WriteLine("Projector set to wide screen mode");
    }
}
