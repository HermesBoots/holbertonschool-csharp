using MyMath;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void AllSmallInts()
        {
            for (int a = -100; a < 101; a++)
                for (int b = 100; b > -101; b--)
                    Assert.AreEqual(Operations.Add(a, b), a + b);
        }

        [Test]
        public void NearEdge()
        {
            Assert.AreEqual(Operations.Add(int.MaxValue, -1), int.MaxValue - 1);
            Assert.AreEqual(Operations.Add(int.MinValue, 1), int.MinValue + 1);
            Assert.AreEqual(Operations.Add(int.MaxValue, int.MinValue), -1);
        }
    }
}
