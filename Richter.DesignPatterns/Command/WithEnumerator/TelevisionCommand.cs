namespace Richter.DesignPatterns.Command
{
    public class TelevisionCommand : ICommand
    {
        private Television Television { get; set; }
        private TelevisionAction Action { get; set; }
        public TelevisionCommand(Television television, TelevisionAction action)
        {
            this.Action = action;
            this.Television = television;
        }

        public void Call()
        {
            switch (Action)
            {
                case TelevisionAction.Mute:
                    this.Television.Mute();
                    break;
                case TelevisionAction.UnMute:
                    this.Television.UnMute();
                    break;
                case TelevisionAction.Volume:
                    this.Television.SetVolume();
                    break;
                case TelevisionAction.Channel:
                    this.Television.ChangeChannel();
                    break;
            }
        }
    }
}
