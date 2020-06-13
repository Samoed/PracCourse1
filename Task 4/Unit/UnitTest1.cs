using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_4;

namespace Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = Program.Solve(0.0001);
            var expected = 0.5;
            Assert.AreEqual(expected, actual);
        }
    }
}
