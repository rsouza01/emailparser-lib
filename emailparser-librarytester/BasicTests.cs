using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmailParser;

namespace EmailParser.Tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMUCReturnsString()
        {
            string sample = "Test String";
            Assert.IsInstanceOfType(EmailMessage.makeAllUppercase(sample), typeof(string));
        }

        [TestMethod]
        public void TestMRReturnsString()
        {
            string sample = "Test String";
            Assert.IsInstanceOfType(EmailMessage.makeReverse(sample), typeof(string));
        }        

        [TestMethod]
        public void TestMakeAllUppercase()
        {
            string sample = "Test String";
            Assert.AreEqual(EmailMessage.makeAllUppercase(sample), "TEST STRING");
        }

        [TestMethod]
        public void TestMakeReverse()
        {
            string sample = "Test String";
            Assert.AreEqual(EmailMessage.makeReverse(sample), "gnirtS tseT");
        }

    }
}
