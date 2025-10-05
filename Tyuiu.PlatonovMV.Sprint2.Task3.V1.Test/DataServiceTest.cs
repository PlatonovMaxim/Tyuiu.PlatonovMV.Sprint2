using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PlatonovMV.Sprint2.Task3.V1.Lib;

namespace Tyuiu.PlatonovMV.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateValue()
        {
            var ds = new DataService();
            double x = 2;
            double expected = Math.Round(Math.Exp(2) - 12 * 2 + Math.Cos(2), 3);

            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }
    }
}