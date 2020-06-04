using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task7Form;

namespace Task7Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var expected= Form1.Solve(arr);
            Assert.AreEqual(expected, expected);
        }
    }
}
