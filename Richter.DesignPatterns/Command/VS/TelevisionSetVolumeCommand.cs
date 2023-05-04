using Richter.DesignPatterns.Command.VS;

namespace Richter.DesignPatterns.Command.VS
{
    public class TelevisionSetVolumeCommand : ICommand
    {
        private IReceiver Receiver { get; set; }
        private int Volume { get; set; }

        public TelevisionSetVolumeCommand(IReceiver receiver, int volume)
        {
            Receiver = receiver;
            Volume = volume;
        }

        public void Execute()
        {
            Receiver.SetVolume(Volume);
        }
    }
}
