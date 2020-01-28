using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string sep = ", ";
        foreach (int i in Enumerable.Range(0, 100)) {
            if (i == 99)
                sep = "\n";
            Console.Write("{0:D2}{1}", i, sep);
        }
    }
}
