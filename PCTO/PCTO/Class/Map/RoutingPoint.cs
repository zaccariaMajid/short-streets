using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    public class RoutingPoint
    {
        public RoutingPoint(int id, List<int> connected, List<int> costs, int weight, int volume, bool isused)
        {
            this.Id = id;
            this.Connected = connected;
            this.Costs = costs;
            this.Weight = weight;
            this.Volume = volume;
            this.IsUsed = isused;
        }

        public int Id;

        public IList<int> Connected;

        public IList<int> Costs;

        public int Weight;

        public int Volume;

        public bool IsUsed;
    }
}
