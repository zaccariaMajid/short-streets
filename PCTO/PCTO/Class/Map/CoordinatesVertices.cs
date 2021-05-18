using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itinero;
using Itinero.Osm.Vehicles;
using System.IO;
using Itinero.IO.Osm;

namespace PCTO
{
    public class CoordinatesVertices
    {
        // int value  -> distance
        public Dictionary<Coordinates, int> Coordinates { get; set; }
        public Coordinates CurrentPosition { get; set; }

    }
    public static class CoordinatesVerticesMaker
    {
        public static CoordinatesVertices NewCoordinatesvertices(Coordinates c, IList<Coordinates> list, RouterDb rdb)
        {
            Dictionary<Coordinates, int> dictionary = new Dictionary<Coordinates, int>();
            var router = new Router(rdb);
            var profile = Vehicle.Pedestrian.Fastest();
            var start = router.Resolve(profile, float.Parse(c.Lat.ToString()), float.Parse(c.Lng.ToString()));
            foreach (var coordinates in list)
            {
                var end = router.Resolve(profile, float.Parse(coordinates.Lat.ToString()), float.Parse(coordinates.Lng.ToString()));
                var route = router.Calculate(profile, start, end);
                int distance = (int)route.TotalDistance;
                dictionary.Add(coordinates, distance);
            }
            return new CoordinatesVertices() { CurrentPosition = c, Coordinates = dictionary };
        }
    }
}
