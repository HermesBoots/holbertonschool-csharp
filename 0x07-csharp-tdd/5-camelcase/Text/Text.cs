using System;
using Unicode = System.Globalization.CharUnicodeInfo;
using Categories = System.Globalization.UnicodeCategory;

namespace Text
{
    /// <summary>Contains custom string operations.</summary>
    public class Str
    {
        /// <summary>Finds the number of words in a camel case string.</summary>
        /// <param name="s">String to check</param>
        /// <returns>Number of words, delimited by capital letters, in <paramref name="s"/>.</returns>
        public static int CamelCase(string s)
        {
            int ret = 0;

            if (s.Length < 1)
                return 0;
            if (Unicode.GetUnicodeCategory(s[0]) != Categories.UppercaseLetter)
                ret++;
            foreach (char c in s)
                if (Unicode.GetUnicodeCategory(c) == Categories.UppercaseLetter)
                    ret++;
            return ret;
        }
    }
}
