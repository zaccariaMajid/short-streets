using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PCTO
{
    static class PropertyControl
    {
        public static string Province(string s)
        {
            string pattern = "[A-Z]{2}";
            if (!Regex.IsMatch(s, pattern))
                throw new ArgumentException("Province must be a 2 upper chars string");
            return s;
        }

        public static int PositiveNumber(int n)
        {
            if (n <= 0)
                throw new ArgumentException("Non positive number inserted");
            return n;
        }

        public static string ValidString(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
                throw new ArgumentException("Null string inserted");
            return s;
        }
    }
}
