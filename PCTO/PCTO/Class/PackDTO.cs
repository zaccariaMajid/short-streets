using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    class PackDTO
    {
        public PackDTO (int id = 0, int volume = 0, int weight = 0, string number = "", string road = "", string town = "", string province = "")
        {
            if (id != 0)
                this.Id = id;
            else
                this.Id = Package.GetPackagesQuantity() + 1;
            this.Volume = volume;
            this.Weight = weight;
            this.Number = number;
            this.Road = road;
            this.Town = town;
            this.Province = province;
        }
        public override string ToString()
        {
            return $"{this.Id} - {this.Volume} m³ - {this.Weight} Kg - {this.Road} {this.Number}, {this.Town} ({this.Province})";
        }
        public int Id { get; set; }
        public int Volume { get; set; }
        public int Weight { get; set; }
        public string Number { get; set; }
        public string Road { get; set; }
        public string Town { get; set; }
        public string Province { get; set; }

        /// <summary>
        /// Returns a package with all DTO's data
        /// </summary>
        /// <returns></returns>
        public Package ToPackage()
        {
            var binded = Package.GetPackageById(this.Id);
            if (binded != default)
                return binded;
            else
                return new Package(new Place(this.Number, this.Road, this.Town, this.Province), this.Volume, this.Weight);
        }
    }
}
