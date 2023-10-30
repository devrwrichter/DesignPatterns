using Richter.DesignPatterns.Observer.Enumerators;

namespace Richter.DesignPatterns.Observer.ConcreteClasses
{
    public class PedestrianTrafficLight : ISubject, IObserver
    {
        public IList<IObserver> _observers { get; }
        private TrafficLightState _state;
        public string State { get; set; }

        public PedestrianTrafficLight()
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
            if (!_observers.ToList().Exists(x => x.Equals(observer)))
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

        public void Update(TrafficLightState currentState)
        {
            switch (currentState)
            {
                case TrafficLightState.Closed:
                    State = Constants.VehicleTrafficLightOpen;
                    break;
                case TrafficLightState.Opened:
                    State = Constants.VehicleTrafficLightClose;
                    break;
                case TrafficLightState.Warning:
                    State = Constants.VehicleTrafficLightClose;
                    break;
                default:
                    State = Constants.AllLackOfElectricity;
                    break;
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
                case TrafficLightState.Opened:
                    result = Constants.PedestrianTrafficLightClose;
                    break;
                case TrafficLightState.Closed:
                    result = Constants.PedestrianTrafficLightOpen;
                    break;
                case TrafficLightState.Warning:
                    result = Constants.PedestrianTrafficLightClose;
                    break;
                case TrafficLightState.Unknown:
                    result = Constants.AllLackOfElectricity;
                    break;
            }

            return result;
        }
    }
}
