using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        return (int)myDict.LongCount();
    }
}
