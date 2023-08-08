﻿public class LightOffCommand : ICommand
{
    private Light _light;

    public LightOffCommand(Light light)
    {
        this._light = light;
    }

    public void Execute()
    {
        _light.Off();
    }
    public void Undo()
    {
        _light.On();
    }
}
