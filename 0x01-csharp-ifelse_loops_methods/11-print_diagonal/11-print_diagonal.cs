using System;

static class Line
{
    public static void PrintDiagonal(int length)
    {
        char[] buffer;
        int index = 0;
        if (length <= 0) {
            Console.WriteLine();
            return;
        }
        buffer = new char[(length + 1) * (length + 2) / 2 - 1];
        for (int line = 0; line < length; line++) {
            Array.Fill(buffer, ' ', index, line);
            index += line;
            buffer[index] = '\\';
            buffer[index + 1] = '\n';
            index += 2;
        }
        Console.WriteLine(buffer);
    }
}
