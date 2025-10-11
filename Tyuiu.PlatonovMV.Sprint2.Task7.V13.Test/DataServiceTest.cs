using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint2.Task7.V13.Lib;

namespace Tyuiu.PlatonovMV.Sprint2.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestDotInsideCircle()
        {
            var ds = new DataService();
            bool result = ds.CheckDotInShadedArea(0.5, 0.5);
            Assert.IsTrue(result); // точка в круге 1 четверть
        }

        [TestMethod]
        public void TestDotInTriangleZone()
        {
            var ds = new DataService();
            bool result = ds.CheckDotInShadedArea(1, 0.5);
            Assert.IsTrue(result); // точка в треугольнике справа от круга
        }

        [TestMethod]
        public void TestDotOutsideArea()
        {
            var ds = new DataService();
            bool result = ds.CheckDotInShadedArea(-1, 1);
            Assert.IsFalse(result); // слева от оси не в закрашенной области
        }
    }
}