public class StereoOffWithCDCommand : ICommand
{
    private Stereo _stereo;

    public StereoOffWithCDCommand(Stereo stereo)
    {
        _stereo = stereo;
    }

    public void Execute()
    {
        _stereo.Off();
        _stereo.SetCD();
        _stereo.SetVolume(0);
    }

    public void Undo()
    {
        _stereo.On();
        _stereo.SetCD();
        _stereo.SetVolume(11);
    }
}
