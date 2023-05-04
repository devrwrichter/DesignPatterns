namespace Richter.DesignPattern.AssynchronousFactory
{
    public interface IVehicle<T>
    {
        Task<T> InitAsync();
    }
}
