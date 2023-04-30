using FluentAssertions;
using Richter.DesignPattern.FactoryWithReplacementsAndTracking;
using Xunit;

namespace Richter.Tests.FactoryWithReplacementsAndTracking
{
    public class ReplaceableShapeFactoryTest
    {
        [Fact]
        public void Build_ShouldBeOk()
        {
            //Arrange
            var factory = new ReplaceableShapeFactory();

            //Action
            var result1 = factory.Build(Shapes.Circle, Colors.Red, 10);
            var result2 = factory.Build(Shapes.Star, Colors.Green, 10);
            var result3 = factory.Build(Shapes.Circle, Colors.Green, 10);

            //Assert
            result1.Should().BeOfType<Circle>();
            result2.Should().BeOfType<Star>();

            factory.Info.Should().Be("Shape type: Circle, Color: Red, Shape type: Star, Color: Green, Shape type: Circle, Color: Green");

            //Action to Replace color of circles
            factory.ReplaceShapeColor<Circle>(Colors.Yellow);
            factory.Info.Should().Be("Shape type: Circle, Color: Yellow, Shape type: Star, Color: Green, Shape type: Circle, Color: Yellow");
        }
    }
}
