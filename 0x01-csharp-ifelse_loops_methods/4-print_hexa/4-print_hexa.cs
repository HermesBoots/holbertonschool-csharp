using System;

class Program
{
    static void Main(string[] args)
    {
        foreach (int n in System.Linq.Enumerable.Range(0, 99))
            Console.WriteLine("{0:D} = 0x{0:X}", n);
    }
}
