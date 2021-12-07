using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ShowTheWord
{
    public static class ShowTheWord
    {
        public static int ShowWord(this string str, string pattern)
        {
            return Regex.Matches(str, pattern).Count;
        }

    }
}
