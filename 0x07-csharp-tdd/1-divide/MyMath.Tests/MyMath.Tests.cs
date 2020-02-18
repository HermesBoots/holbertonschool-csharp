using MyMath;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void DivideByZero()
        {
            int[,] mat = { { 1, 2 }, { 3, 4 } };
            Assert.IsNull(Matrix.Divide(mat, 0));
        }

        [Test]
        public void Correct()
        {
            int[,] mat = { { 1, 2 }, { 3, 4 } };
            int[,] test = { { 0, 1 }, { 1, 2 } };
            int[,] result;
            result = Matrix.Divide(mat, 2);
            Assert.IsTrue(Enumerable.SequenceEqual(result.Cast<int>(), test.Cast<int>()));
            test = new int[,] { { 0, 0 }, { 0, 0 } };
            result = Matrix.Divide(mat, 10);
            Assert.IsTrue(Enumerable.SequenceEqual(result.Cast<int>(), test.Cast<int>()));
            mat = new int[,] { { 10, 20 }, { 30, 40 } };
            test = new int[,] { { 1, 2 }, { 3, 4 } };
            result = Matrix.Divide(mat, 10);
            Assert.IsTrue(Enumerable.SequenceEqual(result.Cast<int>(), test.Cast<int>()));
            test = new int[,] { { -5, -10 }, { -15, -20 } };
            result = Matrix.Divide(mat, -2);
            Assert.IsTrue(Enumerable.SequenceEqual(result.Cast<int>(), test.Cast<int>()));
        }

        [Test]
        public void EmptyMatrix()
        {
            int[,] mat = { };
            int[,] result;
            result = Matrix.Divide(mat, 2);
            Assert.AreEqual(result.Length, 0);
        }

        [Test]
        public void NullArgument()
        {
            Assert.IsNull(Matrix.Divide(null, 2));
        }

        [Test]
        public void RefUnchanged()
        {
            int[,] mat = { { 1, 2 }, { 3, 4 }};
            int[,] dup = (int[,]) mat.Clone();
            int[,] result;
            result = Matrix.Divide(mat, 1);
            Assert.IsTrue(Enumerable.SequenceEqual(mat.Cast<int>(), dup.Cast<int>()));
            Assert.AreNotSame(mat, result);
        }
    }
}
