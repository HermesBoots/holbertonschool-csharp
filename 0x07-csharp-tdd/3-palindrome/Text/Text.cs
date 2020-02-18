using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Text
{
    /// <summary>Contains custom string operations.</summary>
    public class Str
    {
        // types of characters to ignore when determining a palindrome
        private static readonly HashSet<UnicodeCategory> punctuation =
            new HashSet<UnicodeCategory> {
                UnicodeCategory.ClosePunctuation, UnicodeCategory.ConnectorPunctuation,
                UnicodeCategory.DashPunctuation, UnicodeCategory.FinalQuotePunctuation,
                UnicodeCategory.InitialQuotePunctuation, UnicodeCategory.OpenPunctuation,
                UnicodeCategory.OtherPunctuation, UnicodeCategory.SpaceSeparator,
                UnicodeCategory.Control
            };


        /// <summary>Determines whether a string is a palindrome, ignoring space, punctuation, and case.</summary>
        /// <param name="s">The string to check.</param>
        /// <returns> Whether <paramref name="s"/> is a palindrome.</returns>
        public static bool IsPalindrome(string s)
        {
            int half;
            string left, right;
            StringBuilder pieces;

            if (s.Length < 1)
                return true;

            pieces = new StringBuilder(s.Length);
            foreach (char c in s)
                if (!Str.punctuation.Contains(CharUnicodeInfo.GetUnicodeCategory(c)))
                    pieces.Append(c);
            s = pieces.ToString();
            half = s.Length / 2;
            left = s.Substring(0, half);
            right = String.Join(String.Empty, s.Substring(half + s.Length % 2).Reverse());
            return left.Equals(right, StringComparison.OrdinalIgnoreCase);
        }
    }
}
