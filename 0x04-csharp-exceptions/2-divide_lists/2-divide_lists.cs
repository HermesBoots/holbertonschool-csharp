using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int index = 0;
        List<int> ret = new List<int>(listLength);
        try {
            for (; index < listLength; index++)
                try {
                    ret.Add(list1[index] / list2[index]);
                } catch (DivideByZeroException) {
                    Console.WriteLine("Cannot divide by zero");
                    ret.Add(0);
                }
        } catch (ArgumentOutOfRangeException) {
            Console.WriteLine("Out of range");
        }
        return ret;
    }
}
