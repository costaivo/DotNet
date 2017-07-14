using NUnit.Framework;

namespace Practice.QA.Test
{
    [TestFixture]
    public class VowelCounterTest
    {
        [Test]
        public void TestSimpleString()
        {
            Katas.VowelCounter v = new Katas.VowelCounter();
            int result = v.GetVowelCount("ivo");
            Assert.AreEqual(2, result, "Invalid Result- Dont match ");
        }

        [Test]
        public void TestStringWithSpaces()
        {
            Katas.VowelCounter v = new Katas.VowelCounter();
            int result = v.GetVowelCount("This is a test");
            Assert.AreEqual(4, result, "Invalid Result- for TestStringWithSpaces");
        }

        [Test]
        public void TestUpperCaseString()
        {
            Katas.VowelCounter v = new Katas.VowelCounter();
            int result = v.GetVowelCount("Ivo");
            Assert.AreEqual(2, result, "Invalid Result- Dont match ");
        }

        [Test]
        public void TestEmptyString()
        {
            Katas.VowelCounter v = new Katas.VowelCounter();
            int result = v.GetVowelCount(string.Empty);
            Assert.AreEqual(0, result, "Does not work for Empty String ");
        }


        [Test]
        public void TestNullString()
        {
            Katas.VowelCounter v = new Katas.VowelCounter();
            int result = v.GetVowelCount(null);
            Assert.AreEqual(0, result, "Does not work for Null String ");
     
        }
    }
}
