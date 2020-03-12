/// <summary>Contains operations to perform on vectors.</summary>
class VectorMath
{
    /// <summary>Calculate the cross product of 3D vectors.</summary>
    /// <param name="vector1">First vector.</param>
    /// <param name="vector2">Second vector.</param>
    /// <returns>Cross product of the vectors.</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2) {
        if (vector1 is null || vector1.Length != 3)
            return new double[] { -1 };
        if (vector2 is null || vector2.Length != 3)
            return new double[] { -1 };
        double[] ret = new double[3];
        ret[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        ret[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        ret[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];
        return ret;
    }
}
