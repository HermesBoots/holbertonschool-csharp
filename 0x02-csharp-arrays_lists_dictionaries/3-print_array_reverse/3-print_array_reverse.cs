using System;
using System.Linq;

class Array
{
    public static void Reverse(int[] array)
    {
        if ((array?.Length ?? 0) < 1)
            Console.WriteLine();
        else
            Console.WriteLine(String.Join(
                " ",
                array.Reverse().Select(i => i.ToString())
            ));
    }
}
