using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    class Package
    {
        public Package(int volume, int weight, Place destination)
        {
            this.Volume = volume;
            this.Weight = weight;
            this.Destination = destination;
        }
        public int Volume { get; set; }
        public int Weight { get; set; }
        public Place Destination { get; set; }
    }
}
