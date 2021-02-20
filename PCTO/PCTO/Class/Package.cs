using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    class Package
    {
        public Package(Place destination, int volume = 1, int weight = 1)
        {
            this.Id = _listId.LastOrDefault() + 1;
            _listId.Add(this.Id);
            this._volume = volume;
            this._weight = weight;
            this.Destination = destination;
            _packages.Add(this);
        }
        public int Id { get;  }
        static IList<int> _listId = new List<int>() { 0 };

        int _volume;
        public int Volume { get { return _volume; } set { _volume = PropertyControl.PositiveNumber(value); } }

        int _weight;
        public int Weight { get { return _weight; } set { _weight = PropertyControl.PositiveNumber(value); } }
        public Place Destination { get; set; }

        static IList<Package> _packages = new List<Package>();
        /// <summary>
        /// Returns the package identified by the parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Package GetPackageById(int id)
        {
            return _packages.Where(x => x.Id == id)
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
            return new PackDTO(this.Id, this.Volume, this.Weight, this.Destination.Number, this.Destination.Road, this.Destination.Town, this.Destination.Province);
        }

        /// <summary>
        /// Returns an empty DTO
        /// </summary>
        /// <returns></returns>
        public PackDTO ToEmptyDTO()
        {
            return new PackDTO(this.Id);
        }
        //public PackDTO GetPresetDTO(int x)
        //{
        //    return;
        //}
    }
}
