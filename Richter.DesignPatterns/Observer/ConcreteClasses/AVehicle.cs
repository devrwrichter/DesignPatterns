using Richter.DesignPatterns.Observer.Enumerators;

namespace Richter.DesignPatterns.Observer.ConcreteClasses
{
    public abstract class AVehicle
    {
        public string State { get; set; }
        public void Update(TrafficLightState currentState)
        {
            switch (currentState)
            {
                case TrafficLightState.Closed:
                    State = Constants.VehicleStopped;
                    break;
                case TrafficLightState.Opened:
                    State = Constants.VehicleMoving;
                    break;
                case var _ when State == Constants.VehicleMoving && currentState.Equals(TrafficLightState.Warning):
                    State = Constants.VehicleSlowingDown;
                    break;
                default:
                    State = Constants.AllLackOfElectricity;
                    break;
            }
        }
    }
}
