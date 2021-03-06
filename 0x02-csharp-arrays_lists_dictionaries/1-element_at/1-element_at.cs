using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (index < array.GetLowerBound(0) || index > array.GetUpperBound(0)) {
            Console.WriteLine("Index out of range");
            return -1;
        }
        return array[index];
    }
}
