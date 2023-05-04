using Richter.DesignPatterns.Command.VS;
namespace Richter.DesignPatterns.Command.VS
{
    public class TelevisionVolumeUnMuteCommand : ICommand
    {
        private IReceiver Receiver { get; set; }

        public TelevisionVolumeUnMuteCommand(IReceiver receiver)
        {
            this.Receiver = receiver;
        }

        public void Execute()
        {
            this.Receiver.UnMute();
        }
    }
}
