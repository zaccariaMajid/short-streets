using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    class PackDTO
    {
        public PackDTO (int id, int volume, int weight, string number="29", string road = "Via Mauro Gavazzeni", string town = "Bergamo", string province = "BG")
        {
            this.Id = id;
            this.Volume = volume;
            this.Weight = weight;
            this.Number = number;
            this.Road = road;
            this.Town = town;
            this.Province = province;
        }
        public int Id { get; set; }
        public int Volume { get; set; }
        public int Weight { get; set; }
        public string Number { get; set; }
        public string Road { get; set; }
        public string Town { get; set; }
        public string Province { get; set; }

        public Package ToPackage()
        {
            var binded = Package.GetPackages().Where(x => x.Id == this.Id).SingleOrDefault();
            if (binded != null)
                return binded;
            else
                return new Package(new Place(this.Number, this.Road, this.Town, this.Province), this.Volume, this.Weight);
        }
    }
}
