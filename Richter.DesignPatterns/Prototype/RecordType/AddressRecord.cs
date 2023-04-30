using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richter.DesignPattern.Prototype.RecordType
{
    public record AddressRecord
    {
        public string CEP { get; init; }
        public string City { get; init; }
        public int Number { get; init; }
        public string Street { get; init; }
    }
}
