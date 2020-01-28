using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(String.Join(" ", Enumerable.Range(1, 100).Select(n =>
        {
            if (n % 15 == 0)
                return "FizzBuzz";
            else if (n % 5 == 0)
                return "Buzz";
            else if (n % 3 == 0)
                return "Fizz";
            else
                return n.ToString();
        })));
    }
}
