namespace Richter.DesignPattern.AbstractFactory
{
    public class Monitor<Brand> : IMonitor where Brand : IBrand, new()
    {
        private Brand _brand;

        public Monitor()
        {
            _brand = new Brand();
        }
        public string GetColor()
        {
            return _brand.Color;
        }
    }
}
