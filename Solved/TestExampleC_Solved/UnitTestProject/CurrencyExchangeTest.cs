using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestExampleC;
// ReSharper disable UnusedVariable

namespace UnitTestProject
{
    [TestClass]
    public class CurrencyExchangeTest
    {
        [TestMethod]
        public void TestSetExchangeRate_InsertSingleLegal_OK()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();

            // Act (& implicit Assert)
            testSubject.SetExchangeRate("USDDKK", 6.50);
        }

        [TestMethod]
        public void TestSetExchangeRate_InsertSingleIllegal_TooShort_Exception()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => { testSubject.SetExchangeRate("USDDK", 6.50); });
        }

        [TestMethod]
        public void TestSetExchangeRate_InsertSingleIllegal_TooLong_Exception()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => { testSubject.SetExchangeRate("USDKroner", 6.50); });
        }

        [TestMethod]
        public void TestSetExchangeRate_InsertSingleIllegal_SameCurrency_Exception()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => { testSubject.SetExchangeRate("USDUSD", 6.50); });
        }

        [TestMethod]
        public void TestSetExchangeRate_InsertSingleIllegal_Empty_Exception()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => { testSubject.SetExchangeRate("      ", 6.50); });
        }

        [TestMethod]
        public void TestSetExchangeRate_InsertSingleIllegal_Null_Exception()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => { testSubject.SetExchangeRate(null, 6.50); });
        }

        [TestMethod]
        public void TestSetExchangeRate_InsertSingleIllegal_NegativeExchangeRate_Exception()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => { testSubject.SetExchangeRate(null, -6.50); });
        }

        [TestMethod]
        public void TestSetExchangeRate_InsertSingleIllegal_ZeroExchangeRate_Exception()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => { testSubject.SetExchangeRate(null, 0.0); });
        }

        [TestMethod]
        public void TestSetExchangeRate_InsertMultipleLegal_OK()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();

            // Act (& implicit Assert)
            testSubject.SetExchangeRate("USDDKK", 6.50);
            testSubject.SetExchangeRate("EURDKK", 7.50);
            testSubject.SetExchangeRate("USDGBP", 0.80);
        }

        [TestMethod]
        public void TestSetExchangeRate_InsertMultipleWithIllegal_Exception()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();

            // Act & Assert
            testSubject.SetExchangeRate("USDDKK", 6.50);
            Assert.ThrowsException<ArgumentException>(() => { testSubject.SetExchangeRate("EUDDK", 7.50); });
            testSubject.SetExchangeRate("USDGBP", 0.80);
        }

        [TestMethod]
        public void TestSetExchangeRate_InsertAndUpdateSingleLegal_OK()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();

            // Act (& implicit Assert)
            testSubject.SetExchangeRate("USDDKK", 6.50);
            testSubject.SetExchangeRate("USDDKK", 6.80);
        }

        [TestMethod]
        public void TestDoExchange_Existing_OK()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();
            testSubject.SetExchangeRate("USDDKK", 6.50);
            testSubject.SetExchangeRate("EURDKK", 7.50);
            testSubject.SetExchangeRate("USDGBP", 0.80);
            double expectedResult = 1300.0;

            // Act
            double actualResult = testSubject.DoExchange("USDDKK", 200.0);

            // Assert
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestDoExchange_ExistingWithUpdate_OK()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();
            testSubject.SetExchangeRate("USDDKK", 6.50);
            testSubject.SetExchangeRate("EURDKK", 7.50);
            testSubject.SetExchangeRate("USDGBP", 0.80);
            testSubject.SetExchangeRate("USDDKK", 6.80);
            double expectedResult = 1360.0;

            // Act
            double actualResult = testSubject.DoExchange("USDDKK", 200.0);

            // Assert
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        public void TestDoExchange_NonExisting_Exception()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();
            testSubject.SetExchangeRate("USDDKK", 6.50);
            testSubject.SetExchangeRate("EURDKK", 7.50);
            testSubject.SetExchangeRate("USDGBP", 0.80);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => { double actualResult = testSubject.DoExchange("USDNOR", 200.0); });
        }

        [TestMethod]
        public void TestDoExchange_Illegal_Exception()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();
            testSubject.SetExchangeRate("USDDKK", 6.50);
            testSubject.SetExchangeRate("EURDKK", 7.50);
            testSubject.SetExchangeRate("USDGBP", 0.80);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => { double actualResult = testSubject.DoExchange("USDNK", 200.0); });
        }

        [TestMethod]
        public void TestDoExchange_Illegal_NegativeAmount_Exception()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();
            testSubject.SetExchangeRate("USDDKK", 6.50);
            testSubject.SetExchangeRate("EURDKK", 7.50);
            testSubject.SetExchangeRate("USDGBP", 0.80);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => { double actualResult = testSubject.DoExchange("USDDKK", -200); });
        }

        [TestMethod]
        public void TestDoExchange_Illegal_ZeroAmount_Exception()
        {
            // Arrange
            CurrencyExchange testSubject = new CurrencyExchange();
            testSubject.SetExchangeRate("USDDKK", 6.50);
            testSubject.SetExchangeRate("EURDKK", 7.50);
            testSubject.SetExchangeRate("USDGBP", 0.80);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => { double actualResult = testSubject.DoExchange("USDDKK", 0); });
        }
    }
}
