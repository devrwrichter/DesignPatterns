using FluentAssertions;
using Richter.DesignPattern.AbstractFactory;
using Xunit;

namespace Richter.Tests.AbstractFactory
{
    public class AbstractFactoryOCPTest
    {
        [Fact]
        public void Chef_GetLunchsAllItems_ShouldBeOk()
        {
            //Arrange
            var chef = new ChefImprovedForOCP();

            //Action
            var result = chef.GetLunchs(LunchTypeImproveForOcp.Omelet, LunchTypeImproveForOcp.Hamburguer);

            //Assert
            result.Should().SatisfyRespectively(
                f => f.GetDescription().Should().Be("3 Ovos, tomates e cebola"),
                s => s.GetDescription().Should().Be("Alface, Maionese, Pão, Haburguer e Bacon!")
            );
        }
    }
}
