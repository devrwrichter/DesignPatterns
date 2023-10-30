using Richter.DesignPatterns.Observer.ConcreteClasses;
using Richter.DesignPatterns.Observer.Enumerators;

double secondsOpened = 0;
var semaforoStates = new List<TrafficLightState>();
var countState = 0;
Console.WriteLine("Cruzamento perigoso!");
Console.WriteLine("Initializing traffic light");
Console.WriteLine("Escolha 1 Semaforo Fechado e 2 para Aberto.");
var vlr = Console.ReadLine();
vlr = ValidateInputSemaforoState(vlr);

Console.WriteLine("Escolha uma quantidade de segundos entre 5 segundos e 45 segundos para operação dos Semaforos");
var vlrSeconds = "0";
vlrSeconds = Console.ReadLine();
vlrSeconds = ValidateInputSeconds(vlrSeconds);
secondsOpened = double.Parse(vlrSeconds);

static string ValidateInputSeconds(string? vlrSeconds)
{
    while (int.Parse(vlrSeconds) < 5 || int.Parse(vlrSeconds) > 45)
    {
        Console.WriteLine($"Escolha uma quantidade de segundos entre 5 segundos e 45 segundos para operação dos Semaforos. Você escolheu: {vlrSeconds}");
        vlrSeconds = Console.ReadLine();
    }

    return vlrSeconds;
}

var stateCarSemaforo = (TrafficLightState)int.Parse(vlr);
Cruzamento cruzamento = new();
AutomateSemaforo(stateCarSemaforo);
await CruzamentoOperateAsync(GetNextState());


static string ValidateInputSemaforoState(string? vlr)
{
    while (vlr != "1" && vlr != "2")
    {
        Console.WriteLine($"Escolha 1 para inicializar o Semaforo carro Fechado e 2 para Aberto. Você escolheu: {vlr}");
        vlr = Console.ReadLine();
    }

    return vlr;
}
async Task SetIntervalAsync()
{
    await Task.Delay(TimeSpan.FromSeconds(secondsOpened));
    await CruzamentoOperateAsync(GetNextState());
}

TrafficLightState GetNextState()
{
    var state = semaforoStates[countState];
    if (countState <= 1)
        countState++;
    else
        countState = 0;
    return state;
}

void AutomateSemaforo(TrafficLightState semaforoStateCarro)
{
    if (semaforoStateCarro.Equals(TrafficLightState.Opened))
    {
        semaforoStates.Add(TrafficLightState.Opened);
        semaforoStates.Add(TrafficLightState.Warning);
        semaforoStates.Add(TrafficLightState.Closed); 
    }
    else
    {
        semaforoStates.Add(TrafficLightState.Closed);
        semaforoStates.Add(TrafficLightState.Opened);
        semaforoStates.Add(TrafficLightState.Warning);
    }
}

async Task CruzamentoOperateAsync(TrafficLightState state)
{
    
    cruzamento.Initialize(state);

    var trafficVehicle = cruzamento.GetVehicleTrafficState();
    Console.ForegroundColor = trafficVehicle.color;
    Console.WriteLine(trafficVehicle.nameState);

    var trafficPedestrian = cruzamento.GetPedestrianTrafficLightState();
    Console.ForegroundColor = trafficPedestrian.color;
    Console.WriteLine(trafficPedestrian.nameState);


    var vehicleState = cruzamento.GetFriendlyVehycleState();
    Console.ForegroundColor = vehicleState.color;
    Console.WriteLine($"Cars {vehicleState.nameState}, count: {cruzamento.CarCount}");
    Console.WriteLine($"Motorcycle {vehicleState.nameState}, count: {cruzamento.MotorCycleCount}");

    var pedestrianState = cruzamento.GetPedestriansState();
    Console.ForegroundColor = pedestrianState.color;
    Console.WriteLine($"{pedestrianState.nameState}, count: {cruzamento.PedestriansCount}");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("*****************************************************");

    await SetIntervalAsync();
}