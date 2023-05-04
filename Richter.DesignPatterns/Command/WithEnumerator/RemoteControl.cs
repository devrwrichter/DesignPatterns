namespace Richter.DesignPatterns.Command
{
    public class RemoteControl
    {
        private Television _television;
        public string TelevisionState { get; private set; }

        private TelevisionPatameters _defaultParameters = new TelevisionPatameters { ChannelNumber = 1, Muted =  false, Volume = 30 };

        public RemoteControl()
        {
            _television = new(_defaultParameters);
            TelevisionState = _television.State;
        }

        public void Mute()
        {
            TelevisionCommand cmd =  new(_television, TelevisionAction.Mute);
            cmd.Call();
            TelevisionState = _television.State;
        }

        public void UnMute()
        {
            TelevisionCommand cmd = new(_television, TelevisionAction.UnMute);
            cmd.Call();

            TelevisionState = _television.State;
        }

        public void SetVolume(int volume)
        {
            _defaultParameters.Volume = volume;
            _television = new Television(_defaultParameters);
            TelevisionCommand cmd = new(_television, TelevisionAction.Volume);
            cmd.Call();

            TelevisionState = _television.State;
        }

        public void ChangeChannel(int channelNumber)
        {
            _defaultParameters.ChannelNumber = channelNumber;
            _television = new Television(_defaultParameters);
            TelevisionCommand cmd = new(_television, TelevisionAction.Channel);
            cmd.Call();

            TelevisionState = _television.State;
        }
    }
}
