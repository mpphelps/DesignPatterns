public class FanHighCommand : ICommand
{
    private Fan _fan;
    int prevSpeed;

    public FanHighCommand(Fan fan)
    {
        _fan = fan;
    }

    public void Execute()
    {
        prevSpeed = _fan.GetSpeed();
        _fan.High();
    }

    public void Undo()
    {
        if (prevSpeed == Fan.HIGH)
            _fan.High();
        else if (prevSpeed == Fan.MEDIUM)
            _fan.Medium();
        else if (prevSpeed == Fan.LOW)
            _fan.Low();
        else if (prevSpeed == Fan.OFF)
            _fan.Off();
    }
}