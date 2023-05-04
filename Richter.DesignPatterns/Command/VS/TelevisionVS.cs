namespace Richter.DesignPatterns.Command.VS
{
    public class TelevisionVS : IReceiver
    {
        public const string MsgMuted = "Volume Muted";
        public const string MsgUnMuted = "Volume UnMuted";
        public const string MsgAdjustVolume = "Volume set to {0}";

        public string State { get; private set; }
        public void Mute()
        {
            State = MsgMuted;
        }

        public void SetVolume(int volume)
        {
            State = string.Format(MsgAdjustVolume, volume);
        }

        public void UnMute()
        {
            State = MsgUnMuted;
        }
    }
}
