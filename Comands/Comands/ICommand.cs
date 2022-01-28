namespace Comand.Comands
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
