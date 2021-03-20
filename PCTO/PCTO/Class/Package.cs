using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PCTO
{
    class Package
    {
        public Package(Address destination, int volume = 1, int weight = 1)
        {
            this.Id = Guid.NewGuid();
            this._volume = volume;
            this._weight = weight;
            this.Destination = destination;
            _packages.Add(this);
        }

        public bool IsValid
        {
            get
            {
                return this.Volume > 0 &&
                     this.Weight > 0 &&
                     !string.IsNullOrWhiteSpace(this.Destination.Number) &&
                     !string.IsNullOrWhiteSpace(this.Destination.Road) &&
                     !string.IsNullOrWhiteSpace(this.Destination.Town) &&
                     !string.IsNullOrWhiteSpace(this.Destination.Province);
            }
        }

        public Guid Id { get; }

        int _volume;
        public int Volume
        {
            get { return _volume; }
            set { _volume = PropertyControl.PositiveNumber(value); }
        }

        int _weight;
        public int Weight
        {
            get { return _weight; }
            set { _weight = PropertyControl.PositiveNumber(value); }
        }
        public Address Destination { get; set; }

        static IList<Package> _packages = new List<Package>();

        /// <summary>
        /// Returns the package identified by the parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Package GetPackageById(string id)
        {
            return _packages.Where(x => x.Id.ToString() == id)
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns an int value equal the packages' quantity
        /// </summary>
        /// <returns></returns>
        public static int GetPackagesQuantity()
        {
            return _packages.Count;
        }

        /// <summary>
        /// Returns a DTO with all package's data
        /// </summary>
        /// <returns></returns>
        public PackDTO ToDTO()
        {
            return new PackDTO(this.Id, this.Volume, this.Weight, this.Destination.Number,
                this.Destination.Road, this.Destination.Town, this.Destination.Province);
        }

        /// <summary>
        /// Returns an empty DTO
        /// </summary>
        /// <returns></returns>
        public PackDTO ToEmptyDTO()
        {
            return new PackDTO(this.Id);
        }

        public static List<PackDTO> GetPresetDTO(int x)
        {
            if (x < 1)
                throw new ArgumentException("Parameter must be a positive int value");
            List<Package> resultPackages = GetPackagesFromJson();
            if (x > resultPackages.Count())
                throw new ArgumentException("Parameter too high");
            List<PackDTO> resultPackDTO = new List<PackDTO>();
            foreach (var package in resultPackages.GetRange(0, x))
                resultPackDTO.Add(package.ToDTO());
            return resultPackDTO;
        }
        static List<Package> GetPackagesFromJson()
        {
            StreamReader r = new StreamReader("file.json");
            string json = r.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Package>>(json);
        }
    }
}
