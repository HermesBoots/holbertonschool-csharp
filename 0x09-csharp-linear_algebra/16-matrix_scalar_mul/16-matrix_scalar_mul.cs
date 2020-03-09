class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar) {
        if (matrix is null || matrix.Rank < 2 || matrix.Rank > 3)
            return new double[,] { { -1 } };
        double[,] ret = (double[,])matrix.Clone();
        for (int x = 0; x < ret.GetLength(0); x++)
            for (int y = 0; y < ret.GetLength(1); y++)
                ret[x, y] *= scalar;
        return ret;
    }
}
