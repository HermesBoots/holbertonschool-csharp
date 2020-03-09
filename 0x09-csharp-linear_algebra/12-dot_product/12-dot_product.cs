/// <summary>Contains methods to operate on vectors.</summary>
class VectorMath
{
    /// <summary>Calculate dot product of 2 vectors.</summary>
    /// <param name="vector1">First vector.</param>
    /// <param name="vector2">Second vector.</param>
    /// <returns>Dot product of both vectors.</returns>
    public static double DotProduct(double[] vector1, double[] vector2) {
        if (vector1 is null || vector2.Rank != 1 || vector1.Length < 2 || vector1.Length > 3)
            return -1;
        if (vector2 is null || vector2.Rank != 1 || vector2.Length < 2 || vector2.Length > 3)
            return -1;
        if (vector1.Length != vector2.Length)
            return -1;

        double ret = 0;
        for (int i = 0; i < vector1.Length; i++)
            ret += vector1[i] * vector2[i];
        return ret;
    }
}
