using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richter.DesignPattern.Prototype
{
    [Serializable]
    public class AddressSerializeble
    {
        public string CEP { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
    }
}
