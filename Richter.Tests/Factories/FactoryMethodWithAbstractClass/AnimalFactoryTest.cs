using FluentAssertions;
using Richter.DesignPattern.FactoryMethodWithAbstractClass;
using Xunit;

namespace Richter.Tests.FactoryMethodWithAbstractClass
{
    public class AnimalFactoryTest
    {
        [Theory]
        [InlineData(AnimalType.Mouse, "Quiiii")]
        [InlineData(AnimalType.Cat, "Miau")]
        [InlineData(AnimalType.Dog, "Au au")]
        public void GetAnimal_ShouldBeOk(AnimalType type, string sound)
        {
            //Arrange
            var factory = new ConcreteMammalsAnimalFactory();

            //Action
            var result = factory.GetAnimal(type).Sounds;

            //Assert
            result.Should().Be(sound);
        }
    }
}
