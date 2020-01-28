using System;
using System.Globalization;

static class Character
{
    public static bool IsLower(this char c)
    {
        return Char.GetUnicodeCategory(c) == UnicodeCategory.LowercaseLetter;
    }
}
