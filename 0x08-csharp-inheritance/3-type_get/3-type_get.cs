using System;
using System.Reflection;

/// <summary>Contains methods for checking types.</summary>
class Obj
{
    /// <summary>Print the names of a type's attributes.</summary>
    /// <param name="myObj">Object of type to print.</param>
    public static void Print(object myObj)
    {
        Type type;
        string name;

        type = myObj.GetType();
        name = type.Name;
        Console.WriteLine("{0} Properties:", name);
        foreach (PropertyInfo property in type.GetProperties())
            Console.WriteLine(property.Name);
        Console.WriteLine("{0} Methods:", name);
        foreach (MethodInfo method in type.GetMethods())
            Console.WriteLine(method.Name);
    }
}
