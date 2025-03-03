using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberComparison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparison.Tests
{
    [TestClass]
    public class LogicTests
    {
        // Тест для строки с буквами и пробелами
        [TestMethod]
        public void PercentTest_LettersAndSpaces()
        {
            string sentence = "Hello World!";
            double percent = Logic.Percent(sentence);

            // Ожидаемый процент: 10 букв, длина строки = 12 символов
            Assert.AreEqual(83.33, percent, 0.01, "Процент букв должен быть примерно 83.33%");
        }

        // Тест для строки только с буквами
        [TestMethod]
        public void PercentTest_OnlyLetters()
        {
            string sentence = "Hello";
            double result = Logic.Percent(sentence);

            Assert.AreEqual(100.0, result, 0.01, "Процент букв должен быть 100% для строки из букв");
        }

        // Тест для строки без букв (только пробелы и знаки препинания)
        [TestMethod]
        public void PercentTest_NoLetters()
        {
            string sentence = "   !!!";
            double percent = Logic.Percent(sentence);

            Assert.AreEqual(0.0, percent, 0.01, "Процент букв должен быть 0% для строки без букв");
        }

        // Тест для пустой строки
        [TestMethod]
        public void PercentTest_EmptyString()
        {
            string sentence = "";
            double percent = Logic.Percent(sentence);

            Assert.AreEqual(0.0, percent, 0.01, "Процент букв должен быть 0% для пустой строки");
        }

        // Тест для строки с цифрами и буквами
        [TestMethod]
        public void PercentTest_LettersAndNumbers()
        {
            string sentence = "Hello123";
            double percent = Logic.Percent(sentence);

            Assert.AreEqual(62.5, percent, 0.01, "Процент букв должен быть примерно 62.5%");
        }
    }
}
