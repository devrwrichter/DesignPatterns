using Richter.DesignPatterns.Observer.Enumerators;

namespace Richter.DesignPatterns.Observer
{
    public interface ISubject
    {
        IList<IObserver> _observers { get; }
        void Notify(TrafficLightState currentState);
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
    }
}
