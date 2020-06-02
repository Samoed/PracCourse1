using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace UnitTask1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0.5,Form1.Solve(0.5,0));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0.5, Form1.Solve(0.5, -1));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, Form1.Solve(2, 0));
        }
    }
}
