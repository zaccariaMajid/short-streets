using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PCTO
{
    public static class PropertyControl
    {
        /// <summary>
        /// The string is taken if it's a 2 upper chars string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Province(string s)
        {
            string pattern = "^[A-Z]{2}$";
            if (!Regex.IsMatch(s, pattern))
                throw new ArgumentException("Province must be a 2 upper chars string");
            return s;
        }

        /// <summary>
        /// The number is taken if it's positive
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int PositiveNumber(int n)
        {
            if (n <= 0)
                throw new ArgumentException("Not positive number inserted");
            return n;
        }

        /// <summary>
        /// The string is taeken if it isn't null
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ValidString(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
                throw new ArgumentException("Null string inserted");
            return s;
        }
    }
}
