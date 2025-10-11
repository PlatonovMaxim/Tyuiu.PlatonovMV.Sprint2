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

            Assert.AreEqual("пики", ds.FindCardSuit(1));
            Assert.AreEqual("трефы", ds.FindCardSuit(2));
            Assert.AreEqual("бубны", ds.FindCardSuit(3));
            Assert.AreEqual("червы", ds.FindCardSuit(4));

            Assert.AreEqual("Некорректное значение! Введите число от 1 до 4", ds.FindCardSuit(7));
        }
    }
}