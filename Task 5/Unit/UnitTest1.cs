using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_5;

namespace Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = Program.Solve(new int[,] { { 1, 2, 3 }, { 3, 2, 1 }, { 1, 3, 2 } }, 3);
            var expected = new int[] { 1, 1, 0 };
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
