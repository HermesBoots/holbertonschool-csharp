using NUnit.Framework;
using Text;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void DifferentCase()
        {
            Assert.IsTrue(Str.IsPalindrome("AbBa"));
            Assert.IsTrue(Str.IsPalindrome("LevEL"));
        }

        [Test]
        public void EmptyString()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [Test]
        public void IgnoredCharacters()
        {
            Assert.IsTrue(Str.IsPalindrome("rats live on no evil star."));
            Assert.IsTrue(Str.IsPalindrome("desserts, i stressed!"));
            Assert.IsTrue(Str.IsPalindrome("a man, a plan, a canal: panama"));
        }

        [Test]
        public void MatchingCase()
        {
            Assert.IsTrue(Str.IsPalindrome("level"));
            Assert.IsTrue(Str.IsPalindrome("abba"));
            Assert.IsTrue(Str.IsPalindrome("z"));
        }

        [Test]
        public void MixedTest()
        {
            Assert.IsTrue(Str.IsPalindrome("Rats live on no evil star."));
            Assert.IsTrue(Str.IsPalindrome("Desserts, I stressed!"));
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama"));
        }

        [Test]
        public void NotPalindrome()
        {
            Assert.IsFalse(Str.IsPalindrome("muffin"));
            Assert.IsFalse(Str.IsPalindrome("The cake is a lie."));
            Assert.IsFalse(Str.IsPalindrome("ab"));
        }
    }
}
