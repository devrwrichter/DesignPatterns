using FluentAssertions;
using Richter.DesignPattern.AssynchronousFactory;
using System.Threading.Tasks;
using Xunit;

namespace Richter.Tests.AssynchronousFactory
{
    public class AsynchronousFactoryTest
    {
        [Fact]
        public async Task CreateAsync_ShouldBeOk()
        {
            //Arrange/Action
            var moto = await Motorcycle.CreateAsync(2023);

            //Assert
            moto.Should().BeOfType<Motorcycle>();
            moto.Year.Should().Be(2023);
        }
    }
}
