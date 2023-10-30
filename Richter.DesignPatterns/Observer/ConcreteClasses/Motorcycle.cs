using Richter.DesignPatterns.Observer.Enumerators;

namespace Richter.DesignPatterns.Observer.ConcreteClasses
{
    public class Motorcycle : AVehicle, IObserver
    {
        public Motorcycle()
        {
            State = string.Empty;
        }
    }
}
