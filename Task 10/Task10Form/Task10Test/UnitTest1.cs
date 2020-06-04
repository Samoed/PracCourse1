using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task10Form;

namespace Task10Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 5;
            List<int> arr = new List<int>{ 1, 2, 3, 4, 5 };
            List<int> actual = Form1.Solve(n, arr);
            var expected = new List<int> { -4, -3, -2, -1 };
        }
    }
}
