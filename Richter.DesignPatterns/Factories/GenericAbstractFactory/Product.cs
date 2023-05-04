namespace Richter.DesignPattern.AbstractFactory
{
    public class Product
    {
        public IMonitor Monitor { get; set; }
        public IComputer Computer { get; set; }
    }
}
