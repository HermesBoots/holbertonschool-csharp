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
        double[,] fail = { { -1, -1 }, { -1, -1 } };
        if (matrix1 is null || matrix1.Rank != 2 || !(matrix1.Length == 4 || matrix1.Length == 9))
            return fail;
        if (matrix2 is null || matrix2.Rank != 2 || !(matrix2.Length == 4 || matrix2.Length == 9))
            return fail;
        if (matrix1.Length != matrix2.Length || matrix1.GetLength(0) != matrix2.GetLength(0))
            return fail;

        double[,] ret = (double[,])matrix1.Clone();
        for (int x = 0; x < matrix1.GetLength(0); x++)
            for (int y = 0; y < matrix1.GetLength(1); y++)
                ret[x, y] = matrix1[x, y] + matrix2[x, y];
        return ret;
    }
}
