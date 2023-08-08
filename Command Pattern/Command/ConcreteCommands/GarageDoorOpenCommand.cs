public class GarageDoorOpenCommand : ICommand
{
    GarageDoor _door;

    public GarageDoorOpenCommand(GarageDoor door)
    {
        _door = door;
    }

    public void Execute()
    {
        _door.Open();
    }

    public void Undo()
    {
        _door.Close();
    }
}
