using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint2.Task2.V11.Lib;

namespace Tyuiu.PlatonovMV.Sprint2.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void InsidePoints_ReturnTrue()
        {
            var ds = new DataService();

            // Верхний левый блок
            Assert.IsTrue(ds.CheckDotInShadedArea(3, 3));
            Assert.IsTrue(ds.CheckDotInShadedArea(5, 4));

            // y=7: x=2..5
            Assert.IsTrue(ds.CheckDotInShadedArea(2, 7));
            Assert.IsTrue(ds.CheckDotInShadedArea(5, 7));

            // Центральный прямоугольник 6..9 × 5..10
            Assert.IsTrue(ds.CheckDotInShadedArea(6, 5));
            Assert.IsTrue(ds.CheckDotInShadedArea(8, 9));

            // (9,3), (9,4)
            Assert.IsTrue(ds.CheckDotInShadedArea(9, 3));
            Assert.IsTrue(ds.CheckDotInShadedArea(9, 4));

            // x=10: y=8..10
            Assert.IsTrue(ds.CheckDotInShadedArea(10, 8));

            // x=11..12: y=5..11
            Assert.IsTrue(ds.CheckDotInShadedArea(11, 5));
            Assert.IsTrue(ds.CheckDotInShadedArea(12, 11));

            // y=11: x=3..7
            Assert.IsTrue(ds.CheckDotInShadedArea(3, 11));
            Assert.IsTrue(ds.CheckDotInShadedArea(7, 11));

            // Одиночные
            Assert.IsTrue(ds.CheckDotInShadedArea(7, 12));
            Assert.IsTrue(ds.CheckDotInShadedArea(13, 8));
        }

        [TestMethod]
        public void OutsidePoints_ReturnFalse()
        {
            var ds = new DataService();

            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
            Assert.IsFalse(ds.CheckDotInShadedArea(5, 5));   // рядом, но вне
            Assert.IsFalse(ds.CheckDotInShadedArea(10, 7));  // выше столбца x=10
            Assert.IsFalse(ds.CheckDotInShadedArea(12, 12)); // ниже столбцов 11..12
            Assert.IsFalse(ds.CheckDotInShadedArea(15, 15));
        }
    }
}