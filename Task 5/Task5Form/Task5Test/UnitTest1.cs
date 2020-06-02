using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5;

namespace Task5Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var matr = new double[1, 5];
            for (int i = 0; i < 5; ++i)
                matr[0, i] = i;
            Assert.AreEqual(Form1.Solve(matr).ToString(), (new int[1] { 1 }).ToString());
        }
        [TestMethod]
        public void TestMethod2()
        {
            var matr = new double[1, 5];
            for (int i = 0; i < 5; ++i)
                matr[0, i] = 10-i;
            Assert.AreEqual(Form1.Solve(matr).ToString(), (new int[1] { 1 }).ToString());
        }
        [TestMethod]
        public void TestMethod3()
        {
            Random rnd = new Random();
            var matr = new double[1, 5];
            for (int i = 0; i < 5; ++i)
                matr[0, i] = rnd.Next(1000);
            Assert.AreEqual(Form1.Solve(matr).ToString(), (new int[1] { 0 }).ToString());
        }
    }
}
