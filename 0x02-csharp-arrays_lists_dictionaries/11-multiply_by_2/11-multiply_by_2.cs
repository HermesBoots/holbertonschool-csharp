using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(
        Dictionary<string, int> myDict
    ) {
        return myDict.ToDictionary(
            pair => pair.Key,
            pair => pair.Value * 2
        );
    }
}
