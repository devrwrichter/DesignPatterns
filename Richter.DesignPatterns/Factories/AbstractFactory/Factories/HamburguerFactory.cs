namespace Richter.DesignPattern.AbstractFactory
{
    internal class HamburguerFactory : IHamburguerFactory
    {
        public ILunch Prepare()
        {
            return new Hamburguer();
        }
    }
}
