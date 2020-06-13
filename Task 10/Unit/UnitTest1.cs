using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_10;

namespace Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = new List(new double[] { 1, 2, 3, 4, 5 });
            string str = "";
            for (int i = 0; i < 5; ++i)
                str += actual[i];
            var expected = "22345";
            Assert.AreEqual(expected, str);
            actual.Add(10);
            var tmp = actual[actual.Length-1];
            actual[2] = tmp;
            actual.Clear();
            actual = new List();
        }
    }
}
