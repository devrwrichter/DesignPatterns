using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richter.DesignPattern.Prototype
{
    [Serializable]
    public class OrderSerializable
    {
        public IList<ProductSerializable> Items { get; set; } = new List<ProductSerializable>();
        public AddressSerializeble Address { get; set; } = new AddressSerializeble();
    }
}
