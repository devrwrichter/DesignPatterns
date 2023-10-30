using Richter.DesignPatterns.Observer.Enumerators;

namespace Richter.DesignPatterns.Observer.ConcreteClasses
{
    public class Pedestrian : IObserver
    {
        public string State { get; set; }
        public void Update(TrafficLightState currentState)
        {
            switch (currentState)
            {
                case TrafficLightState.Closed:
                    State = Constants.PedestrianMoving;
                    break;
                case TrafficLightState.Opened:
                    State = Constants.PedestrianWaiting;
                    break;
                case var _ when State == Constants.PedestrianMoving && currentState.Equals(TrafficLightState.Warning):
                    State = Constants.PedestrianWaiting; 
                    break;
                case var _ when State == Constants.PedestrianWaiting && currentState.Equals(TrafficLightState.Warning):
                    State = Constants.PedestrianWaiting; ;
                    break;
                default:
                    State = Constants.AllLackOfElectricity;
                    break;
            }
        }
    }
}
