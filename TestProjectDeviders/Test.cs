using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibraryDividers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectDeviders
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Метод для тестирования функции "Deviders"
        /// </summary>
        [TestMethod]
        public void TestDeviders()
        {
            // Входные данные
            int n = 24;
            HashSet<int> expected = new HashSet<int>() { 1, 2, 3, 4, 6, 8, 12, 24 }; // Ожидаемый результат
            //Фактический результат
            HashSet<int> result = ClassDividers.Dividers(n);
            Assert.IsTrue(expected.SetEquals(result)); // Сравнение ожидаемого и фактического результатов
        }
        /// <summary>
        /// Метод для тестирования функции "Five Deviders"
        /// </summary>
        [TestMethod]
        public void TestFiveDividers()
        {
            // Входные данные
            int m = 1;
            int n = 100;
            List<int> expected = new List<int>() { 16, 81 }; // Ожидаемый результат
            //Фактический результат
            List<int> result = ClassDividers.FiveDividers(m, n);
            CollectionAssert.AreEqual(expected, result); // Сравнение ожидаемого и фактического результатов
        }
        /// <summary>
        /// Метод для тестирования функции "Factoria"
        /// </summary>
        [TestMethod]
        public void TestFactoria()
        {
            // Входные данные
            int n = 126;
            List<int> expected = new List<int>() { 2, 3, 3, 7 }; // Ожидаемый результат
            //Фактический результат
            List<int> result = ClassDividers.Factoria(n);
            CollectionAssert.AreEqual(expected, result); // Сравнение ожидаемого и фактического результатов
        }
        /// <summary>
        /// Метод для тестирования функции "Prost Div"
        /// </summary>
        [TestMethod]
        public void TestProstDiv()
        {
            // Входные данные
            int n = 10;
            List<int> expected = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 }; // Ожидаемый результат
            //Фактический результат
            List<int> result = ClassDividers.ProstDiv(n);
            CollectionAssert.AreEqual(expected, result); // Сравнение ожидаемого и фактического результатов
        }
        /// <summary>
        /// Метод для тестирования функции "Prost Div Er"
        /// </summary>
        [TestMethod]
        public void TestProstDivEr()
        {
            // Входные данные
            int n = 10;
            List<int> expected = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 }; // Ожидаемый результат
            //Фактический результат
            List<int> result = ClassDividers.ProstDivEr(n);
            CollectionAssert.AreEqual(expected, result); // Сравнение ожидаемого и фактического результатов
        }
        /// <summary>
        /// Метод для тестирования функции "NOD"
        /// </summary>
        [TestMethod]
        public void TestNOD()
        {
            // Входные данные
            int m = 4;
            int n = 16;
            int expected = 4; // Ожидаемый результат
            //Фактический результат
            int result = ClassDividers.NOD(m, n);
            Assert.AreEqual(expected, result); // Сравнение ожидаемого и фактического результатов
        }
        /// <summary>
        /// Метод для тестирования функции "NOK"
        /// </summary>
        [TestMethod]
        public void TestNOK()
        {
            // Входные данные
            int m = 12;
            int n = 34;
            int expected = 204; // Ожидаемый результат
            //Фактический результат
            int result = ClassDividers.NOK(m, n);
            Assert.AreEqual(expected, result); // Сравнение ожидаемого и фактического результатов
        }
    }
}
