using Richter.DesignPatterns.Command.JB;
using Xunit;
using static Richter.DesignPatterns.Command.JB.CommandPatternJB;

namespace Richter.Tests.Command.JudithBishopTests
{
    public class JBTest
    {
        [Fact]
        public void Test()
        {
            var cmd = new CommandJB(new Receiver());
            CommandPatternJB.Execute();
            CommandPatternJB.Redo();
            CommandPatternJB.Undo();
            CommandPatternJB.Execute();
        }
    }
}
