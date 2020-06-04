using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task9Form.Form1;

namespace Task9Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyList expected = new MyList(10);
            MyList actual = new MyList(10);
            expected.Find(5);
            actual.Remove(5);
            expected.Remove(5);
            var a=actual.Size;
            a=actual[0];
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
