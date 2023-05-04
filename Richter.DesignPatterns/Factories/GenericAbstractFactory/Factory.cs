namespace Richter.DesignPattern.AbstractFactory
{
    internal class Factory<Brand> : IFactory<Brand> where Brand : IBrand, new()
    {
        public IComputer CreateComputer()
        {
            return new Computer<Brand>();
        }

        public IMonitor CreateMonitor()
        {
            return new Monitor<Brand>();
        }
    }
}
