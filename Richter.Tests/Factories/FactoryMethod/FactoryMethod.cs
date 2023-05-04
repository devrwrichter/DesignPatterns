using FluentAssertions;
using Richter.DesignPattern.FactoryMethod;
using Xunit;

namespace Richter.Tests
{
    public class FactoryMethodTest
    {
        [Theory]
        [InlineData(12, " entregue do Brasil.")]
        [InlineData(10, " entregue da França.")]
        [InlineData(1, " entregue da França.")]
        [InlineData(5, " entrega indisponível.")]
        [InlineData(7, " entrega indisponível.")]
        [InlineData(9, " entrega indisponível.")]
        public void FactoryMethod_ShouldBeOk(int month, string msg)
        {
            //Arrange
            Creator creator = new();

            //Action
            var msgResult = creator.FactoryMethod(month).ShipFrom();

            //Assert
            msgResult.Should().Be(msg);
        }
    }
}