using FluentAssertions;
using Richter.DesignPattern.AbstractFactory;
using Richter.DesignPattern.GenericAbstractFactory.Brand;
using Xunit;

namespace Richter.Tests.AbstractFactory
{
    public class GenericAbstractFactoryTest
    {
        [Theory]
        [InlineData(BrandType.Dell, "Black")]
        [InlineData(BrandType.Apple, "White")]
        public void GetProduct_DellProduct_ShouldBeOk(BrandType brand, string color)
        {
            //Arrange & Action
            var product = ExternalClient.GetProduct(brand);

            //Assert
            product.Computer.GetColor().Should().Be(color);
            product.Monitor.GetColor().Should().Be(color);
        }
    }
}
