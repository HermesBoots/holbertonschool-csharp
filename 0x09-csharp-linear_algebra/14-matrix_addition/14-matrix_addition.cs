using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>Contains operations on matrices.</summary>
class MatrixMath
{
    /// <summary>Add two matrices.</summary>
    /// <param name="matrix1">First matrix.</param>
    /// <param name="matrix2">Second matrix.</param>
    /// <returns>Sum of the matrices.</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2) {
        if (matrix1 is null || matrix1.Rank < 2 || matrix1.Rank > 3)
            return new double[,] { { -1 } };
        if (matrix2 is null || matrix2.Rank < 2 || matrix2.Rank > 3)
            return new double[,] { { -1 } };
        if (matrix1.Rank != matrix2.Rank)
            return new double[,] { { -1 } };
        for (int dimension = 0; dimension < matrix1.Rank; dimension++)
            if (matrix1.GetLength(dimension) != matrix2.GetLength(dimension))
                return new double[,] { { -1 } };

        double[,] ret = (double[,])matrix1.Clone();
        for (int x = 0; x < matrix1.GetLength(0); x++)
            for (int y = 0; y < matrix1.GetLength(1); y++)
                ret[x, y] = matrix1[x, y] + matrix2[x, y];
        return ret;
    }
}
