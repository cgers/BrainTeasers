using System;
using BrainTeasers.Examples.InsertDeleteGetRandom;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class RandomizedSetUnitTest
    {
        private RandomizedSet randomizedSet { get; set; }
        public RandomizedSetUnitTest()
        {
            randomizedSet = new RandomizedSet();
        }
        [TestMethod]
        public void InsertTestMethod()
        {
            // Inserts 1 to the set. Returns false as 1 did not exist in the list.
            Assert.AreEqual(randomizedSet.Insert(1), false);
            Assert.AreEqual(randomizedSet.Insert(2), false);

            //Values now exist so should return true.
            Assert.AreEqual(randomizedSet.Insert(1), true);
            Assert.AreEqual(randomizedSet.Insert(2), true);

        }
        [TestMethod]
        public void RemoveTestMethod()
        {
            // Starts with an empty set.
            // Returns false as 2 does not exist in the set.
            Assert.AreEqual(randomizedSet.Remove(2), false);

            // Add a value
            randomizedSet.Insert(2);

            // Returns true as 2 does exist in the set.
            Assert.AreEqual(randomizedSet.Remove(2), true);

        }

        [TestMethod]
        public void InsertTestMethod2()
        {
            // Inserts 2 to the set, returns false because it did not exist before the insert.
            // Set now contains [1,2].
            randomizedSet.Insert(1);
            Assert.AreEqual(randomizedSet.Insert(2), false);
        }
        //Todo: Test for randomness
        //[TestMethod]
        //public void RandomTestMethod1()
        //{
        //    var Value = randomizedSet.GetRandom();

        //}
    }
}
