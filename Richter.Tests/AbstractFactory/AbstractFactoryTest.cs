using FluentAssertions;
using Richter.DesignPattern.AbstractFactory;
using Xunit;

namespace Richter.Tests.AbstractFactory
{
    public class AbstractFactoryTest
    {
        [Theory]
        [InlineData(LunchType.Omelet, "3 Ovos, tomates e cebola")]
        [InlineData(LunchType.Hamburguer, "Alface, Maionese, Pão, Haburguer e Bacon!")]
        public void Chef_GetLunchs_ShouldBeOk(LunchType type, string descr)
        {
            //Arrange
            var chef = new Chef();

            //Action
            var result = chef.GetLunchs(type);

            //Assert
            result[0].GetDescription().Should().Be(descr);
        }

        [Fact]
        public void Chef_GetLunchsAllItems_ShouldBeOk()
        {
            //Arrange
            var chef = new Chef();

            //Action
            var result = chef.GetLunchs(LunchType.Omelet, LunchType.Hamburguer);

            //Assert
            result.Should().SatisfyRespectively(
                f => f.GetDescription().Should().Be("3 Ovos, tomates e cebola"),
                s => s.GetDescription().Should().Be("Alface, Maionese, Pão, Haburguer e Bacon!")
            );
        }

    }
}
