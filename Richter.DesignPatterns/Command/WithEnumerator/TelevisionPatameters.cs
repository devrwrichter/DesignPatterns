namespace Richter.DesignPatterns.Command
{
    public record TelevisionPatameters
    {
        public int ChannelNumber { get; set; }
        public int Volume { get; set; }
        public bool Muted { get; set; }
    }
}
