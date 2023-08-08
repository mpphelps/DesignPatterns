using System.Data;

public class Program
{
    static void Main(string[] args)
    {
        /*
         * The facade pattern provides a unified interface to a
         * set of interfaces in a subssystem. Facade defines a higher
         * level interface that makes the subsystem easier to use.
         */
        var amplifer = new Amplifier();
        var tuner = new Tuner();
        var streamingPlayer = new StreamingPlayer();
        var projector = new Projector();
        var theaterLights = new TheaterLights();
        var screen = new Screen();
        var popcornPopper = new PopcornPopper();
        var homeTheater = new HomeTheatreFacade(amplifer,
                                                tuner,
                                                streamingPlayer,
                                                projector,
                                                theaterLights,
                                                screen,
                                                popcornPopper);
        homeTheater.WatchMovie();
        homeTheater.EndMovie();
    }
}
