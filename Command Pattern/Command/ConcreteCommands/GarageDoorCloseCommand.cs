public class GarageDoorCloseCommand : ICommand
{
    GarageDoor _door;

    public GarageDoorCloseCommand(GarageDoor door)
    {
        _door = door;
    }

    public void Execute()
    {
        _door.Close();
    }

    public void Undo()
    {
        _door.Open();
    }
}
