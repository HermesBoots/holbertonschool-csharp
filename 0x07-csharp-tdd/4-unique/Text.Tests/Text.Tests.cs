using NUnit.Framework;
using Text;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void ConsecutiveRepeats()
        {
            Assert.AreEqual(Str.UniqueChar("aabbc"), 4);
            Assert.AreEqual(Str.UniqueChar("aaabbcdd"), 5);
            Assert.AreEqual(Str.UniqueChar("zzzyyxc"), 5);
            Assert.AreEqual(Str.UniqueChar("qaad"), 0);
        }

        [Test]
        public void NoUniques()
        {
            Assert.AreEqual(Str.UniqueChar(""), -1);
            Assert.AreEqual(Str.UniqueChar("aa"), -1);
            Assert.AreEqual(Str.UniqueChar("abab"), -1);
        }

        [Test]
        public void SeparateRepeats()
        {
            Assert.AreEqual(Str.UniqueChar("ababc"), 4);
            Assert.AreEqual(Str.UniqueChar("abcab"), 2);
            Assert.AreEqual(Str.UniqueChar("zyxxcy"), 0);
        }
    }
}
