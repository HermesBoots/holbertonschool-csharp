using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        char[] buffer = new char[50];
        int index = 0;
        int[,] array = new int[5, 5];
        array[2, 2] = 1;
        foreach (int val in array) {
            Array.Copy(val.ToString().ToCharArray(), 0, buffer, index, 1);
            buffer[index + 1] = index % 10 == 8 ? '\n' : ' ';
            index += 2;
        }
        Console.Write(buffer);
    }
}
