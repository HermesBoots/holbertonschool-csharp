/// <summary>Contains operations to perform on matrices.</summary>
class MatrixMath
{
    /// <summary>Multiply one matrix by another.</summary>
    /// <param name="matrix1">First matrix.</param>
    /// <param name="matrix2">Second matrix.</param>
    /// <returns>New matrix as result of multiplication.</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2) {
        if (matrix1 is null || matrix2 is null)
            return new double[,] { { -1, -1 }, { -1, -1 } };
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] { { -1, -1 }, { -1, -1 } };
        double[,] ret = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int y = 0; y < ret.GetLength(1); y++)
            for (int x = 0; x < ret.GetLength(0); x++) {
                double sum = 0;
                for (int i = 0; i < matrix1.GetLength(0); i++) {
                    sum += matrix1[i, y] * matrix2[x, i];
                }
                ret[x, y] = sum;
            }
        return ret;
    }
}
