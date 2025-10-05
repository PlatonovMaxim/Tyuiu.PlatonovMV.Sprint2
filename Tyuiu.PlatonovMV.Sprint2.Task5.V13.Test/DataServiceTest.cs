using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint2.Task5.V13.Lib;

namespace Tyuiu.PlatonovMV.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestEndOfMonth()
        {
            var ds = new DataService();
            string result = ds.FindDateOfNextDay(2023, 3, 31);
            Assert.AreEqual("01.04.2023", result);
        }

        [TestMethod]
        public void TestMiddleOfMonth()
        {
            var ds = new DataService();
            string result = ds.FindDateOfNextDay(2023, 5, 10);
            Assert.AreEqual("11.05.2023", result);
        }

        [TestMethod]
        public void TestEndOfYear()
        {
            var ds = new DataService();
            string result = ds.FindDateOfNextDay(2023, 12, 31);
            Assert.AreEqual("01.01.2024", result);
        }
    }
}