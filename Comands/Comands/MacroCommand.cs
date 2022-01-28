namespace Comand.Comands
{
    public class MacroCommand : ICommand
    {
        private ICommand[] commands;
        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }
        public void Execute()
        {
            foreach (ICommand command in commands)
            {
                command.Execute();
            }
        }
        public void Undo()
        {
            foreach (ICommand command in commands)
            {
                command.Undo();
            }
        }
    }
}