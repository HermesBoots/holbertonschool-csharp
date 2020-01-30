using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        return myList.Select(i => i % 2 == 0).ToList();
    }
}
