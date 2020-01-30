class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int index = 0;
        int width = myMatrix.GetUpperBound(0) + 1;
        int[,] ret = new int[myMatrix.GetUpperBound(0) + 1, myMatrix.GetUpperBound(1) + 1];
        foreach (int val in myMatrix) {
            ret[index / width, index % width] = val * val;
            index++;
        }
        return ret;
    }
}
