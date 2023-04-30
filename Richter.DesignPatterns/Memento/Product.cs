using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richter.DesignPattern.Memento
{
    [Serializable]
    public record Product
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
