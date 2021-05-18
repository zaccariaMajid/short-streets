using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    public class RoutingPoint
    {
        public int Id;

        public IList<int> Connected;

        public IList<int> Costs;

        public int Weight;

        public int Volume;

        public bool IsUsed;
    }
}
