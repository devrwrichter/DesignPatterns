using FluentAssertions;
using Richter.DesignPattern.FactoryMethod;
using Xunit;

namespace Richter.Tests
{
    public class FactoryMethodTest
    {
        [Theory]
        [InlineData(12, " entregue do Brasil.")]
        [InlineData(10, " entregue da Fran�a.")]
        [InlineData(1, " entregue da Fran�a.")]
        [InlineData(5, " entrega indispon�vel.")]
        [InlineData(7, " entrega indispon�vel.")]
        [InlineData(9, " entrega indispon�vel.")]
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