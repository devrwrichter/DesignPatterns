using Richter.DesignPattern.Prototype.DeepCopy;
using Richter.DesignPattern.Prototype.Help;

namespace Richter.DesignPattern.Prototype
{
    public class OrderDeepCopy : IDeepCopy<OrderDeepCopy>
    {
        public IList<Product> Items { get; set; } =  new List<Product>();
        public AddressDeepCopy Address { get; set; } =  new AddressDeepCopy();

        public void CopyTo(OrderDeepCopy target)
        {
            //for (int i = 0; i < Items.Count; i++)
            //{

            //    //if (target.Items.Count != Items.Count)
            //    //{
            //    //    Product product = new Product();
            //    //   // Items[i].CopyTo(product);

            //    //    //target.Items.Add(product);

            //    //    target.Items.Add(Items[i].DeepCopy());
            //    //}
            //    //else
            //    //    Items[i].CopyTo(target.Items[i]);
            //}

            target.Items =  new List<Product>(Items);

            Address.CopyTo(target.Address);
        }
    }
}
