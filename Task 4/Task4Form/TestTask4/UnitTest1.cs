using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4Form;

namespace TestTask4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Form1.Solve(0.0001),0.5);
        }
    }
}
