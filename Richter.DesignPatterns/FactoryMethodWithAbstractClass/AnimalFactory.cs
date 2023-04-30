namespace Richter.DesignPattern.FactoryMethodWithAbstractClass
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(AnimalType type);
    }
}
