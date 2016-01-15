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
    }
}
