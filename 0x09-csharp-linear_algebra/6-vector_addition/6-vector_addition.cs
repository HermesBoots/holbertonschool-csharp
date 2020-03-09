using System;

/// <summary>Contains operations to perform on vectors.</summary>
class VectorMath
{
    /// <summary>Add two vectors.</summary>
    /// <param name="vector1">First vector.</param>
    /// <param name="vector2">Second vector.</param>
    /// <returns>Sum of vectors.<returns>
    public static double[] Add(double[] vector1, double[] vector2) {
        if (vector1 is null || vector1.Rank != 1 || vector1.Length < 2 || vector1.Length > 3)
            return new double[] { -1 };
        if (vector2 is null || vector2.Rank != 1 || vector2.Length < 2 || vector2.Length > 3)
            return new double[] { -1 };
        if (vector1.Length != vector2.Length)
            return new double[] { -1 };

        double[] ret = new double[vector1.Length];
        for (int i = 0; i < ret.Length; i++)
            ret[i] = vector1[i] + vector2[i];
        return ret;
    }
}
