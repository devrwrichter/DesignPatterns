using Richter.DesignPatterns.Observer.Enumerators;

namespace Richter.DesignPatterns.Observer.ConcreteClasses
{
    public sealed class Cruzamento
    {
        public int PedestriansCount = 0;
        public int CarCount = 0;
        public int MotorCycleCount = 0;
        
        public CarTrafficLight _carTrafficLight = new();
        public PedestrianTrafficLight _pedestrianTrafficLight = new();
        
        public IDictionary<string, ConsoleColor> _dicColors = new Dictionary<string, ConsoleColor>() {
            { Constants.VehicleStopped, ConsoleColor.Red },
            { Constants.VehicleMoving, ConsoleColor.Green },
            { Constants.PedestrianWaiting, ConsoleColor.Red },
            { Constants.PedestrianMoving, ConsoleColor.Green },
            { Constants.VehicleTrafficLightWarning, ConsoleColor.Yellow },
            { Constants.VehicleTrafficLightOpen, ConsoleColor.Green },
            { Constants.VehicleTrafficLightClose, ConsoleColor.Red },            
            { Constants.PedestrianTrafficLightOpen, ConsoleColor.Green },
            { Constants.PedestrianTrafficLightClose, ConsoleColor.Red },
            { Constants.VehicleSlowingDown, ConsoleColor.Yellow }
        };

        public IList<Car> _cars =  new List<Car>();
        public IList<Motorcycle> _motorcycles = new List<Motorcycle>();
        public IList<Pedestrian> _pedestrians = new List<Pedestrian>();

        public void Initialize(TrafficLightState semaforoStateCarro)
        {
            Random random = new();            
            
            var state = GetVehicleState();
            if (state == Constants.VehicleMoving)
            {
                CarCount = random.Next(1, 7);
                MotorCycleCount = random.Next(1, 3);
                InitializeCars();
                InitializeMotoCycle();
            }
            else if(state == Constants.VehicleStopped)
            {
                PedestriansCount = random.Next(1, 6);
                InitializePedestres();
            }else
            {
                CarCount = random.Next(1, 7);
                MotorCycleCount = random.Next(1, 3);
                PedestriansCount = random.Next(1, 6);
                InitializeCars();
                InitializeMotoCycle();
                InitializePedestres();
            }

            _carTrafficLight.Initialize(semaforoStateCarro);
            _pedestrianTrafficLight.Initialize(semaforoStateCarro);
        }

        private void InitializePedestres()
        {
            _pedestrians.Clear();
            var state = GetPedestresState();
            for (int i = 0; i < PedestriansCount; i++)
            {
                Pedestrian pedestre = new() { State = state };
                _pedestrians.Add(pedestre);
                _pedestrianTrafficLight.Subscribe(pedestre);
            }

            _carTrafficLight.Subscribe(_pedestrianTrafficLight);
        }

        private string GetVeicleState()
        {
            if (_carTrafficLight.Equals(TrafficLightState.Closed))
                return Constants.VehicleStopped;
            else
                return Constants.VehicleMoving;
        }

        private string GetPedestresState()
        {
            if (_carTrafficLight.Equals(TrafficLightState.Closed))
                return Constants.PedestrianMoving;
            else
                return Constants.PedestrianWaiting;
        }

        private void InitializeMotoCycle()
        {
            _motorcycles.Clear();
            var state = GetVeicleState();
            for (int i = 0; i < MotorCycleCount; i++)
            {
                Motorcycle moto = new() { State = state };
                _motorcycles.Add(moto);
                _carTrafficLight.Subscribe(moto);
            }
        }

        private void InitializeCars()
        {
            _cars.Clear();
            var state = GetVeicleState();
            for (int i = 0; i < CarCount; i++)
            {
                Car carro = new() { State = state };
                _cars.Add(carro);
                _carTrafficLight.Subscribe(carro);
            }
        }

        private string? GetVehicleState()
        {
            return _cars.FirstOrDefault()?.State;
        }

        public (string nameState, ConsoleColor color) GetVehicleTrafficState()
        {
            var state = _carTrafficLight.GetFriendlyState();
            return (state, _dicColors[state]);
        }

        public (string nameState, ConsoleColor color) GetPedestrianTrafficLightState()
        {
            var state = _pedestrianTrafficLight.GetFriendlyState();
            return (state, _dicColors[state]);
        }

        public (string nameState, ConsoleColor color) GetFriendlyVehycleState()
        {
            var state = _cars.First().State;
            return (state, _dicColors[state]);
        }

        public (string nameState, ConsoleColor color) GetPedestriansState()
        {
            var state = _pedestrians.First().State;
            return (state, _dicColors[state]); ;
        }
    }
}
