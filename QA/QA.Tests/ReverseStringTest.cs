using NUnit.Framework;
using Statements;

namespace QA.Tests
{
    [TestFixture]
    public class ReverseStringTest
    {
        [Test]
        public void EmptyStringTest()
        {
            string result =  Program.ReverseString(string.Empty);
            Assert.AreEqual(string.Empty, result);
        }


        [Test]
        public void NullStringTest()
        {
            string result =  Program.ReverseString(null);
            Assert.AreEqual(null, result);
        }

        [Test]
        public void ShortStringTest()
        {
            string result =  Program.ReverseString("Ivo");
            Assert.AreEqual("ovI", result);
        }

        [Test]
        public void LongStringTest()
        {
            string result =  Program.ReverseString("Afganistan");
            Assert.AreEqual("natsinagfA", result);
        }


        [Test]
        public void StringWithSpacesTest()
        {
            string result =  Program.ReverseString("This is a Funny Test i know it");
            Assert.AreEqual("ti wonk i tseT ynnuF a si sihT", result);
        }
    }
}
