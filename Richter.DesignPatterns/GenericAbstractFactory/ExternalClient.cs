using Richter.DesignPattern.GenericAbstractFactory.Brand;

namespace Richter.DesignPattern.AbstractFactory
{
    public class ExternalClient
    {
        public static Product GetProduct(BrandType brandType)
        {
            switch (brandType)
            {
                case BrandType.Dell:
                    return new Client<Dell>().GetProduct();
                case BrandType.Apple:
                    return new Client<Apple>().GetProduct();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
