/// <summary>Contains methods to check types.</summary>
class Obj
{
    /// <summary>Checks whether an object is an <see cref="System.Array"/> instance.</summary>
    /// <param name="obj">Object to check type of.</param>
    /// <returns>Whether <paramref name="obj"/> is an instance of <see cref="System.Array"/> or one of its subclasses.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is System.Array;
    }
}
