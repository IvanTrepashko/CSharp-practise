using System;
using System.Collections.Generic;
using System.Text;

namespace Lect14.Task1
{
    public static class StringExtensions
    {
        public static string TrimString(this string str)
        {
            return str.Substring(0, 5) + "...";
        }
    }
}
