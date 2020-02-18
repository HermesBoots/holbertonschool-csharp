using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>Contains custom string operations.</summary>
    public class Str
    {
        /// <summary>Finds the first unique character in a string.</summary>
        /// <param name="s">String to check.</param>
        /// <returns>Index of the first unique character in <paramref name="s"/>.</returns>
        public static int UniqueChar(string s)
        {
            int i = 0;
            HashSet<char> uniqs, dups;
            Queue<(int i, char c)> chars;

            uniqs = new HashSet<char>();
            dups = new HashSet<char>();
            chars = new Queue<(int i, char c)>(s.Length);

            foreach (char c in s) {
                if (!dups.Contains(c))
                    if (uniqs.Contains(c)) {
                        dups.Add(c);
                        uniqs.Remove(c);
                    }
                    else {
                        uniqs.Add(c);
                        chars.Enqueue((i: i, c: c));
                    }
                i++;
            }
            foreach ((int i, char c) pair in chars)
                if (uniqs.Contains(pair.c))
                    return pair.i;
            return -1;
        }
    }
}
