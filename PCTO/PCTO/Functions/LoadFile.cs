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
        public static async Task<FileStream> GetStreamAsync(string pathfile) => await Task.Run(() => new FileInfo(pathfile).OpenRead());
    }
}
