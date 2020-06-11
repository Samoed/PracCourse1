using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task6Form;

namespace Task6Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double q = 10;int w;
            var a = Form1.Solve(6, 6,ref q, 5, 5,out w);
            Assert.AreEqual(a[3], 9);
        }
    }
}
