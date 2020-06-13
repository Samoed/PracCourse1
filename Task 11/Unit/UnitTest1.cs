using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_11;

namespace Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = "0101011101";
            var actual = Program.Code(expected);
            Assert.AreEqual(expected, Program.Encode(actual));
        }
    }
}
