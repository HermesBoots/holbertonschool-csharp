using System;

/// <summary>Contains methods for checking types.</summary>
class Obj
{
    /// <summary>Check if a type is a subclass of another type.</summary>
    /// <param name="derivedType">The supposed subclass.</param>
    /// <param name="baseType">The supposed base class.</param>
    /// <returns>Whether <paramref name="derivedType"/> is a subclass of <paramref name="baseType"/>.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
