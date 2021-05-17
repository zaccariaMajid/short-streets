using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    public class RoutingPoint
    {
        public int Id { get; set; }
        public int Volume { get; set; }
        public int Weight { get; set; }
        public IList<Vertex> Vertices { get; set; }
        public bool IsUsed { get; set; }
    }
    public struct Vertex
    {
        public int Id { get; set; }
        public int Distance { get; set; }
    }
}
