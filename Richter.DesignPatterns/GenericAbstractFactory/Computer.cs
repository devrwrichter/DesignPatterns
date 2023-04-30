namespace Richter.DesignPattern.AbstractFactory
{
    public class Computer<Brand> : IComputer where Brand : IBrand, new()
    {
        private Brand _brand;

        public Computer()
        {
            _brand = new Brand();
        }
        public string GetColor()
        {
            return _brand.Color;
        }
    }
}
