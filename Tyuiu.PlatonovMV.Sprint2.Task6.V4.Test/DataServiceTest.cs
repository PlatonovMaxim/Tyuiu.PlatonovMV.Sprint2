using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint2.Task6.V4.Lib;

namespace Tyuiu.PlatonovMV.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFindCardSuit()
        {
            var ds = new DataService();

            Assert.AreEqual("Пики", ds.FindCardSuit(1));
            Assert.AreEqual("Трефы", ds.FindCardSuit(2));
            Assert.AreEqual("Бубны", ds.FindCardSuit(3));
            Assert.AreEqual("Червы", ds.FindCardSuit(4));

            Assert.AreEqual("Некорректное значение! Введите число от 1 до 4", ds.FindCardSuit(7));
        }
    }
}