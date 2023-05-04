namespace Richter.DesignPattern.FactoryMethodWithAbstractClass
{
    public interface IAnimal : ISpecificSound
    {
        string Name { get; }
    }
}