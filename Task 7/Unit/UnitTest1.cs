using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_7;

namespace Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = Program.Solve(new int[] {1,2,3,4,5});
            var expected = new string[] { "010","110","00","01","11" };
            string expectedStr="",actualStr="";
            foreach (var tmp in expected)
                expectedStr += tmp+" ";
            foreach (var tmp in actual.Values)
                actualStr += tmp + " ";
            Assert.AreEqual(expectedStr.ToString(), actualStr.ToString());
        }
    }
}