using System;

/// <summary>Contains methods to operate on vectors.</summary>
class VectorMath
{
    /// <summary>Find the magnitude of a vector.</summary>
    /// <param name="vector">The two coordinates of the vector destination, assuming a source of (0, 0[, 0]).</param>
    /// <returns>The length/magnitude of the vector.</returns>
    public static double Magnitude(double[] vector) {
        if (vector is null || vector.Rank != 1 || vector.Length < 2 || vector.Length > 3)
            return -1;
        double ret = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2);
        if (vector.Length > 2)
            ret += Math.Pow(vector[2], 2);
        ret = Math.Sqrt(ret);
        ret = Math.Round(ret, 1);
        return ret;
    }
}
