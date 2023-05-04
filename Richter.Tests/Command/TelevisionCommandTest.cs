using FluentAssertions;
using Richter.DesignPatterns.Command;
using Xunit;

namespace Richter.Tests.Command
{
    public class TelevisionCommandTest
    {
        [Fact]
        public void TestCommand()
        {
            RemoteControl remoteCtrl = new();
            remoteCtrl.TelevisionState.Should().Be(Television.MsgUnMuted);
            
            remoteCtrl.Mute();
            remoteCtrl.TelevisionState.Should().Be(Television.MsgMuted);
            
            remoteCtrl.UnMute();
            remoteCtrl.TelevisionState.Should().Be(Television.MsgUnMuted);

            
            //Aumentando o Volume
            remoteCtrl.SetVolume(50);
            remoteCtrl.TelevisionState.Should().Be("The TV volume is inmuted. Volume set to 50");

            //Aumentando o Volume
            remoteCtrl.ChangeChannel(400);
            remoteCtrl.TelevisionState.Should().Be("The TV volume is inmuted. Channel changed to 400");
        }
    }
}
