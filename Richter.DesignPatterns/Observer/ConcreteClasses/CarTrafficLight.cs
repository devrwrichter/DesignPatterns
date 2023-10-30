using Richter.DesignPatterns.Observer.Enumerators;

namespace Richter.DesignPatterns.Observer.ConcreteClasses
{
    public class CarTrafficLight : ISubject
    {
        public IList<IObserver> _observers { get; }
        private TrafficLightState _state;

        public CarTrafficLight()
        {
            _observers = new List<IObserver>();
        }

        public void Notify(TrafficLightState currentState)
        {
            foreach (var observer in _observers)
            {
                observer.Update(_state);
            }
        }

        public void Subscribe(IObserver observer)
        {
            if(!_observers.ToList().Exists(x => x.Equals(observer)))
            {
                _observers.Add(observer);
            }
        }

        public void Unsubscribe(IObserver observer)
        {
            if (_observers.ToList().Exists(x => x.Equals(observer)))
            {
                _observers.Remove(observer);
            }
        }

        internal void Initialize(TrafficLightState semaforoStateCarro)
        {
            _state = semaforoStateCarro;
            Notify(_state);
        }

        internal string GetFriendlyState()
        {
            var result = string.Empty;
            switch (_state)
            {
                case TrafficLightState.Warning:
                    result = Constants.VehicleTrafficLightWarning;
                    break;
                case TrafficLightState.Opened:
                    result = Constants.VehicleTrafficLightOpen;
                    break;
                case TrafficLightState.Closed:
                    result = Constants.VehicleTrafficLightClose;
                    break;
                case TrafficLightState.Unknown:
                    result = Constants.AllLackOfElectricity;
                    break;
            }

            return result;
        }
    }
}
