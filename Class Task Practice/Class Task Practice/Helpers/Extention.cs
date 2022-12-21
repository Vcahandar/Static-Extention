using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Class_Task_Practice.Helpers
{
    public static class Extention
    {
        public static int GetNums(this int num)
        {
            return num;
        }


        public static bool CheckString(this string text,string pattern)
        {

            return Regex.IsMatch(text, pattern);
        }

    }
}
