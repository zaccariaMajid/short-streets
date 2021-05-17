using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PCTO
{
    public static class LoadFile
    {
        public static FileStream GetStream(string pathfile) => new FileInfo(pathfile).OpenRead();
    }
}
