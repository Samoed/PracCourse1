using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = Program.Solve(1, 1);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var actual = Program.Solve(5, 1);
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }
    }
}
