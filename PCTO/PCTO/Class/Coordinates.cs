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
        decimal _lat;
        public decimal Lat 
        { 
            get => _lat; 
            set => _lat = ControlLatitude(value); 
        }

        decimal _lng;
        public decimal Lng 
        { 
            get => _lng;
            set => _lng = ControlLongitude(value); 
        }
        public int Confidence { get; set; }
        public override string ToString()
        {
            return $"{Lat}, {Lng} (Confidence: {Confidence})";
        }
        static decimal ControlLatitude(decimal lat)
        {
            if (lat < -90.0M)
                return -90.0M;
            else if (lat > 90.0M)
                return 90.0M;
            else
                return lat;
        }
        static decimal ControlLongitude(decimal lng)
        {
            if (lng < -180.0M)
                return -180.0M;
            else if (lng > 180.0M)
                return 180.0M;
            else
                return lng;
        }
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