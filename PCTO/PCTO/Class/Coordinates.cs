using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    public class Coordinates
    {
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public int Confidence { get; set; }
    }
    public static class Confidences
    {
        public static Dictionary<int, string> List = new Dictionary<int, string>()
        {
            {0, "Unable"},
            {1, "> 25 Km"},
            {2, "< 25 Km"},
            {3, "< 20 Km"},
            {4, "< 15 Km"},
            {5, "< 10 Km"},
            {6, "< 7,5 Km"},
            {7, "< 5 Km"},
            {8, "< 1 Km"},
            {9, "< 0,5 Km"},
            {10, "< 0,25 Km"}
        };
    }
}