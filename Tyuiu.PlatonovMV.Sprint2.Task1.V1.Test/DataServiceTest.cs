using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint2.Task1.V1.Lib;

namespace Tyuiu.PlatonovMV.Sprint2.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetLogicOperations_ReturnsExpectedSequence()
        {
            var ds = new DataService();
            int a = 119, b = 196, c = 134, d = 327;
            bool[] expected = { true, false, true, false, true, false };

            var actual = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}