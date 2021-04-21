using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    class ShowingFormMapEventArgs : EventArgs
    {
        public ShowingFormMapEventArgs(IList<Package> list) => packages = list;
        public IList<Package> packages { get; set; }
    }
}
