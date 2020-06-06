using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task12Form;

namespace task12Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHeap()
        {
            int a=0, b=0;
            var arr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var actual = Form1.HeapSort(arr,ref a, ref b);
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.AreEqual(actual.ToString(), expected.ToString());
        }
        [TestMethod]
        public void TestCocktail()
        {
            int a = 0, b = 0;
            var arr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var actual = Form1.CoctailSort(arr,ref a,ref b);
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.AreEqual(actual.ToString(), expected.ToString());
        }
    }
}
