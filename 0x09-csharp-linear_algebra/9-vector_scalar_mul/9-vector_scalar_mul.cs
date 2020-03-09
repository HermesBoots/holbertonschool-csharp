/// <summary>Contains operations to perform on vectors.</summary>
class VectorMath
{
    /// <summary>Multiplies a vector by a scalar.</summary>
    /// <param name="vector">2D or 3D vector to multiply.</param>
    /// <param name="scalar">Scalar to multiply vector by.</param>
    /// <returns>New vector result of multiplication.</returns>
    public static double[] Multiply(double[] vector, double scalar) {
        if (vector is null || vector.Rank != 1 || vector.Length < 2 || vector.Length > 3)
            return new double[] { -1 };
        double[] ret = new double[vector.Length];
        for (int i = 0; i < ret.Length; i++)
            ret[i] = vector[i] * scalar;
        return ret;
    }
}
