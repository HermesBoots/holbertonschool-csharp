using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int digit = number % 10;
        Console.Write("The last digit of {0} is {1} and is ", number, digit);
        if (digit > 5)
            Console.WriteLine("greater than 5");
        else if (digit == 0)
            Console.WriteLine("0");
        else
            Console.WriteLine("less than 6 and not 0");
    }
}
