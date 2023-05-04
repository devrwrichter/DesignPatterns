using FluentAssertions;
using Richter.DesignPatterns.Command.VS;
using Xunit;

namespace Richter.Tests.Command.VSTests
{
    public class VSTests
    {
        [Fact]
        public void Test()
        {
            var invoker = new Invoke();
            IReceiver receiver = new TelevisionVS();

            ICommand cmdMute = new TelevisionVolumeMuteCommand(receiver);
            invoker.SetCommand(cmdMute);
            invoker.ExecuteCommand();
            receiver.State.Should().Be(TelevisionVS.MsgMuted);

            ICommand cmdUnMute = new TelevisionVolumeUnMuteCommand(receiver);
            invoker.SetCommand(cmdUnMute);
            invoker.ExecuteCommand();
            receiver.State.Should().Be(TelevisionVS.MsgUnMuted);

            var volume = 25;
            ICommand cmdSetVolume = new TelevisionSetVolumeCommand(receiver, volume);
            invoker.SetCommand(cmdSetVolume);
            invoker.ExecuteCommand();
            receiver.State.Should().Be(string.Format(TelevisionVS.MsgAdjustVolume, volume));
        }
    }
}
