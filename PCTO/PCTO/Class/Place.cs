using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    class Place
    {
        public Place(string number, string road, string town, string province)
        {
            this.Number = number;
            this.Road = road;
            this.Town = town;
            this.Province = province;
        }
        public string Number { get; set; }
        public string Road { get; set; }
        public string Town { get; set; }
        public string Province { get; set; }
    }
}
