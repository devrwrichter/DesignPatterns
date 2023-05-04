using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richter.DesignPattern.FactoryWithReplacementsAndTracking
{
    public class NullShape : IShape
    {
        public Colors Color { get; set; } = Colors.Unknown;

        public int Radius => 0;
    }
}
