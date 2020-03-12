/// <summary>Contains operations to perform on matrices.</summary>
class MatrixMath
{
    /// <summary>Calculate the determinant of a square matrix.</summary>
    /// <param name="matrix">Input matrix.</param>
    /// <returns>The matrix's determinant.</returns>
    public static double Determinant(double[,] matrix) {
        if (matrix is null)
            return -1;
        if (!(matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) && !(matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3))
            return -1;
        double ret;
        if (matrix.Length == 4) {
            ret = matrix[0, 0] * matrix[1, 1];
            ret -= matrix[0, 1] * matrix[1, 0];
            return ret;
        }
        ret = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
        ret -= matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
        ret += matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        return ret;
    }
}
