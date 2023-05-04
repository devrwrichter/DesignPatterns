namespace Richter.DesignPatterns.Command
{
    public class Television 
    {
        public const string MsgMuted = "The TV volume is muted.";
        public const string MsgUnMuted = "The TV volume is inmuted.";        

        public string State { get; private set; }

        private TelevisionPatameters Parameters { get; set; }

        public Television(TelevisionPatameters parameters)
        {
            this.State = parameters.Muted ? MsgMuted : MsgUnMuted;
            this.Parameters = parameters;
        }

        internal void Mute()
        {
            State = MsgMuted;
        }

        internal void UnMute()
        {
            State = MsgUnMuted;
        }

        internal void SetVolume()
        {
            UnMute();
            State = MsgUnMuted + $" Volume set to {Parameters.Volume}";
        }

        internal void ChangeChannel()
        {
            State = State + $" Channel changed to {Parameters.ChannelNumber}";
        }
    }
}
