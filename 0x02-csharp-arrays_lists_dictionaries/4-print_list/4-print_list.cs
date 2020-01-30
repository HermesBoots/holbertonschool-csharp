using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static List<int> CreatePrint(int size)
    {
        IEnumerable<int> seq;
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        seq = Enumerable.Range(0, size);
        Console.WriteLine(String.Join(' ', seq.Select(i => i.ToString())));
        return seq.ToList();
    }
}
