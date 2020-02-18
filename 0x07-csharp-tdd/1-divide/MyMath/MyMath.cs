using System;
using System.Linq;

namespace MyMath
{
    /// <summary>Contains custom matrix operations.</summary>
    public class Matrix
    {
        /// <summary>Divides all values in a matrix by a fixed integer.</summary>
        /// <param name="matrix">The matrix to divide.</param>
        /// <param name="num">Number to divide all values in matrix by.</param>
        /// <returns>New matrix with results of division.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int index = 0, width;
            int[,] ret;

            if (matrix == null)
                return null;
            if (num == 0) {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            width = matrix.GetLength(0);
            ret = new int[matrix.GetLength(0), matrix.GetLength(1)];
            foreach (int val in matrix) {
                ret[index / width, index % width] = val / num;
                index++;
            }
            return ret;
        }
    }
}
