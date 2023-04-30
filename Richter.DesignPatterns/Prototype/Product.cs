using Richter.DesignPattern.Prototype.DeepCopy;

namespace Richter.DesignPattern.Prototype
{
    public class Product : IDeepCopy<Product>
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public string? Name { get; set; }

        public void CopyTo(Product target)
        {
            target.Id = Id;
            target.Name = Name;
            target.Value = Value;
        }
    }
}
