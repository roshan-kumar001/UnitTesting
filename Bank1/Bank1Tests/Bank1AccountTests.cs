using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank1;

namespace Bank1Tests
{
    [TestClass]
    public class Bank1AccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expectedAmount = 7.44;
            Bank1Account bank1Account = new Bank1Account("Roshan Kumar", beginningBalance);

            // Act
            bank1Account.Debit(debitAmount);

            // Assert
            Assert.AreEqual(bank1Account.Balance, expectedAmount, 0.001, "Account not debited correctly.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            Bank1Account bank1Account = new Bank1Account("Roshan Kumar", beginningBalance);

            // Act
            bank1Account.Debit(debitAmount);

            // Assert handled by ExpectedException.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsGreaterThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 100.00;
            Bank1Account bank1Account = new Bank1Account("Roshan Kumar", beginningBalance);

            // Act
            bank1Account.Debit(debitAmount);

            // Assert handled by ExpectedException.
        }

    }
}
