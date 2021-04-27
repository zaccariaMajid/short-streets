using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    public static class Demo
    {
        public static IList<Address> SimulatePreviousAddresses()
        {
            return new List<Address>()
            {
                new Address() {Coordinates=new Coordinates() {Lat=45.690494M, Lng=9.681876M, Confidence=9}},
                new Address("53", "Via G. Tiraboschi", "Bergamo", "BG") {Coordinates=new Coordinates() {Lat=45.69352M, Lng=9.66962M, Confidence=9}},
                new Address("9", "Piazza della Libertà", "Bergamo", "BG") {Coordinates=new Coordinates() {Lat=45.69719M, Lng=9.66965M, Confidence=9}}
            };
        }
    }
}
