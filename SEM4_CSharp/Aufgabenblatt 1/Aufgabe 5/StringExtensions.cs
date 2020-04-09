using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aufgabe_5
{
    public static class StringExtensions
    {
        public static  int CountWords(this string str)
        {
            return Regex.Split(str.Trim(), @"\s+").Length;
        }
    }
}
