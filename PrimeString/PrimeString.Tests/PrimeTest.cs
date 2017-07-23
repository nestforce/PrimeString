using NUnit.Framework;

namespace PrimeString.Tests
{
    [TestFixture]
    public class PrimeTest
    {
        [Test]
        public void BasicTests()
        {
            var kata = new Kata();

            Assert.AreEqual(true, kata.PrimeString("abac"));

            Assert.AreEqual(false, kata.PrimeString("abab"));

            Assert.AreEqual(false, kata.PrimeString("aaaa"));

            Assert.AreEqual(true, kata.PrimeString("x"));

            Assert.AreEqual(true, kata.PrimeString("abc"));

            Assert.AreEqual(false, kata.PrimeString("fdsyffdsyffdsyffdsyffdsyf"));

            Assert.AreEqual(true, kata.PrimeString("utdutdtdutd"));

            Assert.AreEqual(true, kata.PrimeString("abba"));

            Assert.AreEqual(false, kata.PrimeString("vvv"));

            Assert.AreEqual(false, kata.PrimeString("xxxxx"));

            Assert.AreEqual(true, kata.PrimeString2("abac"));

            Assert.AreEqual(false, kata.PrimeString2("abab"));

            Assert.AreEqual(false, kata.PrimeString2("aaaa"));

            Assert.AreEqual(true, kata.PrimeString2("x"));

            Assert.AreEqual(true, kata.PrimeString2("abc"));

            Assert.AreEqual(false, kata.PrimeString2("fdsyffdsyffdsyffdsyffdsyf"));

            Assert.AreEqual(true, kata.PrimeString2("utdutdtdutd"));

            Assert.AreEqual(true, kata.PrimeString2("abba"));

            Assert.AreEqual(false, kata.PrimeString2("vvv"));

            Assert.AreEqual(false, kata.PrimeString2("xxxxx"));
        }
    }
}
