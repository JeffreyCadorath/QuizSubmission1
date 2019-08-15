using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public int[] testArray = new int[10];
        [TestMethod]
        public void ContainsDuplicateTrue()
        {
            var results = Program.containDuplicate(testArray);
            Assert.IsTrue(results); 
        }

        [TestMethod]
        public void ContainsDuplicateFalse()
        {
            var results = Program.containDuplicate(testArray);
            Assert.IsFalse(results);
        }
        [TestMethod]
        public void showSingleIntegerTrue()
        {
            var results = Program.showSingles(testArray);
            Assert.IsNotNull(results);
        }
        [TestMethod]
        public void showSingleIntegerFalse()
        {
            var results = Program.showSingles(testArray);
            Assert.IsTrue(results.Equals(testArray));
        }
        [TestMethod]
        public void ContainDuplicateSetTrue()
        {
            var results = Program.containDuplicateWithSets(testArray);
            Assert.IsTrue(results);
        }
        [TestMethod]
        public void ContainDuplicateSetsFalse()
        {
            var results = Program.containDuplicateWithSets(testArray);
            Assert.IsFalse(results);

        }
    }
}
