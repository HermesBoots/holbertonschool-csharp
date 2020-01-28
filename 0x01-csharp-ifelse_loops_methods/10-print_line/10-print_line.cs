using System;

static class Line
{
    public static void PrintLine(int length)
    {
        char[] line;
        if (length <= 0) {
            Console.WriteLine();
            return;
        }
        line = new char[length];
        Array.Fill(line, '_');
        Console.WriteLine(line);
    }
}
