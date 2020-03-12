/// <summary>Contains operations to perform on matrices.</summary>
class MatrixMath
{
    /// <summary>Multiplies a matrix by a scalar.</summary>
    /// <param name="matrix">Matrix to multiply.</param>
    /// <param name="scalar">Scalar to multiply matrix by.</param>
    /// <returns>New matrix as result of multiplication.</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar) {
        if (matrix is null)
            return new double[,] { { -1 } };
        if (!(matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) && !(matrix.GetLength(0) == 3 || matrix.GetLength(1) == 3))
            return new double[,] { { -1 } };
        double[,] ret = (double[,])matrix.Clone();
        for (int x = 0; x < ret.GetLength(0); x++)
            for (int y = 0; y < ret.GetLength(1); y++)
                ret[x, y] *= scalar;
        return ret;
    }
}
