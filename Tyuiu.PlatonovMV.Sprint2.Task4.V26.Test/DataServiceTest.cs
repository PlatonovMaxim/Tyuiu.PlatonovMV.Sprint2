using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint2.Task4.V26.Lib;
using System;

namespace Tyuiu.PlatonovMV.Sprint2.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestIfBranch()
        {
            var ds = new DataService();
            double x = 2;
            double y = 4;

            // Условие: x - 2 < y / 2 → 0 < 2  истина
            double expected = Math.Round(Math.Pow(10 + 2 / Math.Pow(x, 2), y), 3);
            double result = ds.Calculate(x, y);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestElseBranch()
        {
            var ds = new DataService();
            double x = 10;
            double y = 1;

            // Условие: 10 - 2 < 1 / 2 → 8 < 0.5  ложь
            double expected = Math.Round(Math.Pow(x, 2) - (1 / y), 3);
            double result = ds.Calculate(x, y);

            Assert.AreEqual(expected, result);
        }
    }
}