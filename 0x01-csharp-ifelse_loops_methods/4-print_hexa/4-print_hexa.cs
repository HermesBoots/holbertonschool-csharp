using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        for (bool b = true; b; b = false) {
        Console.WriteLine(String.Join(
            "\n", 
            Enumerable.Range(0, 99).Select(
                i => String.Concat(i.ToString("d"), " = 0x", i.ToString("x"))
            )
        ));
        }
    }
}
