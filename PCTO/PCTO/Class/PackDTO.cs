using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    class PackDTO
    {
        public PackDTO(string id = default, int volume = 0, int weight = 0, string number = "",
            string road = "", string town = "", string province = "")
        {
            if (id != default)
                this.Id = id;
            else
                this.Id = Guid.NewGuid().ToString();
            this.Volume = volume;
            this.Weight = weight;
            this.Number = number;
            this.Street = road;
            this.Town = town;
            this.Province = province;
        }
        public override string ToString()
        {
            return $"{this.Id} - {this.Volume} m³ - {this.Weight} Kg - {this.Street} {this.Number}, {this.Town} ({this.Province})";
        }
        public string Id { get; set; }
        public int Volume { get; set; }
        public int Weight { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Province { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public int Confidence { get; set; }

        /// <summary>
        /// Returns a package with all DTO's data
        /// </summary>
        /// <returns></returns>
        public Package ToPackage()
        {
            var binded = Package.GetPackageById(this.Id.ToString());
            if (binded != default)
                return binded;
            else
                return new Package(new Address(this.Number, this.Street, this.Town, this.Province), this.Id, this.Volume, this.Weight);
        }
    }
}
