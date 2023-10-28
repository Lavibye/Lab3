using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab3;

namespace UnitTest
{
    [TestClass]
    public class BirdTests
    {
        [TestMethod]
        public void SparrowFoodCalculationTest()
        {
            Sparrow sparrow = new Sparrow { L = 1000 };
            Assert.AreEqual(0.5, sparrow.FoodRequired);
        }

        [TestMethod]
        public void CrowHeightCalculationTest()
        {
            Crow crow = new Crow { L = 100 };
            Assert.AreEqual(80, crow.Height);
        }
    }

}
