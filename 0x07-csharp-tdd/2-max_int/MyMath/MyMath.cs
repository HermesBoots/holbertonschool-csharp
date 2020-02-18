using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary>Contains custom math operations.</summary>
    public class Operations
    {
        /// <summary>Finds the largest value in a list.</summary>
        /// <param name="nums">List to search.</param>
        /// <returns>Largest value in <paramref name="nums"/>.</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count < 1)
                return 0;
            return nums.Max();
        }
    }
}
