/// <summary>Contains operations to perform on matrices.</summary>
class MatrixMath
{
    /// <summary>Transpose a matrix.</summary>
    /// <param name="matrix">Matrix to transpose.</param>
    /// <returns>A new matrix that is the transposition of the original.</returns>
    public static double[,] Transpose(double[,] matrix) {
        if (matrix is null || matrix.Length < 1)
            return new double[0, 0];
        double[,] ret = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for (int y = 0; y < matrix.GetLength(0); y++)
            for (int x = 0; x < matrix.GetLength(1); x++)
                ret[x, y] = matrix[y, x];
        return ret;
    }
}
