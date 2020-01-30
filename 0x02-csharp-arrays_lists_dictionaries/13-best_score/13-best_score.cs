using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count < 1)
            return "None";
        return myList.Aggregate((a, b) => a.Value > b.Value ? a : b).Key;
    }
}
