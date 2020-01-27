using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
        str = String.Join(char.ConvertFromUtf32(32), new string[] { str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)[8], str.Split(null as char[])[11], str.Split(null as char[])[17], str.Split(null as char[])[0]});
        Console.WriteLine(str);
    }
}
