using FluentAssertions;
using Richter.DesignPattern.FactoryMethod;
using Xunit;

namespace Richter.Tests
{
    public class FactoryMethodTest
    {
        [Theory]
        [InlineData(12, " entregue do Brasil.")]
        [InlineData(10, " entregue da Franša.")]
        [InlineData(1, " entregue da Franša.")]
        [InlineData(5, " entrega indisponÝvel.")]
        [InlineData(7, " entrega indisponÝvel.")]
        [InlineData(9, " entrega indisponÝvel.")]
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