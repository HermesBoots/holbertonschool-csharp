using MyMath;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void EmptyList()
        {
            List<int> list = new List<int> { };
            Assert.AreEqual(Operations.Max(list), 0);
        }

        [Test]
        public void OneValue()
        {
            List<int> list = new List<int> { 10 };
            Assert.AreEqual(Operations.Max(list), 10);
        }

        [Test]
        public void Mixed()
        {
            List<int> list = new List<int> { -100, 1000, 50, 0, -2, 12345 };
            Assert.AreEqual(Operations.Max(list), 12345);
        }

        [Test]
        public void Negative()
        {
            List<int> list = new List<int> { -1, -2, -3, -4, -5 };
            Assert.AreEqual(Operations.Max(list), -1);
            list = new List<int> { -3, -2, -4, -5 };
            Assert.AreEqual(Operations.Max(list), -2);
        }

        [Test]
        public void Positive()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            Assert.AreEqual(Operations.Max(list), 5);
            list = new List<int> { 3, 2, 4, 1 };
            Assert.AreEqual(Operations.Max(list), 4);
        }

        [Test]
        public void RepeatedMax()
        {
            List<int> list = new List<int> { 1, 1, 1, 1, 1, 1 };
            Assert.AreEqual(Operations.Max(list), 1);
            list = new List<int> { 1, 1, 2, 2, 3, 3, 5, 5 };
            Assert.AreEqual(Operations.Max(list), 5);
        }
    }
}
