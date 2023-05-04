namespace Richter.DesignPatterns.Command.VS
{
    public interface IReceiver
    {
        void Mute();
        void UnMute();
        void SetVolume(int volume); 

        string State { get; }
    }
}
