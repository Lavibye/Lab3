using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab3;
using BirdsApp;

namespace UnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.ObjectModel;

    namespace BirdTests
    {
        [TestClass]
        public class BirdUnitTests
        {
            [TestMethod]
            public void StorkCreationTest()
            {
                double wingSpan = 2.5;
                Stork stork = new Stork("Test Stork", wingSpan);
                Assert.AreEqual("Test Stork", stork.Name);
                Assert.AreEqual(wingSpan, stork.WingSpan);
            }

            [TestMethod]
            public void CrowCreationTest()
            {
                double height = 1.0;
                Crow crow = new Crow("Test Crow", height);
                Assert.AreEqual("Test Crow", crow.Name);
                Assert.AreEqual(height, crow.Height);
            }

            [TestMethod]
            public void StorkFoodRequirementTest()
            {
                double wingSpan = 2.5;
                Stork stork = new Stork("Test Stork", wingSpan);
                double expectedFoodRequirement = wingSpan * 1 / 2000;
                Assert.AreEqual(expectedFoodRequirement, stork.CalculateFoodRequirement());
            }

            [TestMethod]
            public void CrowFoodRequirementTest()
            {
                double height = 1.0;
                Crow crow = new Crow("Test Crow", height);
                double expectedFoodRequirement = 0.8 * height;
                Assert.AreEqual(expectedFoodRequirement, crow.CalculateFoodRequirement());
            }

            [TestMethod]
            public void BirdsCollectionTest()
            {
                var birds = new ObservableCollection<Bird>();
                birds.Add(new Stork("Stork 1", 2.5));
                birds.Add(new Crow("Crow 1", 1.0));

                Assert.AreEqual(2, birds.Count);
                Assert.IsInstanceOfType(birds[0], typeof(Stork));
                Assert.IsInstanceOfType(birds[1], typeof(Crow));
            }
        }
    }
}
