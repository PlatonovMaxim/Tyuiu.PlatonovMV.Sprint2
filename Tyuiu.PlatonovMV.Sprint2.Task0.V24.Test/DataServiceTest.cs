using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint2.Task0.V24.Lib;

namespace Tyuiu.PlatonovMV.Sprint2.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations_ReturnsExpectedSequence()
        {
            var ds = new DataService();
            int x = 135, y = 755;
            bool[] expected = { true, true, false, false, true, true };

            var actual = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}