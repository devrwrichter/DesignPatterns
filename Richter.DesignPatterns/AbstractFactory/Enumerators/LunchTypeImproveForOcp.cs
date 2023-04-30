namespace Richter.DesignPattern.AbstractFactory
{
    public enum LunchTypeImproveForOcp
    {
        Unknown = 0,
        [FactoryName("HamburguerFactory")]
        Hamburguer = 1,
        [FactoryName("OmeletFactory")]
        Omelet = 2
    }
}
