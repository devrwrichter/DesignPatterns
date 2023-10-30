using Richter.DesignPatterns.Observer.Enumerators;

namespace Richter.DesignPatterns.Observer
{
    public interface IObserver
    {
        void Update(TrafficLightState currentState);
    }
}
