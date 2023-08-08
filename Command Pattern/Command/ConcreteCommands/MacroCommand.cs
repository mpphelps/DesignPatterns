public class MacroCommand : ICommand
{
    private List<ICommand> _commands;

    public MacroCommand(List<ICommand> commands)
    {
        _commands = commands;
    }

    public void Execute()
    {
        for(int i = 0; i < _commands.Count; i++)
        {
            _commands[i].Execute();
        }
    }

    public void Undo()
    {
        for (int i = 0; i < _commands.Count; i++)
        {
            _commands[i].Undo();
        }
    }
}