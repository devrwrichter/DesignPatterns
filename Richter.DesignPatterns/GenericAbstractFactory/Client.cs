namespace Richter.DesignPattern.AbstractFactory
{
    internal class Client<Brand> : IClient where Brand : IBrand, new()
    {
        public Product GetProduct()
        {
            IFactory<Brand> factory = new Factory<Brand>();
            IComputer computer = factory.CreateComputer();
            IMonitor monitor = factory.CreateMonitor();

            return new Product { Computer = computer, Monitor = monitor };
        }
    }
}
