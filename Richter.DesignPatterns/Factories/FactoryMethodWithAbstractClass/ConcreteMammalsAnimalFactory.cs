namespace Richter.DesignPattern.FactoryMethodWithAbstractClass
{
    public class ConcreteMammalsAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Dog:
                    return new Dog();
                case AnimalType.Cat:
                    return new Cat();
                case AnimalType.Mouse:
                    return new Mouse();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
