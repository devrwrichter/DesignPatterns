using FluentAssertions;
using Richter.DesignPattern.FactoryWithReplacementsAndTracking;
using Xunit;

namespace Richter.Tests.FactoryWithReplacementsAndTracking
{
    public class TrackingShapeFactoryTest
    {
        [Fact]
        public void Build_ShouldBeOk()
        {
            //Arrange
            var factory = new TrackingShapeFactory();

            //Action
            var result1 = factory.Build(Shapes.Circle, Colors.Red, 10);
            var result2 = factory.Build(Shapes.Star,Colors.Green, 10);

            //Assert
            result1.Should().BeOfType<Circle>();
            result2.Should().BeOfType<Star>();

            factory.Info.Should().Be("Circle, Star");
        }
    }
}
