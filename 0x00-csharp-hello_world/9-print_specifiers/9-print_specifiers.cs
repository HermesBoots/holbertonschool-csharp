using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = .75;
        double currency = 98765.4321;
        Console.Write("Percent: {0:P}\nCurrency: {1:C}", percent, currency);
        Console.WriteLine();
    }
}
