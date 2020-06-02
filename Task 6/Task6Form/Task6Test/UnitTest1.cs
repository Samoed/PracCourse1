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
            double q = 300;int w;
            var a = Form1.Solve(100, 200,ref q, 5, 5,out w);
            Assert.AreEqual(a, a);
        }
    }
}
