using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[][] array = new int[3][];
        array[0] = Enumerable.Range(0, 4).ToArray();
        array[1] = Enumerable.Range(0, 7).ToArray();
        array[2] = Enumerable.Range(0, 2).ToArray();
        foreach (int[] sub in array)
            Console.WriteLine(String.Join(' ', sub.Select(i => i.ToString())));
    }
}
