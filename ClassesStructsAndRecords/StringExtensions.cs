using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords
{
    internal static class StringExtensions
    {
        internal static int CountWords(this string str)
        {
            if(string.IsNullOrEmpty(str)) return -1;

            var separators = new string[] {" ", Environment.NewLine };
            var words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
