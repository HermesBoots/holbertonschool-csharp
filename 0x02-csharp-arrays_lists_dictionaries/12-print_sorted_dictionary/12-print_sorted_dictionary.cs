using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<KeyValuePair<string, string>> list;
        if ((myDict?.Count ?? 0) < 1) {
            Console.WriteLine();
            return;
        }
        list = myDict.ToList();
        list.Sort((first, second) => String.Compare(first.Key, second.Key));
        Console.WriteLine(String.Join(
            '\n',
            list.Select(pair => String.Concat(pair.Key, ": ", pair.Value))
        ));
    }
}
