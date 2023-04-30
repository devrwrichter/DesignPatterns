namespace Richter.DesignPattern.FactoryMethod
{
    public sealed class Creator
    {
        public IProduct FactoryMethod(int month)
        {

            if (month == 12)
                return new ProductA();
            else if (month == 1 || month == 10)
                return new ProductB();
            else
                return new DefaultProduct();
        }
    }
}
