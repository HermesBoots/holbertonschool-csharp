/// <summary>Contains methods to check types and inheritance.</summary>
class Obj
{
    /// <summary>Check whether an object is an <c>int</c>.</summary>
    /// <param name="obj">Object to check.</param>
    /// <returns>Whether <paramref name="obj"/> is an <c>int</c>.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj.GetType() == typeof(int);
    }
}
