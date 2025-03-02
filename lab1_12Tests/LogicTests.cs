using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolMarks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMarks.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void SchetTest1()
        {
            int[] marks = new int[] { 1, 2, 3, 4, 4, 5 };

            var (excellent, good, satisfactory, bad) = Logic.Schet(marks.ToArray());
            Assert.AreEqual(1, excellent);
            Assert.AreEqual(2, good);
            Assert.AreEqual(1, satisfactory);
            Assert.AreEqual(1, bad);
        }
        [TestMethod()]
        public void SchetTest2()
        {
            int[] marks = new int[] { -1, -2, 3, 4, 4, -5, 5, 5, 5 };

            var (excellent, good, satisfactory, bad) = Logic.Schet(marks.ToArray());
            Assert.AreEqual(3, excellent);
            Assert.AreEqual(2, good);
            Assert.AreEqual(1, satisfactory);
            Assert.AreEqual(0, bad);
        }
        [TestMethod()]
        public void SchetTest3()
        {
            int[] marks = new int[] { };

            var (excellent, good, satisfactory, bad) = Logic.Schet(marks.ToArray());
            Assert.AreEqual(0, excellent);
            Assert.AreEqual(0, good);
            Assert.AreEqual(0, satisfactory);
            Assert.AreEqual(0, bad);
        }
        [TestMethod()]
        public void SchetTest4()
        {
            int[] marks = new int[] { 5, 5, 5, 2, 2, 2 };

            var (excellent, good, satisfactory, bad) = Logic.Schet(marks.ToArray());
            Assert.AreEqual(3, excellent);
            Assert.AreEqual(0, good);
            Assert.AreEqual(0, satisfactory);
            Assert.AreEqual(3, bad);
        }
    }
}