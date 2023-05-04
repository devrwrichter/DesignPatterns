using Richter.DesignPatterns.Command.VS;

namespace Richter.DesignPatterns.Command.VS
{
    public class TelevisionVolumeMuteCommand : ICommand
    {
        private IReceiver Receiver { get; set; }

        public TelevisionVolumeMuteCommand(IReceiver receiver)
        {
            this.Receiver = receiver;
        }

        public void Execute()
        {
            this.Receiver.Mute();
        }
    }
}
