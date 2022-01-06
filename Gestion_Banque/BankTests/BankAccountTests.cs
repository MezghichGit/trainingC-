using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banque;
namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double soldeInitial = 100;
            double debitAmount = 60;
            double expected = 40;
            BankAccount account = new BankAccount("Mr. Mohamed Amine Mezghich", soldeInitial);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Solde;
            Assert.AreEqual(expected, actual, 0.001, "Problème dans la méthode Debit");
        }

        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            double soldeInitial = 100;
            double debitAmount = -60;
            BankAccount account = new BankAccount("Mr. Mohamed Amine Mezghich", soldeInitial);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            double soldeInitial = 100;
            double debitAmount = 600;
            BankAccount account = new BankAccount("Mr. Mohamed Amine Mezghich", soldeInitial);

            // Act and assert
            //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
            // Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }
    }
}
