public class HomeTheatreFacade
{
    private Amplifier _amplifier;
    private Tuner _tuner;
    private StreamingPlayer _streamingPlayer;
    private Projector _projector;
    private TheaterLights _theaterLights;
    private Screen _screen;
    private PopcornPopper _popcornPopper;

    public HomeTheatreFacade(Amplifier amplifer,
                             Tuner tuner,
                             StreamingPlayer streamingPlayer,
                             Projector projector,
                             TheaterLights theaterLights,
                             Screen screen,
                             PopcornPopper popcornPopper)
    {
        _amplifier = amplifer;
        _tuner = tuner;
        _streamingPlayer = streamingPlayer;
        _projector = projector;
        _theaterLights = theaterLights;
        _screen = screen;
        _popcornPopper = popcornPopper;
    }

    public void WatchMovie()
    {
        Console.WriteLine("Get ready to watch a movie");
        _popcornPopper.On();
        _popcornPopper.Pop();
        _theaterLights.Dim(10);
        _screen.Down();
        _projector.On();
        _projector.WideScreenMode();
        _amplifier.On();
        _amplifier.SetStreamingPlayer(_streamingPlayer);
        _amplifier.SetSurroundSound();
        _amplifier.SetVolume(5);
        _streamingPlayer.On();
        _streamingPlayer.Play();
    }
    public void EndMovie()
    {
        Console.WriteLine("Shutting movie theatre down");
        _popcornPopper.Off();
        _theaterLights.Off();
        _screen.Up();
        _projector.Off();
        _amplifier.Off();
        _streamingPlayer.Stop();
        _streamingPlayer.Off();
    }
    public void ListenToRadio() { }
    public void EndRadio() { }
}
