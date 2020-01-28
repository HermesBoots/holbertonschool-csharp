using System;

class Program
{
    static void Main(string[] args)
    {
        foreach (char c in "abcdefghijklmnopqrstuvwxyz")
            if (!"eq".Contains(c))
                Console.Write(c);
    }
}
