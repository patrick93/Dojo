using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dojo.Tests
{
    [TestClass]
    public class NumberParserTest
    {
        [TestMethod]
        public void test_number_1_to_roman_I()
        {
            string expected = "I";
            string result = NumberParser.ParseToRoman(1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void test_number_2_to_roman_II()
        {
            string expected = "II";
            string result = NumberParser.ParseToRoman(2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void test_number_3_to_roman_III()
        {
            string expected = "III";
            string result = NumberParser.ParseToRoman(3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void test_number_4_to_roman_IV()
        {
            string expected = "IV";
            string result = NumberParser.ParseToRoman(4);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void test_number_5_to_roman_V()
        {
            string expected = "V";
            string result = NumberParser.ParseToRoman(5);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void test_number_6_to_roman_VI()
        {
            string expected = "VI";
            string result = NumberParser.ParseToRoman(6);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void test_number_9_to_roman_IX()
        {
            string expected = "IX";
            string result = NumberParser.ParseToRoman(9);
            Assert.AreEqual(expected, result);
        }
    }
}
