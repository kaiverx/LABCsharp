using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberComparison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparison.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void GetSortedTest1()
        {
            // Arrange
            int first = 5, second = 2, third = 8;

            // Act
            var (max, mid, min) = Logic.GetSorted(first, second, third);

            // Assert
            Assert.AreEqual(8, max);
            Assert.AreEqual(5, mid);
            Assert.AreEqual(2, min);
        }

        [TestMethod()]
        public void GetSortedTest2()
        {
            // Arrange
            int first = 9, second = 12, third = 3;

            // Act
            var (max, mid, min) = Logic.GetSorted(first, second, third);

            // Assert
            Assert.AreEqual(12, max);
            Assert.AreEqual(9, mid);
            Assert.AreEqual(3, min);
        }

        [TestMethod()]
        public void GetSortedTest3()
        {
            // Arrange
            int first = -1, second = -10, third = 0;

            // Act
            var (max, mid, min) = Logic.GetSorted(first, second, third);

            // Assert
            Assert.AreEqual(0, max);
            Assert.AreEqual(-1, mid);
            Assert.AreEqual(-10, min);
        }

        [TestMethod()]
        public void GetSortedTest4()
        {
            // Arrange
            int first = -5, second = -2, third = -8;

            // Act
            var (max, mid, min) = Logic.GetSorted(first, second, third);

            // Assert
            Assert.AreEqual(-2, max);
            Assert.AreEqual(-5, mid);
            Assert.AreEqual(-8, min);
        }
    }
}