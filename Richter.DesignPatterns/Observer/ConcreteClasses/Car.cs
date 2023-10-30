using Richter.DesignPatterns.Observer.Enumerators;

namespace Richter.DesignPatterns.Observer.ConcreteClasses
{
    public class Car : AVehicle, IObserver
    {
        public Car()
        {
            State = string.Empty;
        }
    }
}
