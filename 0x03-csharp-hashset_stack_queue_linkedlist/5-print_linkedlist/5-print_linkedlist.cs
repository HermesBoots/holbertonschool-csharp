using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> list;
        list = new LinkedList<int>(Enumerable.Range(0, size));
        foreach (int item in list)
            Console.WriteLine(item);
        return list;
    }
}
