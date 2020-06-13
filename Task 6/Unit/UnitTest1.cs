using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_6;

namespace Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int j = 0;
            var actual = Program.Solve(100, 200, 300, 5, 5, out j);
            Assert.AreEqual(2, j);
        }
    }
}
