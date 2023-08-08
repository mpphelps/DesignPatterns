public class StreamingPlayer
{
    private Amplifier _amplifier;
    public void On()
    {
        Console.WriteLine($"Streaming player turned on");
    }
    public void Off()
    {
        Console.WriteLine($"Streaming player turned off");
    }
    public void Pause()
    {
        Console.WriteLine($"Streaming player paused");
    }
    public void Play()
    {
        Console.WriteLine($"Streaming player played");
    }
    public void SetSurroundAudio()
    {
        Console.WriteLine($"Streaming player set to surround audio");
    }
    public void SetTwoChannelAudio()
    {
        Console.WriteLine($"Streaming player set to two channel audio");
    }
    public void Stop()
    {
        Console.WriteLine($"Streaming player stopped");
    }
}