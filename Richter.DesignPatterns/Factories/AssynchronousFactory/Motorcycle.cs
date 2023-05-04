namespace Richter.DesignPattern.AssynchronousFactory
{
    public class Motorcycle : IVehicle<Motorcycle>
    {
        public int Year { get;private set; }
        private Motorcycle(int year)
        {
            Year = year;
        }
        public async Task<Motorcycle> InitAsync()
        {
            await Task.Delay(1);
            return this;
        }

        public static Task<Motorcycle> CreateAsync(int year)
        {
            var instance = new Motorcycle(year);
            return instance.InitAsync();
        }
    }
}
