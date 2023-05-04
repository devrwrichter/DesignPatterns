namespace Richter.DesignPattern.AbstractFactory
{
    internal class OmeletFactory : IOmeletFactory
    {
        public ILunch Prepare()
        {
            return new Omelet();
        }
    }
}
