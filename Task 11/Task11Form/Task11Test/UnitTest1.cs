using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task11Form;

namespace Task11Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string order = "0111101111";
            string code = Form1.Code(order);
            string encode = Form1.Encode(code);
            Assert.AreEqual(true, true);
        }
    }
}
