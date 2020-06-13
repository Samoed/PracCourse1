using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_8;

namespace Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program.g = new List<List<int>> { new List<int>{ 1, 2 }, new List<int> { 0, 2 }, new List<int> { 0, 1 } };
            Program.Solve(3, 3);
            Assert.AreEqual(1, Program.cycle_st+1);
        }
    }
}
