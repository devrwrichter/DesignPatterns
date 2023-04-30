namespace Richter.DesignPattern.AbstractFactory
{
    internal interface IFactory<Brand> where Brand : IBrand
    {
        IComputer CreateComputer();
        IMonitor CreateMonitor();

    }
}
