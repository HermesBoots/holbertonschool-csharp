/// <summary>Contains operations to perform on matrices.</summary>
class MatrixMath
{
    /// <summary>Finds the inverse of a 2x2 or 3x3 matrix.</summary>
    /// <param name="matrix">Matrix to find inverse of.</param>
    /// <returns>New matrix that is inverse of input matrix.</returns>
    public static double[,] Inverse2D(double[,] matrix) {
        if (matrix is null)
            return new double[,] { { -1 } };
        if (!(matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) && !(matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3))
            return new double[,] { { -1 } };
        double det;
        double[,] ret = new double[matrix.GetLength(0), matrix.GetLength(1)];

        if (matrix.Length == 4) {
            det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            if (det == 0)
                return new double[,] { { -1 } };
            det = 1 / det;
            ret[0, 0] = matrix[1, 1] * det;
            ret[0, 1] = matrix[0, 1] * -det;
            ret[1, 0] = matrix[1, 0] * -det;
            ret[1, 1] = matrix[0, 0] * det;
            return ret;
        }

        det = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
        det -= matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
        det += matrix[0, 1] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        if (det == 0)
            return new double[,] { { -1 } };
        ret[0, 0] = matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1];
        ret[0, 1] = matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0];
        ret[0, 2] = matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0];
        ret[1, 0] = matrix[0, 1] * matrix[2, 2] - matrix[0, 2] * matrix[2, 1];
        ret[1, 1] = matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0];
        ret[1, 2] = matrix[0, 0] * matrix[2, 1] - matrix[0, 1] * matrix[2, 0];
        ret[2, 0] = matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1];
        ret[2, 1] = matrix[0, 0] * matrix[1, 2] - matrix[0, 2] * matrix[1, 0];
        ret[2, 2] = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        det = 1 / det;
        double[,] copy = (double[,])ret.Clone();
        for (int y = 0; y < matrix.GetLength(0); y++)
            for (int x = 0; x < matrix.GetLength(1); x++) {
                ret[x, y] = copy[y, x];
                if ((x + y) % 2 == 1)
                    ret[x, y] *= -1;
                ret[x, y] *= det;
            }
        return ret;
    }
}
