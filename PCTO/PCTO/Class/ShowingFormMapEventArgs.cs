using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    public class ShowingFormMapEventArgs : EventArgs
    {
        public ShowingFormMapEventArgs(Address address, IList<Package> list)
        {
            CurrentAddress = address;
            Packages = list;
        }
        public Address CurrentAddress { get; set; }
        public IList<Package> Packages { get; set; }
    }
}
