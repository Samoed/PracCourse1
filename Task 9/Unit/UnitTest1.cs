using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_9;

namespace Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = new List(5);
            string str = "";
            for (int i = 1; i < 6; ++i)
                str += actual[i];
            Assert.AreEqual("12345", str);
            actual.Add(10);
            actual.Find(5);
            actual.Remove(5);
            actual.Remove(5);
            var tmp=actual[2];
            actual[0] = tmp;
            actual.Clear();
        }
    }
}
