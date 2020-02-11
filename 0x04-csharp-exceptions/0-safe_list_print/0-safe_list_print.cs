using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int index = 0;
        try {
            for (; index < n; index++)
                Console.WriteLine(myList[index]);
        } catch (ArgumentOutOfRangeException) {
            return index;
        } catch (NullReferenceException) {
            return 0;
        }
        return n;
    }
}
