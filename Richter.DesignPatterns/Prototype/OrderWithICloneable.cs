using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richter.DesignPattern.Prototype
{
    public class OrderWithICloneable : ICloneable
    {
        public IList<Product> Items { get; set; }

        public object Clone()
        {
            return (OrderWithICloneable)MemberwiseClone();
        }
    }
}
