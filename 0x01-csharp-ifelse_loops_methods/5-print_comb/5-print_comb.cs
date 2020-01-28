using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        System.Collections.Generic.IEnumerable<string> seq;
        seq = Enumerable.Range(0, 100).Select(n => n.ToString("D2"));
        for (bool b = true; b; b = false)
            Console.Write(String.Join(", ", seq));
        Console.WriteLine();
    }
}
