using NUnit.Framework;
using Text;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void CamelAndPascalCase()
        {
           Assert.AreEqual(Str.CamelCase("XMLHttpRequest"), 5);
           Assert.AreEqual(Str.CamelCase("xhr"), 1);
           Assert.AreEqual(Str.CamelCase(""), 0);
           Assert.AreEqual(Str.CamelCase("socketTcpHttp"), 3);
           Assert.AreEqual(Str.CamelCase("Sockets"), 1);
           Assert.AreEqual(Str.CamelCase("RDP"), 3);
           Assert.AreEqual(Str.CamelCase("usingHTTPSecure"), 6);
           Assert.AreEqual(Str.CamelCase("usingRDP"), 4);
        }

        [Test]
        public void NonAlphabetic()
        {
            Assert.AreEqual(Str.CamelCase(" a b "), 1);
            Assert.AreEqual(Str.CamelCase("back2theFuture"), 2);
            Assert.AreEqual(Str.CamelCase("eat Every egg"), 2);
        }
    }
}
