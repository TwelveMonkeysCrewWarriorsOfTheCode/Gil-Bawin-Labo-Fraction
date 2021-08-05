using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        #region TestConstructeurs
        [DataRow(2, 5, 0, "2/5")]
        [DataRow(5, 10, 3, "3 1/2")]
        [DataTestMethod]
        public void TestConstructor(int numerator, int denominator, int number, string expectedValue)
        {
            Fraction fractionTest = new Fraction(numerator, denominator, number);
            Assert.AreEqual(expectedValue, fractionTest.ToString());
        }

        [DataRow(2, 0, 0)]
        [DataTestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestZeroFraction(int numerator, int denominator, int number)
        {
           new Fraction(numerator, denominator, number);
        }

        [DataRow("3,25","3 1/4")]
        [DataRow("0,5","1/2")]
        [DataTestMethod]
        public void TestConstructorDecimal(string userDecimal, string expectedValue)
        {
            decimal ExpectedDecimal = decimal.Parse(userDecimal);
            Fraction fractionTest = new Fraction(ExpectedDecimal);
            Assert.AreEqual(expectedValue, fractionTest.ToString());
        }
        #endregion

        #region TestCasts
        [DataRow(2, 5, 0, "2/5")]
        [DataRow(5, 10, 3, "3 1/2")]
        [DataRow(-2, 10, 0, "-1/5")]
        [DataRow(-2, 10, 5, "-5 1/5")]
        [DataTestMethod]
        public void TestToString(int numerator, int denominator, int number, string expectedValue)
        {
            Fraction fractionTest = new Fraction(numerator, denominator, number);
            Assert.AreEqual(expectedValue, fractionTest.ToString());
        }

        [DataRow(2, 5, 0, "0,4")]
        [DataRow(5, 10, 3, "3,5")]
        [DataRow(-2, 10, 0, "-0,2")]
        [DataRow(-2, 10, 5, "-5,2")]
        [DataTestMethod]
        public void TestToDecimal(int numerator, int denominator, int number, string expectedValue)
        {
            decimal ExpectedDecimal = decimal.Parse(expectedValue);
            Fraction fractionTest = new Fraction(numerator, denominator, number);
            Assert.AreEqual(ExpectedDecimal, fractionTest.ToDecimal());
        }
        #endregion
    }
}
