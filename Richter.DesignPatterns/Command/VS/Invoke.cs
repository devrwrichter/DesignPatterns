namespace Richter.DesignPatterns.Command.VS
{
    public class Invoke
    {
        ICommand Command;
        public void SetCommand(ICommand command)
        {
            Command = command;
        }
        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }
}
