using System;


/// <summary>Custom class that stores a queue of objects of the same type.</summary>
class Queue<T>
{
    /// <summary>Returns the type stored in this collection.</summary>
    /// <returns>Type of the T generic parameter.</returns>
    public Type CheckType() {
        return typeof(T);
    }
}
