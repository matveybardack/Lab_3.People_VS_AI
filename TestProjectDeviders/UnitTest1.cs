using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibraryDividers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectDividers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDividers()
        {
            int n = 24;
            HashSet<int> expected = new HashSet<int>() { 1, 2, 3, 4, 6, 8, 12, 24 };

            HashSet<int> result = ClassDividers.Dividers(n);
            Assert.IsTrue(expected.SetEquals(result));
        }

        [TestMethod]
        public void TestFiveDividers()
        {
            int m = 1;
            int n = 100;
            List<int> expected = new List<int>() { 16, 81 };

            List<int> result = ClassDividers.FiveDividers(m, n);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFactoria()
        {
            int n = 126;
            List<int> expected = new List<int>() { 2, 3, 3, 7 };

            List<int> result = ClassDividers.Factoria(n);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestProstDiv()
        {
            int n = 10;
            List<int> expected = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            List<int> result = ClassDividers.ProstDiv(n);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestProstDivEr()
        {
            int n = 10;
            List<int> expected = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            List<int> result = ClassDividers.ProstDivEr(n);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNOD()
        {
            int m = 4;
            int n = 16;
            int expected = 4;

            int result = ClassDividers.NOD(m, n);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNOK()
        {
            int m = 3;
            int n = 11;
            int expected = 33;

            int result = ClassDividers.NOK(m, n);
            Assert.AreEqual(expected, result);
        }
    }
}
