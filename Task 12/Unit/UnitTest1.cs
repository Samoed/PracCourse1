using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Heap()
        {
            var expected = new int[] { 1,2,3,4,5,6,7,8,9,10};
            var actual = Programm.HeapSort(new int[] { 10,9,8,7,6,5,4,3,2,1 });
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void Cocktail()
        {
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var actual = Programm.CoctailSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
