public class Amplifier
{
    private Tuner _tuner;
    private StreamingPlayer _player;
    public void On()
    {
        Console.WriteLine("Amplifier turned on");
    }
    public void Off()
    {
        Console.WriteLine("Amplifier turned off");
    }
    public void SetStreamingPlayer(StreamingPlayer streamingPlayer)
    {
        _player = streamingPlayer;
        Console.WriteLine("Amplifier streaming player set");
    }
    public void SetStereoSound()
    {
        Console.WriteLine("Amplifier stereo sound set");
    }
    public void SetSurroundSound()
    {
        Console.WriteLine("Amplifier surround sound set");
    }
    public void SetTuner(Tuner tuner)
    {
        _tuner = tuner;
        Console.WriteLine("Amplifier tuner set");
    }
    public void SetVolume(int volume)
    {
        Console.WriteLine($"Volume set to {volume}");
    }
}
