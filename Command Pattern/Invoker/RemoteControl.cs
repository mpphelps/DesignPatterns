using System.Text;

public class RemoteControl
{
    private ICommand[] _onCommands;
    private ICommand[] _offCommands;
    private ICommand _undoCommand;

    public RemoteControl()
    {
        _onCommands = new ICommand[7];
        _offCommands = new ICommand[7];

        ICommand noCommand = new NoCommand();
        for (int i = 0; i < 7; i++)
        {
            _onCommands[i] = noCommand;
            _offCommands[i] = noCommand;
        }
        _undoCommand = new NoCommand();
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
        _onCommands[slot].Execute();
        _undoCommand = _onCommands[slot];
    }

    public void OffButtonWasPushed(int slot)
    {
        _offCommands[slot].Execute();
        _undoCommand = _offCommands[slot];
    }

    public void UndoButtonWasPushed()
    {
        Console.WriteLine("Undo last action.");
        _undoCommand.Undo();
    }

    public override string ToString()
    {
        var buffer = new StringBuilder();
        buffer.Append($"\n------- Remote Control -------");
        for (int i = 0; i < _onCommands.Length; i++)
        {
            buffer.Append($"\n[slot {i+1}] {_onCommands[i].GetType().Name} {_offCommands[i].GetType().Name}");
        }
        buffer.Append($"\n[undo] {_undoCommand.GetType().Name}");
        return buffer.ToString();
    }
}
